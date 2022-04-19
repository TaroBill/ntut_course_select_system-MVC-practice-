using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class CourseSelectionResultPresentationModel
    {
        private readonly Data _yourData;

        public CourseSelectionResultPresentationModel(Data data)
        {
            _yourData = data;
        }

        //按下退選按鈕
        public void PressRemoveCourseButton(int? columnIndex, int? rowIndex)
        {
            if (columnIndex != null && rowIndex != null)
            {
                if ((int)columnIndex == 0)
                {
                    _yourData.RemoveCourseAt((int)rowIndex);
                    _yourData.NotifyCourseObserver();
                }
                    
            }
        }
    }
}
