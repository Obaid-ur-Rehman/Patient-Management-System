namespace patient_monitoring_system
{
    partial class addRecord
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbbll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cv = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.rbP = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(215, 380);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 52);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbbll
            // 
            this.lbbll.AutoSize = true;
            this.lbbll.Location = new System.Drawing.Point(82, 316);
            this.lbbll.Name = "lbbll";
            this.lbbll.Size = new System.Drawing.Size(56, 17);
            this.lbbll.TabIndex = 24;
            this.lbbll.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Location = new System.Drawing.Point(82, 172);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(45, 17);
            this.cv.TabIndex = 21;
            this.cv.Text = "Name";
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(283, 313);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(181, 22);
            this.tbContact.TabIndex = 20;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(283, 266);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(182, 22);
            this.tbAddress.TabIndex = 19;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(283, 215);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(181, 22);
            this.tbPass.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(283, 172);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(181, 22);
            this.tbName.TabIndex = 17;
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(371, 380);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(94, 52);
            this.x.TabIndex = 16;
            this.x.Text = "Close";
            this.x.UseVisualStyleBackColor = true;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(79, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 94);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbN);
            this.groupBox2.Controls.Add(this.rbP);
            this.groupBox2.Controls.Add(this.rbD);
            this.groupBox2.Location = new System.Drawing.Point(63, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 63);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // rbN
            // 
            this.rbN.AutoSize = true;
            this.rbN.Location = new System.Drawing.Point(163, 27);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(67, 21);
            this.rbN.TabIndex = 2;
            this.rbN.TabStop = true;
            this.rbN.Text = "Nurse";
            this.rbN.UseVisualStyleBackColor = true;
            // 
            // rbP
            // 
            this.rbP.AutoSize = true;
            this.rbP.Location = new System.Drawing.Point(7, 27);
            this.rbP.Name = "rbP";
            this.rbP.Size = new System.Drawing.Size(73, 21);
            this.rbP.TabIndex = 0;
            this.rbP.TabStop = true;
            this.rbP.Text = "Patient";
            this.rbP.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(86, 27);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(71, 21);
            this.rbD.TabIndex = 1;
            this.rbD.TabStop = true;
            this.rbD.Text = "Doctor";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // addRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 470);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbbll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cv);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.x);
            this.Controls.Add(this.groupBox1);
            this.Name = "addRecord";
            this.Text = "addRecord";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbbll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.RadioButton rbP;
        private System.Windows.Forms.RadioButton rbD;
    }
}