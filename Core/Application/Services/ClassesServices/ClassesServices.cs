using Domain.Entities;
namespace Application.Services.ClassesServices
{
   public class ClassesService : IClassServices
    {
        public List<ClassJua>GetAllClasses()
        {
            return new List<ClassJua>
            {
               new ClassJua{Id=1,EducationLevel="Bacherlor",Faculty="Accountant",Department="Finance",Session="valo@gmail.com"},
             new ClassJua{Id=2,EducationLevel="Bacherlor",Faculty="Accountant",Department="Finance",Session="valo@gmail.com"},
             new ClassJua{Id=3,EducationLevel="Bacherlor",Faculty="Accountant",Department="Finance", Session ="valo@gmail.com"}
                
            };
        }
         }
          }
