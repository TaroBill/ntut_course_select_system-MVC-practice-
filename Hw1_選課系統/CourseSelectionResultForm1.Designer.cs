
namespace Homework_選課系統
{
    partial class CourseSelectionResultForm1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._courseResultGridView = new System.Windows.Forms.DataGridView();
            this._courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._removeButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this._courseResultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseResultGridView
            // 
            this._courseResultGridView.AllowUserToAddRows = false;
            this._courseResultGridView.AllowUserToDeleteRows = false;
            this._courseResultGridView.AllowUserToResizeRows = false;
            this._courseResultGridView.AutoGenerateColumns = false;
            this._courseResultGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._courseResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseResultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._removeButtonColumn,
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
            this._courseResultGridView.DataSource = this._courseBindingSource;
            this._courseResultGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this._courseResultGridView.Location = new System.Drawing.Point(0, 0);
            this._courseResultGridView.MultiSelect = false;
            this._courseResultGridView.Name = "_courseResultGridView";
            this._courseResultGridView.RowHeadersVisible = false;
            this._courseResultGridView.RowTemplate.Height = 24;
            this._courseResultGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._courseResultGridView.Size = new System.Drawing.Size(800, 379);
            this._courseResultGridView.TabIndex = 3;
            this._courseResultGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCourseDataGridView);
            // 
            // _courseBindingSource
            // 
            this._courseBindingSource.DataSource = typeof(Homework_選課系統.Course);
            // 
            // _removeButtonColumn
            // 
            this._removeButtonColumn.HeaderText = "退選";
            this._removeButtonColumn.Name = "_removeButtonColumn";
            this._removeButtonColumn.Text = "退選";
            this._removeButtonColumn.UseColumnTextForButtonValue = true;
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
            // CourseSelectionResultForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._courseResultGridView);
            this.Name = "CourseSelectionResultForm1";
            this.Text = "CourseSelectionResultForm1";
            ((System.ComponentModel.ISupportInitialize)(this._courseResultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView _courseResultGridView;
        private System.Windows.Forms.BindingSource _courseBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn _removeButtonColumn;
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
    }
}