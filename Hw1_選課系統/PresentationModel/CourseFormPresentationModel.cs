using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class CourseFormPresentationModel
    {
        public delegate void ButtonChangedEnableEventHandler();
        public delegate void CourseChangedEventHandler();
        public ButtonChangedEnableEventHandler ButtonChangedEnable
        {
            get; set;
        }
        public CourseChangedEventHandler CourseChanged
        {
            get; set;
        }

        private const string POSITIVE = "True";
        private readonly Data _yourData;
        private readonly CourseWebCrawlerModel _courseWebCrawlerModel;

        public CourseFormPresentationModel(CourseWebCrawlerModel courseWebCrawlerModel, Data inputData)
        {
            _courseWebCrawlerModel = courseWebCrawlerModel;
            _yourData = inputData;
            _yourData.CourseChanged += RefreshAllCourseList;
            CurrentTabPage = 0;
        }

        private int _currentTabPage;
        public int CurrentTabPage
        {
            get
            {
                return _currentTabPage;
            }
            set
            {
                _currentTabPage = value;
                RefreshAllCourseList();
            }
        }

        //yourData刷新資料時通知View也刷新資料
        public void RefreshAllCourseList()
        {
            AddCourse(CurrentTabPage);
        }

        //確認有checkbox被選取
        public void IsCheckedCheckBox()
        {
            foreach (string[] course in _allCourseList)
            {
                if (course[0] == POSITIVE)
                {
                    SendButtonEnable = true;
                    return;
                }
            }
            SendButtonEnable = false;
        }

        //設置所選的課是否被勾選
        public void SetCourseIsChoosed(int? rowIndex, string result)
        {
            if(rowIndex != null || result != null)
                CourseList[(int)rowIndex][0] = result;
        }

        //將所選的課程加入已選課程
        public string AddToYourCourse()
        {
            string returnValue = _courseWebCrawlerModel.CourseConflictResult(CourseList, _yourData.YourCourse);
            if (returnValue == "")
            {
                for (int index = _allCourseList.Count() - 1; index >= 0; index--)
                {
                    if (_allCourseList.ElementAt(index)[0] == POSITIVE)
                    {
                        _yourData.AddCourse(new Course(_allCourseList[index]));
                        _allCourseList.ElementAt(index)[0] = "False";
                        _allCourseList.RemoveAt(index);
                    }
                }
                SendButtonEnable = false;
                _yourData.NotifyCourseObserver();
                const string SUCCESS = "加選成功";
                return SUCCESS;
            }
            return returnValue;
        }

        //通知觀察者Button的狀態改變了
        private void NotifyButtonEnableObserver()
        {
            ButtonChangedEnable?.Invoke();
        }

        //通知觀察者CourseList的狀態改變了
        private void NotifyCourseObserver()
        {
            CourseChanged?.Invoke();
        }

        private List<string[]> _allCourseList;
        public List<string[]> CourseList
        {
            get
            {
                return _allCourseList;
            }
            set
            {
                _allCourseList = value;
                NotifyCourseObserver();
            }
        }

        //將CourseList<string>轉回List<Course>
        public List<Course> GetCourseList()
        {
            List<Course> courses = new List<Course>();
            foreach (string[] course in CourseList)
                courses.Add(new Course(course));
            return courses;
        }

        //爬蟲讀取Course到list裡，若爬蟲過則從list讀取Course
        public void AddCourse(int mode)
        {
            this.CourseList = _yourData.GetUnchooseCourse(mode).ToList();
        }


        private bool _sendButtonEnable = false;
        public bool SendButtonEnable
        {
            get
            {
                return _sendButtonEnable;
            }
            set 
            {
                _sendButtonEnable = value;
                NotifyButtonEnableObserver();
            }
        }
    }
}
