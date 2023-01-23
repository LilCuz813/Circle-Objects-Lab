using System;
namespace Circle_Objects_Lab
{
	public class Circle
	{
		//properties
		public double Radius { get; set; }

		private string FormatNumber { get; set; }

		//constructor
		public Circle(double _radius)
		{
			Radius = _radius;
		}

		//methods
		public double CalculatedCircumference()
		{
			double circleCircumference = 2 * Radius * Math.PI;
			return circleCircumference;
        }
	
		public string CalculatedFormattedCircumference()
		{
			return $"Circumference: {GetFormatNumber(CalculatedCircumference())}";
		}

		public double CalculatedArea()
		{
			double circleArea = Math.PI * Radius * Radius;
			return circleArea;
		}

		public string CalculatedFormattedArea()
		{
			return $"Area: {GetFormatNumber(CalculatedArea())}";
		}

		public string GetFormatNumber(double x)
		{
			return Math.Round(x, 2).ToString();
		}
	
	}
}

