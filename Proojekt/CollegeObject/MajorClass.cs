using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class MajorClass: Department
    {
        /// <summary>
        /// Đại diện cho một Lớp Học, gồm nhiều Học Sinh.
        /// 
        /// </summary>
        public string ID { get; set; }
        public List<Student> students = new List<Student>();
                public List<Student> FindByClassID(String ClassIDFinding)
        {
            List<Student> ClassIDSearchResult = new List<Student>();
            foreach (Student s in Students)
            {
                if (s.ClassID.Equals(ClassIDFinding, StringComparison.OrdinalIgnoreCase))
                {
                    ClassIDSearchResult.Add(s);
                }
            }
            return ClassIDSearchResult;
        }
        public void PrintStudents(List<Student> ClassIDSearchResult)
        {
            foreach (Student s in ClassIDSearchResult)
            {
                Console.WriteLine($"ID: {s.ID}");
                Console.WriteLine($"Name: {s.Name}");
                Console.WriteLine($"Gender: {s.Gender}");
                Console.WriteLine($"Bday: {s.Bday}");
                Console.WriteLine($"ClassID: {s.ClassID}");

                Console.WriteLine($"Major: {s.Major}");
                Console.WriteLine($"Year: {s.Year}");
                Console.WriteLine($"SchoolYear: {s.SchoolYear}");
                Console.WriteLine($"GPA: {s.GPA}");

                Console.WriteLine($"Email: {s.Email}");
                Console.WriteLine($"Phone: {s.PhoneNumber}");
            }
        }
    }
}
