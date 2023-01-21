using System;
namespace CSharpExercises
{
	public class CharacterManipulation
	{
		public static void RemoveChar(string word, int number)
		{
			string newWord = word.Remove(number, 1);
			Console.WriteLine($"{newWord}");
		}
	}
}

