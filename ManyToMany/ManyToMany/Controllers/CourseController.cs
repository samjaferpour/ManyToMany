using ManyToMany.Dtos;
using ManyToMany.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManyToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly AddCourseService _addCourseService;
        private readonly GetAllCoursesService _getAllCoursesService;

        public CourseController(AddCourseService addCourseService, GetAllCoursesService getAllCoursesService)
        {
            this._addCourseService = addCourseService;
            this._getAllCoursesService = getAllCoursesService;
        }
        [HttpPost]
        [Route("[action]")]
        public ActionResult AddCourse(AddCourseRequest request)
        {
            _addCourseService.Execute(request);
            return Ok("Added Successfully");
        }
        [HttpGet]
        [Route("[action]")]
        public ActionResult GetAllCourses()
        {
            var courses = _getAllCoursesService.Execute();
            return Ok(courses);
        }
    }
}
