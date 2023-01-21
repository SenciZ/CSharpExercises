using System;
namespace CSharpExercises
{
	public class AverageCalculation
	{
		public static void CalculateAverage()
		{
			int numberOne, numberTwo, numberThree, numberFour;

			Console.WriteLine("Enter the first number out of four that you wish to average?");
			numberOne = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the second number");
			numberTwo = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the third number");
			numberThree = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the fourth number");
			numberFour = Convert.ToInt32(Console.ReadLine());

			float average = (numberOne + numberTwo + numberThree + numberFour) / 4;
			Console.WriteLine($"The average of the four numbers you entered is {average}");
		}
	}
}

