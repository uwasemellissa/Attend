using Domain.Entities;
namespace Application.Servises.StudentServices
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
    }
}
