using SchoolSis.Utilities;

namespace SchoolSis
{
  public class DataContext
  {
    public static int StudentId { get; set; } = 1;
        public static int CourseId { get; set; } = 1;
        public static int TeacherId { get; set; } = 1;
    public List<Student> Students { get; set; }
    public List<Course> Courses { get; set; }
    public List<Teacher> Teachers { get; set; }
    public DataContext()
    {
      Students = new List<Student> { new Student { Id = StudentId++,Name="Ruth", Age=15, Status=1 },
            new Student { Id = StudentId++,Name="Miri", Age=19, Status=1 },
            new Student { Id = StudentId++,Name="Ayala", Age=16, Status=1 }
      };
      Courses = new List<Course> { new Course { Id = CourseId++, Name="History" ,Description="A short and concise course in the history of the Jewish people"},
            new Course { Id = CourseId++, Name="English" ,Description="English course for beginners in the basics of the language"},
            new Course { Id = CourseId++, Name="Math" ,Description="A deep and theoretical course in the field of group theory"}
      };
      Teachers = new List<Teacher> { new Teacher { Id = TeacherId++ , Name="Tachan", Subject="History" ,Status=1},
            new Teacher { Id = TeacherId++ , Name="Frid", Subject="Math" ,Status=1},
            new Teacher { Id = TeacherId++ , Name="Davidoviz", Subject="English" ,Status=1}
      };
    }
  }
}
