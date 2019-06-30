using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace IP_Lookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string ipAddress = ipaddr.Text;
            dynamic ipobject = getIPInfo(ipAddress);
            User user = createUser(ipobject);
            displayInfo(user);
        }

        public dynamic getIPInfo(string ipaddress)
        {
            WebClient client = new WebClient();
            string queryString = "http://ip-api.com/json/" + ipaddr.Text;
            string response = client.DownloadString(queryString);
            dynamic ipobject = JsonConvert.DeserializeObject(response);
            return ipobject;
        }

         User createUser(dynamic ipobj)
        {
            string address = "", aS = "",country = "",countryCode="",city="",isp="",org="",region="",
                regionName="",timezone="";
            decimal lat = 0, longitude = 0;
            string zip = "";
            if(ipobj["status"] == "success")
            {
                 address = ipobj["query"];
                 aS = ipobj["aS"];
                 country = ipobj["country"];
                 countryCode = ipobj["countryCode"];
                 city = ipobj["city"];
                 isp = ipobj["isp"];
                 lat = ipobj["lat"];
                 longitude = ipobj["lon"];
                 org = ipobj["org"];
                 region = ipobj["region"];
                 regionName = ipobj["regionName"];
                 timezone = ipobj["timezone"];
                 zip = ipobj["zip"];
                status.Text = "Success";
            }
            else
            {
                status.Text = "Failure : The IP Address you entered might not exist or is private";
            }
            User user = new User(country,countryCode,region,regionName,city,zip,lat,longitude,timezone,isp,org,aS,address);
            return user;
        }

        void displayInfo(User user)
        {
            country.Text = user.getCountry();
            countryCode.Text = user.getCountryCode();
            region.Text = user.getRegion();
            regionName.Text = user.getRegionName();
            city.Text = user.getCity();
            isp.Text = user.getISP();
            lat.Text = Convert.ToString(user.getLat());
            lon.Text = Convert.ToString(user.getLong());
            aS.Text = user.getAS();
            zip.Text = Convert.ToString(user.getZip());
            timezone.Text = user.getTimezone();
        }

       
    }
}
