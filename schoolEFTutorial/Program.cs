using schoolEFTutorial;

using (var context = new SchoolContext())
{
  context.Database.EnsureCreated();

  var grade1 = new Grade() { GradeName = "Grade 1" };
  var student1 = new Student() { FirstName = "Paul", LastName = "Json", Grade = grade1 };

  context.Students.Add(student1);

  context.SaveChanges();

  foreach (var student in context.Students)
  {
    var studentsGrade = student.GradeId;
    Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}");
    Console.WriteLine($"{student.FirstName} is in {studentsGrade}");
  }

  context.Database.EnsureDeleted();

}
