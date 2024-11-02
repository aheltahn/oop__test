    
        // định danh các đối tượng có ID và Name
        public interface INDENTITY
        {
            int ID { get; }
            string Name { get; }
        }

        // trừu tượng hóa thao tác quản lý sinh viên
        public interface IListStudent
        {
            void AddStudent(Student student);
            void RemoveStudent(int studentID);
            void UpdateStudent(Student updatedStudent);
            Student FindStudent(int studentID);
            List<Student> GetAllStudents();
        }


        // LopStudent
        public class Student : INDENTITY
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int DepartmentID { get; set; }
            public string DepartmentName { get; set; }

            public Student(int id, string name, int departmentID, string departmentName)
            {
                ID = id;
                Name = name;
                DepartmentID = departmentID;
                DepartmentName = departmentName;
            }
        }
        
      //LopDepartment
    public class Department : IListStudent
{
    public int DepartmentID { get; set; }
    public string DepartmentName { get; set; }
    private List<Student> ListStudents { get; set; }
    
    public Department(int departmentID, string departmentName)
    {
        DepartmentID = departmentID;
        DepartmentName = departmentName;
        ListStudents = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        ListStudents.Add(student);
    }

    public void RemoveStudent(int studentID)
    {
        Student studentToRemove = FindStudent(studentID);
        if (studentToRemove != null)
        {
            ListStudents.Remove(studentToRemove);
            Console.WriteLine($"Đã xóa sinh viên với ID: {studentID}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sinh viên với ID: {studentID}");
        }
    }

    public void UpdateStudent(Student updatedStudent)
    {
        foreach (Student student in ListStudents)
        {
            if (student.ID == updatedStudent.ID)
            {
                student.Name = updatedStudent.Name;
                student.DepartmentID = updatedStudent.DepartmentID;
                student.DepartmentName = updatedStudent.DepartmentName;
                Console.WriteLine($"Đã cập nhật sinh viên với ID: {student.ID}");
                return;
            }
        }
        Console.WriteLine($"Không tìm thấy sinh viên để cập nhật với ID: {updatedStudent.ID}");
    }

    public Student FindStudent(int studentID)
    {
        foreach (Student student in ListStudents)
        {
            if (student.ID == studentID)
            {
                return student;
            }
        }
        return null; 
    }

    public List<Student> GetAllStudents()
    {
        return new List<Student>(ListStudents);
    }
   }

    

