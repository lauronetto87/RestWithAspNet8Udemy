using Microsoft.AspNetCore.Mvc;
using RestWithAspNetUdemy.API.Model;
using RestWithAspNetUdemy.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestWithAspNetUdemy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_personService.GetAll());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var person = _personService.GetById(id);

            if(person == null)
                return NotFound();

            return Ok(person);
        }

        // POST api/<PersonController>
        [HttpPost]
        public IActionResult Post([FromBody] PersonModel personModel)
        {
            if (personModel == null)
                return BadRequest();

            return Ok(_personService.Create(personModel));
        }

        // PUT api/<PersonController>/5
        [HttpPut]
        public IActionResult Put([FromBody] PersonModel personModel)
        {
            if (personModel == null)
                return BadRequest();

            return Ok(_personService.Update(personModel));
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);

            return NoContent();
        }
    }
}
