using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_選課系統
{
    public class StartUpFormPresentationModel
    {
        private readonly Data _yourData;
        public delegate void ButtonChangedEnableEventHandler();
        public ButtonChangedEnableEventHandler ButtonChangedEnable
        {
            get; set;
        }

        public StartUpFormPresentationModel()
        {
            _yourData = new Data();
        }

        public Data YourData
        {
            get
            {
                return _yourData;
            }
        }

        //呼叫view更新所有button狀態
        private void NotifyButtonEnableObserver()
        {
            ButtonChangedEnable?.Invoke();
        }

        private bool _courseSelectButtonEnable = true;
        public bool CourseSelectButtonEnable
        {
            get
            {
                return _courseSelectButtonEnable;
            }
            set
            {
                _courseSelectButtonEnable = value;
                NotifyButtonEnableObserver();
            }
        }

        private bool _courseManageButtonEnable = true;
        public bool CourseManageButtonEnable
        {
            get
            {
                return _courseManageButtonEnable;
            }
            set
            {
                _courseManageButtonEnable = value;
                NotifyButtonEnableObserver();
            }
        }

    }
}
