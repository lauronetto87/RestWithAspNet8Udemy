using RestWithAspNetUdemy.API.Model;

namespace RestWithAspNetUdemy.API.Services
{
    public interface IPersonService
    {        
        PersonModel GetById(long id);
        PersonModel Create(PersonModel personModel);
        PersonModel Update(PersonModel personModel);
        void Delete(long id);
        List<PersonModel> GetAll();


    }
}
