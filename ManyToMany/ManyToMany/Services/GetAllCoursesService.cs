using ManyToMany.Dtos;
using ManyToMany.Repositories;

namespace ManyToMany.Services
{
    public class GetAllCoursesService
    {
        private readonly CourseRepository _courseRepository;

        public GetAllCoursesService(CourseRepository courseRepository)
        {
            this._courseRepository = courseRepository;
        }
        public IEnumerable<GetAllCoursesRequest> Execute()
        {
            var courses = _courseRepository.GetAll();
            var responses = new List<GetAllCoursesRequest>();
            foreach (var item in courses)
            {
                responses.Add(new GetAllCoursesRequest { Id = item.Id, Name = item.Name });
            }
            return responses;
        }
    }
}
