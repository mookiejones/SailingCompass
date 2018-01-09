using System;
using System.Windows.Controls;

namespace Kompass
{
  public class Position
	{
		private double lat=0.0;

		private double lon=0.0;

		private bool lat_set=false;

		private bool lon_set=false;

		public Position()
		{
		}

		public bool stop_set()
		{
			lat_set = false;
			lon_set = false;
			var result=false;
			return result;
		}

		public bool is_set()
		{
			return lat_set & lon_set;
		}

		public bool set_from_NMEA(string lat_in, string latd, string lon_in, string lond)
		{
			var result=false;
			try
			{
			    var flag = string.CompareOrdinal(latd, "S") == 0;

				if (flag)
				{
					lat = -1.0 * (Convert.ToDouble(lat_in.Substring(0, 2)) * 60.0 + Convert.ToDouble(lat_in.Substring(2)));
				}
				else
				{
					lat = Convert.ToDouble(lat_in.Substring(0, 2)) * 60.0 + Convert.ToDouble(lat_in.Substring(2));
				}
				flag = string.CompareOrdinal(latd, "S") == 0;
				if (flag)
				{
					lon = -1.0 * (Convert.ToDouble(lon_in.Substring(0, 3)) * 60.0 + Convert.ToDouble(lon_in.Substring(2)));
				}
				else
				{
					lon = Convert.ToDouble(lon_in.Substring(0, 3)) * 60.0 + Convert.ToDouble(lon_in.Substring(3));
				}
				lat_set = true;
				lon_set = true;
				result = true;
			}
			catch (Exception expr_FE)
			{ 
				lat_set = false;
				lon_set = false;
			 
			}
			return result;
		}

		public bool set_from_Textbox(TextBox TextBox_lat, TextBox TextBox_lon)
		{
			var result=false;
			try
			{
				var array = TextBox_lat.Text.Split(new char[]
				{
					' '
				});
				var array2 = TextBox_lon.Text.Split(new char[]
				{
					' '
				});
				lat = Convert.ToDouble(array[0]) * 60.0 + Convert.ToDouble(Funktionen.String_DecimalSeparato_Culture(array[1]));
				lon = Convert.ToDouble(array2[0]) * 60.0 + Convert.ToDouble(Funktionen.String_DecimalSeparato_Culture(array2[1]));
				lat_set = true;
				lon_set = true;
				result = true;
			}
			catch (Exception expr_9A)
			{
			 
				lat_set = false;
				lon_set = false;
			 
			}
			return result;
		}

		public bool set_from_MIN(double lat_in, double lon_in)
		{
			var result=false;
			try
			{
				lat = lat_in;
				lon = lon_in;
				lat_set = true;
				lon_set = true;
				result = true;
			}
			catch (Exception expr_24)
			{
			 
				lat_set = false;
				lon_set = false;
			 
			}
			return result;
		}

		public bool de_set()
		{
			lat_set = false;
			lon_set = false;
			return true;
		}

		public double lat_in_min()
		{
			return lat;
		}

		public double lon_in_min()
		{
			return lon;
		}

		public double lat_in_deg()
		{
			return lat / 60.0;
		}

		public double lon_in_deg()
		{
			return lon / 60.0;
		}

		public double abstand(Position second)
		{
			var flag = is_set() & second.is_set();
			double result;
			if (flag)
			{
				var num = Math.Abs(lat_in_min() - second.lat_in_min());
				var num2 = Math.Abs(lon_in_min() - second.lon_in_min());
				var num3 = Math.Sqrt(Math.Pow(num, 2.0) + Math.Pow(num2 * Math.Cos(num / 180.0), 2.0));
				result = num3;
			}
			else
			{
				result = -1.0;
			}
			return result;
		}
	}
}
