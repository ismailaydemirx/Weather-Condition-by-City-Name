using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;


namespace Weather_Condition_By_City_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        string apiKey = "88c37e82cae8c5864ad2934fe741bc07";

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", tbCity.Text, apiKey);
                var json = web.DownloadString(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/02n.png";
                labCondition.Text = info.weather[0].main;
                labDetails.Text = info.weather[0].description;
                labSunset.Text = info.sys.sunset.ToString();
                labSunrise.Text = info.sys.sunrise.ToString();

                labWinSpeed.Text = info.wind.speed.ToString();
                labPressure.Text = info.main.pressure.ToString();
                
            }
        }
    }
}
