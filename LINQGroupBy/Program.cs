using System.Threading.Channels;

namespace LINQGroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LINQGroupBy();
            Console.WriteLine("------------------------------");
            ToLookUp();

        }
        
        static void LINQGroupBy()
        {
            {
                var result = PeopleList.peoples
                    .GroupBy(x => x.Age);

                foreach (var age in result)
                {
                    Console.WriteLine("Vanus " + age.Key);  //Each group has a key 

                    foreach (var p in age)  //Each group has a inner collection  
                    {
                        Console.WriteLine("Nimi " + p.Name);
                    }
                }
            }
        }
        static void ToLookUp()
        {
            {
                var result = PeopleList.peoples
                    .ToLookup(x => x.Age);

                foreach (var age in result)
                {
                    Console.WriteLine("Vanus " + age.Key);  //Each group has a key 

                    foreach (var p in age)  //Each group has a inner collection  
                    {
                        Console.WriteLine("Nimi " + p.Name);
                    }
                }
            }
        }
    }
}
