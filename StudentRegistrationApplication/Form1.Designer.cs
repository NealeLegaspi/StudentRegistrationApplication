namespace StudentRegistrationApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtLastname = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            maleGenderButton = new RadioButton();
            femaleGenderButton = new RadioButton();
            dayComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            registerStudentButton = new Button();
            programComboBox = new ComboBox();
            label7 = new Label();
            pictureBox = new PictureBox();
            browseButton_Click = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(210, 21);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 67);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 117);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 2;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 171);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 3;
            label4.Text = "Middle name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 4;
            label5.Text = "Gender *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 256);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 5;
            label6.Text = "Date of birth *";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(12, 91);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(240, 23);
            txtLastname.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 141);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(240, 23);
            txtFirstName.TabIndex = 7;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(12, 196);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(240, 23);
            txtMiddleName.TabIndex = 8;
            // 
            // maleGenderButton
            // 
            maleGenderButton.AutoSize = true;
            maleGenderButton.Location = new Point(90, 225);
            maleGenderButton.Name = "maleGenderButton";
            maleGenderButton.Size = new Size(51, 19);
            maleGenderButton.TabIndex = 9;
            maleGenderButton.TabStop = true;
            maleGenderButton.Text = "Male";
            maleGenderButton.UseVisualStyleBackColor = true;
            // 
            // femaleGenderButton
            // 
            femaleGenderButton.AutoSize = true;
            femaleGenderButton.Location = new Point(147, 225);
            femaleGenderButton.Name = "femaleGenderButton";
            femaleGenderButton.Size = new Size(63, 19);
            femaleGenderButton.TabIndex = 10;
            femaleGenderButton.TabStop = true;
            femaleGenderButton.Text = "Female";
            femaleGenderButton.UseVisualStyleBackColor = true;
            // 
            // dayComboBox
            // 
            dayComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Location = new Point(12, 292);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(65, 29);
            dayComboBox.TabIndex = 11;
            dayComboBox.Text = "-Day-";
            // 
            // monthComboBox
            // 
            monthComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Location = new Point(83, 292);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(83, 29);
            monthComboBox.TabIndex = 12;
            monthComboBox.Text = "-Month-";
            // 
            // yearComboBox
            // 
            yearComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(172, 292);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(80, 29);
            yearComboBox.TabIndex = 13;
            yearComboBox.Text = "-Year-";
            // 
            // registerStudentButton
            // 
            registerStudentButton.BackColor = Color.Crimson;
            registerStudentButton.FlatStyle = FlatStyle.Flat;
            registerStudentButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerStudentButton.ForeColor = Color.White;
            registerStudentButton.Location = new Point(9, 402);
            registerStudentButton.Name = "registerStudentButton";
            registerStudentButton.Size = new Size(175, 37);
            registerStudentButton.TabIndex = 14;
            registerStudentButton.Text = "Register Student";
            registerStudentButton.UseVisualStyleBackColor = false;
            registerStudentButton.Click += registerStudentButton_Click;
            // 
            // programComboBox
            // 
            programComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programComboBox.FormattingEnabled = true;
            programComboBox.Location = new Point(12, 356);
            programComboBox.Name = "programComboBox";
            programComboBox.Size = new Size(300, 29);
            programComboBox.TabIndex = 15;
            programComboBox.Text = "-Select program-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 330);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 16;
            label7.Text = "Program to apply *";
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Location = new Point(276, 67);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(234, 210);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 17;
            pictureBox.TabStop = false;
            // 
            // browseButton_Click
            // 
            browseButton_Click.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browseButton_Click.Location = new Point(335, 283);
            browseButton_Click.Name = "browseButton_Click";
            browseButton_Click.Size = new Size(122, 38);
            browseButton_Click.TabIndex = 18;
            browseButton_Click.Text = "Browse";
            browseButton_Click.UseVisualStyleBackColor = true;
            browseButton_Click.Click += browseButton_Click_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 486);
            Controls.Add(browseButton_Click);
            Controls.Add(pictureBox);
            Controls.Add(label7);
            Controls.Add(programComboBox);
            Controls.Add(registerStudentButton);
            Controls.Add(yearComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(dayComboBox);
            Controls.Add(femaleGenderButton);
            Controls.Add(maleGenderButton);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtLastname;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private RadioButton maleGenderButton;
        private RadioButton femaleGenderButton;
        private ComboBox dayComboBox;
        private ComboBox monthComboBox;
        private ComboBox yearComboBox;
        private Button registerStudentButton;
        private ComboBox programComboBox;
        private Label label7;
        private PictureBox pictureBox;
        private Button browseButton_Click;
        private OpenFileDialog openFileDialog;
    }
}
