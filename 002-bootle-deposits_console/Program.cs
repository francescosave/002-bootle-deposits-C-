using System;
using System.Diagnostics;
using System.Threading;
using _002_bootle_deposits;


namespace _002_bootle_deposits_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // declaration
            BootleOneLiter bootleOneLiter = new BootleOneLiter();
            BootleOverLiter bootleOverLiter = new BootleOverLiter();
            Bill bill = new Bill(bootleOneLiter, bootleOverLiter, 500, 700);

            //print bill report
            ReportBill.Print(bootleOneLiter, bootleOverLiter, bill);


            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Elapsed Time is {stopwatch.ElapsedMilliseconds} ms");

            Console.Read();

        }

     
    }
}
