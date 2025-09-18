using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { // 1 amocana
             Console.WriteLine("input: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 5 == 0)
                Console.WriteLine("Output: Yes");
            else
                Console.WriteLine("Output: No");
            

            // 2 amocana
            /* Console.WriteLine("Enter X: ");
             int x = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Y: ");
             int y = int.Parse(Console.ReadLine());

             int sum = x + y;
             int diff;
             if (x > y)
                 diff = x - y;
             else
                 diff = y - x;
             int prod = x * y;
             int Max, Min;
             if (x > y)
             {
                 Max = x;
                 Min = y;
             }
                 else
                 {
                     Max = y;
                     Min = x;
                 }

             Console.WriteLine($"X+Y = {sum}");
             Console.WriteLine($"X-Y = {diff}");
             Console.WriteLine($"X*Y = {prod}");

             if (Min == 0)
                 Console.WriteLine("X/Y = Not Allowed To Divide By Zero");
             else
                 Console.WriteLine($"X/Y = {Max / Min}"); */

            // 3 amocana

            /* int x, y, z;
            Console.WriteLine("Enter X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y: ");
            y = int.Parse(Console.ReadLine());
            z = x;
            x = y;
            y = z;


            Console.WriteLine(x);
            Console.WriteLine(y);
            */

            // 4 amocana
            /* int x;
            Console.WriteLine("Enter X: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            { int y = x * i;
               Console.WriteLine($"{x} * {i} = {y}");
            */
            // 5 amocana
            /* int x;
            Console.WriteLine("Enter X: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i*i);
             */     
            }





    }
    }
}
