namespace foreacharray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] genders = { "m", "f", "m", "m", "m", "f", "f", "m", "m","f"};
              
            int female = 0, male = 0;

            foreach (string gender in genders) 
            {
                if (gender == "m")
                {
                    male++;
                }
                if (gender == "f")
                {
                    female++;
                }
            }

            Console.WriteLine("number of female {0} and nr of male {1}", female, male);
        }
    }
}