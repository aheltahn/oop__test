using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Course : Department
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public Lecturer Lecturer { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public List<Student> EnrolledStudents = new List<Student>();

        public void AddStudent(Student student)
        {
            this.EnrolledStudents.Add(student); 
        }
        public void RemoveStudent(Student student)
        {
            this.EnrolledStudents.Remove(student);
        }

        public void AddLecturer(Lecturer lecturer)
        {
            this.Lecturer = lecturer;
        }
    }
}