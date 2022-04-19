
namespace Homework_選課系統
{
    partial class CourseManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
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
            _chooseOpenComboBox.TextChanged += SendCourseToModel;
            _courseNumberTextBox.KeyPress += PressKeyInNumberOnlyTextBox;
            _courseStageTextBox.KeyPress += PressKeyInNumberOnlyTextBox;
            _courseCreditTextBox.KeyPress += PressKeyInNumberOnlyTextBox;
            _allClassesListBox.SelectedIndexChanged += SelectedIndexChangedClassesListBox;
            _addClassButton.Click += ClickAddClassButton;
            _classNameTextBox.TextChanged += ChangeClassNameTextBoxText;
            _addButton.Click += ClickAppendClassButton;
            _yourData.CourseChanged += UpdateClassCourseListBox;
            _yourData.Done += UpdateClasses;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.BindingSource classTimePeriodBindingSource;
            this._tabControl = new System.Windows.Forms.TabControl();
            this._courseManageTabPage = new System.Windows.Forms.TabPage();
            this._addAllComputerScienceButton = new System.Windows.Forms.Button();
            this._courseGroupBox = new System.Windows.Forms.GroupBox();
            this._courseClassTypeLabel = new System.Windows.Forms.Label();
            this._courseTeacherLabel = new System.Windows.Forms.Label();
            this._courseCreditLabel = new System.Windows.Forms.Label();
            this._courseClassLabel = new System.Windows.Forms.Label();
            this._courseLanguageLabel = new System.Windows.Forms.Label();
            this._courseTeacherAssistanceLabel = new System.Windows.Forms.Label();
            this._courseHourLabel = new System.Windows.Forms.Label();
            this._courseNoteLabel = new System.Windows.Forms.Label();
            this._courseStageLabel = new System.Windows.Forms.Label();
            this._courseNameLabel = new System.Windows.Forms.Label();
            this._courseNumberLabel = new System.Windows.Forms.Label();
            this._courseLanguageTextBox = new System.Windows.Forms.TextBox();
            this._courseTeacherTextBox = new System.Windows.Forms.TextBox();
            this._courseNoteTextBox = new System.Windows.Forms.TextBox();
            this._courseTeacherAssistanceTextBox = new System.Windows.Forms.TextBox();
            this._courseCreditTextBox = new System.Windows.Forms.TextBox();
            this._courseStageTextBox = new System.Windows.Forms.TextBox();
            this._courseNameTextBox = new System.Windows.Forms.TextBox();
            this._courseNumberTextBox = new System.Windows.Forms.TextBox();
            this._courseClassTypeComboBox = new System.Windows.Forms.ComboBox();
            this._courseHourComboBox = new System.Windows.Forms.ComboBox();
            this._courseClassComboBox = new System.Windows.Forms.ComboBox();
            this._chooseOpenComboBox = new System.Windows.Forms.ComboBox();
            this._classTimeDataGridView = new System.Windows.Forms.DataGridView();
            this._periodsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sundayColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._mondayColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._tuesdayColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._wednesdayColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._thursdayColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._fridayColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._saturdayColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._saveButton = new System.Windows.Forms.Button();
            this._addNewCourseButton = new System.Windows.Forms.Button();
            this._coursesListBox = new System.Windows.Forms.ListBox();
            this._courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._classManageTabPage = new System.Windows.Forms.TabPage();
            this._addClassButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._classGroupBox = new System.Windows.Forms.GroupBox();
            this._classCoursesListBox = new System.Windows.Forms.ListBox();
            this._classNameTextBox = new System.Windows.Forms.TextBox();
            this._classContainCourseLabel = new System.Windows.Forms.Label();
            this._classNameLabel = new System.Windows.Forms.Label();
            this._allClassesListBox = new System.Windows.Forms.ListBox();
            classTimePeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(classTimePeriodBindingSource)).BeginInit();
            this._tabControl.SuspendLayout();
            this._courseManageTabPage.SuspendLayout();
            this._courseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._classTimeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._courseBindingSource)).BeginInit();
            this._classManageTabPage.SuspendLayout();
            this._classGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classTimePeriodBindingSource
            // 
            classTimePeriodBindingSource.DataSource = typeof(Homework_選課系統.ClassTimePeriod);
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._courseManageTabPage);
            this._tabControl.Controls.Add(this._classManageTabPage);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(800, 450);
            this._tabControl.TabIndex = 0;
            // 
            // _courseManageTabPage
            // 
            this._courseManageTabPage.Controls.Add(this._addAllComputerScienceButton);
            this._courseManageTabPage.Controls.Add(this._courseGroupBox);
            this._courseManageTabPage.Controls.Add(this._saveButton);
            this._courseManageTabPage.Controls.Add(this._addNewCourseButton);
            this._courseManageTabPage.Controls.Add(this._coursesListBox);
            this._courseManageTabPage.Location = new System.Drawing.Point(4, 22);
            this._courseManageTabPage.Name = "_courseManageTabPage";
            this._courseManageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._courseManageTabPage.Size = new System.Drawing.Size(792, 424);
            this._courseManageTabPage.TabIndex = 0;
            this._courseManageTabPage.Text = "課程管理";
            this._courseManageTabPage.UseVisualStyleBackColor = true;
            // 
            // _addAllComputerScienceButton
            // 
            this._addAllComputerScienceButton.Location = new System.Drawing.Point(78, 354);
            this._addAllComputerScienceButton.Name = "_addAllComputerScienceButton";
            this._addAllComputerScienceButton.Size = new System.Drawing.Size(65, 59);
            this._addAllComputerScienceButton.TabIndex = 4;
            this._addAllComputerScienceButton.Text = "匯入資工系全部課程";
            this._addAllComputerScienceButton.UseVisualStyleBackColor = true;
            this._addAllComputerScienceButton.Click += new System.EventHandler(this.ClickAddAllComputerScienceButton);
            // 
            // _courseGroupBox
            // 
            this._courseGroupBox.Controls.Add(this._courseClassTypeLabel);
            this._courseGroupBox.Controls.Add(this._courseTeacherLabel);
            this._courseGroupBox.Controls.Add(this._courseCreditLabel);
            this._courseGroupBox.Controls.Add(this._courseClassLabel);
            this._courseGroupBox.Controls.Add(this._courseLanguageLabel);
            this._courseGroupBox.Controls.Add(this._courseTeacherAssistanceLabel);
            this._courseGroupBox.Controls.Add(this._courseHourLabel);
            this._courseGroupBox.Controls.Add(this._courseNoteLabel);
            this._courseGroupBox.Controls.Add(this._courseStageLabel);
            this._courseGroupBox.Controls.Add(this._courseNameLabel);
            this._courseGroupBox.Controls.Add(this._courseNumberLabel);
            this._courseGroupBox.Controls.Add(this._courseLanguageTextBox);
            this._courseGroupBox.Controls.Add(this._courseTeacherTextBox);
            this._courseGroupBox.Controls.Add(this._courseNoteTextBox);
            this._courseGroupBox.Controls.Add(this._courseTeacherAssistanceTextBox);
            this._courseGroupBox.Controls.Add(this._courseCreditTextBox);
            this._courseGroupBox.Controls.Add(this._courseStageTextBox);
            this._courseGroupBox.Controls.Add(this._courseNameTextBox);
            this._courseGroupBox.Controls.Add(this._courseNumberTextBox);
            this._courseGroupBox.Controls.Add(this._courseClassTypeComboBox);
            this._courseGroupBox.Controls.Add(this._courseHourComboBox);
            this._courseGroupBox.Controls.Add(this._courseClassComboBox);
            this._courseGroupBox.Controls.Add(this._chooseOpenComboBox);
            this._courseGroupBox.Controls.Add(this._classTimeDataGridView);
            this._courseGroupBox.Location = new System.Drawing.Point(149, 0);
            this._courseGroupBox.Name = "_courseGroupBox";
            this._courseGroupBox.Size = new System.Drawing.Size(637, 369);
            this._courseGroupBox.TabIndex = 3;
            this._courseGroupBox.TabStop = false;
            this._courseGroupBox.Text = "編輯課程";
            // 
            // _courseClassTypeLabel
            // 
            this._courseClassTypeLabel.AutoSize = true;
            this._courseClassTypeLabel.Location = new System.Drawing.Point(468, 56);
            this._courseClassTypeLabel.Name = "_courseClassTypeLabel";
            this._courseClassTypeLabel.Size = new System.Drawing.Size(31, 12);
            this._courseClassTypeLabel.TabIndex = 3;
            this._courseClassTypeLabel.Text = "修(*)";
            // 
            // _courseTeacherLabel
            // 
            this._courseTeacherLabel.AutoSize = true;
            this._courseTeacherLabel.Location = new System.Drawing.Point(309, 56);
            this._courseTeacherLabel.Name = "_courseTeacherLabel";
            this._courseTeacherLabel.Size = new System.Drawing.Size(43, 12);
            this._courseTeacherLabel.TabIndex = 3;
            this._courseTeacherLabel.Text = "教師(*)";
            // 
            // _courseCreditLabel
            // 
            this._courseCreditLabel.AutoSize = true;
            this._courseCreditLabel.Location = new System.Drawing.Point(143, 56);
            this._courseCreditLabel.Name = "_courseCreditLabel";
            this._courseCreditLabel.Size = new System.Drawing.Size(43, 12);
            this._courseCreditLabel.TabIndex = 3;
            this._courseCreditLabel.Text = "學分(*)";
            // 
            // _courseClassLabel
            // 
            this._courseClassLabel.AutoSize = true;
            this._courseClassLabel.Location = new System.Drawing.Point(309, 144);
            this._courseClassLabel.Name = "_courseClassLabel";
            this._courseClassLabel.Size = new System.Drawing.Size(43, 12);
            this._courseClassLabel.TabIndex = 3;
            this._courseClassLabel.Text = "班級(*)";
            // 
            // _courseLanguageLabel
            // 
            this._courseLanguageLabel.AutoSize = true;
            this._courseLanguageLabel.Location = new System.Drawing.Point(309, 84);
            this._courseLanguageLabel.Name = "_courseLanguageLabel";
            this._courseLanguageLabel.Size = new System.Drawing.Size(53, 12);
            this._courseLanguageLabel.TabIndex = 3;
            this._courseLanguageLabel.Text = "授課語言";
            // 
            // _courseTeacherAssistanceLabel
            // 
            this._courseTeacherAssistanceLabel.AutoSize = true;
            this._courseTeacherAssistanceLabel.Location = new System.Drawing.Point(3, 84);
            this._courseTeacherAssistanceLabel.Name = "_courseTeacherAssistanceLabel";
            this._courseTeacherAssistanceLabel.Size = new System.Drawing.Size(53, 12);
            this._courseTeacherAssistanceLabel.TabIndex = 3;
            this._courseTeacherAssistanceLabel.Text = "教學助理";
            // 
            // _courseHourLabel
            // 
            this._courseHourLabel.AutoSize = true;
            this._courseHourLabel.Location = new System.Drawing.Point(3, 144);
            this._courseHourLabel.Name = "_courseHourLabel";
            this._courseHourLabel.Size = new System.Drawing.Size(43, 12);
            this._courseHourLabel.TabIndex = 3;
            this._courseHourLabel.Text = "時數(*)";
            // 
            // _courseNoteLabel
            // 
            this._courseNoteLabel.AutoSize = true;
            this._courseNoteLabel.Location = new System.Drawing.Point(3, 112);
            this._courseNoteLabel.Name = "_courseNoteLabel";
            this._courseNoteLabel.Size = new System.Drawing.Size(29, 12);
            this._courseNoteLabel.TabIndex = 3;
            this._courseNoteLabel.Text = "備註";
            // 
            // _courseStageLabel
            // 
            this._courseStageLabel.AutoSize = true;
            this._courseStageLabel.Location = new System.Drawing.Point(3, 56);
            this._courseStageLabel.Name = "_courseStageLabel";
            this._courseStageLabel.Size = new System.Drawing.Size(43, 12);
            this._courseStageLabel.TabIndex = 3;
            this._courseStageLabel.Text = "階段(*)";
            // 
            // _courseNameLabel
            // 
            this._courseNameLabel.AutoSize = true;
            this._courseNameLabel.Location = new System.Drawing.Point(309, 24);
            this._courseNameLabel.Name = "_courseNameLabel";
            this._courseNameLabel.Size = new System.Drawing.Size(67, 12);
            this._courseNameLabel.TabIndex = 3;
            this._courseNameLabel.Text = "課程名稱(*)";
            // 
            // _courseNumberLabel
            // 
            this._courseNumberLabel.AutoSize = true;
            this._courseNumberLabel.Location = new System.Drawing.Point(143, 24);
            this._courseNumberLabel.Name = "_courseNumberLabel";
            this._courseNumberLabel.Size = new System.Drawing.Size(43, 12);
            this._courseNumberLabel.TabIndex = 3;
            this._courseNumberLabel.Text = "課號(*)";
            // 
            // _courseLanguageTextBox
            // 
            this._courseLanguageTextBox.Location = new System.Drawing.Point(362, 81);
            this._courseLanguageTextBox.Name = "_courseLanguageTextBox";
            this._courseLanguageTextBox.Size = new System.Drawing.Size(269, 22);
            this._courseLanguageTextBox.TabIndex = 2;
            // 
            // _courseTeacherTextBox
            // 
            this._courseTeacherTextBox.Location = new System.Drawing.Point(362, 53);
            this._courseTeacherTextBox.Name = "_courseTeacherTextBox";
            this._courseTeacherTextBox.Size = new System.Drawing.Size(100, 22);
            this._courseTeacherTextBox.TabIndex = 2;
            // 
            // _courseNoteTextBox
            // 
            this._courseNoteTextBox.Location = new System.Drawing.Point(62, 109);
            this._courseNoteTextBox.Name = "_courseNoteTextBox";
            this._courseNoteTextBox.Size = new System.Drawing.Size(569, 22);
            this._courseNoteTextBox.TabIndex = 2;
            // 
            // _courseTeacherAssistanceTextBox
            // 
            this._courseTeacherAssistanceTextBox.Location = new System.Drawing.Point(62, 81);
            this._courseTeacherAssistanceTextBox.Name = "_courseTeacherAssistanceTextBox";
            this._courseTeacherAssistanceTextBox.Size = new System.Drawing.Size(241, 22);
            this._courseTeacherAssistanceTextBox.TabIndex = 2;
            // 
            // _courseCreditTextBox
            // 
            this._courseCreditTextBox.Location = new System.Drawing.Point(192, 53);
            this._courseCreditTextBox.Name = "_courseCreditTextBox";
            this._courseCreditTextBox.Size = new System.Drawing.Size(111, 22);
            this._courseCreditTextBox.TabIndex = 2;
            // 
            // _courseStageTextBox
            // 
            this._courseStageTextBox.Location = new System.Drawing.Point(62, 53);
            this._courseStageTextBox.Name = "_courseStageTextBox";
            this._courseStageTextBox.Size = new System.Drawing.Size(64, 22);
            this._courseStageTextBox.TabIndex = 2;
            // 
            // _courseNameTextBox
            // 
            this._courseNameTextBox.Location = new System.Drawing.Point(382, 19);
            this._courseNameTextBox.Name = "_courseNameTextBox";
            this._courseNameTextBox.Size = new System.Drawing.Size(249, 22);
            this._courseNameTextBox.TabIndex = 2;
            // 
            // _courseNumberTextBox
            // 
            this._courseNumberTextBox.Location = new System.Drawing.Point(192, 21);
            this._courseNumberTextBox.Name = "_courseNumberTextBox";
            this._courseNumberTextBox.Size = new System.Drawing.Size(111, 22);
            this._courseNumberTextBox.TabIndex = 2;
            // 
            // _courseClassTypeComboBox
            // 
            this._courseClassTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._courseClassTypeComboBox.FormattingEnabled = true;
            this._courseClassTypeComboBox.Items.AddRange(new object[] {
            "○",
            "△",
            "☆",
            "●",
            "▲",
            "★"});
            this._courseClassTypeComboBox.Location = new System.Drawing.Point(505, 53);
            this._courseClassTypeComboBox.Name = "_courseClassTypeComboBox";
            this._courseClassTypeComboBox.Size = new System.Drawing.Size(126, 20);
            this._courseClassTypeComboBox.TabIndex = 1;
            // 
            // _courseHourComboBox
            // 
            this._courseHourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._courseHourComboBox.FormattingEnabled = true;
            this._courseHourComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this._courseHourComboBox.Location = new System.Drawing.Point(62, 139);
            this._courseHourComboBox.Name = "_courseHourComboBox";
            this._courseHourComboBox.Size = new System.Drawing.Size(241, 20);
            this._courseHourComboBox.TabIndex = 1;
            // 
            // _courseClassComboBox
            // 
            this._courseClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._courseClassComboBox.FormattingEnabled = true;
            this._courseClassComboBox.Items.AddRange(new object[] {
            "資工三",
            "電子三"});
            this._courseClassComboBox.Location = new System.Drawing.Point(366, 137);
            this._courseClassComboBox.Name = "_courseClassComboBox";
            this._courseClassComboBox.Size = new System.Drawing.Size(269, 20);
            this._courseClassComboBox.TabIndex = 1;
            // 
            // _chooseOpenComboBox
            // 
            this._chooseOpenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._chooseOpenComboBox.FormattingEnabled = true;
            this._chooseOpenComboBox.Items.AddRange(new object[] {
            "開課",
            "未開課"});
            this._chooseOpenComboBox.Location = new System.Drawing.Point(15, 21);
            this._chooseOpenComboBox.Name = "_chooseOpenComboBox";
            this._chooseOpenComboBox.Size = new System.Drawing.Size(111, 20);
            this._chooseOpenComboBox.TabIndex = 1;
            // 
            // _classTimeDataGridView
            // 
            this._classTimeDataGridView.AllowUserToAddRows = false;
            this._classTimeDataGridView.AllowUserToDeleteRows = false;
            this._classTimeDataGridView.AllowUserToResizeColumns = false;
            this._classTimeDataGridView.AllowUserToResizeRows = false;
            this._classTimeDataGridView.AutoGenerateColumns = false;
            this._classTimeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._classTimeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._classTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._classTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._periodsColumn,
            this._sundayColumn,
            this._mondayColumn,
            this._tuesdayColumn,
            this._wednesdayColumn,
            this._thursdayColumn,
            this._fridayColumn,
            this._saturdayColumn});
            this._classTimeDataGridView.DataSource = classTimePeriodBindingSource;
            this._classTimeDataGridView.Location = new System.Drawing.Point(3, 165);
            this._classTimeDataGridView.Name = "_classTimeDataGridView";
            this._classTimeDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._classTimeDataGridView.RowHeadersVisible = false;
            this._classTimeDataGridView.RowTemplate.Height = 24;
            this._classTimeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._classTimeDataGridView.ShowCellErrors = false;
            this._classTimeDataGridView.ShowRowErrors = false;
            this._classTimeDataGridView.Size = new System.Drawing.Size(632, 198);
            this._classTimeDataGridView.TabIndex = 0;
            this._classTimeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClickClassTimeDataGridView);
            // 
            // _periodsColumn
            // 
            this._periodsColumn.DataPropertyName = "Period";
            this._periodsColumn.HeaderText = "節數";
            this._periodsColumn.Name = "_periodsColumn";
            // 
            // _sundayColumn
            // 
            this._sundayColumn.DataPropertyName = "Sunday";
            this._sundayColumn.HeaderText = "日";
            this._sundayColumn.Name = "_sundayColumn";
            // 
            // _mondayColumn
            // 
            this._mondayColumn.DataPropertyName = "Monday";
            this._mondayColumn.HeaderText = "一";
            this._mondayColumn.Name = "_mondayColumn";
            // 
            // _tuesdayColumn
            // 
            this._tuesdayColumn.DataPropertyName = "Tuesday";
            this._tuesdayColumn.HeaderText = "二";
            this._tuesdayColumn.Name = "_tuesdayColumn";
            // 
            // _wednesdayColumn
            // 
            this._wednesdayColumn.DataPropertyName = "Wednesday";
            this._wednesdayColumn.HeaderText = "三";
            this._wednesdayColumn.Name = "_wednesdayColumn";
            // 
            // _thursdayColumn
            // 
            this._thursdayColumn.DataPropertyName = "Thursday";
            this._thursdayColumn.HeaderText = "四";
            this._thursdayColumn.Name = "_thursdayColumn";
            // 
            // _fridayColumn
            // 
            this._fridayColumn.DataPropertyName = "Friday";
            this._fridayColumn.HeaderText = "五";
            this._fridayColumn.Name = "_fridayColumn";
            // 
            // _saturdayColumn
            // 
            this._saturdayColumn.DataPropertyName = "Saturday";
            this._saturdayColumn.HeaderText = "六";
            this._saturdayColumn.Name = "_saturdayColumn";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(658, 375);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(122, 44);
            this._saveButton.TabIndex = 1;
            this._saveButton.Text = "儲存";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.ClickSaveButton);
            // 
            // _addNewCourseButton
            // 
            this._addNewCourseButton.Location = new System.Drawing.Point(3, 354);
            this._addNewCourseButton.Name = "_addNewCourseButton";
            this._addNewCourseButton.Size = new System.Drawing.Size(65, 59);
            this._addNewCourseButton.TabIndex = 1;
            this._addNewCourseButton.Text = "新增課程";
            this._addNewCourseButton.UseVisualStyleBackColor = true;
            this._addNewCourseButton.Click += new System.EventHandler(this.ClickAddNewCourseButton);
            // 
            // _coursesListBox
            // 
            this._coursesListBox.DataSource = this._courseBindingSource;
            this._coursesListBox.DisplayMember = "Name";
            this._coursesListBox.FormattingEnabled = true;
            this._coursesListBox.ItemHeight = 12;
            this._coursesListBox.Location = new System.Drawing.Point(0, 0);
            this._coursesListBox.Name = "_coursesListBox";
            this._coursesListBox.Size = new System.Drawing.Size(146, 340);
            this._coursesListBox.TabIndex = 0;
            this._coursesListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChangedCoursesListBox);
            // 
            // _courseBindingSource
            // 
            this._courseBindingSource.DataSource = typeof(Homework_選課系統.Course);
            // 
            // _classManageTabPage
            // 
            this._classManageTabPage.Controls.Add(this._addClassButton);
            this._classManageTabPage.Controls.Add(this._addButton);
            this._classManageTabPage.Controls.Add(this._classGroupBox);
            this._classManageTabPage.Controls.Add(this._allClassesListBox);
            this._classManageTabPage.Location = new System.Drawing.Point(4, 22);
            this._classManageTabPage.Name = "_classManageTabPage";
            this._classManageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._classManageTabPage.Size = new System.Drawing.Size(792, 424);
            this._classManageTabPage.TabIndex = 1;
            this._classManageTabPage.Text = "班級管理";
            this._classManageTabPage.UseVisualStyleBackColor = true;
            // 
            // _addClassButton
            // 
            this._addClassButton.Location = new System.Drawing.Point(3, 372);
            this._addClassButton.Name = "_addClassButton";
            this._addClassButton.Size = new System.Drawing.Size(120, 44);
            this._addClassButton.TabIndex = 3;
            this._addClassButton.Text = "新增班級";
            this._addClassButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(670, 372);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(116, 44);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "新增";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _classGroupBox
            // 
            this._classGroupBox.Controls.Add(this._classCoursesListBox);
            this._classGroupBox.Controls.Add(this._classNameTextBox);
            this._classGroupBox.Controls.Add(this._classContainCourseLabel);
            this._classGroupBox.Controls.Add(this._classNameLabel);
            this._classGroupBox.Location = new System.Drawing.Point(129, 6);
            this._classGroupBox.Name = "_classGroupBox";
            this._classGroupBox.Size = new System.Drawing.Size(667, 361);
            this._classGroupBox.TabIndex = 1;
            this._classGroupBox.TabStop = false;
            this._classGroupBox.Text = "班級";
            // 
            // _classCoursesListBox
            // 
            this._classCoursesListBox.FormattingEnabled = true;
            this._classCoursesListBox.ItemHeight = 12;
            this._classCoursesListBox.Location = new System.Drawing.Point(9, 114);
            this._classCoursesListBox.Name = "_classCoursesListBox";
            this._classCoursesListBox.Size = new System.Drawing.Size(652, 232);
            this._classCoursesListBox.TabIndex = 2;
            // 
            // _classNameTextBox
            // 
            this._classNameTextBox.Location = new System.Drawing.Point(97, 58);
            this._classNameTextBox.Name = "_classNameTextBox";
            this._classNameTextBox.Size = new System.Drawing.Size(563, 22);
            this._classNameTextBox.TabIndex = 1;
            // 
            // _classContainCourseLabel
            // 
            this._classContainCourseLabel.AutoSize = true;
            this._classContainCourseLabel.Location = new System.Drawing.Point(7, 99);
            this._classContainCourseLabel.Name = "_classContainCourseLabel";
            this._classContainCourseLabel.Size = new System.Drawing.Size(65, 12);
            this._classContainCourseLabel.TabIndex = 0;
            this._classContainCourseLabel.Text = "班級內課程";
            // 
            // _classNameLabel
            // 
            this._classNameLabel.AutoSize = true;
            this._classNameLabel.Location = new System.Drawing.Point(6, 61);
            this._classNameLabel.Name = "_classNameLabel";
            this._classNameLabel.Size = new System.Drawing.Size(67, 12);
            this._classNameLabel.TabIndex = 0;
            this._classNameLabel.Text = "班級名稱(*)";
            // 
            // _allClassesListBox
            // 
            this._allClassesListBox.FormattingEnabled = true;
            this._allClassesListBox.ItemHeight = 12;
            this._allClassesListBox.Location = new System.Drawing.Point(3, 3);
            this._allClassesListBox.Name = "_allClassesListBox";
            this._allClassesListBox.Size = new System.Drawing.Size(120, 364);
            this._allClassesListBox.TabIndex = 0;
            // 
            // CourseManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._tabControl);
            this.Name = "CourseManageForm";
            this.Text = "CourseManageForm";
            ((System.ComponentModel.ISupportInitialize)(classTimePeriodBindingSource)).EndInit();
            this._tabControl.ResumeLayout(false);
            this._courseManageTabPage.ResumeLayout(false);
            this._courseGroupBox.ResumeLayout(false);
            this._courseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._classTimeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._courseBindingSource)).EndInit();
            this._classManageTabPage.ResumeLayout(false);
            this._classGroupBox.ResumeLayout(false);
            this._classGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _courseManageTabPage;
        private System.Windows.Forms.TabPage _classManageTabPage;
        private System.Windows.Forms.Button _addNewCourseButton;
        private System.Windows.Forms.ListBox _coursesListBox;
        private System.Windows.Forms.GroupBox _courseGroupBox;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.DataGridView _classTimeDataGridView;
        private System.Windows.Forms.Label _courseStageLabel;
        private System.Windows.Forms.Label _courseNameLabel;
        private System.Windows.Forms.Label _courseNumberLabel;
        private System.Windows.Forms.TextBox _courseLanguageTextBox;
        private System.Windows.Forms.TextBox _courseTeacherTextBox;
        private System.Windows.Forms.TextBox _courseNoteTextBox;
        private System.Windows.Forms.TextBox _courseTeacherAssistanceTextBox;
        private System.Windows.Forms.TextBox _courseCreditTextBox;
        private System.Windows.Forms.TextBox _courseStageTextBox;
        private System.Windows.Forms.TextBox _courseNameTextBox;
        private System.Windows.Forms.TextBox _courseNumberTextBox;
        private System.Windows.Forms.ComboBox _chooseOpenComboBox;
        private System.Windows.Forms.Label _courseClassTypeLabel;
        private System.Windows.Forms.Label _courseTeacherLabel;
        private System.Windows.Forms.Label _courseCreditLabel;
        private System.Windows.Forms.ComboBox _courseClassTypeComboBox;
        private System.Windows.Forms.Label _courseLanguageLabel;
        private System.Windows.Forms.Label _courseTeacherAssistanceLabel;
        private System.Windows.Forms.Label _courseHourLabel;
        private System.Windows.Forms.Label _courseNoteLabel;
        private System.Windows.Forms.Label _courseClassLabel;
        private System.Windows.Forms.ComboBox _courseClassComboBox;
        private System.Windows.Forms.BindingSource _courseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn _periodsColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _sundayColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _mondayColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _tuesdayColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _wednesdayColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _thursdayColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _fridayColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _saturdayColumn;
        private System.Windows.Forms.ComboBox _courseHourComboBox;
        private System.Windows.Forms.Button _addAllComputerScienceButton;
        private System.Windows.Forms.ListBox _allClassesListBox;
        private System.Windows.Forms.Button _addClassButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.GroupBox _classGroupBox;
        private System.Windows.Forms.ListBox _classCoursesListBox;
        private System.Windows.Forms.TextBox _classNameTextBox;
        private System.Windows.Forms.Label _classContainCourseLabel;
        private System.Windows.Forms.Label _classNameLabel;
    }
}