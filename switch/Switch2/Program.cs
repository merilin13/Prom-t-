namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number ja vajuta enter");

            string ch = Console.ReadLine();
            int nr = int.Parse(ch);

            switch (nr) 
            {
                case 1:

                    Console.WriteLine("Sisestasid ühe");
                    Console.Beep();
                    break;

                case 2:
                    Console.WriteLine("Sisestasid kahe");
                    Console.Beep();
                    Console.Beep();

                    break;

                case 3:
                    Console.WriteLine("Sisestasid kolme ");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();

                    break;

                 default:
                    Console.WriteLine("sisesta midagi muud");
                    break;

            }
        }
    }
}