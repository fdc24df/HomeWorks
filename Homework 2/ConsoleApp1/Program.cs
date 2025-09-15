using System;

class Program
{
    static void Main()
    {

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();


        Console.WriteLine("author: Saba Glonti");


        Console.Write("Enter some text: ");
        string input = Console.ReadLine();

        Console.WriteLine("your text: " + input);
        Console.Beep();
    }
}
