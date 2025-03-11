namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentName = new Label();
            label2 = new Label();
            lblMajor = new Label();
            lblAdvisor = new Label();
            lblGrade = new Label();
            txtStudentName = new TextBox();
            txtStudentID = new TextBox();
            txtMajor = new TextBox();
            txtGrade = new TextBox();
            comboBoxAdvisor = new ComboBox();
            btnSaveStudent = new Button();
            btnShowStudents = new Button();
            btnTopStudent = new Button();
            listBoxStudents = new ListBox();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(20, 20);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(26, 20);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "ชื่อ";
            lblStudentName.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "รหัสนักศึกษา";
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Location = new Point(20, 100);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(40, 20);
            lblMajor.TabIndex = 2;
            lblMajor.Text = "สาขา";
            // 
            // lblAdvisor
            // 
            lblAdvisor.AutoSize = true;
            lblAdvisor.Location = new Point(20, 140);
            lblAdvisor.Name = "lblAdvisor";
            lblAdvisor.Size = new Size(103, 20);
            lblAdvisor.TabIndex = 3;
            lblAdvisor.Text = "อาจารย์ที่ปรึกษา";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(20, 180);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(37, 20);
            lblGrade.TabIndex = 4;
            lblGrade.Text = "เกรด";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(100, 20);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 5;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(100, 60);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 6;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(100, 100);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(125, 27);
            txtMajor.TabIndex = 7;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(100, 180);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(125, 27);
            txtGrade.TabIndex = 8;
            // 
            // comboBoxAdvisor
            // 
            comboBoxAdvisor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAdvisor.FormattingEnabled = true;
            comboBoxAdvisor.Location = new Point(150, 140);
            comboBoxAdvisor.Name = "comboBoxAdvisor";
            comboBoxAdvisor.Size = new Size(151, 28);
            comboBoxAdvisor.TabIndex = 9;
            // 
            // btnSaveStudent
            // 
            btnSaveStudent.Location = new Point(100, 220);
            btnSaveStudent.Name = "btnSaveStudent";
            btnSaveStudent.Size = new Size(94, 29);
            btnSaveStudent.TabIndex = 10;
            btnSaveStudent.Text = "บันทึกข้อมูล";
            btnSaveStudent.UseVisualStyleBackColor = true;
            btnSaveStudent.Click += btnSaveStudent_Click;
            // 
            // btnShowStudents
            // 
            btnShowStudents.Location = new Point(100, 260);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(138, 29);
            btnShowStudents.TabIndex = 11;
            btnShowStudents.Text = "แสดงรายชื่อนักศึกษา";
            btnShowStudents.UseVisualStyleBackColor = true;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // btnTopStudent
            // 
            btnTopStudent.Location = new Point(100, 300);
            btnTopStudent.Name = "btnTopStudent";
            btnTopStudent.Size = new Size(176, 29);
            btnTopStudent.TabIndex = 12;
            btnTopStudent.Text = "นักศึกษาที่ได้เกรดสูงสุด";
            btnTopStudent.UseVisualStyleBackColor = true;
            btnTopStudent.Click += btnTopStudent_Click;
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(335, 20);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(424, 324);
            listBoxStudents.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxStudents);
            Controls.Add(btnTopStudent);
            Controls.Add(btnShowStudents);
            Controls.Add(btnSaveStudent);
            Controls.Add(comboBoxAdvisor);
            Controls.Add(txtGrade);
            Controls.Add(txtMajor);
            Controls.Add(txtStudentID);
            Controls.Add(txtStudentName);
            Controls.Add(lblGrade);
            Controls.Add(lblAdvisor);
            Controls.Add(lblMajor);
            Controls.Add(label2);
            Controls.Add(lblStudentName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ระบบบันทึกข้อมูลนักศึกษา";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private Label label2;
        private Label lblMajor;
        private Label lblAdvisor;
        private Label lblGrade;
        private TextBox txtStudentName;
        private TextBox txtStudentID;
        private TextBox txtMajor;
        private TextBox txtGrade;
        private ComboBox comboBoxAdvisor;
        private Button btnSaveStudent;
        private Button btnShowStudents;
        private Button btnTopStudent;
        private ListBox listBoxStudents;
    }
}
