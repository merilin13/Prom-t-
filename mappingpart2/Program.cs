using AutoMapper;
using System.Net.Security;

namespace mappingpart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("super cool sanrio mapper");

            Hellokitty hell = new Hellokitty();
            
            hell.Id = 1;
            hell.Name = "hello";
            hell.Title = "kitty";
            hell.Description = "my melody";

            Kuromi kur = new Kuromi();

            kur.Id = hell.Id;
            kur.Name = hell.Name;
            kur.Description = hell.Description;
            kur.Title = hell.Title;
            Console.WriteLine(kur.Id + " " + kur.Name + " " + kur.Title + " " + kur.Description);
            Console.WriteLine("-------------ato mapper in action-------");
            Hellokitty hellokitty = new Hellokitty
            {
                Id = 2,
                Name = "my melody",
                Description = "my melody",
                Title = "romeks on totu"
            };
            var mapper = Program.InitializeAutomapper();

            var hellkur = mapper.Map<Hellokitty,Kuromi>(hellokitty);

            Console.WriteLine(hellkur.Id + " " + hellkur.Name + " " + hellkur.Title + " " + hellkur.Description);
        }

        public static Mapper InitializeAutomapper()
        {
            var confiq = new MapperConfiguration(cfg =>
            {
                //mappiminw employee ja employeedto classid oma vahel
                cfg.CreateMap<Hellokitty, Kuromi>();
            });
            //loob mappimise instanti mapperist ja returnib selle
            var mapper = new Mapper(confiq);
            return mapper;
        }
    }
   
    public class Hellokitty
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }

    public class Kuromi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}
