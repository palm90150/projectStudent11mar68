namespace StudentManagement
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAdvisors();
        }

        private void LoadAdvisors()
        {
            comboBoxAdvisor.Items.Clear();
            comboBoxAdvisor.Items.Add("Dr. Full frontal");
            comboBoxAdvisor.Items.Add("Dr. Wichaphop");
            comboBoxAdvisor.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxAdvisor.Items.Add("Dr. Char aznable");
            comboBoxAdvisor.Items.Add("Dr. Amuro rey");
            comboBoxAdvisor.SelectedIndex = 0; // เลือกค่าเริ่มต้น
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text;
            string studentID = txtStudentID.Text;
            string major = txtMajor.Text;
            double grade = double.Parse(txtGrade.Text);
            string advisor = comboBoxAdvisor.SelectedItem.ToString();

            string studentInfo = $"{name} ({studentID}), สาขา: {major}, เกรด: {grade}, ที่ปรึกษา: {advisor}";

            listBoxStudents.Items.Add(studentInfo);
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย!");
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.Items.Count == 0)
            {
                MessageBox.Show("ยังไม่มีข้อมูลนักศึกษา");
                return;
            }
        }

        private void btnTopStudent_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.Items.Count == 0)
            {
                MessageBox.Show("ยังไม่มีข้อมูลนักศึกษา");
                return;
            }

            string topStudent = "";
            double maxGrade = 0;

            foreach (string student in listBoxStudents.Items)
            {
                string[] data = student.Split(',');
                string gradePart = data[2].Trim().Split(':')[1]; // ดึงค่าเกรด
                double grade = double.Parse(gradePart);

                if (grade > maxGrade)
                {
                    maxGrade = grade;
                    topStudent = student;
                }
            }

            MessageBox.Show($"นักศึกษาที่ได้เกรดสูงสุดคือ: {topStudent}");
        }
    }
}
