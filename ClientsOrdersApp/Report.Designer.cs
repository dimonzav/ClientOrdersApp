namespace ClientsOrdersApp
{
    partial class Report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnExportToTxt = new System.Windows.Forms.Button();
            this.btnCloseReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(324, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "to";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 342);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToExcel.Location = new System.Drawing.Point(319, 457);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(136, 30);
            this.btnExportToExcel.TabIndex = 3;
            this.btnExportToExcel.Text = "Export to excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            // 
            // btnExportToTxt
            // 
            this.btnExportToTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToTxt.Location = new System.Drawing.Point(485, 457);
            this.btnExportToTxt.Name = "btnExportToTxt";
            this.btnExportToTxt.Size = new System.Drawing.Size(110, 30);
            this.btnExportToTxt.TabIndex = 4;
            this.btnExportToTxt.Text = "Export to txt";
            this.btnExportToTxt.UseVisualStyleBackColor = true;
            // 
            // btnCloseReport
            // 
            this.btnCloseReport.Location = new System.Drawing.Point(626, 457);
            this.btnCloseReport.Name = "btnCloseReport";
            this.btnCloseReport.Size = new System.Drawing.Size(75, 30);
            this.btnCloseReport.TabIndex = 5;
            this.btnCloseReport.Text = "Close";
            this.btnCloseReport.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnCloseReport);
            this.Controls.Add(this.btnExportToTxt);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnExportToTxt;
        private System.Windows.Forms.Button btnCloseReport;
    }
}