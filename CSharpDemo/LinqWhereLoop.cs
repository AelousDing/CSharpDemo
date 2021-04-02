using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    public class LinqWhereLoop
    {
        public static void Run()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 200000; i++)
            {
                list.Add(i);
            }
            DateTime dt1 = DateTime.Now;
            var ll = list.Select(a => a).ToList();
            Data.GetStudents().Where(p => ll.Any(a => a == p.Age)).ToList();
            DateTime dt2 = DateTime.Now;
            Console.WriteLine($"1:{dt2.Ticks - dt1.Ticks}");

            DateTime dt5 = DateTime.Now;
            Data.GetStudents().Where(p => list.Select(a => a).Any(a => a == p.Age)).ToList();
            DateTime dt6 = DateTime.Now;
            Console.WriteLine($"2:{dt6.Ticks - dt5.Ticks}");


            DateTime dt3 = DateTime.Now;
            var l = list.Select(p => p).ToList();
            Data.GetStudents().Where(p => l.Contains(p.Age)).ToList();
            DateTime dt4 = DateTime.Now;
            Console.WriteLine($"3:{dt4.Ticks - dt3.Ticks}");
        }
    }
}
