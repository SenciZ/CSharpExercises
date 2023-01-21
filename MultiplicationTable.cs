using System;
namespace CSharpExercises
{
	public class MultiplicationTable
	{
		public static void MultiplicationTablePrint()
		{
			bool userEnteredNumber = false;
			int numberToMultiply = -1;
			while (userEnteredNumber == false)
            {
				Console.WriteLine("Which number would you like a multiplicaiton table for?");
				numberToMultiply = Convert.ToInt32(Console.ReadLine());
				if (numberToMultiply >= 0)
                {
					userEnteredNumber = true;
                }
			}

			Console.WriteLine("You entered " + numberToMultiply);
			for(int i = 0; i <= 10; i++)
            {
				Console.WriteLine(numberToMultiply * i);
            };

		}
	}
}

