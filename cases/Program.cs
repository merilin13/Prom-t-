namespace cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string topic, category;

            topic = "Jump Statements";

            switch (topic)
            {
                case "Intro to C#":
                case "Variables":
                case "Data Types":

                    category = "Basic";
                    break;

                case "Loops":
                case "If Statements":
                case "Jump Statements":

                    category = "Control flow";
                    break;

                case "Class & objects":
                case "Inheritance":
                case "Constructors":

                    category = "OOP-S Consept";
                    break;

                default:
                    category = "UNKNOWN"; 
                    break;
            }
            Console.WriteLine("category is " + category);
        }
    }
}