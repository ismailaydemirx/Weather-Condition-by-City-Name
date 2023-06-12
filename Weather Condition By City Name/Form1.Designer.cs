using System;
using Newtonsoft.Json;

namespace Weather_Condition_By_City_Name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.labWinSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCity
            // 
            this.tbCity.AccessibleName = "tbCity";
            this.tbCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(146, 69);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(110, 24);
            this.tbCity.TabIndex = 1;
            this.tbCity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(275, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AccessibleName = "labCondition";
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.DarkRed;
            this.labCondition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labCondition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(69, 206);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(85, 23);
            this.labCondition.TabIndex = 0;
            this.labCondition.Text = "Condition";
            this.labCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labCondition.Click += new System.EventHandler(this.label2_Click);
            // 
            // labDetails
            // 
            this.labDetails.AccessibleName = "labDetails";
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.DarkRed;
            this.labDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(69, 249);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(62, 23);
            this.labDetails.TabIndex = 0;
            this.labDetails.Text = "Details";
            this.labDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AccessibleName = "labCondition";
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(69, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sunrise:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSunrise
            // 
            this.labSunrise.AccessibleName = "labSunrise";
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.DarkRed;
            this.labSunrise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labSunrise.Location = new System.Drawing.Point(142, 302);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(39, 23);
            this.labSunrise.TabIndex = 0;
            this.labSunrise.Text = "N/A";
            this.labSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSunset
            // 
            this.labSunset.AccessibleName = "labSunset";
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.DarkRed;
            this.labSunset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labSunset.Location = new System.Drawing.Point(142, 347);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(39, 23);
            this.labSunset.TabIndex = 3;
            this.labSunset.Text = "N/A";
            this.labSunset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AccessibleName = "labCondition";
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(69, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sunset:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labPressure
            // 
            this.labPressure.AccessibleName = "labPressure";
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labPressure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labPressure.Location = new System.Drawing.Point(479, 249);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(39, 23);
            this.labPressure.TabIndex = 7;
            this.labPressure.Text = "N/A";
            this.labPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pressure
            // 
            this.Pressure.AccessibleName = "labPressure";
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pressure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pressure.Location = new System.Drawing.Point(366, 249);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(83, 23);
            this.Pressure.TabIndex = 8;
            this.Pressure.Text = "Pressure:";
            this.Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labWinSpeed
            // 
            this.labWinSpeed.AccessibleName = "labWinSpeed";
            this.labWinSpeed.AutoSize = true;
            this.labWinSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWinSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWinSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labWinSpeed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labWinSpeed.Location = new System.Drawing.Point(479, 206);
            this.labWinSpeed.Name = "labWinSpeed";
            this.labWinSpeed.Size = new System.Drawing.Size(39, 23);
            this.labWinSpeed.TabIndex = 5;
            this.labWinSpeed.Text = "N/A";
            this.labWinSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AccessibleName = "labCondition";
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(366, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wind Speed:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIcon
            // 
            this.picIcon.AccessibleName = "picIcon";
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("picIcon.InitialImage")));
            this.picIcon.Location = new System.Drawing.Point(73, 128);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(63, 59);
            this.picIcon.TabIndex = 9;
            this.picIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::Weather_Condition_By_City_Name.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 470);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.labWinSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label labWinSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

