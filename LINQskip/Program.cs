


namespace LINQskip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("----------------");
            Console.WriteLine("1 - Skip ");
            Console.WriteLine("2 - SkipWhile ");
            Console.WriteLine("3 - TakeWhile ");
            Console.WriteLine("4 - Take ");
            Console.WriteLine("----------------");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Skip();
                    break;
                case 2:
                    SkipWhile();
                    break;
                case 3:
                    TakeWhile();
                    break;
                case 4:
                    Take();
                    break;

            }           
        }
        public static void Skip()
        {
            Console.WriteLine("Average LINQ age ");
            var skipResult = PeopleList.people
                .Skip(3);
            {
                foreach (var item in skipResult)
                {
                    Console.WriteLine(item.Name);
                }                   
            }
            
        }

        public static void SkipWhile()
        {
            Console.WriteLine("Average LINQ age ");
            var skipwhileResult = PeopleList.people
                .SkipWhile(s => s.Age > 18);
            {
                foreach (var item in skipwhileResult)
                {
                    Console.WriteLine(item.Age);
                }
            }
            
        }

        public static void TakeWhile()
        {
            Console.WriteLine("Average LINQ age ");
            var takewhileResult = PeopleList.people
                .TakeWhile(x => x.Age > 18);
            {
                foreach (var item in takewhileResult)
                {
                    Console.WriteLine(item.Name+ " " + item.Age);
                }
            }
            
        }

        public static void Take()
        {
            Console.WriteLine("Average LINQ age ");
            var takeResult = PeopleList.people
                .Take(3);
            {
                foreach (var item in takeResult)
                {
                    Console.WriteLine(item.Name+" " + item.Age);
                }
            }
            
        }
    }

}
