using link.models;
using System.Xml.Linq;

namespace link
{
    public class peoplelist
    {
        public static readonly List<people> peoples = new List<people>
        {
            new people()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("e7bd898b-40aa-4019-b5fb-8b7d3fb520c2"),
            },
            new people()
            {
                Id = 2,
                Name = "Piip",
                Age = 21,
                GenderId = Guid.Parse("e7bd898b-40aa-4019-b5fb-8b7d3fb520c2"),
            },
            new people()
            {
                Id = 3,
                Name = "Tuut",
                Age = 18,
                GenderId = Guid.Parse("e060e9ee-aee1-43cd-8c10-43d04fe063e0"),
            },
             new people()
            {
                Id = 4,
                Name = "Lili",
                Age = 20,
                GenderId = Guid.Parse("e7bd898b-40aa-4019-b5fb-8b7d3fb520c2"),
            },
              new people()
            {
                Id = 5,
                Name = "Piip",
                Age = 50,
                GenderId = Guid.Parse("e7bd898b-40aa-4019-b5fb-8b7d3fb520c2"),
            },
               new people()
              {
                Id = 6,
                Name = "Tuule",
                Age = 80,
                GenderId = Guid.Parse("e7bd898b-40aa-4019-b5fb-8b7d3fb520c2"),
            }

        };
    }
}
