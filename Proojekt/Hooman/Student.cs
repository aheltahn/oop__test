using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Student: Human
    {
        public string Major { get; set; }
        public int Year { get; set; }
        public double GPA { get; set; }
        public string SchoolYear { get; set; }

        public List<string> classID = new List<string>();

        public override void DisplayInfo()
        {
            //cá nhân
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Bday: {Bday}");
            Console.WriteLine($"ClassID: {ClassID}");
            //học tập
            Console.WriteLine($"Major: {Major}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"SchoolYear: {SchoolYear}");
            Console.WriteLine($"GPA: {GPA}");
            //liên lạc
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {PhoneNumber}");
        }
    }
}
