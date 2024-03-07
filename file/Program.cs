namespace file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta faili läbi konsooli");

            string filepath = @"C:/Users/opilane/Desktop/Uus kaust/WriteToFile.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filepath, inputText);
        }
    }
}