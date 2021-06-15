using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Data
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 20; i++)
            {
                students.Add(new Student
                {
                    Name = "name" + i,
                    Age = i
                });
            }

            return students;
        }
    }
}
