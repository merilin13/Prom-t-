namespace ifandelsecolor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nimi");
            string name = Console.ReadLine();

            Console.WriteLine("nimi on sisestatud ja nüüd hakkab kontroll");
            if(name !="")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.BackgroundColor= ConsoleColor.Red;

                Console.WriteLine("Tere, " + name + " ! " );
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else 
            { 

            Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor= ConsoleColor.Red;

                Console.WriteLine("Nime ei sisestatud.");
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}