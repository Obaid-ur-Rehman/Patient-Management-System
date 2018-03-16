namespace patient_monitoring_system
{
    partial class modifyRecord
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbP = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.x = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.cv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbbll = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(364, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 52);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Submit";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
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
            // x
            // 
            this.x.Location = new System.Drawing.Point(365, 437);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(94, 52);
            this.x.TabIndex = 3;
            this.x.Text = "Close";
            this.x.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(277, 229);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(181, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(277, 272);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(181, 22);
            this.tbPass.TabIndex = 5;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(277, 323);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(182, 22);
            this.tbAddress.TabIndex = 6;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(277, 370);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(181, 22);
            this.tbContact.TabIndex = 7;
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.Location = new System.Drawing.Point(76, 229);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(45, 17);
            this.cv.TabIndex = 8;
            this.cv.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address";
            // 
            // lbbll
            // 
            this.lbbll.AutoSize = true;
            this.lbbll.Location = new System.Drawing.Point(76, 373);
            this.lbbll.Name = "lbbll";
            this.lbbll.Size = new System.Drawing.Size(56, 17);
            this.lbbll.TabIndex = 11;
            this.lbbll.Text = "Contact";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(76, 176);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 17);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "Name";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(139, 92);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbN);
            this.groupBox2.Controls.Add(this.rbP);
            this.groupBox2.Controls.Add(this.rbD);
            this.groupBox2.Location = new System.Drawing.Point(16, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 63);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(209, 437);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 52);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // modifyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 548);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblID);
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
            this.Controls.Add(this.btnSearch);
            this.Name = "modifyRecord";
            this.Text = "modifyRecord";
            this.Load += new System.EventHandler(this.modifyRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbP;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label cv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbbll;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
    }
}