namespace peoplelistül
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AverageLINQ();
            Console.WriteLine("----------------");
            Console.WriteLine("1 - AverageLINQ ");
            Console.WriteLine("2 - Count");
            Console.WriteLine("3 - Sum");
            Console.WriteLine("4 - Max");
            Console.WriteLine("5 - Aggregate");
            Console.WriteLine("6 - Min");
            Console.WriteLine("----------------");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AverageLINQ();
                    break;

                case 2:
                    Count();
                    break;
                case 3:
                    Sum();
                    break;
                case 4:
                    Max();
                    break;
                case 5:
                    Aggregate();
                    break;
                case 6:
                    Min();
                    break;

                default:
                    Console.WriteLine("valikut ei ole");
                    break;
            }
        }

        public static void AverageLINQ()
        {
            Console.WriteLine("Average LINQ age ");
            var averageResult = PeopleList.people
                .Average(x => x.Age);

            Console.WriteLine(averageResult);
        }

        public static void Count()
        {
            Console.WriteLine("count LINQ inimesed ");
            var countResult = PeopleList.people.Count;

            Console.WriteLine("inimesi kokku " + countResult);
            var adultPerson = PeopleList.people.Count(x => x.Age >= 18);
            Console.WriteLine("täiskasvanuid " + adultPerson);
        }

        public static void Sum()
        {
            Console.WriteLine("sum vanused");
            //start
            var SumAge = PeopleList.people.Sum(x => x.Age);
            Console.WriteLine(SumAge);

            var sumAdults = 0;

            var SumAdultAge = PeopleList.people.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            Console.WriteLine("täiskasvanute koond arv " + SumAdultAge);
            //end    
        }
        public static void Max()
        {
            var oldperson = PeopleList.people.Max(x => x.Age);
            Console.WriteLine("vanim inimene on " + oldperson + ".a vana");
        }
        public static void Aggregate()
        {
            var commaSeparatedPersonNames = PeopleList.people
                .Aggregate<People, string>(
                "People names: ",
                (str, y) => str += y.Name + ", "
                );
            Console.WriteLine(commaSeparatedPersonNames);
        }
        public static void Min()
        {
            var youngperson = PeopleList.people.Min(x => x.Age);
            Console.WriteLine("noorim inimene on " + youngperson + ".a vana");
        }
    }
}