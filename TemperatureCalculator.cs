using System;
namespace CSharpExercises
{
	public class TemperatureCalculator
	{
		public static void CelsiusToFandK()
		{
			double degreesInC, degreesInK, degreesInF;
			Console.WriteLine("Enter temperature in Celsius to get Fahrenheit and Kelvin");
			degreesInC = Convert.ToDouble(Console.ReadLine());
			degreesInF = degreesInC * 1.8 + 32;
			degreesInK = degreesInC + 273.15;
			Console.WriteLine($"{degreesInC} is equal to {degreesInK} degrees in Kelvin and is equal to {degreesInF} degrees in Fahrenheit.");
		}
	}
}

