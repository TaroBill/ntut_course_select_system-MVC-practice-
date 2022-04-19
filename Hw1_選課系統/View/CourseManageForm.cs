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
            EventConnector();
            ChangeDataSourceUpdateMode(DataSourceUpdateMode.Never);
            BindTools();
            InitDataGridView();
            SetAddCourseMode();
            UpdateClasses();
            _courseManageFormPresentationModel.AddNewClassMode = 0;
            _classNameTextBox.Enabled = false;
            ClearClassText();
        }

        //更新可選班級的combobox和所有班級的listbox
        public void UpdateClasses()
        {
            _courseClassComboBox.Items.Clear();
            _courseClassComboBox.Items.AddRange(_yourData.AllClassesNameList);
            _allClassesListBox.DataSource = _yourData.AllClassesNameList;
        }

        //送出所有資料更新
        public void SendCourseToModel(object sender = null, EventArgs e = null)
        {
            Course storedCourse = new Course(_courseNumberTextBox.Text, _courseNameTextBox.Text, _courseStageTextBox.Text, _courseCreditTextBox.Text,
                _courseTeacherTextBox.Text, _courseClassTypeComboBox.Text, _courseTeacherAssistanceTextBox.Text, _courseLanguageTextBox.Text, _courseNoteTextBox.Text,
                _courseHourComboBox.Text, _courseClassComboBox.Text)
            { 
                IsOpened = _chooseOpenComboBox.Text
            };
            _courseManageFormPresentationModel.TemporaryCourseData = storedCourse;
            _courseManageFormPresentationModel.SaveButtonEnable = _courseManageFormPresentationModel.CheckCourseNeccessary();
        }

        //更新按鈕狀態
        private void UpdateButton()
        {
            _saveButton.Enabled = _courseManageFormPresentationModel.SaveButtonEnable;
            _saveButton.Text = _courseManageFormPresentationModel.SaveButtonText;
            _courseGroupBox.Text = _courseManageFormPresentationModel.CourseGroupBoxText;
            _classGroupBox.Text = _courseManageFormPresentationModel.ClassGroupBoxText;
            _addButton.Enabled = _courseManageFormPresentationModel.AppendClassButtonEnable;
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
            _chooseOpenComboBox.DataBindings.Add(TEXT, _yourData.AllCourses, "IsOpened");
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
            _chooseOpenComboBox.DataBindings.DefaultDataSourceUpdateMode = mode;
        }

        private BindingManagerBase BindingManager
        {
            get 
            { 
                return BindingContext[_yourData.AllCourses]; 
            }
        }

        //移除所有輸入方塊的text
        private void ClearCourseText()
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

        //移除所有輸入方塊的text
        private void ClearClassText()
        {
            _classNameTextBox.Text = "";
            _classCoursesListBox.DataSource = null;
        }

            //當選擇其他課程時
            private void SelectedIndexChangedCoursesListBox(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            BindingManager.ResumeBinding();
            _courseBindingSource.ResumeBinding();
            _courseManageFormPresentationModel.AddNewButtonMode = 0;
            BindingManager.Position = listBox.SelectedIndex;
            _courseManageFormPresentationModel.LoadCourseClassTimeToDataGridView(listBox.SelectedIndex);
            _classTimeDataGridView.Refresh();
            _courseManageFormPresentationModel.SaveButtonEnable = false;
        }

        //當選擇其他班級時
        private void SelectedIndexChangedClassesListBox(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            string name = _yourData.AllClassesNameList[listBox.SelectedIndex];
            _classNameTextBox.Text = name;
            UpdateClassCourseListBox();
            _courseManageFormPresentationModel.AddNewClassMode = 0;
            _addButton.Enabled = false;
            _addClassButton.Enabled = true;
        }

        //更新所選班級的課程
        private void UpdateClassCourseListBox()
        {
            _classCoursesListBox.DataSource = _courseManageFormPresentationModel.GetClassCoursesList(_allClassesListBox.SelectedIndex);
        }

        //點擊儲存按鈕
        private void ClickAddClassButton(object sender, EventArgs e)
        {
            _addClassButton.Enabled = false;
            _classNameTextBox.Enabled = true;
            ClearClassText();
            _courseManageFormPresentationModel.AddNewClassMode = 1;
        }

        //當變更班級名稱時
        private void ChangeClassNameTextBoxText(object sender, EventArgs e)
        {
            _courseManageFormPresentationModel.ClassNameTextBoxText = _classNameTextBox.Text;
        }

        //點擊新增班級按鈕
        private void ClickAppendClassButton(object sender, EventArgs e)
        {
            _yourData.AddClass(_classNameTextBox.Text);
            UpdateClasses();
            _yourData.NotifyDone();
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
            SetAddCourseMode();
        }

        //設置成新增課程模式
        private void SetAddCourseMode()
        {
            _coursesListBox.SelectedIndex = -1;
            BindingManager.SuspendBinding();
            _courseBindingSource.SuspendBinding();
            _courseManageFormPresentationModel.ResetAllPeriods();
            _classTimeDataGridView.Refresh();
            _courseManageFormPresentationModel.AddNewButtonMode = 1;
            ClearCourseText();
        }


        private ImportCourseProgressForm _importCourseProgressForm;
        //按下加入所有資工課程按鈕
        private void ClickAddAllComputerScienceButton(object sender, EventArgs e)
        {
            _importCourseProgressForm = new ImportCourseProgressForm(new ImportCourseProgressFormPresentationModel(_yourData));
            _addAllComputerScienceButton.Enabled = false;
            _importCourseProgressForm.ShowDialog();
            _addAllComputerScienceButton.Enabled = true;
        }

        //當調整是否開課
        private void IsOpenedComboBoxChanged(object sender, EventArgs e)
        {
            _yourData.NotifyCourseObserver();
        }
    }
}
