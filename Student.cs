using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private int id;
        private string name;
        private double gpa;

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double GPA { get { return gpa; } set { gpa = value; } }

        public Student(int id, string name, double gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        }

        public string Info()
        {
            return $"ID: {id}, Name: {name}, GPA: {gpa}";
        }
    }
}
