namespace ifandelsefootnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jalanumbrid");
            string cm = Console.ReadLine();
            int jalg = int.Parse(cm);

            if (jalg >= 30 && jalg <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("sul on väike jalanumber");
            }

            else if (jalg >= 34 && jalg <= 38)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Mul on umbes sama suur");


            }

            else if (jalg >= 39 && jalg <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;

                Console.WriteLine("suuur");

            }

            else if (jalg >= 45 && jalg <= 48)
            {
                Console.Beep();
                Console.WriteLine("HUGE");

            }

            else
            {

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Magenta;

                Console.WriteLine("ON SEE JALASUURUS IKKA????");
            }

        }
    }
}