using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;


namespace StudentService
{
    // Обрабатывает всякие штуки
    public class StudentManager : IStudentManager
    {
        private readonly DataContext _dbContext;

        public StudentManager()
        {
            _dbContext = new DataContext();
        }
        public async Task<Student> Add(Student student)
        {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
            return student;
        }
        public async Task<Student> DeleteById(int id)
        {
            var student = _dbContext.Students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                _dbContext.Remove(student);
                await _dbContext.SaveChangesAsync();
                return student;
            }
            else
                return null;
        }
        public async Task<List<Student>> GetAll()
        {
            var students = await _dbContext.Students.ToListAsync();
            return students;
        }

        public async Task<List<Student>> FilterStudents(Filter filter)
        {
            IEnumerable<Student> students = await _dbContext.Students.ToListAsync();
            students = students.Where(x => x.AdmissionDate >= filter.MinAdmissionDate && x.AdmissionDate <= filter.MaxAdmissionDate &&
            CountAge(x.BirthDate) >= filter.MinAge && CountAge(x.BirthDate)<=filter.MaxAge);
            List<Student> studentsList = students.ToList();
            return studentsList;
        }
        private int CountAge(DateTime birthday)
        {
            return DateTime.Now.Year - birthday.Year;
        }
    }
}
