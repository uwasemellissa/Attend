using Domain.Entities;
namespace Application.Services.StudentServices
{
   public class StudentService : IStudentService
    {
        public List<Student>GetAllStudent()
        {
            return new List<Student>
            {
               new Student{Id=1,Name="Valentin Blossom",Phone="0788820318",sex="male",Email="valo@gmail.com"},
                new Student{Id=2,Name="Uwase Kevine",Phone="0788820318",sex="female",Email="valo@gmail.com"},
                 new Student{Id=3,Name="Richard mwitende",Phone="0788820318",sex="male",Email="valo@gmail.com"},
                  new Student{Id=1,Name="meli Blossom",Phone="0788820318",sex="male",Email="valo@gmail.com"}
            };
        }
    }

}