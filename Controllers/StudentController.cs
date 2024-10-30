using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace StudentService
{
    //Взаимодействует с внешними штуками
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentManager _studentManager;

        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        [HttpPost]
        public async Task<Student>Add(Student student)
        {
            return await _studentManager.Add(student);
        }

        [HttpDelete("{id:int}")]
        public async Task<Student>DeleteById(int id)
        {
            return await _studentManager.DeleteById(id);
        }

        [HttpGet("many")]
        public async Task<List<Student>> GetAll()
        {
            return await _studentManager.GetAll();
        }

        [HttpPost("filter")]
        public async Task<List<Student>> FilterStudents(Filter filter)
        {
            return await _studentManager.FilterStudents(filter);
        }
    }
}
