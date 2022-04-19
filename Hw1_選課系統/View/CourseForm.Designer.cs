
using System.Linq;
using System.Windows.Forms;

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

        //生成一個tabpage
        private System.Windows.Forms.TabPage ConstructTabPage(string pageName, int tabPageIndex)
        {
            TabPage tabPage = new TabPage();
            DataGridView dataGridView = new DataGridView();
            System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
            System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
            dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView)).BeginInit();
            // 
            // tabPage
            // 
            tabPage.Controls.Add(dataGridView);
            tabPage.Location = new System.Drawing.Point(4, 22);
            tabPage.Name = "_tabPage" + tabPageIndex;
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(702, 357);
            tabPage.TabIndex = tabPageIndex;
            tabPage.Text = pageName;
            tabPage.UseVisualStyleBackColor = true;
            // 
            // 初始化DataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            dataGridViewCheckBoxColumn1,
            dataGridViewTextBoxColumn1,
            dataGridViewTextBoxColumn2,
            dataGridViewTextBoxColumn3,
            dataGridViewTextBoxColumn4,
            dataGridViewTextBoxColumn5,
            dataGridViewTextBoxColumn6,
            dataGridViewTextBoxColumn7,
            dataGridViewTextBoxColumn8,
            dataGridViewTextBoxColumn9,
            dataGridViewTextBoxColumn10,
            dataGridViewTextBoxColumn11,
            dataGridViewTextBoxColumn12,
            dataGridViewTextBoxColumn13,
            dataGridViewTextBoxColumn14,
            dataGridViewTextBoxColumn15,
            dataGridViewTextBoxColumn16,
            dataGridViewTextBoxColumn17,
            dataGridViewTextBoxColumn18,
            dataGridViewTextBoxColumn19,
            dataGridViewTextBoxColumn20,
            dataGridViewTextBoxColumn21,
            dataGridViewTextBoxColumn22,
            dataGridViewTextBoxColumn23});
            dataGridView.DataSource = _courseBindingSource;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.Location = new System.Drawing.Point(3, 3);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView" + tabPageIndex;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 24;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new System.Drawing.Size(696, 351);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCourseDataGridView);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.FalseValue = "False";
            dataGridViewCheckBoxColumn1.HeaderText = "選";
            dataGridViewCheckBoxColumn1.Name = "_tabpage" + tabPageIndex + "DataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.TrueValue = "True";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Number";
            dataGridViewTextBoxColumn1.HeaderText = "課程編號";
            dataGridViewTextBoxColumn1.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "課程名稱";
            dataGridViewTextBoxColumn2.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Stage";
            dataGridViewTextBoxColumn3.HeaderText = "階段";
            dataGridViewTextBoxColumn3.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Credit";
            dataGridViewTextBoxColumn4.HeaderText = "學分";
            dataGridViewTextBoxColumn4.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Hour";
            dataGridViewTextBoxColumn5.HeaderText = "時數";
            dataGridViewTextBoxColumn5.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "ClassType";
            dataGridViewTextBoxColumn6.HeaderText = "修";
            dataGridViewTextBoxColumn6.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Teacher";
            dataGridViewTextBoxColumn7.HeaderText = "教師";
            dataGridViewTextBoxColumn7.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "ClassTimeSunday";
            dataGridViewTextBoxColumn8.HeaderText = "日";
            dataGridViewTextBoxColumn8.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "ClassTimeMonday";
            dataGridViewTextBoxColumn9.HeaderText = "一";
            dataGridViewTextBoxColumn9.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "ClassTimeTuesday";
            dataGridViewTextBoxColumn10.HeaderText = "二";
            dataGridViewTextBoxColumn10.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "ClassTimeWednesday";
            dataGridViewTextBoxColumn11.HeaderText = "三";
            dataGridViewTextBoxColumn11.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "ClassTimeThursday";
            dataGridViewTextBoxColumn12.HeaderText = "四";
            dataGridViewTextBoxColumn12.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "ClassTimeFriday";
            dataGridViewTextBoxColumn13.HeaderText = "五";
            dataGridViewTextBoxColumn13.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "ClassTimeSaturday";
            dataGridViewTextBoxColumn14.HeaderText = "六";
            dataGridViewTextBoxColumn14.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "Classroom";
            dataGridViewTextBoxColumn15.HeaderText = "教室";
            dataGridViewTextBoxColumn15.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "NumberOfStudent";
            dataGridViewTextBoxColumn16.HeaderText = "人";
            dataGridViewTextBoxColumn16.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "NumberOfDropStudent";
            dataGridViewTextBoxColumn17.HeaderText = "撤";
            dataGridViewTextBoxColumn17.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "Assistance";
            dataGridViewTextBoxColumn18.HeaderText = "教學助理";
            dataGridViewTextBoxColumn18.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "Language";
            dataGridViewTextBoxColumn19.HeaderText = "授課語言";
            dataGridViewTextBoxColumn19.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "Syllabus";
            dataGridViewTextBoxColumn20.HeaderText = "教學大綱與進度條";
            dataGridViewTextBoxColumn20.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "Note";
            dataGridViewTextBoxColumn21.HeaderText = "備註";
            dataGridViewTextBoxColumn21.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.DataPropertyName = "Audit";
            dataGridViewTextBoxColumn22.HeaderText = "隨班附讀";
            dataGridViewTextBoxColumn22.Name = "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.DataPropertyName = "Experiment";
            dataGridViewTextBoxColumn23.HeaderText = "實驗實習";
            dataGridViewTextBoxColumn23.Name = "_tabpage" + tabPageIndex + "_tabpage" + tabPageIndex + "DataGridViewTextBoxColumn23";
            dataGridViewTextBoxColumn23.ReadOnly = true;

            tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridView)).EndInit();
            
            return tabPage;
        }

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._sendButton = new System.Windows.Forms.Button();
            this._courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._resultButton = new System.Windows.Forms.Button();
            this._tabControl1 = new System.Windows.Forms.TabControl();
            
            ((System.ComponentModel.ISupportInitialize)(this._courseBindingSource)).BeginInit();
            this._tabControl1.SuspendLayout();
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
            for (int index = 0; index < _yourData.AllClasses.Count(); index++)
            {
                this._tabControl1.TabPages.Add(ConstructTabPage(_yourData.AllClasses[index].Name, index));
            }

            this._tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this._tabControl1.Location = new System.Drawing.Point(0, 0);
            this._tabControl1.Name = "_tabControl1";
            this._tabControl1.SelectedIndex = 0;
            this._tabControl1.Size = new System.Drawing.Size(710, 383);
            this._tabControl1.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this._courseBindingSource)).EndInit();
            this._tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.Button _resultButton;
        private System.Windows.Forms.BindingSource _courseBindingSource;
        private System.Windows.Forms.TabControl _tabControl1;
    }
}

