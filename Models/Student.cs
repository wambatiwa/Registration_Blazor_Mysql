

using System.ComponentModel.DataAnnotations;
using Registrar.Models;

namespace Registrar;

public class Student
{
   
    public int Id { get; set; } = new Random().Next(100000, 999999);
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Type { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
     public List<CheckBoxItem> MyCourses {get;set;} = [];
  
}
