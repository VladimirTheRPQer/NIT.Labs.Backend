namespace StudentService
{
    public interface IStudentManager
    {
        //Интерфейс в данном случае нужен для прокидывания DI в данном проекте это не нужно, просто привычку формирую
        Task<Student> Add(Student student);
        Task<Student> DeleteById(int id);
        Task<List<Student>> GetAll();
        Task<List<Student>> FilterStudents(Filter filter);
    }
}
