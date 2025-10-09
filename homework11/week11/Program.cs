using System.Text.Json;
using System.Xml.Linq;

namespace week11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //string filePath = "data.txt";


            //if (!File.Exists(filePath))
            //{
            //    File.Create(filePath).Close();
            //}

            //Console.Write("How many lines should be in the file?: ");
            //int n = int.Parse(Console.ReadLine());


            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine("-----------");
            //        string line = Console.ReadLine();
            //        writer.WriteLine(line);
            //    }
            //}


            //string[] lines = File.ReadAllLines(filePath);
            //string lastLine = lines[lines.Length - 1];

            //Console.WriteLine("Output : " + lastLine);
            #endregion
            #region Task 2

            //string filePath = "multiplication_table.txt";

            //Console.Write("Enter N: ");
            //int n = int.Parse(Console.ReadLine());

            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    for (int i = 1; i <= 9; i++)
            //    {
            //        for (int j = 1; j <= n; j++)
            //        {
            //            writer.Write($"{j} * {i} = {j * i}");
            //            if (j < n)
            //                writer.Write(" | ");    
            //        }
            //        writer.WriteLine();
            //    }
            //}

            //Console.WriteLine("Multiplication table has been written to the file successfully!");
            //Console.WriteLine($"File created at: {Path.GetFullPath(filePath)}");

            #endregion
            #region Task 3
            //Console.Write("Enter text: ");
            //string text = Console.ReadLine();

            //Console.Write("Enter number of parts (N): ");
            //int n = int.Parse(Console.ReadLine());

            //int partLength = text.Length / n;
            //XDocument xmlDoc = new XDocument(new XElement("root"));

            //for (int i = 0; i < n; i++)
            //{
            //    int start = i * partLength;
            //    string part;


            //    if (i == n - 1)
            //        part = text.Substring(start);
            //    else
            //        part = text.Substring(start, partLength);

            //    XElement node = new XElement(part, $"string {i + 1}");
            //    xmlDoc.Root.Add(node);
            //}

            //string filePath = "output.xml";
            //xmlDoc.Save(filePath);

            //Console.WriteLine($"XML file created successfully at: {Path.GetFullPath(filePath)}");
            #endregion


        }
    
    }

  
}



