﻿
namespace SchoolLibraryManager
{
    partial class StudentListForm
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
            this.lblGraduatedStudent = new System.Windows.Forms.Label();
            this.lblLeaveStudent = new System.Windows.Forms.Label();
            this.lblAttendingStudent = new System.Windows.Forms.Label();
            this.lblAllStudent = new System.Windows.Forms.Label();
            this.lvwStudentList = new System.Windows.Forms.ListView();
            this.chStuId = new System.Windows.Forms.ColumnHeader();
            this.chStuName = new System.Windows.Forms.ColumnHeader();
            this.chStuBirth = new System.Windows.Forms.ColumnHeader();
            this.chStuGender = new System.Windows.Forms.ColumnHeader();
            this.chStuPhone = new System.Windows.Forms.ColumnHeader();
            this.chStuZip = new System.Windows.Forms.ColumnHeader();
            this.chStuEmail = new System.Windows.Forms.ColumnHeader();
            this.chStuAdmitdate = new System.Windows.Forms.ColumnHeader();
            this.txtSearchStuStuForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGraduatedStudent);
            this.groupBox1.Controls.Add(this.lblLeaveStudent);
            this.groupBox1.Controls.Add(this.lblAttendingStudent);
            this.groupBox1.Controls.Add(this.lblAllStudent);
            this.groupBox1.Location = new System.Drawing.Point(27, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(168, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생현황";
            // 
            // lblGraduatedStudent
            // 
            this.lblGraduatedStudent.AutoSize = true;
            this.lblGraduatedStudent.Location = new System.Drawing.Point(12, 94);
            this.lblGraduatedStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGraduatedStudent.Name = "lblGraduatedStudent";
            this.lblGraduatedStudent.Size = new System.Drawing.Size(86, 15);
            this.lblGraduatedStudent.TabIndex = 8;
            this.lblGraduatedStudent.Text = "졸업 학생 수 : ";
            // 
            // lblLeaveStudent
            // 
            this.lblLeaveStudent.AutoSize = true;
            this.lblLeaveStudent.Location = new System.Drawing.Point(12, 71);
            this.lblLeaveStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaveStudent.Name = "lblLeaveStudent";
            this.lblLeaveStudent.Size = new System.Drawing.Size(86, 15);
            this.lblLeaveStudent.TabIndex = 7;
            this.lblLeaveStudent.Text = "휴학 학생 수 : ";
            // 
            // lblAttendingStudent
            // 
            this.lblAttendingStudent.AutoSize = true;
            this.lblAttendingStudent.Location = new System.Drawing.Point(12, 49);
            this.lblAttendingStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttendingStudent.Name = "lblAttendingStudent";
            this.lblAttendingStudent.Size = new System.Drawing.Size(86, 15);
            this.lblAttendingStudent.TabIndex = 6;
            this.lblAttendingStudent.Text = "재학 학생 수 : ";
            // 
            // lblAllStudent
            // 
            this.lblAllStudent.AutoSize = true;
            this.lblAllStudent.Location = new System.Drawing.Point(12, 26);
            this.lblAllStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllStudent.Name = "lblAllStudent";
            this.lblAllStudent.Size = new System.Drawing.Size(86, 15);
            this.lblAllStudent.TabIndex = 5;
            this.lblAllStudent.Text = "전체 학생 수 : ";
            // 
            // lvwStudentList
            // 
            this.lvwStudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStuId,
            this.chStuName,
            this.chStuBirth,
            this.chStuGender,
            this.chStuPhone,
            this.chStuZip,
            this.chStuEmail,
            this.chStuAdmitdate});
            this.lvwStudentList.FullRowSelect = true;
            this.lvwStudentList.GridLines = true;
            this.lvwStudentList.HideSelection = false;
            this.lvwStudentList.Location = new System.Drawing.Point(229, 38);
            this.lvwStudentList.Margin = new System.Windows.Forms.Padding(2);
            this.lvwStudentList.Name = "lvwStudentList";
            this.lvwStudentList.Size = new System.Drawing.Size(555, 380);
            this.lvwStudentList.TabIndex = 1;
            this.lvwStudentList.UseCompatibleStateImageBehavior = false;
            this.lvwStudentList.View = System.Windows.Forms.View.Details;
            // 
            // chStuId
            // 
            this.chStuId.Text = "학번";
            this.chStuId.Width = 120;
            // 
            // chStuName
            // 
            this.chStuName.Text = "이름";
            this.chStuName.Width = 80;
            // 
            // chStuBirth
            // 
            this.chStuBirth.Text = "생년월일";
            this.chStuBirth.Width = 100;
            // 
            // chStuGender
            // 
            this.chStuGender.Text = "성별";
            // 
            // chStuPhone
            // 
            this.chStuPhone.Text = "전화번호";
            this.chStuPhone.Width = 100;
            // 
            // chStuZip
            // 
            this.chStuZip.Text = "주소";
            this.chStuZip.Width = 130;
            // 
            // chStuEmail
            // 
            this.chStuEmail.Text = "이메일";
            this.chStuEmail.Width = 130;
            // 
            // chStuAdmitdate
            // 
            this.chStuAdmitdate.Text = "입학일";
            this.chStuAdmitdate.Width = 100;
            // 
            // txtSearchStuStuForm
            // 
            this.txtSearchStuStuForm.Location = new System.Drawing.Point(27, 193);
            this.txtSearchStuStuForm.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStuStuForm.Name = "txtSearchStuStuForm";
            this.txtSearchStuStuForm.Size = new System.Drawing.Size(169, 23);
            this.txtSearchStuStuForm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "학번/이름";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(115, 220);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(80, 30);
            this.btnSearchStudent.TabIndex = 4;
            this.btnSearchStudent.Text = "검색";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(27, 393);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(168, 25);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "학생 추가";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 446);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchStuStuForm);
            this.Controls.Add(this.lvwStudentList);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentListForm";
            this.Text = "StudentListForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwStudentList;
        private System.Windows.Forms.Label lblGraduatedStudent;
        private System.Windows.Forms.Label lblLeaveStudent;
        private System.Windows.Forms.Label lblAttendingStudent;
        private System.Windows.Forms.Label lblAllStudent;
        private System.Windows.Forms.TextBox txtSearchStuStuForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ColumnHeader chStuId;
        private System.Windows.Forms.ColumnHeader chStuName;
        private System.Windows.Forms.ColumnHeader chStuBirth;
        private System.Windows.Forms.ColumnHeader chStuGender;
        private System.Windows.Forms.ColumnHeader chStuPhone;
        private System.Windows.Forms.ColumnHeader chStuZip;
        private System.Windows.Forms.ColumnHeader chStuEmail;
        private System.Windows.Forms.ColumnHeader chStuAdmitdate;
    }
}