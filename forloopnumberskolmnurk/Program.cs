namespace forloopnumberskolmnurk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.WriteLine("sisesta püramiidi suurus");
            rows=Convert.ToInt32(Console.ReadLine());

           

            for(i = 1; i <= rows; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }
    }
}