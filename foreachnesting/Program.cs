namespace foreachnesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for each nesting");

            var words = new List<List<string>>
            {
                new List<string> {"tea","coffee","jucie","smoothie"},
                new List<string> {"cup","plate","knife","spoon"},
                new List<string> {"rain","snow","hailstorm","sunny"}
            };
            //foreach on foreachi sees 
            foreach (var word in words)
            {
                foreach (var List in word)
                {
                    Console.WriteLine(List);
                }
                
            }
        }
    }
}