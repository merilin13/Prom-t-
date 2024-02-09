namespace foreachnumberadd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {5, -8, 3, 14, 9, 17, 0, 4};

            int sum = 0;

            foreach(int i in numbers)
            {
                sum += i;

            }

            Console.WriteLine("Sum {0} ", sum);
            Console.ReadLine();
        }
    }
}