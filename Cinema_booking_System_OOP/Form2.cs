using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_System_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {


            string selectedMovie = comboBox1.SelectedItem?.ToString();
            string selectedTime = comboBox2.SelectedItem.ToString(); // Format time properly

            if (!string.IsNullOrEmpty(selectedMovie) && !string.IsNullOrEmpty(selectedTime))
            {
                Booking form = new Booking(selectedMovie, selectedTime);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a movie and a valid time before proceeding.");
            }
        }
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateProceedButton();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateProceedButton();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ValidateProceedButton();
        }
        private void ValidateProceedButton()
        {
            bool isMovieSelected = comboBox1.SelectedItem != null;
            bool isShowtimeValid = dateTimePicker1.Value > DateTime.Now;

            button1.Enabled = isMovieSelected && isShowtimeValid;
        }
    }
}
