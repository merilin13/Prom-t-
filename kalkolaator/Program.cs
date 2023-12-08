using System.ComponentModel;
using System.Threading.Channels;

namespace kalkolaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kalkulaator");
            Console.WriteLine("sisesta esimene number");
            float nr1 = float.Parse(Console.ReadLine());
            Console.WriteLine("sisesta tehe");

            string arvutus = Console.ReadLine();

            Console.WriteLine("siseta teine number");
            float nr2 = float.Parse(Console.ReadLine());

            switch(arvutus)
            {

                case "+":
                    Add(nr1, nr2);
                     break;
                case "-":
                    Minus(nr1, nr2);
                    break;
                case "/":
                    Div(nr1, nr2);
                    break;
                    case "*":
                    Mult(nr1, nr2);
                    break;
            }

        }
        static void Add(float nr1, float nr2)
        {     

            float resultadd = nr1 + nr2;
            Console.WriteLine("Tulemus: " + resultadd);
                    
        }
        static void Minus(float nr1, float nr2)
        {
            float resultmin = nr1 - nr2;
            Console.WriteLine("Tulemus: " + resultmin);
        }
        static void Div(float nr1, float nr2)
        {
            float resultdiv = nr1 / nr2;
            Console.WriteLine("Tulemus: " + resultdiv);
        }
        static void Mult(float nr1, float nr2)
        {
            float resultmult = nr1 * nr2;
            Console.WriteLine("Tulemus: " + resultmult);
        }
    }
}