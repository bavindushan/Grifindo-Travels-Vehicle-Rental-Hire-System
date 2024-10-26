
namespace Griffindo
{
    partial class Form3
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
            this.txtRecID = new System.Windows.Forms.TextBox();
            this.txtLic = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.txtDaily = new System.Windows.Forms.TextBox();
            this.txtWeekly = new System.Windows.Forms.TextBox();
            this.txtMonthly = new System.Windows.Forms.TextBox();
            this.txtDCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecID
            // 
            this.txtRecID.Location = new System.Drawing.Point(746, 49);
            this.txtRecID.Name = "txtRecID";
            this.txtRecID.Size = new System.Drawing.Size(338, 26);
            this.txtRecID.TabIndex = 0;
            // 
            // txtLic
            // 
            this.txtLic.Location = new System.Drawing.Point(746, 118);
            this.txtLic.Name = "txtLic";
            this.txtLic.Size = new System.Drawing.Size(338, 26);
            this.txtLic.TabIndex = 1;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Small car",
            "Sedan car",
            "SUV",
            "Jeep (WD)",
            "7-seater van",
            " Commuter van"});
            this.cmbType.Location = new System.Drawing.Point(746, 186);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(338, 28);
            this.cmbType.TabIndex = 2;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(746, 248);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(54, 24);
            this.rbNo.TabIndex = 3;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(903, 249);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(62, 24);
            this.rbYes.TabIndex = 4;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(746, 306);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(338, 26);
            this.dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(746, 374);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(338, 26);
            this.dtpEnd.TabIndex = 6;
            // 
            // txtDaily
            // 
            this.txtDaily.Location = new System.Drawing.Point(194, 55);
            this.txtDaily.Name = "txtDaily";
            this.txtDaily.Size = new System.Drawing.Size(176, 26);
            this.txtDaily.TabIndex = 7;
            this.txtDaily.Text = "0";
            // 
            // txtWeekly
            // 
            this.txtWeekly.Location = new System.Drawing.Point(194, 118);
            this.txtWeekly.Name = "txtWeekly";
            this.txtWeekly.Size = new System.Drawing.Size(176, 26);
            this.txtWeekly.TabIndex = 8;
            this.txtWeekly.Text = "0";
            // 
            // txtMonthly
            // 
            this.txtMonthly.Location = new System.Drawing.Point(194, 182);
            this.txtMonthly.Name = "txtMonthly";
            this.txtMonthly.Size = new System.Drawing.Size(176, 26);
            this.txtMonthly.TabIndex = 9;
            this.txtMonthly.Text = "0";
            // 
            // txtDCost
            // 
            this.txtDCost.Enabled = false;
            this.txtDCost.Location = new System.Drawing.Point(194, 245);
            this.txtDCost.Name = "txtDCost";
            this.txtDCost.Size = new System.Drawing.Size(176, 26);
            this.txtDCost.TabIndex = 10;
            this.txtDCost.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Daily";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Weekly ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Monthly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Driver cost (Daily)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Record ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "License";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Driver";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(566, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rented day";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(566, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Return day";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(582, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 35);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(712, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 35);
            this.button4.TabIndex = 24;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(194, 311);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(176, 26);
            this.txtTot.TabIndex = 25;
            this.txtTot.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Total";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 34);
            this.button5.TabIndex = 27;
            this.button5.Text = "Calculate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(194, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 35);
            this.button6.TabIndex = 28;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 526);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDCost);
            this.Controls.Add(this.txtMonthly);
            this.Controls.Add(this.txtWeekly);
            this.Controls.Add(this.txtDaily);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtLic);
            this.Controls.Add(this.txtRecID);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Calculation";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecID;
        private System.Windows.Forms.TextBox txtLic;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox txtDaily;
        private System.Windows.Forms.TextBox txtWeekly;
        private System.Windows.Forms.TextBox txtMonthly;
        private System.Windows.Forms.TextBox txtDCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}