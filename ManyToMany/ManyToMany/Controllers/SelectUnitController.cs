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

        public SelectUnitController(SelectUnitService selectUnitService)
        {
            this._selectUnitService = selectUnitService;
        }
        [HttpPost]
        [Route("[controller]")]
        public ActionResult UnitSelect(SelectCoursesRequest request)
        {
            _selectUnitService.Execute(request);
            return Ok("units selected for the student successfully");
        }
    }
}
