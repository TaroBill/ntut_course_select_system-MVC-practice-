using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class ImportCourseProgressFormPresentationModel
    {
        public delegate void ProgressChangedEventHandler();
        public ProgressChangedEventHandler ProgressChanged
        {
            get; set;
        }

        //通知CourseChanged
        public void NotifyProgressObserver()
        {
            ProgressChanged?.Invoke();
        }

        private string _nowProgressLabelText;
        public string NowProgressLabelText
        {
            get
            {
                return _nowProgressLabelText;
            }
            set
            {
                _nowProgressLabelText = value;
                NotifyProgressObserver();
            }
        }

        private readonly Data _yourData;

        public ImportCourseProgressFormPresentationModel(Data yourData)
        {
            _yourData = yourData;
            _yourData.NowProgress = 0;
            NowProgressLabelText = "0%";
        }

        public Data YourData
        {
            get
            {
                return _yourData;
            }
        }

        //將所有資工課加入allCourse
        public void AddComputerScienceCourse()
        {
            _yourData.ProgressChanged += SetProgressFromData;
            _yourData.AddComputerScience();
        }

        //從yourData獲取一次資料
        public void SetProgressFromData()
        {
            NowProgressLabelText = _yourData.Progress;
        }
    }
}
