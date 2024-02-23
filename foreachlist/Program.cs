namespace foreachlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };

            intList.ForEach(el => Console.WriteLine(el));

            foreach (var el in intList)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("------------------");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
        }
    }
}