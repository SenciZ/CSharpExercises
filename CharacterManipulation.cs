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

		/*Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
The quick brown fox jumps over the lazy dog.  --->>  TThe quick brown fox jumps over the lazy dog.T */
		public static void AddFirstAndLast(string word)
        {
			Console.WriteLine($"{word[0]}{word}{word[0]}", word);
        }
	}
}

