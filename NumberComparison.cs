using System;
namespace CSharpExercises
{
	public class NumberComparison
	{
		public static void PosNegNumbers(int num1, int num2)
		{
			if (num1 < 0 && num2 >= 0 || num1 >= 0 && num2 < 0)
            {
			Console.WriteLine("True");
				return;
            }
			Console.WriteLine("False");
		}
	}
}

