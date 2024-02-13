namespace forlooparray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array e jada e massiiv");

            int[] array = new int[5];
            array[0] = 10;
            array[2] = 20;
            array[4] = 30;
             for (int i = 0; i < array.Length; i++ )
            {

                Console.WriteLine(array[i]);

            }
                      
        }
    }
}