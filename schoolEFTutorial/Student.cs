using System;

namespace schoolEFTutorial;

public class Student
{
  public int Id { get; set; }
  public string? FirstName { get; set; }
  public string? LastName { get; set; }

  public int GradeId { get; set; }
  public Grade? Grade { get; set; }

}
