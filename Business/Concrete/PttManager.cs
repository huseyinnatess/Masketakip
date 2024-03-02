using Business.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicanteService;
        Mylist<Person> personList = new Mylist<Person>();

        public PttManager(IApplicantService applicantService)
        {
            _applicanteService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if (_applicanteService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " kişisine maske verildi");
            }
            else
                Console.WriteLine("Hatalı kimlik bilgisi");
        }

        public void AddList(Person person)
        {
            personList.Add(person);
            Console.WriteLine("Listeye eklemesi yapıldı");
        }
    }

    class Mylist<T>
    {
        T[] _array;
        T[] _tempArray;

        public Mylist()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public void Remove(T item)
        {
            int removeIndex = -1;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    removeIndex = i;
                    break;
                }
            }
            if (removeIndex == -1)
                return;
            _tempArray = new T[_array.Length - 1];
            for (int i = 0; i < _array.Length; i++)
            {
                if (i == removeIndex)
                    continue;
                _tempArray[i] = _array[i];
            }
            _array = _tempArray;
        }
        public int Count { get { return _array.Length; } }
    }
}
