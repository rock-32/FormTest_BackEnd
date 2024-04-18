using FormSubmission.DTOs;
using FormSubmission.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormSubmission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IStudentService studentService;
        public FormController(IStudentService studentService) 
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(studentService.listAllStudents());
        }


        [HttpPost]
        public IActionResult Add([FromBody] StudentDTO student)
        {
            bool IsAdded = studentService.AddStudent(student);
            return IsAdded? Ok(IsAdded):BadRequest(IsAdded);
        }



        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool IsDeleted = studentService.Delete(id);
                return IsDeleted ? Ok(IsDeleted) : BadRequest(IsDeleted);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }



        [HttpPut("{id}")]
        public IActionResult UpdateUserDetails([FromBody] StudentDTO student,int id)
        {
            try
            {
                bool IsUpdated = studentService.Update(id, student);
                return IsUpdated ? Ok(IsUpdated) : BadRequest(IsUpdated);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
