using Business_Logic__Layer.Interface;
using Data_BaseLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourse _Course;
        public CourseController(ICourse Course)
        {
            _Course = Course;
        }

        // GET: api/<CoursesController>
        [HttpGet]
        public IEnumerable<Course> GetCourses()
        {
            return _Course.GetCourses();
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Course Course = _Course.Get(id);
            if (Course == null)
            {
                return NotFound("The Course record couldn't be found.");
            }
            return Ok(Course);
        }



        // POST api/<CoursesController>
        [HttpPost]
        public IActionResult Post([FromBody] Course Course)
        {
            if (Course == null)
            {
                return BadRequest("Course is null");
            }
            _Course.Post(Course);
            return CreatedAtAction("Get", new { id = Course.CourseId }, Course);
        }



        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Course Course, int id)
        {
            if (Course == null)
            {
                return BadRequest("Course is null.");
            }

            _Course.Put(Course, id);
            return NoContent();
        }



        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Course Course = _Course.Get(id);
            if (Course == null)
            {
                return NotFound("the Course record couldn't be found.");
            }
            _Course.Delete(Course);
            return NoContent();
        }
    }
}