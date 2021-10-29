using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAndrew
{
    class Student
    {
        #region Public class fields (Properties)
        /// <summary>
        /// Gets or sets student surname
        /// </summary>
        public string Surname { get; private set; } // private set means; Only this class can change value inside class

        /// <summary>
        /// Gets or sets student course
        /// </summary>
        public int Course { get; set; } 
    
        /// <summary>
        /// Gets or sets student name
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Constructors

        public Student()
        {

        }

        public Student(string surname)
        {
            this.Surname = surname;
        }

        public Student(string name, int course)
        {
            this.Name = name;
            this.Course = course;
        }
        #endregion

        #region Functions
        public static int Calculate()
        {
            return default;
        }

        public static void Display()
        {
            Console.WriteLine("Output");
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            // if you wanna use as array
            List<Student> students = new List<Student>();

            // if you wanna use as individually
            Student student = new Student();

            // functions
            Student.Display();
            Student.Calculate();
        }
    }
}
