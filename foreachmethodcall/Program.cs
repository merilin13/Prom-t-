namespace foreachmethodcall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("punktide panek");
            int[] marks = { 125, 132, 95, 116, 110 };

            int highestMarks = Maximum(marks);

            Console.WriteLine("the highest score is " + highestMarks);
        }

        public static int Maximum(int[] numbers)
        {
            int maxNumbers = numbers[0];

            foreach(int number in numbers) 
            {
                if (number > maxNumbers)
                {
                    maxNumbers = number;
                }
            }
            return maxNumbers;
        }
    }
}