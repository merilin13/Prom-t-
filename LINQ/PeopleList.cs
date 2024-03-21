using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Joonas",
                Age = 33,
                GenderId = Guid.Parse("8da75439-5447-4b69-a5a2-1e22667d648f")
            },
            new People()
            {
                Id = 2,
                Name = "Moona",
                Age = 21,
                GenderId = Guid.Parse("0579cee8-c724-4b7b-a251-0e57f7158081")
            },
            new People()
            {
                Id = 3,
                Name = "ron",
                Age = 18,
                GenderId = Guid.Parse("8da75439-5447-4b69-a5a2-1e22667d648f")
            },
            new People()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("0579cee8-c724-4b7b-a251-0e57f7158081")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 17,
                GenderId = Guid.Parse("0579cee8-c724-4b7b-a251-0e57f7158081")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("0579cee8-c724-4b7b-a251-0e57f7158081")
            }

        };
    }
}
