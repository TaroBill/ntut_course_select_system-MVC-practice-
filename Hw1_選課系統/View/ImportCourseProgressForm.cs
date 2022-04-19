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
    public partial class ImportCourseProgressForm : Form
    {
        private readonly ImportCourseProgressFormPresentationModel _importCourseProgressFormPresentationModel;
        public ImportCourseProgressForm(ImportCourseProgressFormPresentationModel import)
        {
            _importCourseProgressFormPresentationModel = import;
            InitializeComponent();
            _progressBar1.Value = 0;
            _importCourseProgressFormPresentationModel.ProgressChanged += ChangeProgressBar;
            _importCourseProgressFormPresentationModel.YourData.Done += CloseForm;
        }

        //設置progress bar
        public void ChangeProgressBar()
        {
            Application.DoEvents();
            _progressBar1.Maximum = _importCourseProgressFormPresentationModel.YourData.Total;
            _progressBar1.Value = _importCourseProgressFormPresentationModel.YourData.NowProgress;
            _progressLabel.Text = _importCourseProgressFormPresentationModel.NowProgressLabelText;
        }

        //關閉此表單
        private void CloseForm()
        {
            this.Close();
        }

        //加入課程
        public void AddCourses(object sender = null, DoWorkEventArgs e = null)
        {
            _importCourseProgressFormPresentationModel.AddComputerScienceCourse();
        }

        //當啟動此form
        private new void ActiveForm(object sender, EventArgs e)
        {
            AddCourses();
        }
    }
}
