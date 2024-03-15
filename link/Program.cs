namespace link
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ läbi");
            Console.WriteLine("Vali vastav link numbriga");
            Console.WriteLine("1,2 Where");
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    WhereLINQ();
                    break;

                    default:
                        Console.WriteLine("valikut ei ole");
                        break;
            }

            switch (choice)
            {
                case 2:
                    whereByname();
                    break;

                default:
                    Console.WriteLine("valikut ei ole");
                    break;
            }

            //WhereLINQ();
        }

        public static void WhereLINQ()
        {
            var peopleAge = peoplelist.peoples
                .Where(x => x.Age > 20 && x.Age < 30);

            foreach (var person in peopleAge)
            {
                Console.WriteLine(person.Name);
            }
        }

        public static void whereByname()
        {
            Console.WriteLine("Kirjuta inimese nimi");
            string name = Console.ReadLine();
            var peopleName = peoplelist.peoples
                .Where(x => x.Name == name);

            foreach (var person in peopleName)
            {
                Console.WriteLine(person.Name);
            }
        }

    }
}