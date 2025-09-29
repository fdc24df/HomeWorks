using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    { //N1
        /* Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];


        Console.WriteLine("Enter array elements:");
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(input[i]);


        List<int> even = new List<int>();
        List<int> odd = new List<int>();



        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
                even.Add(arr[i]);
            else
                odd.Add(arr[i]);
        }

        Console.WriteLine("even : " + string.Join(" ", even));
        Console.WriteLine("odd : " + string.Join(" ", odd));
        */
        //N2
        /*  Dictionary<string, string> frequency = new Dictionary<string, string>();
       while (true)
       {
           Console.WriteLine("enter : add | remove | allcontacts | exit");
           string command = Console.ReadLine();
           if (command == "add")
           {
               Console.Write("Enter name: ");
               string name = Console.ReadLine();
               Console.Write("Enter phone number: ");
               string phoneNumber = Console.ReadLine();
               frequency[name] = phoneNumber;
               Console.WriteLine("Contact added/updated.");
           }
           else if (command == "remove")
           {
               Console.Write("Enter name to remove: ");
               string name = Console.ReadLine();
               if (frequency.Remove(name))
                   Console.WriteLine("Contact removed.");
               else
                   Console.WriteLine("Contact not found.");
           }
           else if (command == "allcontacts")
           {
               Console.WriteLine("All contacts:");
               foreach (var contact in frequency)
                   Console.WriteLine($"{contact.Key}: {contact.Value}");
           }
           else if (command == "exit")
           {
               break;
           }
           else
           {
               Console.WriteLine("Invalid command."); */

        //N3
        /* var n = int.Parse(Console.ReadLine());
     int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

         var grouped = arr.GroupBy(x => x);

         foreach (var g in grouped)
         {
             Console.WriteLine($"{g.Key} appears {g.Count()} times sum {g.Sum()}");
         }*/
        //N4
        /* int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
         int n = int.Parse(Console.ReadLine());

         var top = arr.OrderByDescending(x => x).Take(n);
         Console.WriteLine(string.Join(" ", top));*/
        
    }
}











