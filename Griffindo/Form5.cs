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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog=bavindu_griffindo;Integrated Security=True");
        static int total;

        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {// (TotalKM - AllowedKM = ExtraKM | TotalHH - AllowedHH = ExtraHH)
            if (cmbPackType.SelectedItem.ToString() == "Airport_drop")
            { // airport drop is perfect!! Copy this tyle for othrer packages!!!a
                //Airport drop package (pk1)
                int baseCost = 1500;
                int allowedHH = 7;
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
                int sreading = Int32.Parse(txtStartKm.Text);
                int ereading = Int32.Parse(txtEndKm.Text);

                int kmdifference = ereading - sreading;
                int extrakmcost = (kmdifference - allowedKM) * costPerExKm;

                // output extraKMcharge
                txtExtraKm.Text = extrakmcost.ToString() != "" ? extrakmcost.ToString() : "0";

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
                int baseCost = 1500;
                int allowedHH = 7;
                int allowedKM = 100;
                int costPerExKm = 30;
                int costPerExHH = 60;

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
                int sreading = Int32.Parse(txtStartKm.Text);
                int ereading = Int32.Parse(txtEndKm.Text);

                int kmdifference = ereading - sreading;
                int extrakmcost = (kmdifference - allowedKM) * costPerExKm;

                // output extraKMcharge
                txtExtraKm.Text = extrakmcost.ToString() != "" ? extrakmcost.ToString() : "0";

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
                int baseCost = 3000;
                int allowedHH = 7;
                int allowedKM = 100;
                int costPerExKm = 30;
                int costPerExHH = 60;

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
                int sreading = Int32.Parse(txtStartKm.Text);
                int ereading = Int32.Parse(txtEndKm.Text);

                int kmdifference = ereading - sreading;
                int extrakmcost = (kmdifference - allowedKM) * costPerExKm;

                // output extraKMcharge
                txtExtraKm.Text = extrakmcost.ToString() != "" ? extrakmcost.ToString() : "0";

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
                int baseCost = 6000;
                int allowedHH = 7;
                int allowedKM = 200;
                int costPerExKm = 100;
                int costPerExHH = 200;

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
                int sreading = Int32.Parse(txtStartKm.Text);
                int ereading = Int32.Parse(txtEndKm.Text);

                int kmdifference = ereading - sreading;
                int extrakmcost = (kmdifference - allowedKM) * costPerExKm;

                // output extraKMcharge
                txtExtraKm.Text = extrakmcost.ToString() != "" ? extrakmcost.ToString() : "0";

                // output base charge
                txtBaseCharge.Text = baseCost.ToString();

                // total = base + extraKMcharge + extraTIMEcharge
                total = baseCost + extrakmcost + extratimecost;

                // output total
                txtTotal.Text = total.ToString();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string vnum = txtVehNo.Text;
                string ptype = cmbPackType.Text;
                DateTime sdate = dtpStDate.Value;
                DateTime edate = dtpEdDate.Value;
                string skmreadingx = txtStartKm.Text;
                string ekmreadingx = txtEndKm.Text;
                string bhirechargex = txtBaseCharge.Text;
                string extrakmchargex = txtExtraKm.Text;
                string onight = txtExtraTime.Text;
                string totalx = txtTotal.Text;

                //Connection
                con.Open();

                //Sql string
                string insstr = "INSERT INTO longhire_cal VALUES(@Vehicleid,@Pkg_type,@start_day,@end_day,@start_km_reading,@end_km_reading,@base_hire,@extra_km_charge,@overnight_stay,@total)";

                //sql command
                SqlCommand inscmd = new SqlCommand(insstr, con);

                //parametric declaration
                inscmd.Parameters.AddWithValue("@Vehicleid", vnum);
                inscmd.Parameters.AddWithValue("@Pkg_type", ptype);
                inscmd.Parameters.AddWithValue("@start_day", sdate);
                inscmd.Parameters.AddWithValue("@end_day", edate);
                inscmd.Parameters.AddWithValue("@start_km_reading", skmreadingx);
                inscmd.Parameters.AddWithValue("@end_km_reading", ekmreadingx);
                inscmd.Parameters.AddWithValue("@base_hire", bhirechargex);
                inscmd.Parameters.AddWithValue("@extra_km_charge", extrakmchargex);
                inscmd.Parameters.AddWithValue("@overnight_stay", onight);
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
                string delstr = "DELETE FROM longhire_cal WHERE Record_ID = '"+txtRecID.Text+"';";

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
                string skmreadingx = txtStartKm.Text;
                string ekmreadingx = txtEndKm.Text;
                string bhirechargex = txtBaseCharge.Text;
                string extrakmchargex = txtExtraKm.Text;
                string onight = txtExtraTime.Text;
                string totalx = txtTotal.Text;

                //Connection
                con.Open();

                //Sql string
                string updstr = "UPDATE longhire_cal SET Vehicleid = @Vehicleid, Pkg_type  = @Pkg_type, start_day  = @start_day, end_day =  @end_day, start_km_reading = @start_km_reading, end_km_reading  = @end_km_reading, base_hire  = @base_hire,  extra_km_charge = @extra_km_charge, overnight_stay  = @overnight_stay, total = @total where Record_ID = '"+txtRecID.Text+"';";

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
                SqlCommand cmd = new SqlCommand("select * from longhire_cal where Record_ID = '"+txtRecID.Text+"';",con);

                SqlDataReader myR = cmd.ExecuteReader();

                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        txtVehNo.Text = myR["Vehicleid"].ToString();
                        cmbPackType.Text = myR["Pkg_type"].ToString();
                        dtpStDate.Value = DateTime.Parse(myR["start_day"].ToString());
                        dtpEdDate.Value = DateTime.Parse(myR["end_day"].ToString());
                        txtStartKm.Text = myR["start_km_reading"].ToString();
                        txtEndKm.Text = myR["end_km_reading"].ToString();
                        txtBaseCharge.Text = myR["base_hire"].ToString();
                        txtExtraKm.Text = myR["extra_km_charge"].ToString();
                        txtExtraTime.Text = myR["overnight_stay"].ToString();
                        txtTotal.Text = myR["total"].ToString();
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
    }
}
