using System.Collections.Generic;

namespace ContainerizedEFCoreWebApi.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public IEnumerable<StudentCourse> StudentCourses { get; set; }
    }
}
