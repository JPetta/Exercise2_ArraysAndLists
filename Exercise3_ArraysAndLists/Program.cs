using System;
using System.Collections.Generic;

namespace Exercise3_ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter list, minimum 5 number, comma seperated : ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');

                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("invalid list!");
            }

            var numbers = new List<int>();
            foreach (var n in elements)
                numbers.Add(Convert.ToInt32(n));


            var minimal = new List<int>();
            while (minimal.Count < 3)
            {
                var min = numbers[0];
                foreach(var n in numbers)
                {
                    if (n < min)
                        min = n;
                }

                minimal.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The smallest are ");
            foreach (var n in minimal)
                Console.WriteLine(n);

        }
    }
}
