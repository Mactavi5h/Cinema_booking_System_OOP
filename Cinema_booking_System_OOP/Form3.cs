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
    public partial class Form3 : Form
    {
        private object txttextBox1;

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1 form1 = new form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login user = new Login();

            try
            {
                user.Username = textBox1.Text;
                user.Password = textBox2.Text;

                MessageBox.Show($"You logged in as {user.Username}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the next form
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }       

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
