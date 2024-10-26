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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=bavindu_griffindo;Integrated Security=True");
        int bcost,total;

        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cmbPackType.SelectedItem.ToString() == "Airport_drop")
            {
                //Airport drop package (pk1)
                int baseCost = 1200;
                int allowedHH = 10;
                int allowedKM = 60;
                int costPerExKm = 20;
                int costPerExHH = 50;

                //difference of date time pickers
                DateTime stime = dtpStDate.Value;
                DateTime etime = dtpEdDate.Value;

                TimeSpan timeDiffer = etime - stime;

                // Calculate total hours
                double totalHours = timeDiffer.TotalHours;

                // Convert total hours to integer
                int hdifference = (int)totalHours;
                //int hdifference = Int32.Parse(timeDiffer.ToString());

                int extratimecost = 0;

                if (hdifference > allowedHH)
                {
                    extratimecost = (hdifference - allowedHH) * costPerExHH;
                }

                // output extraTIMEcharge
                txtExtraTime.Text = extratimecost.ToString();

                //difference of km range
                int sreading = Int32.Parse(txtStartKM.Text);
                int ereading = Int32.Parse(txtEndKM.Text);

                int kmdifference = ereading - sreading;
                int extrakmcost = (kmdifference - allowedKM) * costPerExKm;

                // output extraKMcharge
                txtExtraKM.Text = extrakmcost.ToString() != "" ? extrakmcost.ToString() : "0";

                // output base charge
                txtBaseCharge.Text = baseCost.ToString();

                // total = base + extraKMcharge + extraTIMEcharge
                total = baseCost + extrakmcost + extratimecost;

                // output total
                txtTotal.Text = total.ToString();
            }
            else if (cmbPackType.SelectedItem.ToString() == "Airport_pickup")
            {
                //Airport pickup package (pk2)
                int baseCost = 1100;
                int allowedHH = 10;
                int allowedKM = 60;
                int costPerExKm = 20;
                int costPerExHH = 50;

                //difference of date time pickers
                DateTime stime = dtpStDate.Value;
                DateTime etime = dtpEdDate.Value;

                TimeSpan timeDiffer = etime - stime;

                // Calculate total hours
                double totalHours = timeDiffer.TotalHours;

                // Convert total hours to integer
                int hdifference = (int)totalHours;
                //int hdifference = Int32.Parse(timeDiffer.ToString());

                int extratimecost = 0;

                if (hdifference > allowedHH)
                {
                    extratimecost = (hdifference - allowedHH) * costPerExHH;
                }

                // output extraTIMEcharge
                txtExtraTime.Text = extratimecost.ToString();

                //difference of km range
                int sreading = Int32.Parse(txtStartKM.Text);
                int ereading = Int32.Parse(txtEndKM.Text);

                int kmdifference = ereading - sreading;
                int extrakmcost = (kmdifference - allowedKM) * costPerExKm;

                // output extraKMcharge
                txtExtraKM.Text = extrakmcost.ToString() != "" ? extrakmcost.ToString() : "0";

                // output base charge
                txtBaseCharge.Text = baseCost.ToString();

                // total = base + extraKMcharge + extraTIMEcharge
                total = baseCost + extrakmcost + extratimecost;

                // output total
                txtTotal.Text = total.ToString();

            }
            else if (cmbPackType.SelectedItem.ToString() == "100KM")
            {
                //100KM package (pk3)
                int baseCost = 1500;
                int allowedHH = 10;
                int allowedKM = 100;
                int costPerExKm = 20;
                int costPerExHH = 50;

                //difference of date time pickers
                DateTime stime = dtpStDate.Value;
                DateTime etime = dtpEdDate.Value;

                TimeSpan timeDiffer = etime - stime;

                // Calculate total hours
                double totalHours = timeDiffer.TotalHours;

                // Convert total hours to integer
                int hdifference = (int)totalHours;
                //int hdifference = Int32.Parse(timeDiffer.ToString());

                int extratimecost = 0;

                if (hdifference > allowedHH)
                {
                    extratimecost = (hdifference - allowedHH) * costPerExHH;
                }

                // output extraTIMEcharge
                txtExtraTime.Text = extratimecost.ToString();

                //difference of km range
                int sreading = Int32.Parse(txtStartKM.Text);
                int ereading = Int32.Parse(txtEndKM.Text);

                int kmdifference = ereading - sreading;
                int extrakmcost = (kmdifference - allowedKM) * costPerExKm;

                // output extraKMcharge
                txtExtraKM.Text = extrakmcost.ToString() != "" ? extrakmcost.ToString() : "0";

                // output base charge
                txtBaseCharge.Text = baseCost.ToString();

                // total = base + extraKMcharge + extraTIMEcharge
                total = baseCost + extrakmcost + extratimecost;

                // output total
                txtTotal.Text = total.ToString();

            }
            else if (cmbPackType.SelectedItem.ToString() == "200KM")
            {
                //200KM package (pk4)
                int baseCost = 3000;
                int allowedHH = 10;
                int allowedKM = 200;
                int costPerExKm = 20;
                int costPerExHH = 50;

                //difference of date time pickers
                DateTime stime = dtpStDate.Value;
                DateTime etime = dtpEdDate.Value;

                TimeSpan timeDiffer = etime - stime;

                // Calculate total hours
                double totalHours = timeDiffer.TotalHours;

                // Convert total hours to integer
                int hdifference = (int)totalHours;
                //int hdifference = Int32.Parse(timeDiffer.ToString());

                int extratimecost = 0;

                if (hdifference > allowedHH)
                {
                    extratimecost = (hdifference - allowedHH) * costPerExHH;
                }

                // output extraTIMEcharge
                txtExtraTime.Text = extratimecost.ToString();

                //difference of km range
                int sreading = Int32.Parse(txtStartKM.Text);
                int ereading = Int32.Parse(txtEndKM.Text);

                int kmdifference = ereading - sreading;
                int extrakmcost = (kmdifference - allowedKM) * costPerExKm;

                // output extraKMcharge
                txtExtraKM.Text = extrakmcost.ToString() != "" ? extrakmcost.ToString() : "0";

                // output base charge
                txtBaseCharge.Text = baseCost.ToString();

                // total = base + extraKMcharge + extraTIMEcharge
                total = baseCost + extrakmcost + extratimecost;

                // output total
                txtTotal.Text = total.ToString();

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                con.Open();

                //Sql string
                string delstr = "DELETE FROM dayhire_Cal WHERE Record_ID = '"+txtRecID.Text+"'";

                //sql command
                SqlCommand delcmd = new SqlCommand(delstr, con);

                //execution
                int insert = delcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Data was deleted successfully ! :) ");

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string vnum = txtVehNo.Text;
                string ptype = cmbPackType.Text;
                DateTime sdate = dtpStDate.Value;
                DateTime edate = dtpEdDate.Value;
                string skmreadingx = txtStartKM.Text;
                string ekmreadingx = txtEndKM.Text;
                string bhirechargex = txtBaseCharge.Text;
                string extrakmchargex = txtExtraKM.Text;
                string onight = txtExtraTime.Text;
                string totalx = txtTotal.Text;

                //Connection
                con.Open();

                //Sql string
                string updstr = "UPDATE dayhire_cal SET Vehicleid = @Vehicleid, Pkg_type  = @Pkg_type, start_time  = @start_day, end_time =  @end_day, start_km_reading = @start_km_reading, end_km_reading  = @end_km_reading, base_hire  = @base_hire,  extra_km_charge = @extra_km_charge, waiting_charge  = @overnight_stay, Total = @total where Record_ID = '" + txtRecID.Text + "';";

                //sql command
                SqlCommand upcmd = new SqlCommand(updstr, con);

                //parametric declaration
                upcmd.Parameters.AddWithValue("@Vehicleid", vnum);
                upcmd.Parameters.AddWithValue("@Pkg_type", ptype);
                upcmd.Parameters.AddWithValue("@start_day", sdate);
                upcmd.Parameters.AddWithValue("@end_day", edate);
                upcmd.Parameters.AddWithValue("@start_km_reading", skmreadingx);
                upcmd.Parameters.AddWithValue("@end_km_reading", ekmreadingx);
                upcmd.Parameters.AddWithValue("@base_hire", bhirechargex);
                upcmd.Parameters.AddWithValue("@extra_km_charge", extrakmchargex);
                upcmd.Parameters.AddWithValue("@overnight_stay", onight);
                upcmd.Parameters.AddWithValue("@total", totalx);

                //execution
                int insert = upcmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Data was updated successfully ! :) ");

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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from dayhire_cal where Record_ID = '" + txtRecID.Text + "';", con);

                SqlDataReader myR = cmd.ExecuteReader();

                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        txtVehNo.Text = myR["Vehicleid"].ToString();
                        cmbPackType.Text = myR["Pkg_type"].ToString();
                        dtpStDate.Value = DateTime.Parse(myR["start_time"].ToString());
                        dtpEdDate.Value = DateTime.Parse(myR["end_time"].ToString());
                        txtStartKM.Text = myR["start_km_reading"].ToString();
                        txtEndKM.Text = myR["end_km_reading"].ToString();
                        txtBaseCharge.Text = myR["base_hire"].ToString();
                        txtExtraKM.Text = myR["extra_km_charge"].ToString();
                        txtExtraTime.Text = myR["waiting_charge"].ToString();
                        txtTotal.Text = myR["Total"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string vnum = txtVehNo.Text;
                string ptype = cmbPackType.Text;
                DateTime stimex = dtpStDate.Value;
                DateTime etimex = dtpEdDate.Value;
                string skmreadingx = txtStartKM.Text;
                string ekmreadingx = txtEndKM.Text;
                string bhirechargex = txtBaseCharge.Text;
                string extrakmchargex = txtExtraKM.Text;
                string watingchartex = txtExtraTime.Text;
                string totalx = txtTotal.Text;
                
                //Connection
                con.Open();

                //Sql string
                string insstr = "INSERT INTO dayhire_cal VALUES(@Vehicleid,@Pkg_type,@start_time,@end_time,@start_km_reading,@end_km_reading,@base_hire,@extra_km_charge,@waiting_charge,@total)";

                //sql command
                SqlCommand inscmd = new SqlCommand(insstr, con);

                //parametric declaration
                inscmd.Parameters.AddWithValue("@Vehicleid", vnum);
                inscmd.Parameters.AddWithValue("@Pkg_type", ptype);
                inscmd.Parameters.AddWithValue("@start_time", stimex);
                inscmd.Parameters.AddWithValue("@end_time", etimex);
                inscmd.Parameters.AddWithValue("@start_km_reading", skmreadingx);
                inscmd.Parameters.AddWithValue("@end_km_reading", ekmreadingx);
                inscmd.Parameters.AddWithValue("@base_hire", bhirechargex);
                inscmd.Parameters.AddWithValue("@extra_km_charge", extrakmchargex);
                inscmd.Parameters.AddWithValue("@waiting_charge", watingchartex);
                inscmd.Parameters.AddWithValue("@total", totalx);

                //execution
                int insert = inscmd.ExecuteNonQuery();
                if (insert > 0)
                {

                    MessageBox.Show("Data was inserted successfully ! :) ");

                }
                else
                {
                    MessageBox.Show("Error : No data was inserted");
                }
                //connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
