namespace TSXtheoKhoa
{
    
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


        // Lớp Student kế thừa INDENTITY và đại diện cho một sinh viên
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
        public class Department : IListStudent
        {
            public string DepartmentID { get; set; }
            public string DepartmentName { get; set; }
            public string Lecturer { get; set; }
            private List<Student> ListStudents { get; set; }

            public Department(string departmentID, string departmentName, string lecturer)
            {
                DepartmentID = departmentID;
                DepartmentName = departmentName;
                Lecturer = lecturer;
                ListStudents = new List<Student>();
            }

            
            public void AddStudent(Student student)
            {
                ListStudents.Add(student);
            }

           
            public void RemoveStudent(int studentID)
            {
                Student student = ListStudents.Find(s => s.ID == studentID);
                if (student != null)
                {
                    ListStudents.Remove(student);
                    Console.WriteLine($"Đã xóa sinh viên với ID: {studentID}");
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy sinh viên với ID: {studentID}");
                }
            }

          
            public void DeleteStudent(int studentID)
            {
                RemoveStudent(studentID);
            }

         
            public void UpdateStudent(Student updatedStudent)
            {
                Student student = ListStudents.Find(s => s.ID == updatedStudent.ID);
                if (student != null)
                {
                    student = updatedStudent;
                }
            }

        
            public Student FindStudent(int studentID)
            {
                return ListStudents.Find(s => s.ID == studentID);
            }

          
            public List<Student> GetAllStudents()
            {
                return new List<Student>(ListStudents);
            }
        }
    }

