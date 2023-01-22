using ManyToMany.Dtos;
using ManyToMany.Repositories;
using ManyToMany.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManyToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectUnitController : ControllerBase
    {
        private readonly SelectUnitService _selectUnitService;
        private readonly GetCoursesByStudentNameService _getCoursesByStudentNameService;

        public SelectUnitController(SelectUnitService selectUnitService, GetCoursesByStudentNameService getCoursesByStudentNameService)
        {
            this._selectUnitService = selectUnitService;
            this._getCoursesByStudentNameService = getCoursesByStudentNameService;
        }
        [HttpPost]
        [Route("[action]")]
        public ActionResult UnitSelect(SelectCoursesRequest request)
        {
            _selectUnitService.Execute(request);
            return Ok("units selected for the student successfully");
        }
        [HttpPost]
        [Route("[action]")]
        public ActionResult GetCoursesByStudentName(GetCoursesByStudentNameRequest request)
        {
            var result = _getCoursesByStudentNameService.Execute(request);
            return Ok(result);
        }
    }
}
