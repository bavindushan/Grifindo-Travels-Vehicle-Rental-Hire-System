
namespace Griffindo
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dtpEdDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPackType = new System.Windows.Forms.ComboBox();
            this.txtExtraTime = new System.Windows.Forms.TextBox();
            this.txtExtraKm = new System.Windows.Forms.TextBox();
            this.txtEndKm = new System.Windows.Forms.TextBox();
            this.txtStartKm = new System.Windows.Forms.TextBox();
            this.txtBaseCharge = new System.Windows.Forms.TextBox();
            this.txtVehNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpStDate = new System.Windows.Forms.DateTimePicker();
            this.txtRecID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(890, 291);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(168, 26);
            this.txtTotal.TabIndex = 45;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(699, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 35);
            this.button5.TabIndex = 44;
            this.button5.Text = "Total";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtpEdDate
            // 
            this.dtpEdDate.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.dtpEdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEdDate.Location = new System.Drawing.Point(244, 325);
            this.dtpEdDate.Name = "dtpEdDate";
            this.dtpEdDate.Size = new System.Drawing.Size(296, 26);
            this.dtpEdDate.TabIndex = 43;
            // 
            // cmbPackType
            // 
            this.cmbPackType.FormattingEnabled = true;
            this.cmbPackType.Items.AddRange(new object[] {
            "Airport_drop",
            "Airport_pickup",
            "100KM",
            "200KM"});
            this.cmbPackType.Location = new System.Drawing.Point(244, 197);
            this.cmbPackType.Name = "cmbPackType";
            this.cmbPackType.Size = new System.Drawing.Size(296, 28);
            this.cmbPackType.TabIndex = 41;
            // 
            // txtExtraTime
            // 
            this.txtExtraTime.Location = new System.Drawing.Point(890, 198);
            this.txtExtraTime.Name = "txtExtraTime";
            this.txtExtraTime.Size = new System.Drawing.Size(168, 26);
            this.txtExtraTime.TabIndex = 40;
            // 
            // txtExtraKm
            // 
            this.txtExtraKm.Location = new System.Drawing.Point(890, 135);
            this.txtExtraKm.Name = "txtExtraKm";
            this.txtExtraKm.Size = new System.Drawing.Size(168, 26);
            this.txtExtraKm.TabIndex = 39;
            // 
            // txtEndKm
            // 
            this.txtEndKm.Location = new System.Drawing.Point(244, 451);
            this.txtEndKm.Name = "txtEndKm";
            this.txtEndKm.Size = new System.Drawing.Size(296, 26);
            this.txtEndKm.TabIndex = 38;
            // 
            // txtStartKm
            // 
            this.txtStartKm.Location = new System.Drawing.Point(244, 388);
            this.txtStartKm.Name = "txtStartKm";
            this.txtStartKm.Size = new System.Drawing.Size(296, 26);
            this.txtStartKm.TabIndex = 37;
            // 
            // txtBaseCharge
            // 
            this.txtBaseCharge.Location = new System.Drawing.Point(890, 68);
            this.txtBaseCharge.Name = "txtBaseCharge";
            this.txtBaseCharge.Size = new System.Drawing.Size(168, 26);
            this.txtBaseCharge.TabIndex = 36;
            // 
            // txtVehNo
            // 
            this.txtVehNo.Location = new System.Drawing.Point(244, 134);
            this.txtVehNo.Name = "txtVehNo";
            this.txtVehNo.Size = new System.Drawing.Size(296, 26);
            this.txtVehNo.TabIndex = 35;
            this.txtVehNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(694, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Extra km charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "overnight_stay_charge";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(694, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Base hire charge ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "End km reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Start km reading ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Package type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vehicle_No ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(925, 522);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 49;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(709, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 32);
            this.button3.TabIndex = 48;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 32);
            this.button2.TabIndex = 47;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpStDate
            // 
            this.dtpStDate.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.dtpStDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStDate.Location = new System.Drawing.Point(244, 262);
            this.dtpStDate.Name = "dtpStDate";
            this.dtpStDate.Size = new System.Drawing.Size(296, 26);
            this.dtpStDate.TabIndex = 42;
            this.dtpStDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtRecID
            // 
            this.txtRecID.Location = new System.Drawing.Point(244, 71);
            this.txtRecID.Name = "txtRecID";
            this.txtRecID.Size = new System.Drawing.Size(296, 26);
            this.txtRecID.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Record ID";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(61, 519);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 35);
            this.button6.TabIndex = 52;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 583);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtRecID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtpEdDate);
            this.Controls.Add(this.dtpStDate);
            this.Controls.Add(this.cmbPackType);
            this.Controls.Add(this.txtExtraTime);
            this.Controls.Add(this.txtExtraKm);
            this.Controls.Add(this.txtEndKm);
            this.Controls.Add(this.txtStartKm);
            this.Controls.Add(this.txtBaseCharge);
            this.Controls.Add(this.txtVehNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Long Hire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dtpEdDate;
        private System.Windows.Forms.ComboBox cmbPackType;
        private System.Windows.Forms.TextBox txtExtraTime;
        private System.Windows.Forms.TextBox txtExtraKm;
        private System.Windows.Forms.TextBox txtEndKm;
        private System.Windows.Forms.TextBox txtStartKm;
        private System.Windows.Forms.TextBox txtBaseCharge;
        private System.Windows.Forms.TextBox txtVehNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpStDate;
        private System.Windows.Forms.TextBox txtRecID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
    }
}