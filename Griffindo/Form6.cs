using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Griffindo
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=bavindu_griffindo;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            showTable("select Record_ID , License , Type , Driver , Rent_day , Return_day , Total_rent from rent_Cal",dataGridView1);
            showTable("select Record_ID , Vehicleid , Pkg_type , start_day, end_day, start_km_reading , end_km_reading , base_hire , extra_km_charge , overnight_stay , total from longhire_cal", dataGridView3);
            showTable("select Record_ID , Vehicleid , Pkg_type , start_time, end_time, start_km_reading , end_km_reading , base_hire , extra_km_charge , waiting_charge , Total from dayhire_cal", dataGridView2);

        }

        private void showTable(string qry, DataGridView dgv)
        {
            // set show table record
            SqlDataAdapter adapt = new SqlDataAdapter(qry, con);

            DataSet ds = new DataSet();

            // fill dataset
            adapt.Fill(ds);

            // create object variable
            object dv = ds.Tables[0];

            // pass to form
            dgv.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool Rent = chkRent.Checked;
            bool Day = chkDHire.Checked;
            bool Long = chkLHire.Checked;

            DateTime Start = dtpStart.Value;
            DateTime End = dtpEnd.Value;

            if (Rent && Day && Long)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM (SELECT SUM(Total) AS Total FROM dayhire_cal WHERE start_time >= '" + Start + "' AND end_time <= '" + End + "' UNION ALL SELECT SUM(Total) AS Total FROM longhire_cal WHERE Start_day >= '" + Start + "' AND End_day <= '" + End + "' UNION ALL SELECT SUM(Total_rent) AS Total FROM rent_Cal WHERE Rent_day >= '" + Start + "' AND Return_day <= '" + End + "') AS subquery;", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        //MessageBox.Show("Hi!");
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                            //MessageBox.Show(Start.ToString() + " - " + End.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Record_ID , start_time , end_time , Total from dayhire_cal Union All select Record_ID , start_day , end_day , Total from longhire_cal Union All select Record_ID , Rent_day , Return_day , Total_rent from rent_Cal", dgvSales);
            }
            else if (Rent && Day)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM ( SELECT SUM(Total) AS Total FROM dayhire_cal WHERE start_time >= '" + Start + "' AND end_time <= '" + End + "'  UNION ALL  SELECT SUM(Total_rent) AS Total FROM rent_Cal WHERE Rent_day >= '" + Start + "' AND Return_day <= '" + End + "' ) AS subquery", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Record_ID , start_time , end_time , Total from dayhire_cal Union All select Record_ID , Rent_day , Return_day , Total_rent from rent_Cal", dgvSales);
            }
            else if (Rent && Long)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM ( SELECT SUM(Total) AS Total FROM longhire_cal WHERE Start_day >= '" + Start + "' AND End_day <= '" + End + "'  UNION ALL  SELECT SUM(Total_rent) AS Total FROM rent_Cal WHERE Rent_day >= '" + Start + "' AND Return_day <= '" + End + "' ) AS subquery", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Record_ID , start_time , end_time , Total from dayhire_cal Union All select Record_ID , Rent_day , Return_day , Total_rent from rent_Cal", dgvSales);
            }
            else if (Rent)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total_rent) AS Total_Sum FROM rent_Cal WHERE Rent_day >= '" + Start + "' AND Return_day <= '" + End + "'", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Record_ID , Rent_day , Return_day , Total_rent from rent_Cal", dgvSales);
            }
            else if (Day && Long)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM ( SELECT SUM(Total) AS Total FROM dayhire_cal WHERE start_time >= '" + Start + "' AND end_time <= '" + End + "'  UNION ALL  SELECT SUM(Total) AS Total FROM longhire_cal WHERE Start_day >= '" + Start + "' AND End_day <= '" + End + "'  ) AS subquery", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Record_ID , start_time , end_time , Total from dayhire_cal Union All select Record_ID , start_day , end_day , Total from longhire_cal", dgvSales);
            }
            else if (Day)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM dayhire_cal WHERE start_time >= '" + Start + "' AND end_time <= '" + End + "' ", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Record_ID , start_time , end_time , Total from dayhire_cal", dgvSales);
            }
            else if (Long)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SUM(Total) AS Total_Sum FROM longhire_cal WHERE Start_day >= '" + Start + "' AND End_day <= '" + End + "'", con);

                    SqlDataReader myR = cmd.ExecuteReader();

                    if (myR.HasRows)
                    {
                        while (myR.Read())
                        {
                            txtTotalSales.Text = myR[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No sales in this period!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                showTable("select Record_ID , start_day , end_day , Total from longhire_cal", dgvSales);
            }
            else
            {
                MessageBox.Show("Please select a service!");
            }
        }
    }
}
