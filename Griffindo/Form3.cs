using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Griffindo
{
   
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=bavindu_griffindo;Integrated Security=True");
        static Int32 months, weeks, days , totalm , totalw , totald, driver;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string rid = txtRecID.Text;
               
                //Connection
                con.Open();

                //Sql string
                string delstr = "DELETE FROM rent_Cal WHERE Record_ID = @rid";

                //sql command
                SqlCommand delcmd = new SqlCommand(delstr, con);

                //parametric declaration
                delcmd.Parameters.AddWithValue("@rid", rid);

                //execution
                int insert = delcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Data was deleted successfully ");

                }
                else
                {
                    MessageBox.Show("Error : No data was deleted");
                }
                //connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new  Form2();
            menu.Show();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                txtDCost.Enabled = true;
            }
            else
            {
                txtDCost.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from rent_Cal where Record_ID = '" + txtRecID.Text + "';", con);

                SqlDataReader myR = cmd.ExecuteReader();

                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        txtLic.Text = myR["License"].ToString();
                        cmbType.Text = myR["Type"].ToString();
                        dtpStart.Value = DateTime.Parse(myR["Rent_day"].ToString());
                        dtpEnd.Value = DateTime.Parse(myR["Return_day"].ToString());
                        txtTot.Text = myR["Total_rent"].ToString();
                        if (myR["Driver"].ToString() == "Yes")
                        {
                            rbYes.Checked = true;
                        }
                        else
                        {
                            rbNo.Checked = true;
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No Record with this ID !", "No Records !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string rid = txtRecID.Text;
                string license = txtLic.Text;
                string type = cmbType.SelectedItem.ToString();
                string driver;
                if (rbNo.Checked)
                {

                    driver = "No";
                }
                else
                {
                    driver = "Yes";

                }
                DateTime ren = dtpStart.Value;
                DateTime ret = dtpEnd.Value;
                string total = txtTot.Text.ToString();

                //Connection
                con.Open();

                //Sql string
                string updstr = "Update rent_Cal SET License = @license, Type = @type, Driver = @driver, Rent_day = @ren,Return_day = @ret, Total_rent = @total WHERE Record_ID = @rid";

                //sql command
                SqlCommand updcmd = new SqlCommand(updstr, con);

                //parametric declaration
                updcmd.Parameters.AddWithValue("@rid", rid);
                updcmd.Parameters.AddWithValue("@license", license);
                updcmd.Parameters.AddWithValue("@type", type);
                updcmd.Parameters.AddWithValue("@driver", driver);
                updcmd.Parameters.AddWithValue("@ren", ren);
                updcmd.Parameters.AddWithValue("@ret", ret);
                updcmd.Parameters.AddWithValue("@total", total);

                //execution
                int insert = updcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Data was updated successfully ");

                }
                else
                {
                    MessageBox.Show("Error : No data was updated");
                }
                //connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string rid = txtRecID.Text;
                string license = txtLic.Text;
                string type = cmbType.SelectedItem.ToString();
                string driver;
                if (rbNo.Checked)
                {

                    driver = "No";
                }
                else
                {
                    driver = "Yes";

                }
                DateTime ren = dtpStart.Value;
                DateTime ret = dtpEnd.Value;
                string total = txtTot.Text.ToString();

                //Connection
                con.Open();

                //Sql string
                string insstr = "INSERT INTO rent_Cal (License, Type, Driver, Rent_day, Return_day, Total_rent) VALUES(@license,@type,@driver,@ren,@ret,@total)";

                //sql command
                SqlCommand inscmd = new SqlCommand(insstr, con);

                //parametric declaration
                inscmd.Parameters.AddWithValue("@license", license);
                inscmd.Parameters.AddWithValue("@type", type);
                inscmd.Parameters.AddWithValue("@driver", driver);
                inscmd.Parameters.AddWithValue("@ren", ren);
                inscmd.Parameters.AddWithValue("@ret", ret);
                inscmd.Parameters.AddWithValue("@total", total);

                //execution
                int insert = inscmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Data was inserted successfully ");
                  
                }
                else
                {
                    MessageBox.Show("Error : No data was inserted");
                }
                //connection
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(""+ex);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked)
            {
                txtDCost.Enabled = false;
            }
            else {
                txtDCost.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
 
            int dailycost = Int32.Parse(txtDaily.Text);
            int weeklycost = Int32.Parse(txtWeekly.Text);
            int monthlycost = Int32.Parse(txtMonthly.Text);
            int dri_cost = Int32.Parse(txtDCost.Text);

            DateTime rendate = dtpStart.Value;
            DateTime retdate = dtpEnd.Value;
            TimeSpan changedates = retdate - rendate;
            string differencestr = changedates.ToString("dd");
            int difference = Int32.Parse(differencestr);

            if (difference > 30) 
            {
                int months = difference / 30;
                int remaining_d = difference - (months * 30);
                totald = remaining_d * dailycost;
                totalm = months * monthlycost;
            }
            
            if (difference > 7)
            {
                int weeks = difference / 7;
                int remaining_d = difference - (weeks * 7);
                totald = remaining_d * dailycost;
                totalw = weeks * weeklycost;
            }

            if (difference < 7 ) { 
                 days = difference;
                 totald = days * dailycost;
                 
            }
            driver = dri_cost * difference;


            int Total_rent = totalm + totald + totalw + driver;
            MessageBox.Show("M + W + D + Driver = T | " + totalm.ToString() + " + " + totalw.ToString() + " + " + totald.ToString() + " + " + driver + " = " + Total_rent.ToString());
            txtTot.Text = Total_rent.ToString();

        }
    }
}
