namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PowerCount()
            {
                Console.Write("Enter a, b, n separated by commas: ");
                string input = Console.ReadLine();
                string[] parts = input.Split(',');

                int a = int.Parse(parts[0].Trim());
                int b = int.Parse(parts[1].Trim());
                int n = int.Parse(parts[2].Trim());

                int count = 0;
                int number = 1;

                while (true)
                {
                    int power = (int)Math.Pow(number, n);

                    if (power > b)
                        break;

                    if (power >= a)
                        count++;

                    number++;
                }

                Console.WriteLine(count);

            }
            PowerCount();
            static void FindSockPairs()
            {
                Console.WriteLine("Enter string symbols:");
                string s = Console.ReadLine();

                int count = 0;
                int i = 0;

                while (i < s.Length - 1)
                {
                    if (s[i] == s[i + 1])
                    {
                        count++; 
                        i += 2;  
                    }
                    else
                    {
                        i++;
                    }
                }

                Console.WriteLine(count);
                
            }
            FindSockPairs();
        }
    }
}
