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

            for (int i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i);
            }

            int currentYear = DateTime.Now.Year;
            for (int i = 1900; i <= currentYear; i++)
            {
                yearComboBox.Items.Add(i);
            }
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
            UpdateSelectedDate();

            MessageBox.Show($"Student Name: {firstName} {middleName} {lastName} \nGender: {gender} \nDate of birth: {selectedDate}");
        }

        private void UpdateSelectedDate()
        {
            int selectedDay = (int)(dayComboBox.SelectedItem ?? 0);
            int selectedMonth = (int)(monthComboBox.SelectedItem ?? 0);
            int selectedYear = (int)(yearComboBox.SelectedItem ?? 0);

            if (selectedDay > 0 && selectedMonth > 0 && selectedYear > 0)
            {
                selectedDate = $"{selectedMonth}/{selectedDay}/{selectedYear}";
            }
            else
            {
                selectedDate = "Invalid Date";
            }
        }

        private string selectedDate;
    }
}
