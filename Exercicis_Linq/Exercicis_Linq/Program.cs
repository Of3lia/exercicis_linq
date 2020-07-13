using System;
using System.Linq;

namespace Exercicis_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////// Fase 1 ////////// 

            int[] nums = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var numsParells = from num in nums
                              where num % 2 == 0
                              select num;

            Console.Write("Nums parells: ");
            foreach (int num in numsParells) { Console.Write(num + ", "); }

            ////////// Fase 2 ////////// 

            var minNote = nums.Min();
            var avgNote = nums.Average();
            var maxNote = nums.Max();

            Console.WriteLine("\nMin note: " + minNote);
            Console.WriteLine("Avg note: " + avgNote);
            Console.WriteLine("Max note: " + maxNote);

            ////////// Fase 3 ////////// 

            var higerThan5 = nums.Where(n => n > 5);
            Console.Write("Numbers higher than 5: ");
            foreach (int num in higerThan5) { Console.Write(num + ", "); }

            var lowerThan5 = nums.Where(n => n < 5);
            Console.Write("\nNumbers lower than 5: ");
            foreach (int num in lowerThan5) { Console.Write(num + ", "); }

            ////////// Fase 4 ////////// 

            string[] names = { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };
            var nameStartWithO = names.Where(n => n.StartsWith("O"));
            Console.Write("\nNames that start with 'O': ");
            foreach (string name in nameStartWithO) { Console.Write(name + ", "); }

            Console.Write("\nNames that have more than 6 letters: ");
            var namesMore6Letters = names.Where(n => n.Length > 6);
            foreach (string name in namesMore6Letters) { Console.Write(name + ", "); }

            Console.Write("\nNames ordered desc: ");
            var namesDesc = names.OrderByDescending(n => n);
            foreach (string name in namesDesc) { Console.Write(name + ", "); }
            Console.Write("\n\n\n ");


        }
    }
}
