using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_選課系統
{
    public partial class StartUpForm : Form
    {
        private CourseForm _courseForm;
        private CourseForm CourseSelectForm
        {
            get
            {
                return _courseForm;
            }
            set
            {
                _courseForm = value;
                _startUpFormPresentationModel.CourseSelectButtonEnable = !_startUpFormPresentationModel.CourseSelectButtonEnable;
            }
        }
        private CourseManageForm _courseManagementForm;
        private CourseManageForm CourseManageForm
        {
            get
            {
                return _courseManagementForm;
            }
            set
            {
                _courseManagementForm = value;
                _startUpFormPresentationModel.CourseManageButtonEnable = !_startUpFormPresentationModel.CourseManageButtonEnable;
            }
        }

        private readonly StartUpFormPresentationModel _startUpFormPresentationModel;
        public StartUpForm()
        {
            InitializeComponent();
            _startUpFormPresentationModel = new StartUpFormPresentationModel();
            _startUpFormPresentationModel.ButtonChangedEnable += UpdateButtonEnable;
        }

        //更新所有按鈕的狀態
        private void UpdateButtonEnable()
        {
            _courseManagementButton.Enabled = _startUpFormPresentationModel.CourseManageButtonEnable;
            _courseSelectButton.Enabled = _startUpFormPresentationModel.CourseSelectButtonEnable;
        }

        //點擊選課系統
        private void ClickCourseSelect(object sender, EventArgs e)
        {
            CourseWebCrawlerModel courseWebCrawlerModel = new CourseWebCrawlerModel();
            CourseFormPresentationModel courseFormPresentationModel = new CourseFormPresentationModel(courseWebCrawlerModel, _startUpFormPresentationModel.YourData);
            CourseSelectForm = new CourseForm(courseFormPresentationModel, _startUpFormPresentationModel.YourData);
            CourseSelectForm.FormClosed += SelectFormClosed;
            CourseSelectForm.Show();
        }

        //點擊管理目前選課系統
        private void ClickCourseManagement(object sender, EventArgs e)
        {
            CourseManageForm = new CourseManageForm(_startUpFormPresentationModel.YourData);
            CourseManageForm.FormClosed += ManageFormClosed;
            CourseManageForm.Show();
        }

        //點擊退出按鈕
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
