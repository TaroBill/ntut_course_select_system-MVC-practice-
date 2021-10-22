using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    class CourseSelectionResultPresentationModel
    {
        private readonly Data _yourData;

        public CourseSelectionResultPresentationModel(Data data)
        {
            _yourData = data;
        }

        //刷新已選的課程畫面
        public List<Course> RefreshCourse()
        {
            List<Course> resultCourse = new List<Course>();
            foreach (Course course in _yourData.YourCourse)
                resultCourse.Add(course);
            return resultCourse;
        }

        //按下退選按鈕
        public void PressRemoveCourseButton(int? columnIndex, int? rowIndex)
        {
            if (columnIndex != null || rowIndex != null)
            {
                if ((int)columnIndex == 0)
                    _yourData.RemoveCourseAt((int)rowIndex);
            }
        }
    }
}
