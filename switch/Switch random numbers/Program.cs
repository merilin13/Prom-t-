using System.Reflection;

namespace Switch_random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamis mäng");

            Random rnd = new Random();

            int cube = rnd.Next(1, 6);

            Console.WriteLine(cube);

            //teine võimalus
            //int cube = new Random().Next(1, 6);
            
            switch ( cube )
            {
                case 1:
                    Console.WriteLine("AAA LAHE");
                    break;

                case 2:
                    Console.WriteLine("cool");
                    break;                  
                case 3:
                    Console.WriteLine("AAAAAA GOOD JOB");
                    break;
                case 4:
                    Console.WriteLine("tubli");
                    break;
                case 5:
                    Console.WriteLine("nice");
                    break;
                case 6:
                    Console.WriteLine("sa oled petumust valmistav");
                    break;
                default:
                    Console.WriteLine("juhtub");
                    break;

            }


        }
    }
}