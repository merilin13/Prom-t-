namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("maa kalkulaator");
            //int circleradius = 3;
            int diam = 127420000;
            //12 742000000
            //25.75 mm
            Console.WriteLine("maa ümbermõõt: " +  (Math.PI ) * ( diam ) );
            Console.WriteLine("ma müntides" + (Math.PI) * (diam) / (25.75));
           
        }
    }
}