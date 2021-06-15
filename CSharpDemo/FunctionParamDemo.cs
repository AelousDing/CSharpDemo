using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpDemo
{
    public class FunctionParamDemo
    {
        public static void Run()
        {
            var students = Data.GetStudents().AsQueryable();
            Query(students);
            var sts = students.ToList();
            foreach (var student in sts)
            {
                Console.WriteLine($"{student.Name} {student.Age}");
            }
        }
        private static void Query(IQueryable<Student> students)
        {
            students = students.Where(p => p.Age > 15);
        }
    }
}
