using System;
namespace CSharpExercises
{
	public class NumberCalculations
	{
		public static void SumOrTriple(int a, int b)
		{
			bool areEqual = a == b;
			if (areEqual)
            {
				Console.WriteLine((a + b) * 3);
				return;
            }
			Console.WriteLine(a + b);
		}

		public static void AbsoluteDifferenceValue(int a, int b)
        {
			bool intAGreater = a > b;
			if (intAGreater)
            {
				Console.WriteLine((a - b) * 2);
				return;
            }
			Console.WriteLine(Math.Abs(a - b));
        }
	}
}

