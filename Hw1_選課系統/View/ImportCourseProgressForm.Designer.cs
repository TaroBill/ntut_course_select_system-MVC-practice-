
namespace Homework_選課系統
{
    partial class ImportCourseProgressForm
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
            this._progressBar1 = new System.Windows.Forms.ProgressBar();
            this._nameLabel = new System.Windows.Forms.Label();
            this._progressLabel = new System.Windows.Forms.Label();
            this._backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // _progressBar1
            // 
            this._progressBar1.Location = new System.Drawing.Point(12, 71);
            this._progressBar1.Name = "_progressBar1";
            this._progressBar1.Size = new System.Drawing.Size(342, 23);
            this._progressBar1.TabIndex = 0;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(12, 44);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(77, 12);
            this._nameLabel.TabIndex = 1;
            this._nameLabel.Text = "正在匯入課程";
            // 
            // _progressLabel
            // 
            this._progressLabel.AutoSize = true;
            this._progressLabel.Location = new System.Drawing.Point(121, 44);
            this._progressLabel.Name = "_progressLabel";
            this._progressLabel.Size = new System.Drawing.Size(0, 12);
            this._progressLabel.TabIndex = 2;
            // 
            // ImportCourseProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 140);
            this.Controls.Add(this._progressLabel);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._progressBar1);
            this.Name = "ImportCourseProgressForm";
            this.Text = "匯入課程";
            this.Activated += new System.EventHandler(this.ActiveForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar _progressBar1;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _progressLabel;
        private System.ComponentModel.BackgroundWorker _backgroundWorker1;
    }
}