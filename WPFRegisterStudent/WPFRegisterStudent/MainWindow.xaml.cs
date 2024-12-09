using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFRegisterStudent
{
    public partial class MainWindow : Window
    {
        Course choice;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize courses and populate ComboBox
            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");

            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);

            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Clear any previous status message
            statusLabel.Content = "";

            // Get the selected course
            choice = (Course)(this.comboBox.SelectedItem);

            // Check if the course is already registered
            if (choice.IsRegisteredAlready())
            {
                statusLabel.Content = $"You have already registered for this {choice.getName()} course.";
                return;
            }

            // Checks hours to see if able to add class
            int totalCreditHours = CalculateTotalCreditHours();
            if (totalCreditHours >= 9)
            {
                statusLabel.Content = "You can not register for more than 9 credit hours.";
                return;
            }

            // Register the course
            choice.SetToRegistered();
            statusLabel.Content = $"Registration Confirmed for course {choice.getName()}.";

            // Update total credit hours
            UpdateCreditHours();

            // Update the registered courses display
            this.listBox.Items.Add(choice.getName());
        }

        private void UpdateCreditHours()
        {
            int totalCredits = CalculateTotalCreditHours();

            // Update the TextBox with total credits
            this.textBox.Text = totalCredits.ToString();
        }

        private int CalculateTotalCreditHours()
        {
            int totalCredits = 0;

            // Calculate total credits for registered courses
            foreach (var item in this.comboBox.Items)
            {
                if (item is Course course && course.IsRegisteredAlready())
                {
                    totalCredits += 3;
                }
            }

            return totalCredits;
        }

    }
}
