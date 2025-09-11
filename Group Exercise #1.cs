using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gasStation = "";
            double tax = 0.0, total = 0.0, price = 0.0, gallons = 0.0, subtotal = 0.0, taxpercent = 0.0;

            Console.Write("Enter the name of the Gas Station: ");
            gasStation = Console.ReadLine();

            Console.Write("Enter the price of gas: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many Gallons: ");
            gallons = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the Tax Percentage for this transaction: ");
            taxpercent = Convert.ToDouble(Console.ReadLine());

            // Correct calculations
            subtotal = price * gallons;
            tax = subtotal * (taxpercent / 100);
            total = subtotal + tax;

            // Display output
            Console.WriteLine("*******(" + gasStation + ")********");
            Console.WriteLine("Gas Price: $" + price);
            Console.WriteLine("Number of Gallons: " + gallons);
            Console.WriteLine("Tax Rate: " + taxpercent + "%");
            Console.WriteLine("Subtotal: $" + subtotal);
            Console.WriteLine("Tax: $" + tax);
            Console.WriteLine("Total: $" + total);
        }
    }
}
