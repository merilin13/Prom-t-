namespace kolmnurk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kirjuta number");
            int i, j, n;
            Console.Write("loo püramid **");
            Console.WriteLine("sisesta suurus");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 1; j < n-i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2*i-1 ; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i ;j++)
                {
                    Console.Write(" ");
                }
                for(j = 1; j <= 2 * i - 1 ;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n"); 
            }

        }
    }
}