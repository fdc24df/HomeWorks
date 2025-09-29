namespace homework7COMM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region n1
            //Console.WriteLine("Enter radius: ");
            //double r = Convert.ToDouble(Console.ReadLine());
            //double bigSquare = Math.Pow(2 * r, 2);
            //double smallSquare = Math.Pow((2 * r) / Math.Sqrt(2), 2);
            //double difference = bigSquare - smallSquare;
            //Console.WriteLine("Difference: " + difference);
            #endregion

            #region n2
            //string[][] jackpots =
            //{
            //    new string[] { "@", "@", "@", "@", "@", "@" },
            //    new string[] { "X", "X", "X" },
            //    new string[] { "S", "S", "S" }
            //};
            //Console.WriteLine("Enter your jackpot code:");
            //string inputLine = Console.ReadLine();
            //string[] input = inputLine.Split(' ');
            //Console.WriteLine(CheckJackpot(input, jackpots));
            //}
            //static string CheckJackpot(string[] input, string[][] jackpots)
            //{
            //    foreach (var jackpot in jackpots)
            //    {
            //        if (input.SequenceEqual(jackpot))
            //            return "Yes";
            //    }
            //    return "No";
            #endregion

            #region n3
            //const int wpoints = 3;
            //const int dpoints = 1;
            //const int lpoints = 0;
            //Console.WriteLine("Enter number of wins: ");
            //int wins = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number of draws: ");
            //int draws = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number of losses: ");
            //int losses = Convert.ToInt32(Console.ReadLine());
            //int totalPoints = (wins * wpoints) + (draws * dpoints) + (losses * lpoints);
            //Console.WriteLine("Total points: " + totalPoints);
            #endregion

            #region n4
            //int[] workHours = new int[7];
            //Console.WriteLine("Enter hours worked for 7 days (separated by commas):");
            //string[] inputs = Console.ReadLine().Split(',');
            //for (int i = 0; i < 7; i++)
            //{
            //    workHours[i] = int.Parse(inputs[i].Trim());
            //}
            //int totalPay = 0;
            //int regularRate = 10;
            //int overtimeRate = 5;
            //for (int i = 0; i < 7; i++)
            //{
            //    int dayHours = workHours[i];
            //    int regularHours = Math.Min(dayHours, 8);
            //    int overtimeHours = Math.Max(dayHours - 8, 0);
            //    int pay = regularHours * regularRate + overtimeHours * (regularRate + overtimeRate);
            //    if (i >= 5)
            //        pay *= 2;
            //    totalPay += pay;
            //}
            //Console.WriteLine("Total pay: " + totalPay);
            #endregion

            #region n5
            //Console.WriteLine("Enter daily results (comma separated):");
            //string[] inputs = Console.ReadLine().Split(',');
            //int[] results = Array.ConvertAll(inputs, s => int.Parse(s.Trim()));
            //int improvedDays = 0;
            //for (int i = 1; i < results.Length; i++)
            //{
            //    if (results[i] > results[i - 1])
            //        improvedDays++;
            //}
            //Console.WriteLine(improvedDays);
            #endregion

            #region n6
            //string[] words = { "Hello", "World", "Programming", "communication" };
            //Console.Write("Enter N: ");
            //int N = int.Parse(Console.ReadLine());
            //var result = words.Where(word => word.Length == N);
            //if (result.Any())
            //{
            //    Console.WriteLine(string.Join(", ", result));
            //}
            //else
            //{
            //    Console.WriteLine("No elements found");
            //}
            #endregion

        }
    }
}