using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTraining.Data.Entity;
using CoreTraining.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreTraining.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(List<Student>), StatusCodes.Status200OK)]
        public IActionResult GetAllStudents()
        {
            try {
                var result = _studentService.GetStudents();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult AddNewStudent([FromBody] Student student)
        {
            try
            {
                var result = _studentService.AddStudent(student);
                return Ok("Student Added Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            try
            {
                var result = _studentService.UpdateStudent(student);
                return Ok("Student Updated Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteStudent([FromBody] int id)
        {
            try
            {
                var result = _studentService.DeleteStudent(id);
                return Ok("Student Deleted Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IEnumerable<Student> GetStudent([FromQuery] int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}