using Business_Logic__Layer.Interface;
using Data_BaseLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {
        private readonly IPrincipal _Principal;
        public PrincipalController(IPrincipal Principal)
        {
            _Principal = Principal;
        }

        // GET: api/<PrincipalsController>
        [HttpGet]
        public IEnumerable<Principal> GetPrincipals()
        {
            return _Principal.GetPrincipals();
        }

        // GET api/<PrincipalsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Principal Principal = _Principal.Get(id);
            if (Principal == null)
            {
                return NotFound("The Principal record couldn't be found.");
            }
            return Ok(Principal);
        }



        // POST api/<PrincipalsController>
        [HttpPost]
        public IActionResult Post([FromBody] Principal Principal)
        {
            if (Principal == null)
            {
                return BadRequest("Principal is null");
            }
            _Principal.Post(Principal);
            return CreatedAtAction("Get", new { id = Principal.Id }, Principal);
        }



        // PUT api/<PrincipalsController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Principal Principal, int id)
        {
            if (Principal == null)
            {
                return BadRequest("Principal is null.");
            }

            _Principal.Put(Principal, id);
            return NoContent();
        }
        // DELETE api/<PrincipalsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Principal Principal = _Principal.Get(id);
            if (Principal == null)
            {
                return NotFound("the Principal record couldn't be found.");
            }
            _Principal.Delete(Principal);
            return NoContent();
        }
    }
}
