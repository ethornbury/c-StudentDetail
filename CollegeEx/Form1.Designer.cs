namespace CollegeEx
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
            this.grpBxStuDetails = new System.Windows.Forms.GroupBox();
            this.lblFnameDisp = new System.Windows.Forms.Label();
            this.lblSurnameDisp = new System.Windows.Forms.Label();
            this.lblDOBDisp = new System.Windows.Forms.Label();
            this.lblGenderDisp = new System.Windows.Forms.Label();
            this.lblEmailDisp = new System.Windows.Forms.Label();
            this.grpBxCourseDet = new System.Windows.Forms.GroupBox();
            this.cmbBxCourseDet = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtBxFname = new System.Windows.Forms.TextBox();
            this.txtBxSurname = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblDispData = new System.Windows.Forms.Label();
            this.grpBxStuDetails.SuspendLayout();
            this.grpBxCourseDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxStuDetails
            // 
            this.grpBxStuDetails.Controls.Add(this.txtBxEmail);
            this.grpBxStuDetails.Controls.Add(this.rdoFemale);
            this.grpBxStuDetails.Controls.Add(this.rdoMale);
            this.grpBxStuDetails.Controls.Add(this.dtpDOB);
            this.grpBxStuDetails.Controls.Add(this.txtBxSurname);
            this.grpBxStuDetails.Controls.Add(this.txtBxFname);
            this.grpBxStuDetails.Controls.Add(this.lblEmailDisp);
            this.grpBxStuDetails.Controls.Add(this.lblGenderDisp);
            this.grpBxStuDetails.Controls.Add(this.lblDOBDisp);
            this.grpBxStuDetails.Controls.Add(this.lblSurnameDisp);
            this.grpBxStuDetails.Controls.Add(this.lblFnameDisp);
            this.grpBxStuDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxStuDetails.ForeColor = System.Drawing.Color.RosyBrown;
            this.grpBxStuDetails.Location = new System.Drawing.Point(43, 12);
            this.grpBxStuDetails.Name = "grpBxStuDetails";
            this.grpBxStuDetails.Size = new System.Drawing.Size(273, 225);
            this.grpBxStuDetails.TabIndex = 0;
            this.grpBxStuDetails.TabStop = false;
            this.grpBxStuDetails.Text = "Student Details";
            // 
            // lblFnameDisp
            // 
            this.lblFnameDisp.AutoSize = true;
            this.lblFnameDisp.Location = new System.Drawing.Point(16, 36);
            this.lblFnameDisp.Name = "lblFnameDisp";
            this.lblFnameDisp.Size = new System.Drawing.Size(73, 16);
            this.lblFnameDisp.TabIndex = 0;
            this.lblFnameDisp.Text = "First Name";
            // 
            // lblSurnameDisp
            // 
            this.lblSurnameDisp.AutoSize = true;
            this.lblSurnameDisp.Location = new System.Drawing.Point(16, 65);
            this.lblSurnameDisp.Name = "lblSurnameDisp";
            this.lblSurnameDisp.Size = new System.Drawing.Size(62, 16);
            this.lblSurnameDisp.TabIndex = 1;
            this.lblSurnameDisp.Text = "Surname";
            // 
            // lblDOBDisp
            // 
            this.lblDOBDisp.AutoSize = true;
            this.lblDOBDisp.Location = new System.Drawing.Point(16, 94);
            this.lblDOBDisp.Name = "lblDOBDisp";
            this.lblDOBDisp.Size = new System.Drawing.Size(37, 16);
            this.lblDOBDisp.TabIndex = 2;
            this.lblDOBDisp.Text = "DOB";
            // 
            // lblGenderDisp
            // 
            this.lblGenderDisp.AutoSize = true;
            this.lblGenderDisp.Location = new System.Drawing.Point(16, 122);
            this.lblGenderDisp.Name = "lblGenderDisp";
            this.lblGenderDisp.Size = new System.Drawing.Size(53, 16);
            this.lblGenderDisp.TabIndex = 3;
            this.lblGenderDisp.Text = "Gender";
            // 
            // lblEmailDisp
            // 
            this.lblEmailDisp.AutoSize = true;
            this.lblEmailDisp.Location = new System.Drawing.Point(16, 190);
            this.lblEmailDisp.Name = "lblEmailDisp";
            this.lblEmailDisp.Size = new System.Drawing.Size(42, 16);
            this.lblEmailDisp.TabIndex = 4;
            this.lblEmailDisp.Text = "Email";
            // 
            // grpBxCourseDet
            // 
            this.grpBxCourseDet.Controls.Add(this.lblCourse);
            this.grpBxCourseDet.Controls.Add(this.cmbBxCourseDet);
            this.grpBxCourseDet.Location = new System.Drawing.Point(43, 263);
            this.grpBxCourseDet.Name = "grpBxCourseDet";
            this.grpBxCourseDet.Size = new System.Drawing.Size(273, 100);
            this.grpBxCourseDet.TabIndex = 1;
            this.grpBxCourseDet.TabStop = false;
            this.grpBxCourseDet.Text = "Course Details";
            // 
            // cmbBxCourseDet
            // 
            this.cmbBxCourseDet.FormattingEnabled = true;
            this.cmbBxCourseDet.Items.AddRange(new object[] {
            "Business",
            "Marketing",
            "IT"});
            this.cmbBxCourseDet.Location = new System.Drawing.Point(130, 29);
            this.cmbBxCourseDet.Name = "cmbBxCourseDet";
            this.cmbBxCourseDet.Size = new System.Drawing.Size(121, 21);
            this.cmbBxCourseDet.TabIndex = 0;
            this.cmbBxCourseDet.Text = "Please Select One";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(6, 32);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Course";
            // 
            // txtBxFname
            // 
            this.txtBxFname.Location = new System.Drawing.Point(130, 33);
            this.txtBxFname.Name = "txtBxFname";
            this.txtBxFname.Size = new System.Drawing.Size(100, 22);
            this.txtBxFname.TabIndex = 5;
            // 
            // txtBxSurname
            // 
            this.txtBxSurname.Location = new System.Drawing.Point(130, 62);
            this.txtBxSurname.Name = "txtBxSurname";
            this.txtBxSurname.Size = new System.Drawing.Size(100, 22);
            this.txtBxSurname.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(130, 89);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(137, 22);
            this.dtpDOB.TabIndex = 7;
            this.dtpDOB.Value = new System.DateTime(2016, 2, 2, 0, 0, 0, 0);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(130, 122);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(56, 20);
            this.rdoMale.TabIndex = 8;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Checked = true;
            this.rdoFemale.Location = new System.Drawing.Point(130, 149);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(72, 20);
            this.rdoFemale.TabIndex = 9;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(130, 185);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(100, 22);
            this.txtBxEmail.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(62, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(219, 380);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // lblDispData
            // 
            this.lblDispData.BackColor = System.Drawing.Color.RosyBrown;
            this.lblDispData.Location = new System.Drawing.Point(43, 435);
            this.lblDispData.Name = "lblDispData";
            this.lblDispData.Size = new System.Drawing.Size(273, 77);
            this.lblDispData.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(351, 534);
            this.Controls.Add(this.lblDispData);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpBxCourseDet);
            this.Controls.Add(this.grpBxStuDetails);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBxStuDetails.ResumeLayout(false);
            this.grpBxStuDetails.PerformLayout();
            this.grpBxCourseDet.ResumeLayout(false);
            this.grpBxCourseDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxStuDetails;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtBxSurname;
        private System.Windows.Forms.TextBox txtBxFname;
        private System.Windows.Forms.Label lblEmailDisp;
        private System.Windows.Forms.Label lblGenderDisp;
        private System.Windows.Forms.Label lblDOBDisp;
        private System.Windows.Forms.Label lblSurnameDisp;
        private System.Windows.Forms.Label lblFnameDisp;
        private System.Windows.Forms.GroupBox grpBxCourseDet;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbBxCourseDet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblDispData;
    }
}

