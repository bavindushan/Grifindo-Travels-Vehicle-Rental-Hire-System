
namespace Griffindo
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.rentCalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.griffindorDataSet1 = new Griffindo.griffindorDataSet1();
            this.dayhirecalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.griffindorDataSet2 = new Griffindo.griffindorDataSet2();
            this.longhirecalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.griffindorDataSet3 = new Griffindo.griffindorDataSet3();
            this.rent_CalTableAdapter = new Griffindo.griffindorDataSet1TableAdapters.rent_CalTableAdapter();
            this.dayhire_calTableAdapter = new Griffindo.griffindorDataSet2TableAdapters.dayhire_calTableAdapter();
            this.longhire_calTableAdapter = new Griffindo.griffindorDataSet3TableAdapters.longhire_calTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRent = new System.Windows.Forms.CheckBox();
            this.chkDHire = new System.Windows.Forms.CheckBox();
            this.chkLHire = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griffindorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayhirecalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griffindorDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longhirecalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griffindorDataSet3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1186, 640);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1178, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Car_renting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 589);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1178, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Day Hire";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1172, 589);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(1178, 595);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Long Hire ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1172, 589);
            this.dataGridView3.TabIndex = 0;
            // 
            // rentCalBindingSource
            // 
            this.rentCalBindingSource.DataMember = "rent_Cal";
            this.rentCalBindingSource.DataSource = this.griffindorDataSet1;
            // 
            // griffindorDataSet1
            // 
            this.griffindorDataSet1.DataSetName = "griffindorDataSet1";
            this.griffindorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dayhirecalBindingSource
            // 
            this.dayhirecalBindingSource.DataMember = "dayhire_cal";
            this.dayhirecalBindingSource.DataSource = this.griffindorDataSet2;
            // 
            // griffindorDataSet2
            // 
            this.griffindorDataSet2.DataSetName = "griffindorDataSet2";
            this.griffindorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // longhirecalBindingSource
            // 
            this.longhirecalBindingSource.DataMember = "longhire_cal";
            this.longhirecalBindingSource.DataSource = this.griffindorDataSet3;
            // 
            // griffindorDataSet3
            // 
            this.griffindorDataSet3.DataSetName = "griffindorDataSet3";
            this.griffindorDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rent_CalTableAdapter
            // 
            this.rent_CalTableAdapter.ClearBeforeFill = true;
            // 
            // dayhire_calTableAdapter
            // 
            this.dayhire_calTableAdapter.ClearBeforeFill = true;
            // 
            // longhire_calTableAdapter
            // 
            this.longhire_calTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1186, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.splitter1);
            this.tabPage4.Controls.Add(this.dgvSales);
            this.tabPage4.Location = new System.Drawing.Point(4, 41);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1178, 595);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Total Sales";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSales.Location = new System.Drawing.Point(0, 326);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 62;
            this.dgvSales.RowTemplate.Height = 28;
            this.dgvSales.Size = new System.Drawing.Size(1178, 269);
            this.dgvSales.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 318);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1178, 8);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalSales);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.chkLHire);
            this.groupBox1.Controls.Add(this.chkDHire);
            this.groupBox1.Controls.Add(this.chkRent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 318);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Services";
            // 
            // chkRent
            // 
            this.chkRent.AutoSize = true;
            this.chkRent.Checked = true;
            this.chkRent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRent.Location = new System.Drawing.Point(229, 101);
            this.chkRent.Name = "chkRent";
            this.chkRent.Size = new System.Drawing.Size(89, 31);
            this.chkRent.TabIndex = 2;
            this.chkRent.Text = "Rent";
            this.chkRent.UseVisualStyleBackColor = true;
            // 
            // chkDHire
            // 
            this.chkDHire.AutoSize = true;
            this.chkDHire.Checked = true;
            this.chkDHire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDHire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDHire.Location = new System.Drawing.Point(371, 101);
            this.chkDHire.Name = "chkDHire";
            this.chkDHire.Size = new System.Drawing.Size(130, 31);
            this.chkDHire.TabIndex = 3;
            this.chkDHire.Text = "Day Hire";
            this.chkDHire.UseVisualStyleBackColor = true;
            // 
            // chkLHire
            // 
            this.chkLHire.AutoSize = true;
            this.chkLHire.Checked = true;
            this.chkLHire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLHire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLHire.Location = new System.Drawing.Point(560, 102);
            this.chkLHire.Name = "chkLHire";
            this.chkLHire.Size = new System.Drawing.Size(142, 31);
            this.chkLHire.TabIndex = 4;
            this.chkLHire.Text = "Long Hire";
            this.chkLHire.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.dtpStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(229, 173);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(473, 35);
            this.dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.CustomFormat = "yyyy/MM/dd - hh:mm:ss";
            this.dtpEnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(229, 245);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(473, 35);
            this.dtpEnd.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(793, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 115);
            this.button2.TabIndex = 7;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(793, 202);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(213, 39);
            this.txtTotalSales.TabIndex = 8;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 712);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Viewer";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentCalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griffindorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayhirecalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griffindorDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longhirecalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griffindorDataSet3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private griffindorDataSet1 griffindorDataSet1;
        private System.Windows.Forms.BindingSource rentCalBindingSource;
        private griffindorDataSet1TableAdapters.rent_CalTableAdapter rent_CalTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private griffindorDataSet2 griffindorDataSet2;
        private System.Windows.Forms.BindingSource dayhirecalBindingSource;
        private griffindorDataSet2TableAdapters.dayhire_calTableAdapter dayhire_calTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private griffindorDataSet3 griffindorDataSet3;
        private System.Windows.Forms.BindingSource longhirecalBindingSource;
        private griffindorDataSet3TableAdapters.longhire_calTableAdapter longhire_calTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox chkLHire;
        private System.Windows.Forms.CheckBox chkDHire;
        private System.Windows.Forms.CheckBox chkRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTotalSales;
    }
}