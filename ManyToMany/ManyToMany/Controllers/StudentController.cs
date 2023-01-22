using ManyToMany.Dtos;
using ManyToMany.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManyToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AddStudentService _addStudentService;
        private readonly GetAllStudentsService _getAllStudentsService;

        public StudentController(AddStudentService addStudentService, GetAllStudentsService getAllStudentsService)
        {
            this._addStudentService = addStudentService;
            this._getAllStudentsService = getAllStudentsService;
        }
        [HttpPost]
        [Route("[controller]")]
        public ActionResult AddStudent(AddStudentRequest request)
        {
            _addStudentService.Execute(request);
            return Ok("Added Successfully");
        }
        [HttpGet]
        [Route("[controller]")]
        public ActionResult GetAllStudents() 
        {
            var students = _getAllStudentsService.Execute();
            return Ok(students);
        }
    }
}
