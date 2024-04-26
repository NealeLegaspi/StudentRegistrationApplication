namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            dayComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            monthComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            yearComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            programComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            for (int i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i);
            }

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string month in months)
            {
                monthComboBox.Items.Add(month);
            }

            int currentYear = DateTime.Now.Year;
            for (int i = 1900; i <= currentYear; i++)
            {
                yearComboBox.Items.Add(i);
            }

            programComboBox.Items.Add("Bachelor of Science in Computer Science");
            programComboBox.Items.Add("Bachelor of Science in Information Technology");
            programComboBox.Items.Add("Bachelor of Science in Information Systems");
            programComboBox.Items.Add("Bachelor of Science in Computer Engineering");
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedDate();
        }

        private void registerStudentButton_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastname.Text;
            string gender = maleGenderButton.Checked ? "Male" : femaleGenderButton.Checked ? "Female" : "Not specified";
            string selectedProgram = programComboBox.SelectedItem?.ToString() ?? "No Program selected";
            UpdateSelectedDate();

            DisplayStudentInfo(firstName, lastName);
            DisplayStudentInfo(firstName, middleName, lastName);
            DisplayStudentInfo(firstName, middleName, lastName, gender, selectedDate, selectedProgram);
        }

        private void DisplayStudentInfo(string firstName, string lastName)
        {
            MessageBox.Show($"Student Name: {firstName} {lastName}");
        }

        private void DisplayStudentInfo(string firstName, string middleName, string lastName)
        {
            MessageBox.Show($"Student Name: {firstName} {middleName} {lastName}");
        }

        private void DisplayStudentInfo(string firstName, string middleName, string lastName, string gender, string dob, string program)
        {
            MessageBox.Show($"Student Name: {firstName} {middleName} {lastName}\nGender: {gender}\nDate of Birth: {dob}\nProgram: {program}");
        }

        private void UpdateSelectedDate()
        {
            int selectedDay = (int)(dayComboBox.SelectedItem ?? 0);
            int selectedMonthIndex = (int)(monthComboBox.SelectedIndex);
            int selectedYear = (int)(yearComboBox.SelectedItem ?? 0);

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            if (selectedDay > 0 && selectedMonthIndex >= 0 && selectedYear > 0)
            {
                selectedDate = $"{selectedDay}/{months[selectedMonthIndex]}/{selectedYear}";
            }
            else
            {
                selectedDate = "Invalid Date";
            }
        }

        private void browseButton_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private string selectedDate;
    }
}
