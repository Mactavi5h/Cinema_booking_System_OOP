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
    public partial class Booking : Form
    {

        private string movieName; // Store the movie name
        private string movieTime; // Store the movie time
        private List<string> selectedSeats = new List<string>();

        public Booking(string  movieName, string movieTime)
        {
            InitializeComponent();
            this.movieName = movieName; // Initialize movie name
            this.movieTime = movieTime; // Initialize movie time
        
        }
        private void InitializeSeats()
        {
            int rows = 5; // Number of rows
            int columns = 10; // Number of columns

            tableLayoutPanel1.RowCount = rows;
            tableLayoutPanel1.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button seatButton = new Button
                    {
                        Text = $"R{i + 1}C{j + 1}", // Seat label (e.g., R1C1 for Row 1, Column 1)
                        BackColor = Color.LightGray, // Default color for unselected seats
                        Dock = DockStyle.Fill,
                        Tag = false // Tag to track if the seat is selected
                    };

                    seatButton.Click += SeatButton_Click; // Attach click event
                    tableLayoutPanel1.Controls.Add(seatButton, j, i); // Add button to the table
                }
            }

        }
      
        

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button seatButton = sender as Button;

            if ((bool)seatButton.Tag == false)
            {
                seatButton.BackColor = Color.Green;
                seatButton.Tag = true;
                selectedSeats.Add(seatButton.Text); // Add seat to the list
            }
            else
            {
                seatButton.BackColor = Color.LightGray;
                seatButton.Tag = false;
                selectedSeats.Remove(seatButton.Text); // Remove seat from the list
            }
           
        
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // Show the selected seats in a message box
            if (selectedSeats.Count > 0)
            {
                string selectedSeatsMessage = string.Join(", ", selectedSeats);
                MessageBox.Show($"Movie: {movieName}\nTime: {movieTime}\nYou have selected the following seats: {selectedSeatsMessage}", "Selected Seats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No seats selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            InitializeSeats();
           
            // Display movie name and time
            Label movieDetailsLabel = new Label
            {
                Text = $"Movie: {movieName}\nTime: {movieTime}",
                Location = new Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(movieDetailsLabel);
        
    }
    }
}
