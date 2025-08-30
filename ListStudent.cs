using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate bool StudentAddDelegate(Student student1, Student student2);

    public class ListStudent
    {
        private List<Student> students = new List<Student>();
        public event StudentAddDelegate? StudentAdded;

        public void AddStudent(Student student, bool Event = true)
        {
            students.Add(student);
            if (Event)
            {
                Sort();
            }
        }

        public void Sort()
        {
            BubbleSort(students);
        }

        public bool CompareTo(Student student1, Student student2)
        {
            return student1.GPA > student2.GPA;
        }

        public void BubbleSort(List<Student> listStudent)
        {
            for (int i = 0; i < listStudent.Count - 1; i++)
            {
                for (int j = 0; j < listStudent.Count - i - 1; j++)
                {
                    if (CompareTo(listStudent[j], listStudent[j + 1]))
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