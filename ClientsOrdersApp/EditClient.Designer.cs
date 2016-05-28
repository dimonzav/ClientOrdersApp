namespace ClientsOrdersApp
{
    partial class EditClient
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtClientBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPhoneClient = new System.Windows.Forms.MaskedTextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // dtClientBirth
            // 
            this.dtClientBirth.Location = new System.Drawing.Point(115, 114);
            this.dtClientBirth.Name = "dtClientBirth";
            this.dtClientBirth.Size = new System.Drawing.Size(180, 20);
            this.dtClientBirth.TabIndex = 4;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClient.Location = new System.Drawing.Point(59, 239);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 30);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(200, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPhoneClient
            // 
            this.tbPhoneClient.Location = new System.Drawing.Point(115, 187);
            this.tbPhoneClient.Mask = "(999) 000-0000";
            this.tbPhoneClient.Name = "tbPhoneClient";
            this.tbPhoneClient.Size = new System.Drawing.Size(180, 20);
            this.tbPhoneClient.TabIndex = 8;
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(115, 48);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(180, 20);
            this.tbClientName.TabIndex = 3;
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.tbPhoneClient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dtClientBirth);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtClientBirth;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox tbPhoneClient;
        private System.Windows.Forms.TextBox tbClientName;
    }
}