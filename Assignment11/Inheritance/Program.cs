using System;

namespace Inheritance
{
    public class Student
    {
        public string studenName;
        protected int _age;
        int _rollNo;

        public void setStudentDetail()
        {
            Console.Write("Enter student rolll no :");
            _rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter student age :");
            _age = int.Parse(Console.ReadLine());
            Console.Write("Enter student name :");
            studenName = Console.ReadLine();             
        }

        public void getStudentDetail()
        {
            Console.WriteLine("Student rolll no is :"+ _rollNo);
            Console.WriteLine("Student age is:"+ _age);
            Console.WriteLine("Student name is:"+ studenName);
        }
    }
    class CollegeStudent : Student
    {
        public string collegeName;
        public string studentCourse;
        public string studentCourseYear;

        public void setCollegeStudentDetail()
        {
            Console.Write("Enter College Name :");
            collegeName = Console.ReadLine();
            Console.Write("Enter student Course name :");
            studentCourse = Console.ReadLine();
            Console.Write("Enter Course year :");
            studentCourseYear = Console.ReadLine();
        }

        public void getCollegeStudentDetail()
        {
            Console.WriteLine("College Student Details are");
            Console.WriteLine("College Name is :"+ collegeName);            
            Console.WriteLine("Student Course name is :"+ studentCourse);
            Console.WriteLine("Course year is :"+ studentCourseYear);
        }
        public static void Main()
        {
            CollegeStudent stu = new CollegeStudent();

            Console.WriteLine("Enter details for College Student");
            stu.setCollegeStudentDetail();
            stu.setStudentDetail();
            stu._age = 10;
            Console.WriteLine("");
            stu.getCollegeStudentDetail();
            stu.getStudentDetail();
   
            SchoolStudent stu2 = new SchoolStudent();

            Console.WriteLine("");
            Console.WriteLine("Enter details for School Student");
            stu2.setSchoolStudentDetail();
            stu2.setStudentDetail();
            Console.WriteLine("");
            stu2.getSchoolStudentDetail();
            stu2.getStudentDetail();
            Console.ReadLine();
        }
    }
    class SchoolStudent : Student
    {
        public string schoolName = "Unknown";
        public string studentClass;
      
        public void setSchoolStudentDetail()
        {
            Console.Write("Enter School Name :");
            schoolName = Console.ReadLine();
            Console.Write("Enter student Class :");
            studentClass = Console.ReadLine();
        }

        public void getSchoolStudentDetail()
        {
            Console.WriteLine("School Student Details are");
            Console.WriteLine("School Name is :"+ schoolName);
            Console.WriteLine("Student Class is :"+ studentClass);            
        }
    }
}