using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author : Aluwani Mahlatse Rambau
 * Student Number : 19010010
 * Programming 2A Assessment
 * Contact no : 0676225015
 * Email : 19010010@rcconnect.co.za
 * 
**/

namespace WeatherStore
{
    class Forecast
    {
        //Declaration Varibles
        string City , Date;
        int Maxi , Mini , Precip , humidity, windSpeed;

        public Forecast(string c, string d, int e, int f, int p, int h, int w)
        {
            this.City = c;
            this.Date = d;
            this.Maxi = e;
            this.Mini = f;
            this.Precip = p;
            this.humidity = h;
            this.windSpeed = w;

        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5},{6}", this.City, this.Date, this.Maxi, this.Mini, this.Precip, this.humidity, this.windSpeed);
        }


    }
}
