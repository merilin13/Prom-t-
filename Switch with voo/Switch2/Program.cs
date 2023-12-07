namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta number string andmetüübina");

            string number = Console.ReadLine();

            switch (number) 
            {
                case "1":                 
                case "2":
                    Console.WriteLine("valisid ühe või kahe");
                    break;
                default:
                    Console.WriteLine("Valisid midagi muud");
                    break;
            }
        }
    }
}