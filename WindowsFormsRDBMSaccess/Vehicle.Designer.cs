﻿namespace WindowsFormsRDBMSaccess
{
	partial class Vehicle
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
			this.label4 = new System.Windows.Forms.Label();
			this.DeleteVehbtn = new System.Windows.Forms.Button();
			this.Search_btn = new System.Windows.Forms.Button();
			this.NameSrchtxt = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.CreateVehbtn = new System.Windows.Forms.Button();
			this.CumulativeObstxt = new System.Windows.Forms.TextBox();
			this.HourlyRatetxt = new System.Windows.Forms.TextBox();
			this.DailyRatetxt = new System.Windows.Forms.TextBox();
			this.RegoNotxt = new System.Windows.Forms.TextBox();
			this.CurrentOdotxt = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Colourtxt = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.UpdateVehbtn = new System.Windows.Forms.Button();
			this.Typetxt = new System.Windows.Forms.TextBox();
			this.Modeltxt = new System.Windows.Forms.TextBox();
			this.Maketxt = new System.Windows.Forms.TextBox();
			this.VINtxt = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(72, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 40);
			this.label4.TabIndex = 71;
			this.label4.Text = "VEHICLE";
			// 
			// DeleteVehbtn
			// 
			this.DeleteVehbtn.Location = new System.Drawing.Point(491, 649);
			this.DeleteVehbtn.Name = "DeleteVehbtn";
			this.DeleteVehbtn.Size = new System.Drawing.Size(132, 28);
			this.DeleteVehbtn.TabIndex = 69;
			this.DeleteVehbtn.Text = "Delete Vehicle";
			this.DeleteVehbtn.UseVisualStyleBackColor = true;
			this.DeleteVehbtn.Click += new System.EventHandler(this.DeleteVehbtn_Click);
			// 
			// Search_btn
			// 
			this.Search_btn.Location = new System.Drawing.Point(753, 567);
			this.Search_btn.Name = "Search_btn";
			this.Search_btn.Size = new System.Drawing.Size(75, 33);
			this.Search_btn.TabIndex = 67;
			this.Search_btn.Text = "Search";
			this.Search_btn.UseVisualStyleBackColor = true;
			// 
			// NameSrchtxt
			// 
			this.NameSrchtxt.Location = new System.Drawing.Point(556, 572);
			this.NameSrchtxt.Name = "NameSrchtxt";
			this.NameSrchtxt.Size = new System.Drawing.Size(165, 22);
			this.NameSrchtxt.TabIndex = 66;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(441, 572);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(114, 17);
			this.label12.TabIndex = 65;
			this.label12.Text = "Search on Name";
			// 
			// CreateVehbtn
			// 
			this.CreateVehbtn.Location = new System.Drawing.Point(74, 649);
			this.CreateVehbtn.Name = "CreateVehbtn";
			this.CreateVehbtn.Size = new System.Drawing.Size(157, 28);
			this.CreateVehbtn.TabIndex = 64;
			this.CreateVehbtn.Text = "Add Vehicle";
			this.CreateVehbtn.UseVisualStyleBackColor = true;
			this.CreateVehbtn.Click += new System.EventHandler(this.CreateVehbtn_Click);
			// 
			// CumulativeObstxt
			// 
			this.CumulativeObstxt.Location = new System.Drawing.Point(189, 563);
			this.CumulativeObstxt.Margin = new System.Windows.Forms.Padding(4);
			this.CumulativeObstxt.Name = "CumulativeObstxt";
			this.CumulativeObstxt.Size = new System.Drawing.Size(132, 22);
			this.CumulativeObstxt.TabIndex = 63;
			// 
			// HourlyRatetxt
			// 
			this.HourlyRatetxt.Location = new System.Drawing.Point(189, 506);
			this.HourlyRatetxt.Margin = new System.Windows.Forms.Padding(4);
			this.HourlyRatetxt.Name = "HourlyRatetxt";
			this.HourlyRatetxt.Size = new System.Drawing.Size(132, 22);
			this.HourlyRatetxt.TabIndex = 62;
			// 
			// DailyRatetxt
			// 
			this.DailyRatetxt.Location = new System.Drawing.Point(189, 456);
			this.DailyRatetxt.Margin = new System.Windows.Forms.Padding(4);
			this.DailyRatetxt.Name = "DailyRatetxt";
			this.DailyRatetxt.Size = new System.Drawing.Size(132, 22);
			this.DailyRatetxt.TabIndex = 61;
			// 
			// RegoNotxt
			// 
			this.RegoNotxt.Location = new System.Drawing.Point(189, 407);
			this.RegoNotxt.Margin = new System.Windows.Forms.Padding(4);
			this.RegoNotxt.Name = "RegoNotxt";
			this.RegoNotxt.Size = new System.Drawing.Size(132, 22);
			this.RegoNotxt.TabIndex = 60;
			// 
			// CurrentOdotxt
			// 
			this.CurrentOdotxt.Location = new System.Drawing.Point(189, 359);
			this.CurrentOdotxt.Margin = new System.Windows.Forms.Padding(4);
			this.CurrentOdotxt.Name = "CurrentOdotxt";
			this.CurrentOdotxt.Size = new System.Drawing.Size(132, 22);
			this.CurrentOdotxt.TabIndex = 59;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(77, 563);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(107, 17);
			this.label11.TabIndex = 58;
			this.label11.Text = "Cumulative Obs";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(76, 506);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 17);
			this.label10.TabIndex = 57;
			this.label10.Text = "Hourly Rate";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(76, 460);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 17);
			this.label9.TabIndex = 56;
			this.label9.Text = "Daily Rate";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(76, 409);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 17);
			this.label8.TabIndex = 55;
			this.label8.Text = "Rego No";
			// 
			// Colourtxt
			// 
			this.Colourtxt.Location = new System.Drawing.Point(189, 256);
			this.Colourtxt.Margin = new System.Windows.Forms.Padding(4);
			this.Colourtxt.Name = "Colourtxt";
			this.Colourtxt.Size = new System.Drawing.Size(132, 22);
			this.Colourtxt.TabIndex = 49;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(75, 256);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 17);
			this.label6.TabIndex = 48;
			this.label6.Text = "Colour";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(76, 309);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 17);
			this.label5.TabIndex = 47;
			this.label5.Text = "Type";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 17);
			this.label3.TabIndex = 46;
			this.label3.Text = "Model";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 17);
			this.label2.TabIndex = 45;
			this.label2.Text = "Make";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 17);
			this.label1.TabIndex = 44;
			this.label1.Text = "VIN";
			// 
			// UpdateVehbtn
			// 
			this.UpdateVehbtn.Location = new System.Drawing.Point(285, 649);
			this.UpdateVehbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.UpdateVehbtn.Name = "UpdateVehbtn";
			this.UpdateVehbtn.Size = new System.Drawing.Size(144, 28);
			this.UpdateVehbtn.TabIndex = 43;
			this.UpdateVehbtn.Text = "Update Vehicle";
			this.UpdateVehbtn.UseVisualStyleBackColor = true;
			this.UpdateVehbtn.Click += new System.EventHandler(this.UpdateVehbtn_Click);
			// 
			// Typetxt
			// 
			this.Typetxt.Location = new System.Drawing.Point(189, 310);
			this.Typetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Typetxt.Name = "Typetxt";
			this.Typetxt.Size = new System.Drawing.Size(132, 22);
			this.Typetxt.TabIndex = 42;
			// 
			// Modeltxt
			// 
			this.Modeltxt.Location = new System.Drawing.Point(189, 199);
			this.Modeltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Modeltxt.Name = "Modeltxt";
			this.Modeltxt.Size = new System.Drawing.Size(132, 22);
			this.Modeltxt.TabIndex = 41;
			// 
			// Maketxt
			// 
			this.Maketxt.Location = new System.Drawing.Point(189, 144);
			this.Maketxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Maketxt.Name = "Maketxt";
			this.Maketxt.Size = new System.Drawing.Size(132, 22);
			this.Maketxt.TabIndex = 40;
			// 
			// VINtxt
			// 
			this.VINtxt.Location = new System.Drawing.Point(189, 98);
			this.VINtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.VINtxt.Name = "VINtxt";
			this.VINtxt.Size = new System.Drawing.Size(132, 22);
			this.VINtxt.TabIndex = 39;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(442, 73);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(908, 458);
			this.dataGridView1.TabIndex = 38;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(78, 362);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 17);
			this.label7.TabIndex = 72;
			this.label7.Text = "Current Odo";
			// 
			// Vehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1410, 700);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DeleteVehbtn);
			this.Controls.Add(this.Search_btn);
			this.Controls.Add(this.NameSrchtxt);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.CreateVehbtn);
			this.Controls.Add(this.CumulativeObstxt);
			this.Controls.Add(this.HourlyRatetxt);
			this.Controls.Add(this.DailyRatetxt);
			this.Controls.Add(this.RegoNotxt);
			this.Controls.Add(this.CurrentOdotxt);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Colourtxt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UpdateVehbtn);
			this.Controls.Add(this.Typetxt);
			this.Controls.Add(this.Modeltxt);
			this.Controls.Add(this.Maketxt);
			this.Controls.Add(this.VINtxt);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Vehicle";
			this.Text = "Vehicle";
			this.Load += new System.EventHandler(this.Vehicle_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button DeleteVehbtn;
		private System.Windows.Forms.Button Search_btn;
		private System.Windows.Forms.TextBox NameSrchtxt;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button CreateVehbtn;
		private System.Windows.Forms.TextBox CumulativeObstxt;
		private System.Windows.Forms.TextBox HourlyRatetxt;
		private System.Windows.Forms.TextBox DailyRatetxt;
		private System.Windows.Forms.TextBox RegoNotxt;
		private System.Windows.Forms.TextBox CurrentOdotxt;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Colourtxt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button UpdateVehbtn;
		private System.Windows.Forms.TextBox Typetxt;
		private System.Windows.Forms.TextBox Modeltxt;
		private System.Windows.Forms.TextBox Maketxt;
		private System.Windows.Forms.TextBox VINtxt;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label7;
	}
}