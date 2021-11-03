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
    public partial class CourseManageForm : Form
    {
        private readonly Data _yourData;
        private readonly CourseManageFormPresentationModel _courseManageFormPresentationModel;
        const string TEXT = "Text";
        public CourseManageForm(Data yourData)
        {
            InitializeComponent();
            _courseManageFormPresentationModel = new CourseManageFormPresentationModel(yourData);
            _yourData = yourData;
            ChangeDataSourceUpdateMode(DataSourceUpdateMode.Never);
            BindTools();
            EventConnector();
            InitDataGridView();
        }

        //將textbox變動事件繫結到一個function
        private void EventConnector()
        {
            _courseManageFormPresentationModel.ButtonChangedEnable += UpdateButton;
            _courseNumberTextBox.TextChanged += SendCourseToModel;
            _courseNameTextBox.TextChanged += SendCourseToModel;
            _courseStageTextBox.TextChanged += SendCourseToModel; 
            _courseCreditTextBox.TextChanged += SendCourseToModel;
            _courseTeacherTextBox.TextChanged += SendCourseToModel;
            _courseClassTypeComboBox.TextChanged += SendCourseToModel;
            _courseTeacherAssistanceTextBox.TextChanged += SendCourseToModel;
            _courseLanguageTextBox.TextChanged += SendCourseToModel;
            _courseNoteTextBox.TextChanged += SendCourseToModel;
            _courseHourComboBox.TextChanged += SendCourseToModel;
            _courseClassComboBox.TextChanged += SendCourseToModel;
            _classTimeDataGridView.CellContentClick += SendCourseToModel;
            _courseNumberTextBox.KeyPress +=  PressKeyInNumberOnlyTextBox;
            _courseStageTextBox.KeyPress += PressKeyInNumberOnlyTextBox;
            _courseCreditTextBox.KeyPress += PressKeyInNumberOnlyTextBox;
        }

        //送出所有資料更新
        public void SendCourseToModel(object sender = null, EventArgs e = null)
        {
            _courseManageFormPresentationModel.TemporaryCourseData = new Course(_courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text,
                _courseTeacherTextBox.Text, _courseClassTypeComboBox.Text, _courseTeacherAssistanceTextBox.Text, _courseLanguageTextBox.Text, _courseNoteTextBox.Text,
                _courseHourComboBox.Text, _courseClassComboBox.Text);
            _courseManageFormPresentationModel.SaveButtonEnable = _courseManageFormPresentationModel.CheckCourseNeccessary();
        }

        //更新按鈕狀態
        private void UpdateButton()
        {
            _saveButton.Enabled = _courseManageFormPresentationModel.SaveButtonEnable;
            _saveButton.Text = _courseManageFormPresentationModel.SaveButtonText;
            _courseGroupBox.Text = _courseManageFormPresentationModel.GroupBoxText;
        }

        //初始化classTime的dataGridView
        private void InitDataGridView()
        {
            _classTimeDataGridView.DataSource = _courseManageFormPresentationModel.ClassTime;
        }

        //dataBinding所有元件
        private void BindTools()
        {
            _courseNumberTextBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Number");
            _courseNameTextBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Name");
            _courseStageTextBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Stage");
            _courseCreditTextBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Credit");
            _courseTeacherTextBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Teacher");
            _courseTeacherAssistanceTextBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Assistance");
            _courseLanguageTextBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Language");
            _courseNoteTextBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Note");
            _courseHourComboBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Hour");
            _courseClassComboBox.DataBindings.Add(TEXT, _yourData.AllCourses, "Class");
            _courseClassTypeComboBox.DataBindings.Add(TEXT, _yourData.AllCourses, "ClassType");
            _courseBindingSource.DataSource = _yourData.AllCourses;
        }

        //改變資料的dataBinding單雙向連結
        private void ChangeDataSourceUpdateMode(DataSourceUpdateMode mode)
        {
            _courseNumberTextBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseNameTextBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseStageTextBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseCreditTextBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseTeacherTextBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseTeacherAssistanceTextBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseLanguageTextBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseNoteTextBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseHourComboBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseClassComboBox.DataBindings.DefaultDataSourceUpdateMode = mode;
            _courseClassTypeComboBox.DataBindings.DefaultDataSourceUpdateMode = mode;
        }

        private BindingManagerBase BindingManager
        {
            get 
            { 
                return BindingContext[_yourData.AllCourses]; 
            }
        }

        //移除所有輸入方塊的text
        private void ClearText()
        {
            _chooseOpenComboBox.SelectedIndex = 0;
            _courseNumberTextBox.Text = "";
            _courseNameTextBox.Text = "";
            _courseStageTextBox.Text = "";
            _courseCreditTextBox.Text = "";
            _courseTeacherTextBox.Text = "";
            _courseClassTypeComboBox.SelectedIndex = 0;
            _courseTeacherAssistanceTextBox.Text = "";
            _courseLanguageTextBox.Text = "";
            _courseNoteTextBox.Text = "";
            _courseHourComboBox.SelectedIndex = 0;
            _courseClassComboBox.SelectedIndex = 0;
            SendCourseToModel();
        }

        //當選擇其他課程時
        private void SelectedIndexChangedCoursesListBox(object sender, EventArgs e)
        {
            _courseBindingSource.ResumeBinding();
            _courseManageFormPresentationModel.SaveButtonEnable = false;
            _courseManageFormPresentationModel.AddNewButtonMode = 0;
            BindingManager.Position = _coursesListBox.SelectedIndex;
            _courseManageFormPresentationModel.LoadCourseClassTimeToDataGridView(_coursesListBox.SelectedIndex);
            _classTimeDataGridView.Refresh();
        }

        //點擊儲存按鈕
        private void ClickSaveButton(object sender, EventArgs e)
        {
            _courseManageFormPresentationModel.ChangeCourseInfo(_coursesListBox.SelectedIndex);
        }

        //點擊選擇開課時間
        private void CellContentClickClassTimeDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            _classTimeDataGridView.EndEdit();
            _courseManageFormPresentationModel.SetClassTimeEnable(_classTimeDataGridView?.CurrentCellAddress, (bool)_classTimeDataGridView.CurrentCell.Value);
        }

        //textBox按鈕輸入事件
        private void PressKeyInNumberOnlyTextBox(object sender, KeyPressEventArgs e)
        {
                e.Handled = _courseManageFormPresentationModel.InputTextBoxNumberOnly((int)e.KeyChar);
        }

        //點擊新增課程
        private void ClickAddNewCourseButton(object sender, EventArgs e)
        {
            _courseBindingSource.SuspendBinding();
            ClearText();
            _courseManageFormPresentationModel.ResetAllPeriods();
            _classTimeDataGridView.Refresh();
            _courseManageFormPresentationModel.AddNewButtonMode = 1;
        }
    }
}
