namespace Switchmethodcalling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string topic, category;

            topic = Console.ReadLine();

            switch (topic)
            {
                case "kollane":
                case "punane":
                case "valge":
                    

                    Main1();
                    break;

                case "roosa":
                case "sinine":
                case "pruun":
                    
                    Main2();
                    break;

                case "roheline":
                case "lilla":
                case "mere sinine":
                case "okse":
                   
                    Main3();
                    break;

                default:

                    category = "sisesta mingi teine värv";
                    break;
                  

            }
        }
        static void Main1()
        {
            Console.WriteLine("lahedad värvid");
        }
        static void Main2()
        {
            Console.WriteLine("eriti lahedad värvid");
        }
        static void Main3()
        {
            Console.WriteLine("arvo pluusi värvid");
        }
    }
}