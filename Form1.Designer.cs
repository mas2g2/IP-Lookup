namespace IP_Lookup
{
    partial class Form1
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
            this.ipaddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.countryCode = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.Label();
            this.regionName = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.isp = new System.Windows.Forms.Label();
            this.lat = new System.Windows.Forms.Label();
            this.lon = new System.Windows.Forms.Label();
            this.aS = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.Label();
            this.timezone = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipaddr
            // 
            this.ipaddr.Location = new System.Drawing.Point(119, 12);
            this.ipaddr.Name = "ipaddr";
            this.ipaddr.Size = new System.Drawing.Size(154, 20);
            this.ipaddr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter IP Address";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(120, 41);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(78, 26);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "AS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Longitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ISP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Region Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Region";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Country Code";
            // 
            // countryCode
            // 
            this.countryCode.AutoSize = true;
            this.countryCode.Location = new System.Drawing.Point(130, 114);
            this.countryCode.Name = "countryCode";
            this.countryCode.Size = new System.Drawing.Size(0, 13);
            this.countryCode.TabIndex = 12;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(130, 90);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(0, 13);
            this.country.TabIndex = 13;
            // 
            // region
            // 
            this.region.AutoSize = true;
            this.region.Location = new System.Drawing.Point(130, 138);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(0, 13);
            this.region.TabIndex = 14;
            // 
            // regionName
            // 
            this.regionName.AutoSize = true;
            this.regionName.Location = new System.Drawing.Point(130, 163);
            this.regionName.Name = "regionName";
            this.regionName.Size = new System.Drawing.Size(0, 13);
            this.regionName.TabIndex = 15;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(130, 187);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(0, 13);
            this.city.TabIndex = 16;
            // 
            // isp
            // 
            this.isp.AutoSize = true;
            this.isp.Location = new System.Drawing.Point(130, 214);
            this.isp.Name = "isp";
            this.isp.Size = new System.Drawing.Size(0, 13);
            this.isp.TabIndex = 17;
            // 
            // lat
            // 
            this.lat.AutoSize = true;
            this.lat.Location = new System.Drawing.Point(130, 244);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(0, 13);
            this.lat.TabIndex = 18;
            // 
            // lon
            // 
            this.lon.AutoSize = true;
            this.lon.Location = new System.Drawing.Point(130, 272);
            this.lon.Name = "lon";
            this.lon.Size = new System.Drawing.Size(0, 13);
            this.lon.TabIndex = 19;
            // 
            // aS
            // 
            this.aS.AutoSize = true;
            this.aS.Location = new System.Drawing.Point(130, 300);
            this.aS.Name = "aS";
            this.aS.Size = new System.Drawing.Size(0, 13);
            this.aS.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Zip";
            // 
            // zip
            // 
            this.zip.AutoSize = true;
            this.zip.Location = new System.Drawing.Point(108, 325);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(0, 13);
            this.zip.TabIndex = 22;
            // 
            // timezone
            // 
            this.timezone.AutoSize = true;
            this.timezone.Location = new System.Drawing.Point(116, 356);
            this.timezone.Name = "timezone";
            this.timezone.Size = new System.Drawing.Size(0, 13);
            this.timezone.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "TimeZone";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(82, 385);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 416);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.timezone);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.aS);
            this.Controls.Add(this.lon);
            this.Controls.Add(this.lat);
            this.Controls.Add(this.isp);
            this.Controls.Add(this.city);
            this.Controls.Add(this.regionName);
            this.Controls.Add(this.region);
            this.Controls.Add(this.country);
            this.Controls.Add(this.countryCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipaddr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipaddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label countryCode;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label region;
        private System.Windows.Forms.Label regionName;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label isp;
        private System.Windows.Forms.Label lat;
        private System.Windows.Forms.Label lon;
        private System.Windows.Forms.Label aS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label zip;
        private System.Windows.Forms.Label timezone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label status;
    }
}

