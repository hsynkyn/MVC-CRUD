using MVC_CRUD.Models.Entities;

namespace MVC_CRUD.Services.Interface
{
    public interface IPersonRepository
    {
        // Bütün tablolar için ortak metotlar eklenir

        bool CreatePerson(Person person);
        bool UpdatePersom(Person person);
        bool DeletePerson(Person person);


        Person FindPerson(int personId);
        List<Person> GetPeople();



    }
}
