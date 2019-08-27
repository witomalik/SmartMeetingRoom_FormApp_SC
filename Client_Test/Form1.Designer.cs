namespace Client_Test
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
            this.send = new System.Windows.Forms.Button();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.portNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.logViewer = new System.Windows.Forms.ListBox();
            this.commandBox = new System.Windows.Forms.ComboBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userCardNumber = new System.Windows.Forms.TextBox();
            this.addUser = new System.Windows.Forms.Button();
            this.receiveData = new System.Windows.Forms.Button();
            this.checkCi = new System.Windows.Forms.Button();
            this.timeZone = new System.Windows.Forms.Button();
            this.acsGroup = new System.Windows.Forms.Button();
            this.inquiryTZ = new System.Windows.Forms.Button();
            this.inquiryAG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(12, 170);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(189, 23);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(12, 32);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(189, 20);
            this.IPAddress.TabIndex = 2;
            // 
            // portNo
            // 
            this.portNo.Location = new System.Drawing.Point(12, 72);
            this.portNo.Name = "portNo";
            this.portNo.Size = new System.Drawing.Size(189, 20);
            this.portNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Command";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(12, 98);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(189, 23);
            this.connect.TabIndex = 7;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // logViewer
            // 
            this.logViewer.FormattingEnabled = true;
            this.logViewer.Location = new System.Drawing.Point(222, 12);
            this.logViewer.Name = "logViewer";
            this.logViewer.Size = new System.Drawing.Size(566, 212);
            this.logViewer.TabIndex = 8;
            // 
            // commandBox
            // 
            this.commandBox.FormattingEnabled = true;
            this.commandBox.Location = new System.Drawing.Point(12, 144);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(189, 21);
            this.commandBox.TabIndex = 9;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(12, 212);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(189, 20);
            this.userName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Card ID";
            // 
            // userCardNumber
            // 
            this.userCardNumber.Location = new System.Drawing.Point(12, 251);
            this.userCardNumber.Name = "userCardNumber";
            this.userCardNumber.Size = new System.Drawing.Size(189, 20);
            this.userCardNumber.TabIndex = 13;
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(12, 277);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(189, 23);
            this.addUser.TabIndex = 14;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // receiveData
            // 
            this.receiveData.Location = new System.Drawing.Point(222, 230);
            this.receiveData.Name = "receiveData";
            this.receiveData.Size = new System.Drawing.Size(75, 23);
            this.receiveData.TabIndex = 15;
            this.receiveData.Text = "Receive Data";
            this.receiveData.UseVisualStyleBackColor = true;
            this.receiveData.Click += new System.EventHandler(this.ReceiveData_Click);
            // 
            // checkCi
            // 
            this.checkCi.Location = new System.Drawing.Point(307, 230);
            this.checkCi.Name = "checkCi";
            this.checkCi.Size = new System.Drawing.Size(77, 23);
            this.checkCi.TabIndex = 16;
            this.checkCi.Text = "Check CI";
            this.checkCi.UseVisualStyleBackColor = true;
            this.checkCi.Click += new System.EventHandler(this.CheckCi_Click);
            // 
            // timeZone
            // 
            this.timeZone.Location = new System.Drawing.Point(396, 231);
            this.timeZone.Name = "timeZone";
            this.timeZone.Size = new System.Drawing.Size(80, 21);
            this.timeZone.TabIndex = 17;
            this.timeZone.Text = "TimeZone";
            this.timeZone.UseVisualStyleBackColor = true;
            this.timeZone.Click += new System.EventHandler(this.TimeZone_Click);
            // 
            // acsGroup
            // 
            this.acsGroup.Location = new System.Drawing.Point(492, 233);
            this.acsGroup.Name = "acsGroup";
            this.acsGroup.Size = new System.Drawing.Size(71, 19);
            this.acsGroup.TabIndex = 18;
            this.acsGroup.Text = "AcsGroup";
            this.acsGroup.UseVisualStyleBackColor = true;
            this.acsGroup.Click += new System.EventHandler(this.AcsGroup_Click);
            // 
            // inquiryTZ
            // 
            this.inquiryTZ.Location = new System.Drawing.Point(396, 269);
            this.inquiryTZ.Name = "inquiryTZ";
            this.inquiryTZ.Size = new System.Drawing.Size(79, 30);
            this.inquiryTZ.TabIndex = 19;
            this.inquiryTZ.Text = "InquiryTZ";
            this.inquiryTZ.UseVisualStyleBackColor = true;
            this.inquiryTZ.Click += new System.EventHandler(this.InquiryTZ_Click);
            // 
            // inquiryAG
            // 
            this.inquiryAG.Location = new System.Drawing.Point(497, 272);
            this.inquiryAG.Name = "inquiryAG";
            this.inquiryAG.Size = new System.Drawing.Size(65, 27);
            this.inquiryAG.TabIndex = 20;
            this.inquiryAG.Text = "Inquiry AG";
            this.inquiryAG.UseVisualStyleBackColor = true;
            this.inquiryAG.Click += new System.EventHandler(this.InquiryAG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.inquiryAG);
            this.Controls.Add(this.inquiryTZ);
            this.Controls.Add(this.acsGroup);
            this.Controls.Add(this.timeZone);
            this.Controls.Add(this.checkCi);
            this.Controls.Add(this.receiveData);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.userCardNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.logViewer);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portNo);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.TextBox portNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ListBox logViewer;
        private System.Windows.Forms.ComboBox commandBox;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userCardNumber;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button receiveData;
        private System.Windows.Forms.Button checkCi;
        private System.Windows.Forms.Button timeZone;
        private System.Windows.Forms.Button acsGroup;
        private System.Windows.Forms.Button inquiryTZ;
        private System.Windows.Forms.Button inquiryAG;
    }
}

