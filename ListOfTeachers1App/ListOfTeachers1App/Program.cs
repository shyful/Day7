using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfTeachers1App
{
    class Program
    {
        static void Main(string[] args)
        {
            list<Teacher> aStudentList=new list<Teacher>();

            Teacher teacher1=new Teacher();

            teacher1.dept = "EEE";
            teacher1.firstName = "Azad";
            teacher1.lastName = "Kalam";

            Teacher teacher2 = new Teacher();

            teacher2.dept = "CSE";
            teacher2.firstName = "Fohrukh";
            teacher2.lastName = "Zaman";

            Teacher teacher3 = new Teacher();

            teacher3.dept = "ETE";
            teacher3.firstName = "Niton";
            teacher3.lastName = "Zaman";

            Teacher.add = (teacher1);
            Teacher.add = (teacher2);
            Teacher.add = (teacher3);

            foreach (Teacher aTeacher in teachers)
            {
                Console.WriteLine("Dept:" + aTeacher.dept + " " + aTeacher.GetFullName());
            }

            Console.ReadKey();
        }
    }
}
