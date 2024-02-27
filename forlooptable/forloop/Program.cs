namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täisarvude kokku liitmine kuni kümneni");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n\n");
            int j;
            int sum = 0;
            for (j=0; j < 10; j++)
            {
                sum += j + 1;
                Console.WriteLine($"Summa on : " + sum);
            }
        }
    }
}