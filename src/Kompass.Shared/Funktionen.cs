using System;
using System.Globalization;

namespace Kompass
{
    internal sealed class Funktionen
    {
        private static readonly string DecimalSeparatoCulture = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator; 

        public static string String_DecimalSeparato_Culture(string a)
        {
            a = a.Replace(".", Funktionen.DecimalSeparatoCulture);
            return a;
        }

        public static string Time2Go(Position S1, Position S2, Position Ship, double COG, double SOG)
        {
            var num = S1.lon_in_min() - Ship.lon_in_min();
            num *= Math.Cos(3.1415926535897931 * Ship.lat_in_min() / 180.0);
            var num2 = S1.lat_in_min() - Ship.lat_in_min();
            var num3 = (S2.lon_in_min() - Ship.lon_in_min()) * Math.Cos(3.1415926535897931 * Ship.lat_in_min() / 180.0) - num;
            var num4 = S2.lat_in_min() - Ship.lat_in_min() - num2;
            var num5 = Math.Sin(3.1415926535897931 * COG / 180.0);
            var num6 = Math.Cos(3.1415926535897931 * COG / 180.0);
            var num7 = (num3 * num2 - num * num4) / (num3 * num6 - num5 * num4);
            var x = num5 * num7;
            var x2 = num6 * num7;
            var num8 = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(x2, 2.0)) / SOG;
            var num9 = checked((int)Math.Round(Fix(num8)));
            num8 = (num8 - (double)num9) * 60.0;
            var num10 = checked((int)Math.Round(Fix(num8)));
            num8 = (num8 - (double)num10) * 60.0;
            var num11 = checked((int)Math.Round(Fix(num8)));
            return string.Concat($"{num9:00}", ":", $"{num10:00}", ":", $"{num11:00}");
        }

        private static double Fix(double Number)
        {
            if (Number >= 0.0)
            {
                return Math.Floor(Number);
            }
            return -Math.Floor(-Number);
        }

    }
}
