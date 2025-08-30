using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void StudentAddHandler();
    public class ListStudent
    {
        private List<Student> students = new List<Student>();

        // Sự kiên thêm sinh viên
        public event StudentAddHandler StudentAdded;

        // Phương thức thêm sinh viên
        public void AddStudent(Student student, bool triggerEvent = true)
        {
            students.Add(student);
            if (triggerEvent)
            {
                Sort();
            }
        }

        public void Sort()
        {
            BubbleSort(students);
            if (StudentAdded != null)
            {
                // Gọi sự kiện
                StudentAdded();
            }
        }
        // Phương thức sắp xếp sinh viên dựa trên delegate
        public void BubbleSort(List<Student> listStudent)
        {
            for (int i = 0; i < listStudent.Count - 1; i++)
            {
                for (int j = 0; j < listStudent.Count - i - 1; j++)
                {
                    if (listStudent[j].GPA > listStudent[j + 1].GPA)
                    {
                        Student temp = listStudent[j];
                        listStudent[j] = listStudent[j + 1];
                        listStudent[j + 1] = temp;
                    }
                }
            }
        }

        public void ShowStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Info());
            }
        }
    }
}
