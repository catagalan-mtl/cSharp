using System;

namespace schoolEFTutorial;

public class Grade
{
  // public Grade()
  // {
  //   Students = new List<Student>();
  // }
  public int Id { get; set; }
  public string? GradeName { get; set; }

  public IList<Student> Students { get; set; } = new List<Student>();
}
