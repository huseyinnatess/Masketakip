using Entities.Concrete;
using Business.Concrete;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }
    }
   
}