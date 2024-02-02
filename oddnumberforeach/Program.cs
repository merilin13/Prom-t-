namespace oddnumberforeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] oddArray = new int [] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

           foreach (int num in oddArray)
            {
                Console.WriteLine(num);
                if (num == 13)
                {
                    break;
                }
            }
        }
    }
}