
namespace Weather_API
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
            this.btnXML = new System.Windows.Forms.Button();
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtFeels = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtClouds = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnXML
            // 
            this.btnXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.ForeColor = System.Drawing.Color.Blue;
            this.btnXML.Location = new System.Drawing.Point(35, 29);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(260, 44);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "Get Weather (XML)";
            this.btnXML.UseVisualStyleBackColor = false;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnJSON
            // 
            this.btnJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSON.ForeColor = System.Drawing.Color.Blue;
            this.btnJSON.Location = new System.Drawing.Point(35, 83);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(260, 44);
            this.btnJSON.TabIndex = 1;
            this.btnJSON.Text = "Get Weather (JSON)";
            this.btnJSON.UseVisualStyleBackColor = false;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(213, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(35, 160);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(260, 20);
            this.txtZip.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(36, 215);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(259, 20);
            this.txtCity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(35, 270);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(129, 20);
            this.txtLatitude.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Longitude";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(100, 326);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(61, 20);
            this.txtLow.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "High";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Temperature";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Clouds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Wind";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Low";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(170, 270);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(125, 20);
            this.txtLongitude.TabIndex = 23;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(35, 326);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(59, 20);
            this.txtTemp.TabIndex = 24;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(167, 326);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(61, 20);
            this.txtHigh.TabIndex = 25;
            // 
            // txtFeels
            // 
            this.txtFeels.Location = new System.Drawing.Point(234, 326);
            this.txtFeels.Name = "txtFeels";
            this.txtFeels.Size = new System.Drawing.Size(61, 20);
            this.txtFeels.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Feels Like";
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(35, 377);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(129, 20);
            this.txtWind.TabIndex = 29;
            // 
            // txtClouds
            // 
            this.txtClouds.Location = new System.Drawing.Point(170, 377);
            this.txtClouds.Name = "txtClouds";
            this.txtClouds.Size = new System.Drawing.Size(125, 20);
            this.txtClouds.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 465);
            this.Controls.Add(this.txtClouds);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFeels);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnJSON);
            this.Controls.Add(this.btnXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtFeels;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtClouds;
    }
}

