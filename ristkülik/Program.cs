using System.Reflection;

namespace ristkülik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta pikkus");
            string p2 = (Console.ReadLine());
            int p = Convert.ToInt32(p2);
            Console.WriteLine("sisesta laius ");
            string l2 = (Console.ReadLine());
            int l = Convert.ToInt32(l2);
            

            for (int row = 1; row <= p ; row++) 
            {
                for (int column = 1; column <= l; column++)
                {
                    string mark;
                    if (row == column || row + column <= +1)
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
        }
    }
}