using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeOrder
{
    class Student : IComparable
    {
        // Implement the Student class here
        // ...
        private string student;
        private int grade;
        private string degree;
        private string lastName;
        private string firstName;

        private int compare;
        private int compareGrade;
        private int compareDegree;
        private int compareLastName;
        private int compareFirstName;

        public Student(string firstName, string lastName, string degree, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.degree = degree;
            this.grade = grade;
        }

        public int CompareTo(Object o)
        {
            Student temp = (Student)o;
            compareGrade = string.Compare(grade.ToString(), temp.grade.ToString());
            compareDegree = string.Compare(degree, temp.degree);
            compareLastName = string.Compare(lastName, temp.lastName);
            compareFirstName = string.Compare(firstName, temp.firstName);

            if (compareGrade == 0)
            {
                if (compareDegree == 0)
                {
                    if (compareLastName == 0)
                    {
                        if (compareFirstName == 0)
                        {
                            // do nothing
                        }
                        else
                        {
                            compare = compareFirstName;
                        }
                    }
                    else
                    {
                        compare = compareLastName * -1;
                    }
                }
                else
                {
                    compare = compareDegree;
                }
            }
            else
            {
                compare = compareGrade * -1;
            }
            return compare;
        }

        public override string ToString()
        {
            student = lastName + ", " + firstName + " (" + degree + ") "
                + "Grade: " + grade.ToString();
            return student;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Jane", "Smith", "Bachelor of Engineering", 6),
                new Student("John", "Smith", "Bachelor of Engineering", 7),
                new Student("John", "Smith", "Bachelor of IT", 7),
                new Student("John", "Smith", "Bachelor of IT", 6),
                new Student("Jane", "Smith", "Bachelor of IT", 6),
                new Student("John", "Bloggs", "Bachelor of IT", 6),
                new Student("John", "Bloggs", "Bachelor of Engineering", 6),
                new Student("John", "Bloggs", "Bachelor of IT", 7),
                new Student("John", "Smith", "Bachelor of Engineering", 6),
                new Student("Jane", "Smith", "Bachelor of Engineering", 7),
                new Student("Jane", "Bloggs", "Bachelor of IT", 6),
                new Student("Jane", "Bloggs", "Bachelor of Engineering", 6),
                new Student("Jane", "Bloggs", "Bachelor of Engineering", 7),
                new Student("Jane", "Smith", "Bachelor of IT", 7),
                new Student("John", "Bloggs", "Bachelor of Engineering", 7),
                new Student("Jane", "Bloggs", "Bachelor of IT", 7),
            };

            Array.Sort(students);
            foreach (Student student in students)
            {
                Console.WriteLine("{0}", student);
            }

            Console.WriteLine("\nPress enter to exit.");
            Console.ReadLine();
        }
    }
}
