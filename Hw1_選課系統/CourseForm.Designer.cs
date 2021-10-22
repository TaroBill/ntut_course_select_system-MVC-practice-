
namespace Homework_選課系統
{
    partial class CourseForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._sendButton = new System.Windows.Forms.Button();
            this._courseDataGridView = new System.Windows.Forms.DataGridView();
            this._column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._resultButton = new System.Windows.Forms.Button();
            this._tabControl1 = new System.Windows.Forms.TabControl();
            this._tabPage1 = new System.Windows.Forms.TabPage();
            this._tabPage2 = new System.Windows.Forms.TabPage();
            this._courseDataGridView2 = new System.Windows.Forms.DataGridView();
            this._dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._courseBindingSource)).BeginInit();
            this._tabControl1.SuspendLayout();
            this._tabPage1.SuspendLayout();
            this._tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // _sendButton
            // 
            this._sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._sendButton.AutoSize = true;
            this._sendButton.Enabled = false;
            this._sendButton.Location = new System.Drawing.Point(431, 389);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(130, 52);
            this._sendButton.TabIndex = 1;
            this._sendButton.Text = "確認送出";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this.ClickSendButton);
            // 
            // _courseDataGridView
            // 
            this._courseDataGridView.AllowUserToAddRows = false;
            this._courseDataGridView.AllowUserToDeleteRows = false;
            this._courseDataGridView.AllowUserToResizeRows = false;
            this._courseDataGridView.AutoGenerateColumns = false;
            this._courseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._column1,
            this._columnNumber,
            this._column2,
            this._column3,
            this._column4,
            this._column5,
            this._column6,
            this._column7,
            this._column8,
            this._column9,
            this._column10,
            this._column11,
            this._column12,
            this._column13,
            this._column14,
            this._column15,
            this._column16,
            this._column17,
            this._column18,
            this._column19,
            this._column20,
            this._column21,
            this._column22,
            this._column23});
            this._courseDataGridView.DataSource = this._courseBindingSource;
            this._courseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseDataGridView.Location = new System.Drawing.Point(3, 3);
            this._courseDataGridView.MultiSelect = false;
            this._courseDataGridView.Name = "_courseDataGridView";
            this._courseDataGridView.RowHeadersVisible = false;
            this._courseDataGridView.RowTemplate.Height = 24;
            this._courseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._courseDataGridView.Size = new System.Drawing.Size(696, 351);
            this._courseDataGridView.TabIndex = 2;
            this._courseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCourseDataGridView);
            // 
            // _column1
            // 
            this._column1.FalseValue = "False";
            this._column1.HeaderText = "選";
            this._column1.Name = "_column1";
            this._column1.TrueValue = "True";
            // 
            // _columnNumber
            // 
            this._columnNumber.DataPropertyName = "Number";
            this._columnNumber.HeaderText = "課程編號";
            this._columnNumber.Name = "_columnNumber";
            this._columnNumber.ReadOnly = true;
            // 
            // _column2
            // 
            this._column2.DataPropertyName = "Name";
            this._column2.HeaderText = "課程名稱";
            this._column2.Name = "_column2";
            this._column2.ReadOnly = true;
            // 
            // _column3
            // 
            this._column3.DataPropertyName = "Stage";
            this._column3.HeaderText = "階段";
            this._column3.Name = "_column3";
            this._column3.ReadOnly = true;
            // 
            // _column4
            // 
            this._column4.DataPropertyName = "Credit";
            this._column4.HeaderText = "學分";
            this._column4.Name = "_column4";
            this._column4.ReadOnly = true;
            // 
            // _column5
            // 
            this._column5.DataPropertyName = "Hour";
            this._column5.HeaderText = "時數";
            this._column5.Name = "_column5";
            this._column5.ReadOnly = true;
            // 
            // _column6
            // 
            this._column6.DataPropertyName = "ClassType";
            this._column6.HeaderText = "修";
            this._column6.Name = "_column6";
            this._column6.ReadOnly = true;
            // 
            // _column7
            // 
            this._column7.DataPropertyName = "Teacher";
            this._column7.HeaderText = "教師";
            this._column7.Name = "_column7";
            this._column7.ReadOnly = true;
            // 
            // _column8
            // 
            this._column8.DataPropertyName = "ClassTimeSunday";
            this._column8.HeaderText = "日";
            this._column8.Name = "_column8";
            this._column8.ReadOnly = true;
            // 
            // _column9
            // 
            this._column9.DataPropertyName = "ClassTimeMonday";
            this._column9.HeaderText = "一";
            this._column9.Name = "_column9";
            this._column9.ReadOnly = true;
            // 
            // _column10
            // 
            this._column10.DataPropertyName = "ClassTimeTuesday";
            this._column10.HeaderText = "二";
            this._column10.Name = "_column10";
            this._column10.ReadOnly = true;
            // 
            // _column11
            // 
            this._column11.DataPropertyName = "ClassTimeWednesday";
            this._column11.HeaderText = "三";
            this._column11.Name = "_column11";
            this._column11.ReadOnly = true;
            // 
            // _column12
            // 
            this._column12.DataPropertyName = "ClassTimeThursday";
            this._column12.HeaderText = "四";
            this._column12.Name = "_column12";
            this._column12.ReadOnly = true;
            // 
            // _column13
            // 
            this._column13.DataPropertyName = "ClassTimeFriday";
            this._column13.HeaderText = "五";
            this._column13.Name = "_column13";
            this._column13.ReadOnly = true;
            // 
            // _column14
            // 
            this._column14.DataPropertyName = "ClassTimeSaturday";
            this._column14.HeaderText = "六";
            this._column14.Name = "_column14";
            this._column14.ReadOnly = true;
            // 
            // _column15
            // 
            this._column15.DataPropertyName = "Classroom";
            this._column15.HeaderText = "教室";
            this._column15.Name = "_column15";
            this._column15.ReadOnly = true;
            // 
            // _column16
            // 
            this._column16.DataPropertyName = "NumberOfStudent";
            this._column16.HeaderText = "人";
            this._column16.Name = "_column16";
            this._column16.ReadOnly = true;
            // 
            // _column17
            // 
            this._column17.DataPropertyName = "NumberOfDropStudent";
            this._column17.HeaderText = "撤";
            this._column17.Name = "_column17";
            this._column17.ReadOnly = true;
            // 
            // _column18
            // 
            this._column18.DataPropertyName = "Assistance";
            this._column18.HeaderText = "教學助理";
            this._column18.Name = "_column18";
            this._column18.ReadOnly = true;
            // 
            // _column19
            // 
            this._column19.DataPropertyName = "Language";
            this._column19.HeaderText = "授課語言";
            this._column19.Name = "_column19";
            this._column19.ReadOnly = true;
            // 
            // _column20
            // 
            this._column20.DataPropertyName = "Syllabus";
            this._column20.HeaderText = "教學大綱與進度條";
            this._column20.Name = "_column20";
            this._column20.ReadOnly = true;
            // 
            // _column21
            // 
            this._column21.DataPropertyName = "Note";
            this._column21.HeaderText = "備註";
            this._column21.Name = "_column21";
            this._column21.ReadOnly = true;
            // 
            // _column22
            // 
            this._column22.DataPropertyName = "Audit";
            this._column22.HeaderText = "隨班附讀";
            this._column22.Name = "_column22";
            this._column22.ReadOnly = true;
            // 
            // _column23
            // 
            this._column23.DataPropertyName = "Experiment";
            this._column23.HeaderText = "實驗實習";
            this._column23.Name = "_column23";
            this._column23.ReadOnly = true;
            // 
            // _courseBindingSource
            // 
            this._courseBindingSource.DataSource = typeof(Homework_選課系統.Course);
            // 
            // _resultButton
            // 
            this._resultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._resultButton.AutoSize = true;
            this._resultButton.Location = new System.Drawing.Point(567, 389);
            this._resultButton.Name = "_resultButton";
            this._resultButton.Size = new System.Drawing.Size(139, 51);
            this._resultButton.TabIndex = 1;
            this._resultButton.Text = "查看選課結果";
            this._resultButton.UseVisualStyleBackColor = true;
            this._resultButton.Click += new System.EventHandler(this.ClickResultButton);
            // 
            // _tabControl1
            // 
            this._tabControl1.Controls.Add(this._tabPage1);
            this._tabControl1.Controls.Add(this._tabPage2);
            this._tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this._tabControl1.Location = new System.Drawing.Point(0, 0);
            this._tabControl1.Name = "_tabControl1";
            this._tabControl1.SelectedIndex = 0;
            this._tabControl1.Size = new System.Drawing.Size(710, 383);
            this._tabControl1.TabIndex = 3;
            this._tabControl1.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChangeTabControl);
            // 
            // _tabPage1
            // 
            this._tabPage1.Controls.Add(this._courseDataGridView);
            this._tabPage1.Location = new System.Drawing.Point(4, 22);
            this._tabPage1.Name = "_tabPage1";
            this._tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage1.Size = new System.Drawing.Size(702, 357);
            this._tabPage1.TabIndex = 0;
            this._tabPage1.Text = "資工三";
            this._tabPage1.UseVisualStyleBackColor = true;
            // 
            // _tabPage2
            // 
            this._tabPage2.Controls.Add(this._courseDataGridView2);
            this._tabPage2.Location = new System.Drawing.Point(4, 22);
            this._tabPage2.Name = "_tabPage2";
            this._tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage2.Size = new System.Drawing.Size(702, 357);
            this._tabPage2.TabIndex = 1;
            this._tabPage2.Text = "電子三甲";
            this._tabPage2.UseVisualStyleBackColor = true;
            // 
            // _courseDataGridView2
            // 
            this._courseDataGridView2.AllowUserToAddRows = false;
            this._courseDataGridView2.AllowUserToDeleteRows = false;
            this._courseDataGridView2.AllowUserToResizeRows = false;
            this._courseDataGridView2.AutoGenerateColumns = false;
            this._courseDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._courseDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._dataGridViewCheckBoxColumn1,
            this._dataGridViewTextBoxColumn1,
            this._dataGridViewTextBoxColumn2,
            this._dataGridViewTextBoxColumn3,
            this._dataGridViewTextBoxColumn4,
            this._dataGridViewTextBoxColumn5,
            this._dataGridViewTextBoxColumn6,
            this._dataGridViewTextBoxColumn7,
            this._dataGridViewTextBoxColumn8,
            this._dataGridViewTextBoxColumn9,
            this._dataGridViewTextBoxColumn10,
            this._dataGridViewTextBoxColumn11,
            this._dataGridViewTextBoxColumn12,
            this._dataGridViewTextBoxColumn13,
            this._dataGridViewTextBoxColumn14,
            this._dataGridViewTextBoxColumn15,
            this._dataGridViewTextBoxColumn16,
            this._dataGridViewTextBoxColumn17,
            this._dataGridViewTextBoxColumn18,
            this._dataGridViewTextBoxColumn19,
            this._dataGridViewTextBoxColumn20,
            this._dataGridViewTextBoxColumn21,
            this._dataGridViewTextBoxColumn22,
            this._dataGridViewTextBoxColumn23});
            this._courseDataGridView2.DataSource = this._courseBindingSource;
            this._courseDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseDataGridView2.Location = new System.Drawing.Point(3, 3);
            this._courseDataGridView2.MultiSelect = false;
            this._courseDataGridView2.Name = "_courseDataGridView2";
            this._courseDataGridView2.RowHeadersVisible = false;
            this._courseDataGridView2.RowTemplate.Height = 24;
            this._courseDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._courseDataGridView2.Size = new System.Drawing.Size(696, 351);
            this._courseDataGridView2.TabIndex = 3;
            this._courseDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCourseDataGridView2);
            // 
            // _dataGridViewCheckBoxColumn1
            // 
            this._dataGridViewCheckBoxColumn1.FalseValue = "False";
            this._dataGridViewCheckBoxColumn1.HeaderText = "選";
            this._dataGridViewCheckBoxColumn1.Name = "_dataGridViewCheckBoxColumn1";
            this._dataGridViewCheckBoxColumn1.TrueValue = "True";
            // 
            // _dataGridViewTextBoxColumn1
            // 
            this._dataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this._dataGridViewTextBoxColumn1.HeaderText = "課程編號";
            this._dataGridViewTextBoxColumn1.Name = "_dataGridViewTextBoxColumn1";
            this._dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn2
            // 
            this._dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this._dataGridViewTextBoxColumn2.HeaderText = "課程名稱";
            this._dataGridViewTextBoxColumn2.Name = "_dataGridViewTextBoxColumn2";
            this._dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn3
            // 
            this._dataGridViewTextBoxColumn3.DataPropertyName = "Stage";
            this._dataGridViewTextBoxColumn3.HeaderText = "階段";
            this._dataGridViewTextBoxColumn3.Name = "_dataGridViewTextBoxColumn3";
            this._dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn4
            // 
            this._dataGridViewTextBoxColumn4.DataPropertyName = "Credit";
            this._dataGridViewTextBoxColumn4.HeaderText = "學分";
            this._dataGridViewTextBoxColumn4.Name = "_dataGridViewTextBoxColumn4";
            this._dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn5
            // 
            this._dataGridViewTextBoxColumn5.DataPropertyName = "Hour";
            this._dataGridViewTextBoxColumn5.HeaderText = "時數";
            this._dataGridViewTextBoxColumn5.Name = "_dataGridViewTextBoxColumn5";
            this._dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn6
            // 
            this._dataGridViewTextBoxColumn6.DataPropertyName = "ClassType";
            this._dataGridViewTextBoxColumn6.HeaderText = "修";
            this._dataGridViewTextBoxColumn6.Name = "_dataGridViewTextBoxColumn6";
            this._dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn7
            // 
            this._dataGridViewTextBoxColumn7.DataPropertyName = "Teacher";
            this._dataGridViewTextBoxColumn7.HeaderText = "教師";
            this._dataGridViewTextBoxColumn7.Name = "_dataGridViewTextBoxColumn7";
            this._dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn8
            // 
            this._dataGridViewTextBoxColumn8.DataPropertyName = "ClassTimeSunday";
            this._dataGridViewTextBoxColumn8.HeaderText = "日";
            this._dataGridViewTextBoxColumn8.Name = "_dataGridViewTextBoxColumn8";
            this._dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn9
            // 
            this._dataGridViewTextBoxColumn9.DataPropertyName = "ClassTimeMonday";
            this._dataGridViewTextBoxColumn9.HeaderText = "一";
            this._dataGridViewTextBoxColumn9.Name = "_dataGridViewTextBoxColumn9";
            this._dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn10
            // 
            this._dataGridViewTextBoxColumn10.DataPropertyName = "ClassTimeTuesday";
            this._dataGridViewTextBoxColumn10.HeaderText = "二";
            this._dataGridViewTextBoxColumn10.Name = "_dataGridViewTextBoxColumn10";
            this._dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn11
            // 
            this._dataGridViewTextBoxColumn11.DataPropertyName = "ClassTimeWednesday";
            this._dataGridViewTextBoxColumn11.HeaderText = "三";
            this._dataGridViewTextBoxColumn11.Name = "_dataGridViewTextBoxColumn11";
            this._dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn12
            // 
            this._dataGridViewTextBoxColumn12.DataPropertyName = "ClassTimeThursday";
            this._dataGridViewTextBoxColumn12.HeaderText = "四";
            this._dataGridViewTextBoxColumn12.Name = "_dataGridViewTextBoxColumn12";
            this._dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn13
            // 
            this._dataGridViewTextBoxColumn13.DataPropertyName = "ClassTimeFriday";
            this._dataGridViewTextBoxColumn13.HeaderText = "五";
            this._dataGridViewTextBoxColumn13.Name = "_dataGridViewTextBoxColumn13";
            this._dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn14
            // 
            this._dataGridViewTextBoxColumn14.DataPropertyName = "ClassTimeSaturday";
            this._dataGridViewTextBoxColumn14.HeaderText = "六";
            this._dataGridViewTextBoxColumn14.Name = "_dataGridViewTextBoxColumn14";
            this._dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn15
            // 
            this._dataGridViewTextBoxColumn15.DataPropertyName = "Classroom";
            this._dataGridViewTextBoxColumn15.HeaderText = "教室";
            this._dataGridViewTextBoxColumn15.Name = "_dataGridViewTextBoxColumn15";
            this._dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn16
            // 
            this._dataGridViewTextBoxColumn16.DataPropertyName = "NumberOfStudent";
            this._dataGridViewTextBoxColumn16.HeaderText = "人";
            this._dataGridViewTextBoxColumn16.Name = "_dataGridViewTextBoxColumn16";
            this._dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn17
            // 
            this._dataGridViewTextBoxColumn17.DataPropertyName = "NumberOfDropStudent";
            this._dataGridViewTextBoxColumn17.HeaderText = "撤";
            this._dataGridViewTextBoxColumn17.Name = "_dataGridViewTextBoxColumn17";
            this._dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn18
            // 
            this._dataGridViewTextBoxColumn18.DataPropertyName = "Assistance";
            this._dataGridViewTextBoxColumn18.HeaderText = "教學助理";
            this._dataGridViewTextBoxColumn18.Name = "_dataGridViewTextBoxColumn18";
            this._dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn19
            // 
            this._dataGridViewTextBoxColumn19.DataPropertyName = "Language";
            this._dataGridViewTextBoxColumn19.HeaderText = "授課語言";
            this._dataGridViewTextBoxColumn19.Name = "_dataGridViewTextBoxColumn19";
            this._dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn20
            // 
            this._dataGridViewTextBoxColumn20.DataPropertyName = "Syllabus";
            this._dataGridViewTextBoxColumn20.HeaderText = "教學大綱與進度條";
            this._dataGridViewTextBoxColumn20.Name = "_dataGridViewTextBoxColumn20";
            this._dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn21
            // 
            this._dataGridViewTextBoxColumn21.DataPropertyName = "Note";
            this._dataGridViewTextBoxColumn21.HeaderText = "備註";
            this._dataGridViewTextBoxColumn21.Name = "_dataGridViewTextBoxColumn21";
            this._dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn22
            // 
            this._dataGridViewTextBoxColumn22.DataPropertyName = "Audit";
            this._dataGridViewTextBoxColumn22.HeaderText = "隨班附讀";
            this._dataGridViewTextBoxColumn22.Name = "_dataGridViewTextBoxColumn22";
            this._dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // _dataGridViewTextBoxColumn23
            // 
            this._dataGridViewTextBoxColumn23.DataPropertyName = "Experiment";
            this._dataGridViewTextBoxColumn23.HeaderText = "實驗實習";
            this._dataGridViewTextBoxColumn23.Name = "_dataGridViewTextBoxColumn23";
            this._dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this._resultButton);
            this.Controls.Add(this._sendButton);
            this.Controls.Add(this._tabControl1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._courseBindingSource)).EndInit();
            this._tabControl1.ResumeLayout(false);
            this._tabPage1.ResumeLayout(false);
            this._tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._courseDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.DataGridView _courseDataGridView;
        private System.Windows.Forms.Button _resultButton;
        private System.Windows.Forms.BindingSource _courseBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn _column23;
        private System.Windows.Forms.TabControl _tabControl1;
        private System.Windows.Forms.TabPage _tabPage1;
        private System.Windows.Forms.TabPage _tabPage2;
        private System.Windows.Forms.DataGridView _courseDataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataGridViewTextBoxColumn23;
    }
}

