using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Student
    {
        private int studentAge;
        private string studentName;
        private int studentClass;
        private int studentRollNo;
        private string studentGender;

        public Student(int age, string name, int clas, string gender)
        {
            studentAge = age;
            studentName = name;
            studentClass = clas;
            studentGender = gender;
        }

        public string getStudentName()
        {
            return studentName;
        }
        public int getStudentAge()
        {
            return studentAge;
        }
        public int getStudentClass()
        {
            return studentClass;
        }
        public int getStudentRollNo()
        {
            Random random = new Random();
            int temp = random.Next();
            studentRollNo = (int)(temp*(0.00000001));
            return studentRollNo;
        }
        public string getStudentGender()
        {
            return studentGender;
        }
        public void print()
        {
            Console.WriteLine("\t\t\tAge is: " + this.getStudentAge());
            Console.WriteLine("\t\t\tClass is :" + this.getStudentClass());
            Console.WriteLine("\t\t\tGender is :" + this.getStudentGender());
            Console.WriteLine("\t\t\tName is :" + this.getStudentName());
            Console.WriteLine("\t\t\tRoll No is :" + this.getStudentRollNo());
        }
        public void print(int ch)
        {
            if (ch == (int)StudentAttribute.age)
            {
                Console.WriteLine("\t\t     Your choice is "+StudentAttribute.age);
                Console.WriteLine("\t\t\t Age is {0}", this.getStudentAge());
            }
            else if (ch == (int)StudentAttribute.name)
            {
                Console.WriteLine("\t\t     Your choice is " + StudentAttribute.name);
                Console.WriteLine("\t\t\t Name is {0}", this.getStudentName());
            }
            else if (ch == (int)StudentAttribute.clas)
            {
                Console.WriteLine("\t\t     Your choice is " + StudentAttribute.clas);
                Console.WriteLine("\t\t\t Class is {0}", this.getStudentClass());
            }
            else if (ch == (int)StudentAttribute.gender)
            {
                Console.WriteLine("\t\t     Your choice is " + StudentAttribute.gender);
                Console.WriteLine("\t\t\t Gender is {0}", this.getStudentGender());
            }
            else if (ch == (int)StudentAttribute.rollNo)
            {
                Console.WriteLine("\t\t     Your choice is " + StudentAttribute.rollNo);
                Console.WriteLine("\t\t\t Roll No is {0}", this.getStudentRollNo());
            }
            else
                Console.WriteLine("\t\t\t     Invalid Entry");
                Console.ReadLine();
        }

        enum StudentAttribute
        {
            age, name, clas, gender, rollNo
        };
        static void Main(string[] args)
        {
            Student s1 = new Student(17, "Shubham", 12, "M");            
            Console.WriteLine("\t\t     Welcome to Boys School");
            Console.WriteLine("\t\t      Student details are");
            s1.print();
            Console.WriteLine("\t\t   Options for specific details");
            Console.WriteLine("\t\t\t{0}. For age", (int)StudentAttribute.age);
            Console.WriteLine("\t\t\t{0}. For name", (int)StudentAttribute.name);
            Console.WriteLine("\t\t\t{0}. For age", (int)StudentAttribute.clas);
            Console.WriteLine("\t\t\t{0}. For gender", (int)StudentAttribute.gender);
            Console.WriteLine("\t\t\t{0}. For roll no", (int)StudentAttribute.rollNo);
            Console.Write("\t\t    Please Enter your choice: ");
            
            int ch = int.Parse(Console.ReadLine());
            s1.print(ch);
        }
    }
}