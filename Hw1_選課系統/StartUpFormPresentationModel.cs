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

        private CourseForm _courseForm;
        public CourseForm CourseSelectForm
        {
            get
            {
                return _courseForm;
            }
            set
            {
                _courseForm = value;
                CourseSelectButtonEnable = !CourseSelectButtonEnable;
            }
        }
        private CourseManagementForm _courseManagementForm;
        public CourseManagementForm CourseManageForm
        {
            get
            {
                return _courseManagementForm;
            }
            set
            {
                _courseManagementForm = value;
                CourseManageButtonEnable = !CourseManageButtonEnable;
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

        //顯示選課系統
        public void ShowCourseSelectForm()
        {
            CourseWebCrawlerModel courseWebCrawlerModel = new CourseWebCrawlerModel();
            CourseFormPresentationModel courseFormPresentationModel = new CourseFormPresentationModel(courseWebCrawlerModel, _yourData);
            CourseSelectForm = new CourseForm(courseFormPresentationModel);
            CourseSelectForm.FormClosed += SelectFormClosed;
            CourseSelectForm.Show();
        }

        //判定SelectForm是否關閉
        private void SelectFormClosed(object sender, EventArgs e)
        {
            CourseSelectForm = null;
        }

        //判定ManageForm是否關閉
        private void ManageFormClosed(object sender, EventArgs e)
        {
            CourseManageForm = null;
        }

        //顯示課程管理系統
        public void ShowCourseManageForm()
        {
            CourseManageForm = new CourseManagementForm();
            CourseManageForm.FormClosed += ManageFormClosed;
            CourseManageForm.Show();
        }
    }
}
