﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather_API.Models;
using WeatherAPI.Services;

namespace Weather_API
{
    public partial class Form1 : Form
    {
        List<Weather> weather;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            this.GetWeather(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //TextBox Settings
            this.txtZip.MaxLength = 5;
            this.txtZip.Text = "78758";
            this.txtCity.Text = "";
            this.txtClouds.Text = "";
            this.txtFeels.Text = "";
            this.txtHigh.Text = "";
            this.txtLatitude.Text = "";
            this.txtLongitude.Text = "";
            this.txtLow.Text = "";
            this.txtTemp.Text = "";
            this.txtWind.Text = "";

            //Disable Text Boxes
            this.txtCity.Enabled = false;
            this.txtClouds.Enabled = false;
            this.txtFeels.Enabled = false;
            this.txtHigh.Enabled = false;
            this.txtLatitude.Enabled = false;
            this.txtLongitude.Enabled = false;
            this.txtLow.Enabled = false;
            this.txtTemp.Enabled = false;
            this.txtWind.Enabled = false;
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            this.GetWeather(false);
        }

        private void GetWeather(bool v)
        {
            string sZip = this.txtZip.Text.Trim();

            int iZip = Validation(sZip);

            if (iZip == 0)
                return;

            try
            {
                weather = WeatherService.GetWeather(iZip, isXML);

                this.PopulateWeatherData(weather);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.SetControls();
            }
        }

        private int Validation(string sZip)
        {
            int iZip = 0;

            bool result = int.TryParse(sZip, out iZip);

            if (!result)
            {
                MessageBox.Show("A numeric value must be entered for zip code!");
                return iZip;
            }
            else if (sZip.Length != 5)
            {
                MessageBox.Show("Zip code must be 5 numbers!");
                iZip = 0;
                return iZip;
            }

            return iZip;
        }

        private void PopulateWeatherData(List<Weather> weather)
        {
            this.txtCity.Text = weather[0].City;
            this.txtClouds.Text = weather[0].Clouds;
            this.txtFeels.Text = weather[0].FeelsLike;
            this.txtHigh.Text = weather[0].High;
            this.txtLatitude.Text = weather[0].Latitude;
            this.txtLongitude.Text = weather[0].Longitude;
            this.txtLow.Text = weather[0].Low;
            this.txtTemp.Text = weather[0].Temperature;
            this.txtWind.Text = weather[0].Wind;
        }

    }
}
