using SunSetRiseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.v4._5._1
{
    class Program
    {
        static double JD = 0;
        static int zone = -8; // Seattle time Zone
        static double latitude = 47.6; // Seattle lat
        static double longitude = -122.32; // Seattle lon 
        static bool dst = true; // Day Light Savings 
        static DateTime date = DateTime.Today;

        static void Main(string[] args)
        {

            JD = Util.calcJD(date);  //OR   JD = Util.calcJD(2014, 6, 1);
            double sunRise = Util.calcSunRiseUTC(JD, latitude, longitude);
            double sunSet = Util.calcSunSetUTC(JD, latitude, longitude);
            System.Console.WriteLine(Util.getTimeString(sunRise, zone, JD, dst));
            System.Console.WriteLine(Util.getTimeString(sunSet, zone, JD, dst));
            System.Console.WriteLine("");
            System.Console.WriteLine(Util.getDateTime(sunRise, zone, date, dst).Value.ToString());
            System.Console.WriteLine(Util.getDateTime(sunSet, zone, date, dst).Value.ToString());
        }
    }
}
