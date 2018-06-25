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
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=Charleston&appid=542ffd081e67f4512b705f89d2a611b2");

                var json = web.DownloadString(url);
            }
        }
    }
}
