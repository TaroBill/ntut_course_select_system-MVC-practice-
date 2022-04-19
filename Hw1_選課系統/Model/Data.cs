using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework_選課系統
{
    public class Data
    {
        public delegate void CourseChangedEventHandler();
        public delegate void ProgressChangedEventHandler();
        public delegate void DoneEventHandler();
        public CourseChangedEventHandler CourseChanged
        {
            get; set;
        }
        public ProgressChangedEventHandler ProgressChanged
        {
            get; set;
        }
        public DoneEventHandler Done
        {
            get; set;
        }

        //通知完成
        public void NotifyDone()
        {
            Done?.Invoke();
        }

        private BindingList<Course> _allCourse;
        private readonly List<Classes> _allClasses;

        private readonly List<int> _yourCourseInAllCourseIndex;
        public Data()
        {
            const string COMPUTER_SCIENCE_GRADE_THREE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
            const string ELECTRONIC_SCIENCE_GRADE_THREE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2423";
            _yourCourseInAllCourseIndex = new List<int>();
            _allCourse = new BindingList<Course>();
            _allClasses = new List<Classes>()
            {
                new Classes("資工三", COMPUTER_SCIENCE_GRADE_THREE),
                new Classes("電子三", ELECTRONIC_SCIENCE_GRADE_THREE),
            };
        }

        public struct Classes
        {
            public Classes(string name, string path)
            {
                Name = name;
                Path = path;
            }

            public string Name
            {
                get;
            }

            public string Path
            {
                get;
            }
        }

        public BindingList<Course> AllCourses
        {
            get
            {
                if(_allCourse.Count < 1)
                    AddDataToAllCourse();
                return _allCourse;
            }
            set
            {
                _allCourse = value; //這裡外面不能取用，單純設給Unit test用
            }
        }

        public List<Classes> AllClasses
        {
            get
            {
                return _allClasses;
            }
        }

        public string[] AllClassesNameList
        {
            get
            {
                List<string> output = new List<string>();
                foreach (Classes classes in _allClasses)
                    output.Add(classes.Name);
                return output.ToArray();
            }
        }

        public string Progress
        {
            get
            {
                double progress = (double) NowProgress / Total;
                return ((int)(progress * 100)).ToString() + "%";
            }
        }

        //將所有資工系班級加入list
        public void AddComputerScience()
        {
            const string COMPUTER_SCIENCE_GRADE_ONE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2676";
            const string COMPUTER_SCIENCE_GRADE_TWO = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2550";
            const string COMPUTER_SCIENCE_GRADE_FOUR = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2314";
            const string COMPUTER_SCIENCE_GRADE_FIVE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2701";
            int nowIndex = _allClasses.Count();
            if (nowIndex > 2)
            {
                NotifyProgressObserver();
                return;
            }
            _allClasses.Add(new Classes("資工一", COMPUTER_SCIENCE_GRADE_ONE));
            _allClasses.Add(new Classes("資工二", COMPUTER_SCIENCE_GRADE_TWO));
            _allClasses.Add(new Classes("資工四", COMPUTER_SCIENCE_GRADE_FOUR));
            _allClasses.Add(new Classes("資工所", COMPUTER_SCIENCE_GRADE_FIVE));
            AddDataToAllCourse(nowIndex);
        }

        public int Total
        {
            get;set;
        }

        private int _nowProgress;
        public int NowProgress
        {
            get
            {
                return _nowProgress;
            }
            set
            {
                _nowProgress = value;
                NotifyProgressObserver();
            }
        }

        //加入一個課程
        public void AddClass(string className)
        {
            foreach (Classes classes in _allClasses)
                if (className == classes.Name)
                    return;
            _allClasses.Add(new Classes(className, ""));
        }


        //爬蟲加入_allCourse
        public void AddDataToAllCourse(int offsetIndex = 0)
        {
            Total = _allClasses.Count() - offsetIndex;
            NowProgress = 0;
            for (int allClassesIndex = offsetIndex; allClassesIndex < _allClasses.Count(); allClassesIndex++)
            {
                NowProgress++;
                if (_allClasses[allClassesIndex].Path == "")
                    continue;
                List<Course> classList = GetData(_allClasses[allClassesIndex].Path);
                SetClass(_allClasses[allClassesIndex].Name, classList);
                Course.AddListToBindingList(_allCourse, classList);
                Thread.Sleep(600);
            }
            NotifyDone();
        }

        //將List裡的Course設定開課的班級
        private List<Course> SetClass(string openClass, List<Course> courses)
        {
            foreach (Course course in courses)
                course.Class = openClass;
            return courses;
        }

        //輸入開課班級尋找所有同班級的資料
        public List<Course> FindCourses(string ClassName)
        {
            List<Course> outputCourses = new List<Course>();
            foreach (Course course in AllCourses)
            {
                if (course.Class == ClassName)
                    outputCourses.Add(course);
            }
            return outputCourses;
        }

        //輸入開課班級尋找所有同班級的資料
        public List<string> GetCoursesNameByClassName(string ClassName)
        {
            List<Course> courses = FindCourses(ClassName);
            List<string> output = new List<string>();
            foreach (Course course in courses)
            {
                output.Add(course.Name);
            }
            return output;
        }

        //從四資三網站爬蟲課程資料
        public List<Course> GetData(string path)
        {
            HtmlWeb webClient = new HtmlWeb()
            {
                OverrideEncoding = Encoding.Default
            };
            HtmlDocument document = webClient.Load(path);
            const string TABLE_FINDER = "//body/table";
            HtmlNode nodeTable = document.DocumentNode.SelectSingleNode(TABLE_FINDER);//找到table
            HtmlNodeCollection nodeTableRow = nodeTable.ChildNodes;
            const int TIMES_TO_REMOVE = 3;
            for (int removeIndex = 0; removeIndex < TIMES_TO_REMOVE; removeIndex++)
            {
                nodeTableRow.RemoveAt(0); //移除table的前三項row
            }
            nodeTableRow.RemoveAt(nodeTableRow.Count() - 1);//移除table最後一項的row
            return AddToList(nodeTableRow);
        }

        //將table剩餘內容加到Course的List裡面
        private List<Course> AddToList(HtmlNodeCollection nodeTableRow)
        {
            List<Course> courseList = new List<Course>();
            //把剩餘table的內容用loop讀出
            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                nodeTableDatas.RemoveAt(0);// 移除 #text
                courseList.Add(new Course(nodeTableDatas));
            }
            return courseList;
        }

        //通知CourseChanged
        public void NotifyCourseObserver()
        {
            CourseChanged?.Invoke();
        }

        //通知ProgressChanged
        public void NotifyProgressObserver()
        {
            ProgressChanged?.Invoke();
        }

        public List<Course> YourCourse
        {
            get
            {
                List<Course> outputCourse = new List<Course>();
                for (int yourCourseIndex = 0; yourCourseIndex < _yourCourseInAllCourseIndex.Count(); yourCourseIndex++)
                        outputCourse.Add(AllCourses[_yourCourseInAllCourseIndex[yourCourseIndex]]);
                return outputCourse;
            }
        }

        //allCourse裡加入Course到yourCourse裡，若allCourse找不到則不加入
        public void AddCourse(Course course)
        {
            for (int allCourseIndex = 0; allCourseIndex < AllCourses.Count(); allCourseIndex++)
            {
                if (course.IsSameClass(AllCourses[allCourseIndex]))
                {
                    _yourCourseInAllCourseIndex.Add(allCourseIndex);
                    break;
                }
            }
        }

        //移除Course資料的第N行
        public void RemoveCourseAt(int index)
        {
            if (index >= 0 && index < _yourCourseInAllCourseIndex.Count())
                _yourCourseInAllCourseIndex.RemoveAt(index);
        }

        private const string UNOPENED = "未開課";
        //將輸入的CourseList裡跟YourCourse相同的資料刪除
        public List<string[]> DeleteSameCourse(List<string[]> inputCourse)
        {
            for (int courseFromWebIndex = (inputCourse.Count() - 1); courseFromWebIndex >= 0; courseFromWebIndex--)
            {
                if (inputCourse[courseFromWebIndex][(int)Course.Index.IsOpened + 1] == UNOPENED)
                {
                    inputCourse.RemoveAt(courseFromWebIndex);
                    continue;
                }

                for (int yourCourseIndex = 0; yourCourseIndex < YourCourse.Count(); yourCourseIndex++)
                {
                    if (YourCourse[yourCourseIndex].IsSameClass(inputCourse.ElementAt(courseFromWebIndex)[1]))
                    {
                        inputCourse.RemoveAt(courseFromWebIndex);
                        break;
                    }
                }
            }
            return inputCourse;
        }

        //將List<Course>轉成List<string[]>
        private List<string[]> CourseListToStringList(List<Course> courseList)
        {
            List<string[]> courseStringList = new List<string[]>();
            foreach (Course course in courseList)
            {
                courseStringList.Add(course.ConvertToStringList());
            }
            return courseStringList;
        }

        //取得被選擇以外的該班級所有課 (0:資工)(1:電子)
        public List<string[]> GetUnchooseCourse(int mode)
        {
            List<string[]> result;
            if (mode >= _allClasses.Count())
                mode = 0;
            result = CourseListToStringList(FindCourses(_allClasses[mode].Name).ToList<Course>());//複製過去
            return DeleteSameCourse(result);
        }
    }
}
