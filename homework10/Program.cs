namespace homework10
{
    
        using System;

    namespace FinanceExample
    {
            
            public abstract class FileWorker
            {
                public double MaxFileSize { get; set; } 
                public abstract string FileExtension { get; } 

                public virtual void Read()
                {
                    Console.WriteLine($"Reading a {FileExtension} file (max size: {MaxFileSize} MB)");
                }

                public virtual void Write()
                {
                    Console.WriteLine($"Writing to a {FileExtension} file");
                }

                public virtual void Edit()
                {
                    Console.WriteLine($"Editing {FileExtension} file...");
                }

                public virtual void Delete()
                {
                    Console.WriteLine($"Deleting {FileExtension} file...");
                }
            }

            
            public class TextFileWorker : FileWorker
            {
                public override string FileExtension => ".txt";

                public override void Read()
                {
                    Console.WriteLine($"[TXT Reader] File size limit: {MaxFileSize} MB");
                }

                public override void Write()
                {
                    Console.WriteLine($"[TXT Writer] Writing text data...");
                }

                public override void Edit()
                {
                    Console.WriteLine($"[TXT Editor] Opening text editor...");
                }

                public override void Delete()
                {
                    Console.WriteLine($"[TXT Remover] Deleting .txt file");
                }
            }

            
            public interface FinanceOperations
            {
                double CalculateLoanPercent(int month, double AmountPerMonth);
                bool CheckUserHistory();
            }

            
            public class Bank : FinanceOperations
            {
                private static Random rand = new Random();

                public bool CheckUserHistory()
                {
                    bool approved = rand.Next(0, 2) == 1; 
                    Console.WriteLine($"Bank user history check: {(approved ? "Approved" : "Rejected")}");
                    return approved;
                }

                public double CalculateLoanPercent(int month, double AmountPerMonth)
                {
                    double total = month * AmountPerMonth;
                    double interest = total * 0.05; 
                    double totalToPay = total + interest;
                    Console.WriteLine($"Bank loan total: {totalToPay}$ (including 5% interest)");
                    return totalToPay;
                }
            }

            
            public class MicroFinance : FinanceOperations
            {
                public bool CheckUserHistory()
                {
                    Console.WriteLine("MicroFinance history check: Always Approved ");
                    return true;
                }

                public double CalculateLoanPercent(int month, double AmountPerMonth)
                {
                    double total = month * AmountPerMonth;
                    double commission = total * 0.10; 
                    double serviceFee = month * 4; 
                    double totalToPay = total + commission + serviceFee;
                    Console.WriteLine($"MicroFinance loan total: {totalToPay}$ (10% + {month * 4}$ service fees)");
                    return totalToPay;
                }
            }

          
            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine(" FileWorker Example ");
                    TextFileWorker worker = new TextFileWorker { MaxFileSize = 50 };
                    worker.Read();
                    worker.Write();
                    worker.Edit();
                    worker.Delete();

                    Console.WriteLine("\n FinanceOperations Example ");

                    FinanceOperations bank = new Bank();
                    if (bank.CheckUserHistory())
                    {
                        bank.CalculateLoanPercent(12, 200);
                    }

                    Console.WriteLine();

                    FinanceOperations micro = new MicroFinance();
                    if (micro.CheckUserHistory())
                    {
                        micro.CalculateLoanPercent(12, 200);
                    }
                }
            }
    }

}


