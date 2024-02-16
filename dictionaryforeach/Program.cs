namespace dictionaryforeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            var domains = new Dictionary<string, string>()
            {
                {"est ","estonia"},
                {"lat ","latvia" },
                {"fin ","finland"},
                {"swe ","sweeden"}

               
        };
            int number = 1;
            foreach (var item in domains)
            {                  
                    Console.WriteLine($"{item.Key} - {item.Value} - {number}"); 
                number++;
            }
        }
    }
}