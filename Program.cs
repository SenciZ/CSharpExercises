using System;
using CSharpExercises;
using static CSharpExercises.HelloWorldClass;
using static CSharpExercises.SwapNumbers;

public class Program
{
    public static void Main()
    {
        //Class that returns a string of "Hello World" and we print it from our Main
        Console.WriteLine(HelloWorld());

        //Class that prints it's own string of "Hello World"
        HelloWorldPrint();

        SwapNumbers.SwapNumbersClass();
    }
}