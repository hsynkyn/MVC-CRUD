using MVC_CRUD.Infrastructure.Context;
using MVC_CRUD.Models.Entities;
using MVC_CRUD.Services.Interface;

namespace MVC_CRUD.Services.Concrete
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext _context;
        public PersonRepository(AppDbContext context)
        {
            _context = context;
            
        }
        public bool CreatePerson(Person person)
        {
            _context.People.Add(person);
            var result = _context.SaveChanges();
            return result > 0;
        }

        public bool DeletePerson(Person person)
        {
            _context.People.Remove(person);
            var result = _context.SaveChanges();
            return result > 0;
        }

        public bool UpdatePersom(Person person)
        {
            _context.People.Update(person);
            var result = _context.SaveChanges();
            return result > 0;
        }

        public Person FindPerson(int personId)
        {
            var person = _context.People.Find(personId);
            return person;
        }

        public List<Person> GetPeople()
        {
            var people = _context.People.ToList();
            return people;
        }

        
    }
}
