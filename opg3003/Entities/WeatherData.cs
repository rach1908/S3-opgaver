using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public struct WeatherData
    {
        private string city;
        private string temperature;

        public WeatherData(string temperature, string city)
        {
            
            this.city = city;
            this.temperature = temperature;
        }

        public string Temperature
        {
            get { return temperature; }
        }

        public string City
        {
            get { return city; }
        }

    }
}
