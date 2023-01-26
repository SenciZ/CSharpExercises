using CSharpExercises;

public class Program
{
    public static void Main()
    {
        //Class that returns a string of "Hello World" and we print it from our Main
        //Console.WriteLine(HelloWorldClass.HelloWorld());

        //Class that prints it's own string of "Hello World"
        //HelloWorldClass.HelloWorldPrint();

        //Write a C# Sharp program to swap two numbers.
        //SwapNumbers.SwapNumbersPrint();

        //Write a C# Sharp program that takes a number as input and print its multiplication table
        //MultiplicationTable.MultiplicationTablePrint();

        //Write a C# Sharp program that takes four numbers as input to calculate and print the average
        //AverageCalculation.CalculateAverage();

        //Write a C# program that takes in a number of degrees in Celsius and calculates its equivalent in Fahrenheit and Kelvin
        //TemperatureCalculator.CelsiusToFandK();

        //Write a C# program remove specified a character from a non-empty string using index of a character.
        //CharacterManipulation.RemoveChar("TestData", 3);

        /*Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
        The quick brown fox jumps over the lazy dog.  --->>  TThe quick brown fox jumps over the lazy dog.T */
        CharacterManipulation.AddFirstAndLast("TestData");
    }
}