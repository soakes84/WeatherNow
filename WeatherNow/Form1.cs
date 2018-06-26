using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherNow
{
    public partial class Form1 : Form
    {
        const string APPID = "";
        string cityName = "Charleston";
        public Form1()
        {
            InitializeComponent();
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=Charleston&appid=52d21909cb6877a3e865b33b6b984a97");

                var json = web.DownloadString(url);
            }
        }
    }
}
