namespace foreachineveryway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach harjutused");
            Console.WriteLine("1.list, kus on foreach");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1) 
            {
                ForeachWithList();
            }
            if (choice == 2)
            {
                Foreachanu();
            }

        }
        static void ForeachWithList()
        {
          var names = new List <string>()
            {"John", "Tom", "Anu", "Villu", "James"};
            foreach (var name in names) 
            { 
                Console.WriteLine(name);
            }
        }

        static void Foreachanu()
        {
            var tuuts = new List<string>()
            { "Arvo", "Sav", "Tuut", "Piip", "Andero"};
            foreach (var tuut in tuuts )
            {
                Console.WriteLine(tuut);
            }

        }
    }
}