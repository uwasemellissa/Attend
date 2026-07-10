using Domain.Entities;

namespace Application.Servises.StudentServices

{
    public class StudentService:IStudentService
    {
        public  List<Student> GetAllStudents()
        {
            return new List<Student> {
            new Student{Id=1,Email="uwase@gmail.com",Name="Uwase melissa",Phone="078882018",sex="Female"},
         new Student{Id=1,Email="uwase@gmail.com",Name="Uwase melissq",Phone="078882018",sex="Female"},
          new Student{Id=1,Email="umutoni@gmail.com",Name="Uwase melissq",Phone="078882018",sex="Female"
        }
        };
    }
    }
}