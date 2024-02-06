namespace korrutus_tabel_fancy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjutanumber, kui pikk korrutus tabel peaks olema");
            Console.WriteLine("--------------------------------------------------");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("korrutustabel 1 kuni {0}", n);
            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= n; j++) 
                {
                    if (j <= n - 1)
                    {
                       Console.Write("{0} x {1} = {2} : ", j, i, i * j);
                    }
                    else
                    {
                        Console.WriteLine("{0} x {1} = {2} : ", j, i, i * j);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}