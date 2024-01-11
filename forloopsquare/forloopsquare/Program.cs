using System.Threading.Channels;

namespace forloopsquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ruut");
            Console.WriteLine("sisesta ruudu suurus");

            int size = int.Parse(Console.ReadLine());
            int row;
            int column;

            for (column = 0; column < size; column++)
            {
                for (row = 1; row < size - column ; row++)
                {
                    Console.Write(" ");
                }
                for (row = 1; row <= 2 * column - 1 ; row++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }


            for (row = 1; row <= size; row++)
            {
                for( column=1; column <= size * 2 - 3; column++)
                {
                    string mark;
                    if(row == column|| row + column <= size +1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }

            Console.WriteLine("ümbermõõt " + size * 4 + " pindala " + size * size);
           
            
            

        }
    }
}