namespace autoforeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("autod");
            string[] cars = { "a", "b", "c", "d" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
         
    }
}