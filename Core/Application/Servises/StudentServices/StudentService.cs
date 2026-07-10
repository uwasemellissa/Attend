namespace Core.Application.Servises.StudentServices
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
        public class Student{
        public int Id{get;set;}
        public string Name { get;set;}
        public string Phone {get; set;}
        public string sex {get; set;}
        public string Email {get; set;}
     
    
    }
}