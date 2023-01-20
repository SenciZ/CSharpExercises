using System;
namespace CSharpExercises
{
	public class SwapNumbers
	{
		public static void SwapNumbersPrint()
		{
			Console.WriteLine("Enter your first number;");
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter your second number:");
			int secondNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Would you like to swap numbers? Y / N");
            string? acceptedSwap = Console.ReadLine();

			int temporaryNum;

			if( acceptedSwap == "Y")
            {
				temporaryNum = firstNumber;
				firstNumber = secondNumber;
				secondNumber = temporaryNum;
				Console.WriteLine("Ok your numbers are swapped!");
            } else
            {
				Console.WriteLine("Ok, will not swap numbers.");
            }

			Console.WriteLine("Your first number is " + firstNumber + " and your second number is " + secondNumber);
		}
	}
}

