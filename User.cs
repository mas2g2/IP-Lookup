using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Lookup
{
    class User
    {
        private string country;
        private string countryCode;
        private string region;
        private string regionName;
        private string city;
        private string zip;
        private decimal lat;
        private decimal log;
        private string timezone;
        private string isp;
        private string org;
        private string aS;
        private string address;
        public User(string country,string countryCode,string region,string regionName,
            string city,string zip, decimal lat, decimal longitude, string timezone, string isp,
            string org, string aS, string address)
        {
            this.country = country;
            this.countryCode = countryCode;
            this.region = region;
            this.regionName = regionName;
            this.city = city;
            this.zip = zip;
            this.lat = lat;
            this.log = longitude;
            this.timezone = timezone;
            this.isp = isp;
            this.org = org;
            this.aS = aS;
            this.address = address;
        }

        public string getAddress()
        {
            return this.address;
        }

        public string getAS()
        {
            return this.aS;
        }

        public string getCity()
        {
            return this.city;
        }

        public string getCountry()
        {
            return this.country;
        }

        public string getCountryCode()
        {
            return this.countryCode;
        }

        public string getISP()
        {
            return this.isp;
        }

        public decimal getLat()
        {
            return this.lat;
        }

        public decimal getLong()
        {
            return this.log;
        }

        public string getOrg()
        {
            return this.org;
        }

        public string getRegion()
        {
            return this.region;
        }

        public string getRegionName()
        {
            return this.regionName;
        }

        public string getTimezone()
        {
            return this.timezone;
        }

        public string getZip()
        {
            return this.zip;
        }
    }
}
