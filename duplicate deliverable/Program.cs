using System;

namespace Deliverable1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            ("How many peanut butter and jelly sandwiches are needed");

            string input = Console.ReadLine();
            int number;
            int.TryParse(input, out number);
            int slices = number * 2;
            int PB = number * 2;
            int Jelly = number * 4;
            Console.WriteLine("Slices of bread:");
            Console.WriteLine(slices);
            Console.WriteLine("TBSP of peanutbutter:");
            Console.WriteLine(PB);
            Console.WriteLine("tsp of jelly:");
            Console.WriteLine(Jelly);

            decimal v = (slices / 28);
            decimal loafs = Math.Ceiling(v);
            decimal w = PB / 32;
            decimal J0PB = Math.Ceiling(w);
            decimal x = Jelly / 48;
            decimal JoJelly = Math.Ceiling(x);
           
            
            

            Console.WriteLine("You will need" + v + "loafs of bread");
            Console.WriteLine(w + "Jars of peanutbutter");
            Console.WriteLine("and" + x + "jars of Jelly");

        }

     
        }
    }

