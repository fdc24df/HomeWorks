using ConsoleApp1;
using System;
using System.Runtime.ExceptionServices;
using System.Transactions;
namespace ConsoleApp1;

    class Company
{    
        public bool IsLocal { get; set; }

            public Company(bool isLocal)

                {
                    IsLocal = isLocal;
                }

            public double CalculateTax(double totalSalary)

                {
                    double taxrate;
                        if (IsLocal)
                        {
                            taxrate = 0.18;
                        }
                        else
                        {
                            taxrate = 0.05;
                        }


                     
                    return totalSalary * taxrate;
                }

}


class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }

    public string Position { get; set; }

    public int[] HoursPerDay { get; set; }

    public Employee(string firstname, string lastname, int age, string position, int[] hoursperday)
    {
        FirstName = firstname;
        LastName = lastname;
        Age = age;
        Position = position;
        HoursPerDay = hoursperday;
    }

    public double CalculateWeeklySalary()
    {
        double totalsalary = 0;
        double hourlyrate = 0;

        for (int i = 0; i < HoursPerDay.Length; i++)
        {
            int hours = HoursPerDay[i];

            switch (Position.ToLower())
            {
                case "Manager":
                    hourlyrate = 40;
                    break;
                case "Developer":
                    hourlyrate = 30;
                    break;
                case "Tester":
                    hourlyrate = 20;
                    break;
                default:
                    hourlyrate = 10;
                    break;
            }
            double daySalary = 0;
            //სამუშაო დღეები
                if (i >= 0 && i <= 4)
            {
                if (hours > 8)
                {
                    int overtime = hours - 8;
                    daySalary = 8 * hourlyrate + overtime * (hourlyrate + 5);
                }
                else
                {
                    daySalary = hours * hourlyrate;
                }
            }
            // შაბათი კვირა
            else
            {
                daySalary = hours * hourlyrate * 2;
            }
            totalsalary += daySalary;
        }
        int totalhours = 0;
        foreach (int h in HoursPerDay) totalhours += h;
        if (totalhours > 50)
        {
            totalsalary += totalsalary * 0.2; // ბონუსი
        }

        return totalsalary;

    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter totalSalary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Is the company local? (yes/no): ");
        string input = Console.ReadLine().ToLower();

        bool isLocal = input == "yes";

        Company company = new Company(isLocal);
        double tax = company.CalculateTax(salary);

        Console.WriteLine($"Will be transferred to the budget: {tax} ");

        Console.Beep();

        Console.WriteLine("Enter FirstName: ");
        string firstname=Console.ReadLine();

        Console.WriteLine("Enter LastName: ");
        string lastname=Console.ReadLine();

        Console.WriteLine("Enter age: ");
        int age =int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Position (Manager, Developer, Tester, Else):");
        string position = Console.ReadLine();

        int[] hoursPerDay = new int[7];
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Enter Work hours {days[i]}: ");
            hoursPerDay[i] = int.Parse(Console.ReadLine());
        }

        Employee emp = new Employee(firstname, lastname, age, position, hoursPerDay);
        double weeklySalary = emp.CalculateWeeklySalary();

        Console.WriteLine($"\n{emp.FirstName} {emp.LastName} weekly salary2: ${weeklySalary}");







    }
}