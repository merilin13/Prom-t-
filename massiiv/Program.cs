namespace massiiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //näide
            string sentence = "Üks euroopa pealinnadest on ";
            Console.WriteLine("tuple");
            var cities = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsingi");
            //tuple all on viis erinevat väärtust ja sellepärast saab maksimaalselt 5 item-t olla
            Console.WriteLine(sentence + cities.Item3);
            Console.WriteLine("-----------------------------------------------------------");
            //näide 2 massiiv

            string[] city = { "Tallinn", "Pariis", "Rooma", "London", "Helsingi" };
            for (int i = 0; i < city.Length; i++ )
            {
                Console.WriteLine(sentence + city[i]);
            }

            //näide 3
            Console.WriteLine(sentence + city[2]);
            Console.WriteLine("-----------------------------------------");

            //näide 4
            Random number = new Random();
            int randomnumber = number.Next(0, 4);
            Console.WriteLine(sentence + city[randomnumber]);
        }
    }
}