namespace whiledo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While ja do");
            int number = 1;
            do
            {
                Console.Write(number);
                number++;
            }
            while (number <= 5000);
        }
    }
}