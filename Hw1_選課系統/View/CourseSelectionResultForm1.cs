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
    public partial class CourseSelectionResultForm1 : Form
    {
        private readonly Data _yourData;
        private readonly CourseSelectionResultPresentationModel _courseSelectionResultPresentationModel;
        public CourseSelectionResultForm1(Data inputData)
        {
            InitializeComponent();
            _yourData = inputData;
            _courseSelectionResultPresentationModel = new CourseSelectionResultPresentationModel(_yourData);
            _yourData.CourseChanged += UpdateDataGridView;
            UpdateDataGridView();
        }

        //刷新dataGridView
        private void UpdateDataGridView()
        {
            _courseResultGridView.DataSource = _yourData.YourCourse;
        }

        //點擊退選按鈕
        private void ClickCourseDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            _courseSelectionResultPresentationModel.PressRemoveCourseButton(_courseResultGridView?.CurrentCell?.ColumnIndex, _courseResultGridView?.CurrentCell?.RowIndex);
        }
    }
}
