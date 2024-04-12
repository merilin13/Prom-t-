namespace LINQjoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            JoinLINQ();
            Console.WriteLine("---------------------------------");
            GroupJoin();

            Console.WriteLine("Vali vastav link numbriga");
            Console.WriteLine("1,2");
            int choice = int.Parse(Console.ReadLine());

           

            switch (choice)
            {
                case 1:
                    GroupJoin();
                    break;

                case 2:
                   GroupJoin();
                    break;

                default:
                    Console.WriteLine("valikut ei ole");
                    break;
            }

        }


        public static void JoinLINQ()
        {
            var innerJoin = PeopleList.people
                .Join
                (
                GenderList.genderList,
                humans => humans.GenderId,
                gender => gender.Id,
                (humans, gender) => new
                {
                    Name= humans.Name,
                    GenderName = gender.GenderName,
                }
                );

            foreach (var item in innerJoin)
            {

                Console.WriteLine("{0} - {1}",item.Name, item.GenderName );
            }
            
        }
        public static void GroupJoin()
        {
             var groupJoin = GenderList.genderList
                .GroupJoin
             (
                PeopleList.people,
                p => p.Id,
                g => g.GenderId,
                (p, peopleGroup) => new
                {
                    Name = peopleGroup,
                    GenderFullName = p.GenderName,
                }
             );

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.GenderFullName);

                foreach (var name in item.Name)
                {
                    Console.WriteLine(name.Name);
                }
            }
        }
    }
}