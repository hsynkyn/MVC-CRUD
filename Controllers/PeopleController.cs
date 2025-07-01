using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Models.Entities;
using MVC_CRUD.Services.Interface;

namespace MVC_CRUD.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PeopleController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public IActionResult Index()
        {
            var people = _personRepository.GetPeople();
            return View(people);
        }

       
    }
}
