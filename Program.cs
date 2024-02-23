namespace listfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var primenumbers = new List<int>();
            primenumbers.Add(2);
            primenumbers.Add(3);
            primenumbers.Add(5);
            primenumbers.Add(7);

            Console.WriteLine("No of elelemts: " + primenumbers.Count);
            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Rome");
            cities.Add(null);
            Console.WriteLine("No of elements: " + cities.Count);
        }
    }
}