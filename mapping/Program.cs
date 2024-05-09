using AutoMapper;

namespace mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");

            Employee emp = new Employee();

            emp.Id = 11;
            emp.Name = "Name1";
            emp.Title = "Title1";
            emp.Description = "Description1";

            //mapping algab
            //data transfer object

            EmployeeDto dto = new EmployeeDto();

            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name + " " + dto.Title + " " + dto.Description);

            Console.WriteLine("-------nüüd algab automapper--------");

            //tegime ja täitsime andmetega employee objekti
            Employee employee = new Employee
            {
                Id = 123,
                Name = "name123",
                Description = "desc123",
                Title = "title123"
            };

            var mapper = Program.InitializeAutomapper();

            var empDto2 = mapper.Map<Employee, EmployeeDto>(employee);

            Console.WriteLine(empDto2.Id + " " + empDto2.Name + " " + empDto2.Title + " " + empDto2.Description);
        }

        //mapper on automapper nugetlist saadud class
        public static Mapper InitializeAutomapper()
        {
            //ana kõik mappimise seadistused
            var confiq = new MapperConfiguration(cfg =>
            {
                //mappiminw employee ja employeedto classid oma vahel
                cfg.CreateMap<Employee, EmployeeDto>();
            });
            //loob mappimise instanti mapperist ja returnib selle
            var mapper = new Mapper(confiq);
            return mapper;
        }

    }
    public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }
    //dto- data transfer object
        public class EmployeeDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }
    
}
