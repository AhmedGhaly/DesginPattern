using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public class Weather
    {
        public double tempture { get; set; }
        public double humaity { get; set; }

        public event EventHandler<Argus> WeatherChanged;

        public Weather(double tempture, double humanity)
        {
            this.tempture = tempture;
            this.humaity = humanity;
        }
        public void addListner(Observers observers)
        {
            WeatherChanged += observers.onUpdate;
        }
        public void removeListner(Observers observers)
        {
            WeatherChanged -= observers.onUpdate;
        }

        public void onChangeWeather(double tempture, double humanity)
        {
            if (WeatherChanged is not null)
            {
                WeatherChanged(this, new Argus() { humaity = humanity, tempture = tempture });
            }
        }

        public override string ToString()
        {
            return "this is the weather program ....";
        }



    }
}
