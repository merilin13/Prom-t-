namespace revout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ref vs out");
            int first = 1;
            int second = 2;

            Method1(out first, out second);
            Method2(first, ref second);
            Method3(ref first, second);

            Console.WriteLine($"first: {first} , second: {second}");
            Console.ReadLine();
        }
        static void Method1(out int a, out int b) 
        {

        a = 2;
        b = 1;

        }
        static void Method2(int a, ref int b)
        {

         a *= 5;
         b *= a;

        }
        static void Method3(ref int a, int b)
        {

        a *= 5;
        b *= b;

        }
    }
}