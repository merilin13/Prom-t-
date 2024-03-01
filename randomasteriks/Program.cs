namespace randomasteriks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stringRowmin = 0;   
            int stringRowmax = 5;

            int[] randomAsterisk = new int[stringRowmax];

            Random asterisk = new Random();
            for (int i = stringRowmin; i < randomAsterisk.Length; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("*",
                    asterisk.Next(1,20))));
            }
            foreach (int i in randomAsterisk)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("*",
                   asterisk.Next(1, 20))));
            }
        }
    }
}