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
    public partial class CourseForm : Form
    {
        private readonly CourseFormPresentationModel _courseFormPresentationModel;
        private readonly Data _yourData;
        public CourseForm(CourseFormPresentationModel inputCourseFormPresentationModel, Data yourdata)
        {
            _yourData = yourdata;
            InitializeComponent();
            _courseFormPresentationModel = inputCourseFormPresentationModel;
            _courseFormPresentationModel.ButtonChangedEnable += UpdateButton;
            _courseFormPresentationModel.CourseChanged += UpdateCourse;
            _tabControl1.SelectedIndex = 0;
            _courseFormPresentationModel.CurrentTabPage = _tabControl1.SelectedIndex;
            _courseFormPresentationModel.AddCourse(_tabControl1.SelectedIndex);
            _courseFormPresentationModel.YourData.Done += UpdateClasses;
            this._tabControl1.SelectedIndexChanged += this.SelectedIndexChangeTabControl;
        }

        //更新所有按鈕的狀態
        private void UpdateButton()
        {
            _sendButton.Enabled = _courseFormPresentationModel.SendButtonEnable;
        }

        //更新課程的變化
        private void UpdateCourse()
        {
            foreach (Control control in _tabControl1.SelectedTab.Controls)
            {
                if (control is DataGridView view)
                {
                    view.DataSource = _courseFormPresentationModel.GetCourseList();
                }
            }
        }

        //更新classes
        private void UpdateClasses()
        {            
            _tabControl1.SuspendLayout();
            this._tabControl1.SelectedIndexChanged -= this.SelectedIndexChangeTabControl;
            _tabControl1.TabPages.Clear();
            for (int index = 0; index < _yourData.AllClasses.Count(); index++)
                this._tabControl1.TabPages.Add(ConstructTabPage(_yourData.AllClasses[index].Name, index));
            _tabControl1.ResumeLayout(false);
            this._tabControl1.SelectedIndexChanged += this.SelectedIndexChangeTabControl;
            _tabControl1.SelectedIndex = _courseFormPresentationModel.CurrentTabPage;
            _tabControl1.Refresh();
            UpdateCourse();
        }

        //點選datagrid內部的格子事件
        private void ClickCourseDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = ((DataGridView)sender);
            dataGridView.EndEdit();
            _courseFormPresentationModel.SetCourseIsChoosed(dataGridView?.CurrentCell?.RowIndex, Convert.ToString(dataGridView.CurrentRow.Cells[0].Value));
            _courseFormPresentationModel.IsCheckedCheckBox();
        }

        //點選送出選課結果的按鈕
        private void ClickSendButton(object sender, EventArgs e)
        {
            string result = _courseFormPresentationModel.AddToYourCourse();
            MessageBox.Show(result);
        }

        //點選查看已選課的內容
        private void ClickResultButton(object sender, EventArgs e)
        {
            CourseSelectionResultForm1 courseSelectionResultForm = new CourseSelectionResultForm1(_yourData);
            courseSelectionResultForm.Show();
        }

        //當換tabpage時
        private void SelectedIndexChangeTabControl(object sender, EventArgs e)
        {
            _courseFormPresentationModel.CurrentTabPage = _tabControl1.SelectedIndex;
        }
    }
}
