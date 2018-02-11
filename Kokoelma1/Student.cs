using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelma1
{
    class Student
    {
        string answer, person;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioID { get; set; }
        public string Group { get; set; }

        public List<Student> students = new List<Student>();

        public Student()
        {

        }

        public Student(string fname, string lname, string asid, string group)
        {
            FirstName = fname;
            LastName = lname;
            AsioID = asid;
            Group = group;

        }

        public void Change(List<Student> alist)
        {
            string firstn, lastn, aid, gro;
            bool IsID = false;
            do
            {
                Console.WriteLine("Do you want to remove or add students. remove/add");
                answer = Console.ReadLine();
                if (answer == "remove")
                {
                    Console.WriteLine("Who would you like to remove?");
                    person = Console.ReadLine();

                    foreach (Student student in alist)
                    {
                        if (student.FirstName == person || student.LastName == person)
                        {
                            alist.Remove(student);
                            break;
                        }
                    }
                }

                else if (answer == "add")
                {
                    Console.WriteLine("Please give information for the new student");

                    Console.WriteLine("First name:");
                    firstn = Console.ReadLine();

                    Console.WriteLine("Last name:");
                    lastn = Console.ReadLine();

                    do
                    {
                        IsID = false;
                        Console.WriteLine("student number:");
                        aid = Console.ReadLine();

                        foreach(Student studen in alist)
                        {
                            if(aid == studen.AsioID)
                            {
                                IsID = true;
                            }
                        }
                        if(IsID == true)
                        {
                            Console.WriteLine("That ID is already in use, choose another one");
                        }

                    } while (IsID == true);

                    Console.WriteLine("students group:");
                    gro = Console.ReadLine();

                    Student student = new Student(firstn, lastn, aid, gro);
                    alist.Add(student);
                }
            } while (answer == "remove" || answer == "add");

        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + AsioID + " " + Group;
        }

    }

}
