namespace Registrar;

public class Course
{
  public string Code { get; set; } = "";
  public string Title { get; set; } = "";
  public int WeeklyHours { get; set; }
  public bool isEnrolled { get; set; } = false;

  public override string ToString()
  {
      return Code + " " + Title + " " + WeeklyHours.ToString() + (WeeklyHours==1 ? "hour":" hours") + " per week";
  }
}
