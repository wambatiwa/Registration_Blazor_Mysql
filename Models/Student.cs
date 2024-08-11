

using Registrar.Models;

namespace Registrar;

public class Student
{
   
    public int Id { get; set; } = new Random().Next(100000, 999999);
    
    public string? FirstName { get; set; }
   
    public string? LastName { get; set; }
  
    public string? Type { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
     public List<CheckBoxItem> MyCourses {get;set;} = [];
  
}
