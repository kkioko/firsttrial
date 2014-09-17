using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 6; x++)
            {
                DoAnAirport();
            }
          
        }
        static public void GetAirportData(out String Name, out String City, out int nrPlanes)
        {
            Console.WriteLine("Enter Airport's Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Airport's City: ");
            City = Console.ReadLine();
            Console.WriteLine("Enter Number of planes: ");
            nrPlanes = int.Parse(Console.ReadLine());
            
        }
        static public int getpositive()
        {
            int a;
            do
            {
                Console.WriteLine("Enter a number: ");
                a = int.Parse(Console.ReadLine());
            }
            while (a < 0);
          
                return a;
        }

        static void DoAnAirport(ref int countBig)
        {
            string name;
            string city;
            int nrplanes = getpositive();
            GetAirportData(out name, out city, out nrplanes);
            for (int x = 1; x <= nrplanes; x++)
            {
                Console.WriteLine("enter number of passengers: ");
                int pass = int.Parse(Console.ReadLine());
                if (pass > 100)
                    countBig++;
            }
        }

    }
}
