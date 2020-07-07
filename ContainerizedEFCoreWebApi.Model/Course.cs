using System.Collections.Generic;

namespace ContainerizedEFCoreWebApi.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int CreditCount { get; set; }
        public IEnumerable<StudentCourse> StudentCourses { get; set; }
    }
}
