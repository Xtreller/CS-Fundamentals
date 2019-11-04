using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int number = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(number);
            }
            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count/2 ]);
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
