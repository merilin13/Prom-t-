namespace ASKASTERISK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta tärnide arv ->"); 
            string nr = Console.ReadLine();
            int muutuja = int.Parse(nr);
            
            for (int i = 0; i < muutuja; i++)
            {
                Console.Write("*");
            }

        }
    }
}