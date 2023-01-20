using CSharpExercises;

public class Program
{
    public static void Main()
    {
        //Class that returns a string of "Hello World" and we print it from our Main
        Console.WriteLine(HelloWorldClass.HelloWorld());

        //Class that prints it's own string of "Hello World"
        HelloWorldClass.HelloWorldPrint();

        SwapNumbers.SwapNumbersPrint();

        MultiplicationTable.MultiplicationTablePrint();
    }
}