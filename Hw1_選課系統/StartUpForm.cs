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
            _startUpFormPresentationModel.ShowCourseSelectForm();
        }

        //點擊管理目前選課系統
        private void ClickCourseManagement(object sender, EventArgs e)
        {
            _startUpFormPresentationModel.ShowCourseManageForm();
        }

        //點擊退出按鈕
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
