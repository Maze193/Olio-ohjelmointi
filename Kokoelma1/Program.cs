using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelma1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            student.students.Add(new Student("Masa", "Niemi", "", ""));
            student.students.Add(new Student("Allan", "Aalto", "A1111", ""));
            student.students.Add(new Student("Hanna", "Husso", "B2222", ""));
            student.students.Add(new Student("Teppo", "Testaaja", "C3333", "TTV17S1"));

            student.Change(student.students);

            foreach(Student opiskelija in student.students)
            {
                Console.WriteLine(opiskelija.ToString());
            }
        }
    }
}
