using Business_Logic__Layer.Interface;
using Data_BaseLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessor _Professor;
        public ProfessorController(IProfessor Professor)
        {
            _Professor = Professor;
        }

        // GET: api/<ProfessorsController>
        [HttpGet]
        public IEnumerable<Professor> GetProfessors()
        {
            return _Professor.GetProfessors();
        }

        // GET api/<ProfessorsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Professor Professor = _Professor.Get(id);
            if (Professor == null)
            {
                return NotFound("The Professor record couldn't be found.");
            }
            return Ok(Professor);
        }



        // POST api/<ProfessorsController>
        [HttpPost]
        public IActionResult Post([FromBody] Professor Professor)
        {
            if (Professor == null)
            {
                return BadRequest("Professor is null");
            }
            _Professor.Post(Professor);
            return CreatedAtAction("Get", new { id = Professor.Id }, Professor);
        }



        // PUT api/<ProfessorsController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Professor Professor, int id)
        {
            if (Professor == null)
            {
                return BadRequest("Professor is null.");
            }

            _Professor.Put(Professor, id);
            return NoContent();
        }



        // DELETE api/<ProfessorsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Professor Professor = _Professor.Get(id);
            if (Professor == null)
            {
                return NotFound("the Professor record couldn't be found.");
            }
            _Professor.Delete(Professor);
            return NoContent();
        }
    }
}