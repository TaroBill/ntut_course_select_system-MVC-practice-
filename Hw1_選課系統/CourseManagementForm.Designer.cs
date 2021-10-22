
namespace Homework_選課系統
{
    partial class CourseManagementForm
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
            this._comingSoonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _comingSoonLabel
            // 
            this._comingSoonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comingSoonLabel.AutoSize = true;
            this._comingSoonLabel.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._comingSoonLabel.Location = new System.Drawing.Point(206, 171);
            this._comingSoonLabel.Name = "_comingSoonLabel";
            this._comingSoonLabel.Size = new System.Drawing.Size(373, 64);
            this._comingSoonLabel.TabIndex = 0;
            this._comingSoonLabel.Text = "Coming Soon";
            this._comingSoonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._comingSoonLabel);
            this.Name = "CourseManagementForm";
            this.Text = "CourseManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _comingSoonLabel;
    }
}