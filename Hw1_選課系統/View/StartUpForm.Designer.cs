
namespace Homework_選課系統
{
    partial class StartUpForm
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
            this._courseSelectButton = new System.Windows.Forms.Button();
            this._courseManagementButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _courseSelectButton
            // 
            this._courseSelectButton.AutoSize = true;
            this._courseSelectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._courseSelectButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._courseSelectButton.Location = new System.Drawing.Point(0, 0);
            this._courseSelectButton.Name = "_courseSelectButton";
            this._courseSelectButton.Size = new System.Drawing.Size(807, 164);
            this._courseSelectButton.TabIndex = 0;
            this._courseSelectButton.Text = "Course Seleting Systtem";
            this._courseSelectButton.UseVisualStyleBackColor = true;
            this._courseSelectButton.Click += new System.EventHandler(this.ClickCourseSelect);
            // 
            // _courseManagementButton
            // 
            this._courseManagementButton.AutoSize = true;
            this._courseManagementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._courseManagementButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._courseManagementButton.Location = new System.Drawing.Point(0, 164);
            this._courseManagementButton.Name = "_courseManagementButton";
            this._courseManagementButton.Size = new System.Drawing.Size(807, 190);
            this._courseManagementButton.TabIndex = 0;
            this._courseManagementButton.Text = "Course Management System";
            this._courseManagementButton.UseVisualStyleBackColor = true;
            this._courseManagementButton.Click += new System.EventHandler(this.ClickCourseManagement);
            // 
            // _exitButton
            // 
            this._exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._exitButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._exitButton.Location = new System.Drawing.Point(542, 354);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(265, 125);
            this._exitButton.TabIndex = 1;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 479);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._courseManagementButton);
            this.Controls.Add(this._courseSelectButton);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _courseSelectButton;
        private System.Windows.Forms.Button _courseManagementButton;
        private System.Windows.Forms.Button _exitButton;
    }
}