namespace ClientsOrdersApp
{
    partial class ReportPeriod
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnCancelReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(305, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 96);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(234, 96);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateReport.Location = new System.Drawing.Point(180, 283);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(104, 30);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // btnCancelReport
            // 
            this.btnCancelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelReport.Location = new System.Drawing.Point(308, 283);
            this.btnCancelReport.Name = "btnCancelReport";
            this.btnCancelReport.Size = new System.Drawing.Size(90, 30);
            this.btnCancelReport.TabIndex = 5;
            this.btnCancelReport.Text = "Cancel";
            this.btnCancelReport.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 356);
            this.Controls.Add(this.btnCancelReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnCancelReport;
    }
}