namespace CSIT314_project
{
    partial class editCPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editCPForm));
            this.goBackButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.cpNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cpIdInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.clinicNameComboBox = new System.Windows.Forms.ComboBox();
            this.contactNoInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.memberSinceInput = new System.Windows.Forms.DateTimePicker();
            this.alternativeContactNoInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.personalQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.personalAnswerInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.Location = new System.Drawing.Point(108, 456);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 35);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "GO BACK";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(335, 108);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 31);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(237, 456);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 35);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cpNameInput
            // 
            this.cpNameInput.Location = new System.Drawing.Point(237, 155);
            this.cpNameInput.Name = "cpNameInput";
            this.cpNameInput.Size = new System.Drawing.Size(171, 21);
            this.cpNameInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Contact Person Name:";
            // 
            // cpIdInput
            // 
            this.cpIdInput.Location = new System.Drawing.Point(237, 113);
            this.cpIdInput.Name = "cpIdInput";
            this.cpIdInput.Size = new System.Drawing.Size(83, 21);
            this.cpIdInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Contact Person ID:";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(151, 54);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(198, 24);
            this.titleLabel1.TabIndex = 22;
            this.titleLabel1.Text = "Edit Contact Person";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(29, 17);
            this.currentUserLabel.TabIndex = 21;
            this.currentUserLabel.Text = "Hi, ";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(160, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.dateTimeLabel.TabIndex = 20;
            this.dateTimeLabel.Text = "Date/Time";
            // 
            // clinicNameComboBox
            // 
            this.clinicNameComboBox.FormattingEnabled = true;
            this.clinicNameComboBox.Location = new System.Drawing.Point(237, 199);
            this.clinicNameComboBox.Name = "clinicNameComboBox";
            this.clinicNameComboBox.Size = new System.Drawing.Size(171, 20);
            this.clinicNameComboBox.TabIndex = 4;
            // 
            // contactNoInput
            // 
            this.contactNoInput.Location = new System.Drawing.Point(237, 239);
            this.contactNoInput.Name = "contactNoInput";
            this.contactNoInput.Size = new System.Drawing.Size(171, 21);
            this.contactNoInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Contact No:";
            // 
            // memberSinceInput
            // 
            this.memberSinceInput.Location = new System.Drawing.Point(237, 318);
            this.memberSinceInput.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.memberSinceInput.Name = "memberSinceInput";
            this.memberSinceInput.Size = new System.Drawing.Size(171, 21);
            this.memberSinceInput.TabIndex = 7;
            this.memberSinceInput.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // alternativeContactNoInput
            // 
            this.alternativeContactNoInput.Location = new System.Drawing.Point(237, 279);
            this.alternativeContactNoInput.MaxLength = 250;
            this.alternativeContactNoInput.Name = "alternativeContactNoInput";
            this.alternativeContactNoInput.Size = new System.Drawing.Size(171, 21);
            this.alternativeContactNoInput.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Alternative Contact No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Member since:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Clinic Name:";
            // 
            // personalQuestionComboBox
            // 
            this.personalQuestionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personalQuestionComboBox.DropDownWidth = 220;
            this.personalQuestionComboBox.Font = new System.Drawing.Font("굴림", 7.8F);
            this.personalQuestionComboBox.FormattingEnabled = true;
            this.personalQuestionComboBox.Location = new System.Drawing.Point(236, 361);
            this.personalQuestionComboBox.Name = "personalQuestionComboBox";
            this.personalQuestionComboBox.Size = new System.Drawing.Size(171, 18);
            this.personalQuestionComboBox.TabIndex = 8;
            // 
            // personalAnswerInput
            // 
            this.personalAnswerInput.Location = new System.Drawing.Point(236, 400);
            this.personalAnswerInput.Name = "personalAnswerInput";
            this.personalAnswerInput.Size = new System.Drawing.Size(171, 21);
            this.personalAnswerInput.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Personal Answer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Personal Question:";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(13, 35);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(43, 12);
            this.logoutLabel.TabIndex = 48;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // editCPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 507);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.personalQuestionComboBox);
            this.Controls.Add(this.personalAnswerInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clinicNameComboBox);
            this.Controls.Add(this.contactNoInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.memberSinceInput);
            this.Controls.Add(this.alternativeContactNoInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cpNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpIdInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "editCPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediSupply System";
            this.Load += new System.EventHandler(this.editCPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox cpNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cpIdInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.ComboBox clinicNameComboBox;
        private System.Windows.Forms.TextBox contactNoInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker memberSinceInput;
        private System.Windows.Forms.TextBox alternativeContactNoInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox personalQuestionComboBox;
        private System.Windows.Forms.TextBox personalAnswerInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel logoutLabel;
    }
}