namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parts = new List<Carpart>()
            {
            new Carpart() {id = 1, partname = "a"},
            new Carpart() {id = 2, partname = "b"},
            new Carpart() {id = 3, partname  = "c"},
            new Carpart() {id = 4, partname = "d"},
            new Carpart() {id = 5, partname = "e"},
            new Carpart() {id = 6, partname = "f"},

            };
            foreach (var part in parts)
            {
                Console.WriteLine(part.partname);
            }
        }
    }
    public class Carpart
    {
        public int id { get; set; }
        public string partname { get; set; } 
    }
}