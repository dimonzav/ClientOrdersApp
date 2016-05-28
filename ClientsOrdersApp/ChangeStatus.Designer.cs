namespace ClientsOrdersApp
{
    partial class ChangeStatus
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
            this.btnSetOrderStatus = new System.Windows.Forms.Button();
            this.cbStatusTypes = new System.Windows.Forms.ComboBox();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change status for order #";
            // 
            // btnSetOrderStatus
            // 
            this.btnSetOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetOrderStatus.Location = new System.Drawing.Point(255, 131);
            this.btnSetOrderStatus.Name = "btnSetOrderStatus";
            this.btnSetOrderStatus.Size = new System.Drawing.Size(87, 33);
            this.btnSetOrderStatus.TabIndex = 1;
            this.btnSetOrderStatus.Text = "Set";
            this.btnSetOrderStatus.UseVisualStyleBackColor = true;
            this.btnSetOrderStatus.Click += new System.EventHandler(this.btnSetOrderStatus_Click);
            // 
            // cbStatusTypes
            // 
            this.cbStatusTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusTypes.FormattingEnabled = true;
            this.cbStatusTypes.Location = new System.Drawing.Point(48, 87);
            this.cbStatusTypes.Name = "cbStatusTypes";
            this.cbStatusTypes.Size = new System.Drawing.Size(294, 21);
            this.cbStatusTypes.TabIndex = 2;
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderNumber.Location = new System.Drawing.Point(270, 35);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(60, 24);
            this.labelOrderNumber.TabIndex = 3;
            this.labelOrderNumber.Text = "label2";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.labelOrderNumber);
            this.Controls.Add(this.cbStatusTypes);
            this.Controls.Add(this.btnSetOrderStatus);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change order status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetOrderStatus;
        private System.Windows.Forms.ComboBox cbStatusTypes;
        private System.Windows.Forms.Label labelOrderNumber;
    }
}