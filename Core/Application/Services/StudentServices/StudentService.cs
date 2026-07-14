using Application.Interfaces;
using Application.Services.StudentServices;
using Domain.Entities;
namespace Application.Services.StudentServices
{
    public class StudentService:IStudentService
    {
      private readonly IStudent _student;  

      public StudentService(IStudent student)
      {
          _student= student;   
      }
      public List<Student> GetAllStudent()
        {
            return _student.GetAllStudent();
        }
    }
}






