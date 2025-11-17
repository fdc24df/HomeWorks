using System.Text;

namespace Week14
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();

            Console.WriteLine("════════════════════════════════════════════════");
            Console.WriteLine("     WELCOME TO LUXURY FURNITURE SHOP      ");
            Console.WriteLine("     Powered by Abstract Factory Pattern     ");
            Console.WriteLine("════════════════════════════════════════════════\n");

            while (true)
            {
                Console.WriteLine("Please choose your desired furniture style:");
                Console.WriteLine("   1. Art Deco   (Glamour & Geometry)");
                Console.WriteLine("   2. Victorian  (Royal & Classic)");
                Console.WriteLine("   3. Modern     (Minimalist & Clean)");
                Console.WriteLine("   4. Exit");
                Console.Write("\nYour choice (1-4): ");

                string input = Console.ReadLine()?.Trim() ?? "";

                IFurnitureFactory? factory = input switch
                {
                    "1" => new ArtDecoFactory(),
                    "2" => new VictorianFactory(),
                    "3" => new ModernFactory(),
                    "4" => null,
                    _ => null
                };

                if (factory == null || input == "4")
                {
                    Console.WriteLine("\nThank you for visiting! Goodbye!");
                    break;
                }

                Console.Clear();
                Console.WriteLine("Processing your order...\n");

                var order = new CustomerOrder(factory);
                order.DeliverAndShow();

                Console.WriteLine("\nPress any key for a new order...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    
    public class CustomerOrder
    {
        private readonly IChair _chair;
        private readonly ISofa _sofa;
        private readonly ICoffeeTable _table;
        private readonly string _style;

        public CustomerOrder(IFurnitureFactory factory)
        {
            _chair = factory.CreateChair();
            _sofa = factory.CreateSofa();
            _table = factory.CreateCoffeeTable();
            _style = _chair.Style; 
        }

        public void DeliverAndShow()
        {
            Console.WriteLine("ORDER DELIVERED!");
            Console.WriteLine($"Your {_style} furniture set is ready:\n");

            Console.WriteLine("Your items:");
            _chair.SitOn();
            _sofa.LieOn();
            _table.PlaceCoffee();

            Console.WriteLine($"\nAll items are perfectly matched in {_style} style");
            Console.WriteLine("Thanks to Abstract Factory – no style mismatch possible!");
        }
    }
}
