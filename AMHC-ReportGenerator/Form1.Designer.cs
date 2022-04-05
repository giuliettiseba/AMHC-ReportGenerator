
namespace AMHC_ReportGenerator
{
    partial class Form1
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
            this.button_CreateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CreateReport
            // 
            this.button_CreateReport.Location = new System.Drawing.Point(235, 260);
            this.button_CreateReport.Name = "button_CreateReport";
            this.button_CreateReport.Size = new System.Drawing.Size(322, 23);
            this.button_CreateReport.TabIndex = 0;
            this.button_CreateReport.Text = "Create Report";
            this.button_CreateReport.UseVisualStyleBackColor = true;
            this.button_CreateReport.Click += new System.EventHandler(this.button_CreateReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_CreateReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CreateReport;
    }
}

