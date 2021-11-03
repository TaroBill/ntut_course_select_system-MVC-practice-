using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class Data
    {
        public delegate void CourseChangedEventHandler();
        private BindingList<Course> _allCourse;

        private readonly List<int> _yourCourseInAllCourseIndex;
        public Data()
        {
            _yourCourseInAllCourseIndex = new List<int>();
        }

        public CourseChangedEventHandler CourseChanged
        {
            get; set;
        }

        public BindingList<Course> AllCourses
        {
            get
            {
                if(_allCourse == null)
                    AddDataToAllCourse();
                return _allCourse;
            }
        }

        //重新爬蟲加入_allCourse
        private void AddDataToAllCourse()
        {
            const string COMPUTER_SCIENCE_GRADE_THREE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
            const string ELECTRONIC_SCIENCE_GRADE_THREE = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2423";
            _allCourse = new BindingList<Course>();
            List<Course> computerScienceCourseList = GetData(COMPUTER_SCIENCE_GRADE_THREE);
            SetClass("資工三", computerScienceCourseList);
            List<Course> electronicScienceCourseList= GetData(ELECTRONIC_SCIENCE_GRADE_THREE);
            SetClass("電子三", electronicScienceCourseList);
            _allCourse = AddListToBindingList(_allCourse, computerScienceCourseList);
            _allCourse = AddListToBindingList(_allCourse, electronicScienceCourseList);
        }

        //將list裡的元素加入bindinglist
        private BindingList<Course> AddListToBindingList(BindingList<Course> bindingListCourse, List<Course> listCourse)
        {
            foreach (Course course in listCourse)
            {
                bindingListCourse.Add(course);
            }
            return bindingListCourse;
        }

        //將List裡的Course設定開課的班級
        private List<Course> SetClass(string openClass, List<Course> courses)
        {
            foreach (Course course in courses)
                course.Class = openClass;
            return courses;
        }

        //輸入開課班級尋找所有同班級的資料
        private List<Course> FindCourses(string ClassName)
        {
            List<Course> outputCourses = new List<Course>();
            foreach (Course course in AllCourses)
            {
                if (course.Class == ClassName)
                    outputCourses.Add(course);
            }
            return outputCourses;
        }

        public List<Course> CourseFromWebComputerScience
        {
            get
            {
                return FindCourses("資工三");
            }
        }

        public List<Course> CourseFromWebEletronicScience
        {
            get
            {
                return FindCourses("電子三");
            }
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

        //加入Course到BindingList裡
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
            if (_yourCourseInAllCourseIndex.Count() > 0)
                _yourCourseInAllCourseIndex.RemoveAt(index);
        }

        //將輸入的CourseList裡跟YourCourse相同的資料刪除
        public List<string[]> DeleteSameCourse(List<string[]> inputCourse)
        {
            for (int courseFromWebIndex = (inputCourse.Count() - 1); courseFromWebIndex >= 0; courseFromWebIndex--)
            {
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

        //根據模式取得該班級的課程(0:資工)(1:電子)
        public List<string[]> GetCourse(int mode)
        {
            switch (mode)
            {
                case 0:
                    return CourseListToStringList(CourseFromWebComputerScience.ToList<Course>());//複製過去
                case 1:
                    return CourseListToStringList(CourseFromWebEletronicScience.ToList<Course>());
                default:
                    return CourseListToStringList(CourseFromWebComputerScience.ToList<Course>());//複製過去
            }
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

        //取得被選擇以外的該班級所有課
        public List<string[]> GetUnchooseCourse(int mode)
        {
            return DeleteSameCourse(GetCourse(mode));
        }
    }
}
