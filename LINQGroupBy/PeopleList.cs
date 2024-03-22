using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQGroupBy
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
                new People()
                {
                    Id = 1,
                    Name = "John",
                    Age = 18,
                    
                },
                new People()
                {
                    Id = 2,
                    Name = "Steve",
                    Age = 21,
                    
                },
                new People() 
                {
                    Id = 3,
                    Name = "Bill",
                    Age = 18,
                   
                },
                new People()
                {
                    Id = 4,
                    Name = "Ram",
                    Age = 20,
                    
                },
                 new People()
                {
                    Id = 5,
                    Name = "Abram",
                    Age = 21,
                    
                }
        };
    }
}
