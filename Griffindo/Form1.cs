using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griffindo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string username = textBox1.Text;
          string passwrd = textBox2.Text;

            if (username == "admin" && passwrd == "1234")
            {
                MessageBox.Show("Welcome Administrator !","Greetigs",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();

            } else {

                MessageBox.Show("Please check your credentials ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else {
                textBox2.UseSystemPasswordChar = true;
            }
           
        }
    }
}
