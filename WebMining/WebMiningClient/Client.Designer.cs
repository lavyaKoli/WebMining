﻿namespace WebMiningClient
{
    partial class ClientForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxProfile = new System.Windows.Forms.ComboBox();
            this.cboxOS = new System.Windows.Forms.ComboBox();
            this.cboxBrowser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewSession = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.txtboxTime = new System.Windows.Forms.TextBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.lstboxSuggestedPages = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPredicatedGender = new System.Windows.Forms.Label();
            this.lstboxRequestedPages = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lstboxRequestedPages);
            this.groupBox1.Controls.Add(this.btnNewUser);
            this.groupBox1.Controls.Add(this.txtboxTime);
            this.groupBox1.Controls.Add(this.txtboxDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnNewSession);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxProfile);
            this.groupBox1.Controls.Add(this.cboxOS);
            this.groupBox1.Controls.Add(this.cboxBrowser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxCountry);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // cboxProfile
            // 
            this.cboxProfile.FormattingEnabled = true;
            this.cboxProfile.Items.AddRange(new object[] {
            "Unkowen",
            "MALE",
            "FEMALE"});
            this.cboxProfile.Location = new System.Drawing.Point(78, 108);
            this.cboxProfile.Name = "cboxProfile";
            this.cboxProfile.Size = new System.Drawing.Size(121, 21);
            this.cboxProfile.TabIndex = 4;
            this.cboxProfile.Text = "Unkowen";
            // 
            // cboxOS
            // 
            this.cboxOS.FormattingEnabled = true;
            this.cboxOS.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "Mac",
            "Other"});
            this.cboxOS.Location = new System.Drawing.Point(78, 81);
            this.cboxOS.Name = "cboxOS";
            this.cboxOS.Size = new System.Drawing.Size(121, 21);
            this.cboxOS.TabIndex = 3;
            this.cboxOS.Text = "Windows";
            // 
            // cboxBrowser
            // 
            this.cboxBrowser.FormattingEnabled = true;
            this.cboxBrowser.Items.AddRange(new object[] {
            "Chrome",
            "FireFox",
            "Opera",
            "Other"});
            this.cboxBrowser.Location = new System.Drawing.Point(78, 54);
            this.cboxBrowser.Name = "cboxBrowser";
            this.cboxBrowser.Size = new System.Drawing.Size(121, 21);
            this.cboxBrowser.TabIndex = 2;
            this.cboxBrowser.Text = "Chrome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country";
            // 
            // cboxCountry
            // 
            this.cboxCountry.FormattingEnabled = true;
            this.cboxCountry.Items.AddRange(new object[] {
            "Syria",
            "Canada",
            "China",
            "France",
            "Italy",
            "Malta"});
            this.cboxCountry.Location = new System.Drawing.Point(78, 27);
            this.cboxCountry.Name = "cboxCountry";
            this.cboxCountry.Size = new System.Drawing.Size(121, 21);
            this.cboxCountry.TabIndex = 0;
            this.cboxCountry.Text = "Syria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Browser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Profile";
            // 
            // btnNewSession
            // 
            this.btnNewSession.Location = new System.Drawing.Point(78, 362);
            this.btnNewSession.Name = "btnNewSession";
            this.btnNewSession.Size = new System.Drawing.Size(121, 23);
            this.btnNewSession.TabIndex = 1;
            this.btnNewSession.Text = "New Session";
            this.btnNewSession.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date";
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(78, 183);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(121, 20);
            this.txtboxDate.TabIndex = 13;
            this.txtboxDate.Text = "01-12-2017";
            this.txtboxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxTime
            // 
            this.txtboxTime.Location = new System.Drawing.Point(78, 158);
            this.txtboxTime.Name = "txtboxTime";
            this.txtboxTime.Size = new System.Drawing.Size(121, 20);
            this.txtboxTime.TabIndex = 14;
            this.txtboxTime.Text = "23:59:59";
            this.txtboxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(78, 408);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(121, 44);
            this.btnNewUser.TabIndex = 15;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // lstboxSuggestedPages
            // 
            this.lstboxSuggestedPages.FormattingEnabled = true;
            this.lstboxSuggestedPages.Location = new System.Drawing.Point(15, 44);
            this.lstboxSuggestedPages.Name = "lstboxSuggestedPages";
            this.lstboxSuggestedPages.Size = new System.Drawing.Size(168, 407);
            this.lstboxSuggestedPages.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Suggested Pages";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Predicated Gender : ";
            // 
            // lblPredicatedGender
            // 
            this.lblPredicatedGender.AutoSize = true;
            this.lblPredicatedGender.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPredicatedGender.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPredicatedGender.Location = new System.Drawing.Point(330, 28);
            this.lblPredicatedGender.Name = "lblPredicatedGender";
            this.lblPredicatedGender.Size = new System.Drawing.Size(50, 17);
            this.lblPredicatedGender.TabIndex = 18;
            this.lblPredicatedGender.Text = "NONE";
            // 
            // lstboxRequestedPages
            // 
            this.lstboxRequestedPages.FormattingEnabled = true;
            this.lstboxRequestedPages.Location = new System.Drawing.Point(20, 250);
            this.lstboxRequestedPages.Name = "lstboxRequestedPages";
            this.lstboxRequestedPages.Size = new System.Drawing.Size(179, 108);
            this.lstboxRequestedPages.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Requested pages";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblPredicatedGender);
            this.groupBox2.Controls.Add(this.lstboxSuggestedPages);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 458);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(189, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 294);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Selected Advertisement:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(332, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Selected Cluster ID: ";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(228, 44);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(214, 341);
            this.treeView1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Make Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Website map";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ClientForm";
            this.Text = "WebMiningClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxProfile;
        private System.Windows.Forms.ComboBox cboxOS;
        private System.Windows.Forms.ComboBox cboxBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewSession;
        private System.Windows.Forms.TextBox txtboxTime;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstboxRequestedPages;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.ListBox lstboxSuggestedPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPredicatedGender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
