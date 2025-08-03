using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP04.First_Project
{
    internal class Duration
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

       public Duration(int hours,int minutes,int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public  Duration(int totalseconds)
        {
            Hours = totalseconds / 3600;
            Minutes = (totalseconds % 3600)%60;
            Seconds = totalseconds % 60;
        }

        public void Durationfromseconds(int hours,int minutes,int seconds)
        {
            Hours = hours + minutes / 60 + seconds / 3600;
            Minutes = (minutes + (seconds / 60)) % 60;
            Seconds = seconds % 60;
        }
        public int ToSeconds()
        {
            return (Hours * 3600) +( Minutes * 60) + Seconds;
        }

        public override string ToString()
        {
            return $"Hours : {Hours} :: Minutes : {Minutes} :: Seconds : {Seconds}";
        }

        public static Duration operator +(Duration d1,Duration d2)
        {
            int totalhours = d1.Hours + d2.Hours;
            int totalminutes = d1.Minutes + d2.Minutes;
            int totalseconds = d1.Seconds + d2.Seconds;
            return new Duration(totalhours, totalminutes, totalseconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalhours = d1.Hours - d2.Hours;
            int totalminutes = d1.Minutes - d2.Minutes;
            int totalseconds = d1.Seconds - d2.Seconds;
            return new Duration(totalhours, totalminutes, totalseconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes+1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes-1, d.Seconds);
        }

        public static bool operator > (Duration d1,Duration d2)
        {
            return d1.ToSeconds() > d2.ToSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToSeconds() < d2.ToSeconds();
        }

    }
}
