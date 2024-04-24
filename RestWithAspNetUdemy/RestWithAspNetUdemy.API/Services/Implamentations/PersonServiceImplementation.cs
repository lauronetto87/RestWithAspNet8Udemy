using RestWithAspNetUdemy.API.Model;

namespace RestWithAspNetUdemy.API.Services.Implamentations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public PersonModel Create(PersonModel personModel)
        {
            return personModel;
        }

        public void Delete(long id)
        {
            
        }

        public List<PersonModel> GetAll()
        {
            List<PersonModel> persons = new List<PersonModel>();

            for(int i = 0; i < 8;  i++)
            {
                PersonModel person = MockPerson(i);
                persons.Add(person);
            }


            return persons;
        }

        public PersonModel GetById(long id)
        {
            return new PersonModel
            {
                Id = IncrementAndGet(),
                FirstName = "Lauro",
                LastName = "Netto",
                Address = "Barra dos Coqueiros",
                Gender = "Male"
            };
        }

        public PersonModel Update(PersonModel personModel)
        {
            return personModel;
        }

        private PersonModel MockPerson(int i)
        {
            return new PersonModel
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person Last Name" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
