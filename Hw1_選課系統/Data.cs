using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class Data
    {
        public delegate void YourCourseChangedEventHandler();
        public YourCourseChangedEventHandler YourCourseChangedEvent
        {
            get; set;
        }
        private List<Course> _yourCourse;

        public Data()
        {
            _yourCourse = new List<Course>();
        }

        //當資料變更時觸發事件
        public void NotifyYourCourseChanged()
        {
            YourCourseChangedEvent?.Invoke();
        }

        public List<Course> YourCourse
        {
            get
            {
                return _yourCourse;
            }
            set
            {
                _yourCourse = value;
                NotifyYourCourseChanged();
            }
        }

        //移除Course資料的第N行
        public void RemoveCourseAt(int index)
        {
            _yourCourse.RemoveAt(index);
            NotifyYourCourseChanged();
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
    }
}
