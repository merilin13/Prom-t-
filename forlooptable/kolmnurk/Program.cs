namespace kolmnurk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kirjuta number");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j <= i; j++)
            {
                for (int k = 0; k <= j; k++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("\n");
            }
           


        }
    }
}