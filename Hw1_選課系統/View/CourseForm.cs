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
            InitializeComponent();
            _yourData = yourdata;
            _courseFormPresentationModel = inputCourseFormPresentationModel;
            _courseFormPresentationModel.ButtonChangedEnable += UpdateButton;
            _courseFormPresentationModel.CourseChanged += UpdateCourse;
            _courseFormPresentationModel.AddCourse(_tabControl1.SelectedIndex);
        }

        //更新所有按鈕的狀態
        private void UpdateButton()
        {
            _sendButton.Enabled = _courseFormPresentationModel.SendButtonEnable;
        }

        //更新課程的變化
        private void UpdateCourse()
        {
            _courseDataGridView.DataSource = _courseFormPresentationModel.GetCourseList();
            _courseDataGridView2.DataSource = _courseFormPresentationModel.GetCourseList();
        }

        //點選datagrid內部的格子事件
        private void ClickCourseDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            _courseDataGridView.EndEdit();
            _courseFormPresentationModel.SetCourseIsChoosed(_courseDataGridView?.CurrentCell?.RowIndex, Convert.ToString(_courseDataGridView.CurrentRow.Cells[0].Value));
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

        //點擊第二個表單
        private void ClickCourseDataGridView2(object sender, DataGridViewCellEventArgs e)
        {
            _courseDataGridView2.EndEdit();
            _courseFormPresentationModel.SetCourseIsChoosed(_courseDataGridView2?.CurrentCell?.RowIndex, Convert.ToString(_courseDataGridView2.CurrentRow.Cells[0].Value));
            _courseFormPresentationModel.IsCheckedCheckBox();
        }

        //當換tabpage時
        private void SelectedIndexChangeTabControl(object sender, EventArgs e)
        {
            _courseFormPresentationModel.CurrentTabPage = _tabControl1.SelectedIndex;
        }
    }
}
