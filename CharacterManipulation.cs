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

		public static void ChangeFirstLast(string word)
		{
			string partialWord = word.Remove(0, 1).Remove((word.Length - 2), 1);
			string newWord = word[word.Length - 1] + partialWord + word[0];
			Console.WriteLine(newWord);
		}

		public static void ChangeFirstLast2(string word)
		{
			string newWord = word.Length > 1 ? word.Substring(word.Length - 1 ) + word.Substring(1, word.Length - 2 ) + word.Substring(0,1) : word;
			Console.WriteLine(newWord);
        }
	}
}

