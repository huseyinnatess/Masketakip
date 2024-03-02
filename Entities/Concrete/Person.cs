
namespace Entities.Concrete
{
    public class Person
    {
        public Person()
        {
            Console.Write("Enter Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter Surname: ");
            LastName = Console.ReadLine();
            Console.Write("Enter Birthday: ");
            DateOfBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter National Identity: ");
            NationalIdentity = long.Parse(Console.ReadLine());
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
