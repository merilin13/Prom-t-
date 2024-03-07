namespace sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted list");

            SortedList<int, string> numberName = new SortedList<int, string>();

            numberName.Add(3, "three");
            numberName.Add(1, "one");
            numberName.Add(2, "two");
            numberName.Add(4, null);
            numberName.Add(10, "ten");
            numberName.Add(5, "five");
            foreach (KeyValuePair<int, string> i in numberName)
            {
                Console.WriteLine("key: {0}, value: {1}", i.Key, i.Value);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("numbrite eemaldamine");
            SortedList<int, string> keyValuePairs = new SortedList<int, string>()
            {
                {3,"three"},
                {1,"one"},
                {2,"two"},
                {5,"five"},
                {4,"four" },
            };

            keyValuePairs.Remove(2);
            keyValuePairs.Remove(0);

            foreach(var i in keyValuePairs)
            {
                Console.WriteLine("key:{0},value:{1}", i.Key, i.Value);
            }
        }
    }
}