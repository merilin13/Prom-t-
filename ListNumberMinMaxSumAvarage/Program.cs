using System.Collections;

namespace ListNumberMinMaxSumAvarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 15, 16, 8, 6 };

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());

            Console.WriteLine("-------------");
            Console.WriteLine("sorteerib numbrid ära alates väiksemast suuremasse");
            Array.Sort(numbers); 

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
           
            Console.WriteLine("-------------");
            Console.WriteLine("sorteerib numbrid ära alates suuremast väiksemasse");
            Array.Reverse(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");

            Console.WriteLine(Array.BinarySearch(numbers, 15));
        }
    }
}