namespace numberpüramiid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             Console.WriteLine("kirjuta number");
            int i, j, n;
            Console.Write("loo püramid **");
            Console.WriteLine("sisesta suurus");
            n = Convert.ToInt32(Console.ReadLine());
            int Number = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 1; j < n-i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2*i-1 ; j++)
                {
                    Console.Write(Number++);
                }
                Console.Write("\n");
            }
        }
    }
}