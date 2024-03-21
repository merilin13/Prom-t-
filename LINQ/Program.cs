namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Kutsume esile LINQ läbi");
            Console.WriteLine("Vali vastav link numbriga");
            Console.WriteLine("1,2,3 Where");
            int choice = int.Parse(Console.ReadLine());

            ThenbyLINQ();
            Console.WriteLine("------------------------------");
            ThenByDecending();
            Console.WriteLine("------------------------------");

            switch (choice)
            {
                case 1:
                    ThenbyLINQ();
                    break;

                case 2:
                    ThenByDecending();
                    break;

                case 3:
                    SelectLINQ();
                    break;

                default:
                    Console.WriteLine("valikut ei ole");
                    break;
            }


        }

        public static void ThenbyLINQ()
        {
            var thenByResult = PeopleList.peoples
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Age);

                Console.WriteLine("ThenBy järgi");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
                
            }
        }

        public static void ThenByDecending()
        {
            var thenByDecending = PeopleList.peoples
                .OrderByDescending(p => p.Age);

                foreach (var people in thenByDecending)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        public static void SelectLINQ()
        {
            var selecRelult = PeopleList.peoples
                .Select(s => new {
                    Name = s.Name,
                    Age = s.Age
                });

            foreach (var people in selecRelult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }    
        }
    }
}