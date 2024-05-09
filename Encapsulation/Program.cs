using Encapsulation.Services;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kapseldamine");
            Student student = new Student ();

            student.Id = 101;
            student.Name = "Test";
            student.Email = "Test@test.com";

            Console.WriteLine("Id = " + student.Id);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);

            ProtectedStudents protectedStudents = new ProtectedStudents ();
            Console.WriteLine("------------");
            //protectedStudents.DoSomething();

            Program program = new Program ();
            program.DoSomethingInProgramClass();
            Console.WriteLine("----------");
            Program pp = new Program ();
            Console.WriteLine("privateProtectedInProgramClassMainMethod");

            //ei saa kasutada kuna on private protected tasemel
            var privateProtectedStudents = new PrivateProtectedStudents ();
            //privateProtectedStudents.PrivateProtectedStudent1 = "asdasdasd"

            Console.WriteLine("------Seald class----------");
            //seald classi kasutamine
            var sc = new SealedStudents();
            sc.Id = 123;
            sc.Name = "Test";
            sc.Email = "Test@test.com";
            Console.WriteLine($"Id on{sc.Id}, Name on {sc.Name}, ja email on {sc.Email}");
        }

        protected void DoSomethingInProgramClass()
        {
            Console.WriteLine("DoSomethingInProgramClass");
        }

        private protected string privateProtectedInProgramClass =
            "privateProtectedInProgramClass";
    }
}
