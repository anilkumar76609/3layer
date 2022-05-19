using Business_Logic__Layer.Interface;
using Data_BaseLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3layer.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CampusController : ControllerBase
    {
        private readonly ICampus _Campus;
        public CampusController(ICampus Campus)
        {
            _Campus = Campus;
        }



        // GET: api/<CampusesController>
        [HttpGet]
        public IEnumerable<Campus> GetCampuses()
        {
            
            return _Campus.GetCampuses();
        }



        // GET api/<CampusesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Campus Campus = _Campus.Get(id);
            if (Campus == null)
            {
                return NotFound("The Campus record couldn't be found.");
            }
            return Ok(Campus);
        }



        // POST api/<CampusesController>
        [HttpPost]
        public IActionResult Post([FromBody] Campus Campus)
        {
            if (Campus == null)
            {
                return BadRequest("Campus is null");
            }
            _Campus.Post(Campus);
            return CreatedAtAction("Get", new { id = Campus.Id }, Campus);
        }



        // PUT api/<CampusesController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Campus Campus, int id)
        {
            if (Campus == null)
            {
                return BadRequest("Campus is null.");
            }

            _Campus.Put(Campus, id);
            return NoContent();
        }

        // DELETE api/<CampusesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Campus Campus = _Campus.Get(id);
            if (Campus == null)
            {
                return NotFound("the Campus record couldn't be found.");
            }
            _Campus.Delete(Campus);
            return NoContent();
        }
    }
}