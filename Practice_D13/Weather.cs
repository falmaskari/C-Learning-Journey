using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Weather
    {
        public delegate void WeatherChanged(Weather weather );
        public event WeatherChanged onWetherChanged;

        public int temperature;
        public string condition;

        public int Temperture { get => this.temperature; set => this.temperature = value; }

        public string Condition => this.condition;

        
        
        public void changeWeather(int temperature)
        {
            this.temperature = temperature;
            if(onWetherChanged != null)
            {
                onWetherChanged(this);
            }
        } 
    }
}
