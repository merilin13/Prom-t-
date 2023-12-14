namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foe Loop");

            int loop = 5;
            for (int i = 0; i < loop; i++) 
            {
                Console.WriteLine("loop" + i); 
                
                Console.Beep();
            }
        }
    }
}