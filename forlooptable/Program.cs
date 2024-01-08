using System.ComponentModel.Design;

namespace forlooptable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("korrutustabel");
            Console.Write("\n");
            int j, i, n;
            Console.WriteLine("sisesta number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("korrutus tabel 1-0", n);

            for (i = 0; i < 10; i++) 
            {
                for (j = 1; j <= 10; j++)
                {
                    if (j <= 1 - n)
                    { 
                        Console.Write("{0}x{1} = {2} ",j,i,i * j); 
                    }
                    else 
                    {
                        Console.Write("{0}x{1} = {2} ", j, i, i * j);
                    }    
                }
                Console.Write("\n"); 
            }
        }      
    }
}