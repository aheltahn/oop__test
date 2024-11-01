using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace projekt
{
    public class CollegeSystem
    {   
        // Database
        protected static string basePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;

        //Departments
        protected string Department_database = Path.Combine(basePath, "database", "department.json");
        private Manager<Department> _departmentStorage = new Manager<Department>("departments.json");

        //Courses
        protected string Course_database = Path.Combine(basePath, "database", "course.json");
        private Manager<Course> _courseStorage = new Manager<Course>("courses.json");

        //Classes
        protected string MajorClass_database = Path.Combine(basePath, "database", "classroom.json");
        private Manager<MajorClass> _classStorage = new Manager<MajorClass>("majorclass.json");




        //Department logic
        public void AddDepartment(Department department)
        {
            _departmentStorage.Add(department);
        }

        public Department SearchDepartment(string id)
        {
            foreach(Department department in _departmentStorage.GetAll())
            {
                if (department.DepartmentID == id) { return department; };
            }
            return null;
        }

        public void RemoveDepartment(int id)
        {
            return;
        }


        //Course logic
        public void AddCourse(Course course)
        {
            _courseStorage.Add(course);
        }

        public Course SearchCourse(string code)
        {
            foreach (Course course in _courseStorage.GetAll())
            {
                if (course.CourseCode == code) { return course; };
            }
            return null;
        }

        public void RemoveCourse(int id)
        {
            return;
        }
    }
}
