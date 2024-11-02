using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tìm kiếm theo ClassID rồi in ra
            List<Student> result = majorClass.FindByClassID("IT0001");
            majorClass.PrintStudents(result);
        }
    }
}
