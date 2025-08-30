namespace ConsoleApp1
{
    public class Program
    {
        static ListStudent listStudent = new ListStudent();

        public static bool OnStudentAdded(Student student1, Student student2)
        {
            return student1.GPA > student2.GPA;
        }

 
        public static void DisplayStudents()
        {
            Console.WriteLine("List student after sort: ");
            listStudent.ShowStudents();
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            listStudent.StudentAdded += OnStudentAdded;

            listStudent.AddStudent(new Student(1, "Nguyen Van A", 3.5), false);
            listStudent.AddStudent(new Student(2, "Tran Thi B", 3.8), false);
            listStudent.AddStudent(new Student(3, "Le Van C", 3.2), false);
            listStudent.AddStudent(new Student(4, "Pham Thi D", 3.9), false);
            listStudent.AddStudent(new Student(5, "Hoang Van E", 3.1), false);

            Console.WriteLine("List student before sort: ");
            listStudent.ShowStudents();
            Console.WriteLine();

            listStudent.Sort();

            DisplayStudents();

            Console.ReadLine();
        }
    }
}/*
Lớp Student có các thuộc tính ID. name, gpa 
Sử dụng delegate và event để giải quyết các vấn đề sau:
- Cho phép sắp xếp các Student trong một list dựa trên delegate (tăng hay giảm tùy ý)
- Mỗi lần bổ sung thêm một sinh viên mới vào trong cấu trúc list, một sự kiện event được sinh ra để sắp xếp sinh viên trong list
*/