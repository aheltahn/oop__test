using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace projekt
{
    public class Department
    {
        public string DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        private List<Course> CourseOffered { get; set; }
        private List<Lecturer> Lecturers { get; set; }
        private List<MajorClass> MajorClasses { get; set; }

        public void AddCourse(Course course)
        {
            if (this.CourseOffered.Contains(course)) {  return; }
            this.CourseOffered.Add(course); 
        }
        //Courses
        public void RemoveCourse(Course course)
        {
            if (!this.CourseOffered.Contains(course)) { return; }
            this.CourseOffered.Remove(course);
        }
        //Lecturers
        public void AddLecturer(Lecturer lecturer)
        {
            if (this.Lecturers.Contains(lecturer)) { return; }
            this.Lecturers.Add(lecturer);
        }

        public void RemoveLecturer(Lecturer lecturer)
        {
            if (!this.Lecturers.Contains(lecturer)) { return; }
            this.Lecturers.Remove(lecturer);
        }
        //Classes
        public void AddClass(MajorClass majorclass)
        {
            if (this.MajorClasses.Contains(majorclass)) { return; }
            this.MajorClasses.Add(majorclass);
        }

        public void RemoveClass(MajorClass majorclass)
        {
            if (!this.MajorClasses.Contains(majorclass)) { return; }
            this.MajorClasses.Remove(majorclass);
        }
    }

}
