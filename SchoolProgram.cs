using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Aggregation_and_Containment
{
    public class SchoolProgram
    {
        //creat the field
        private string _ClassName;
        private string _ClassNumber;
        private string _RoomNumber;
        private Instructor _Instructor; // Aggregation
        private List<Student> _ClassRoster; // Containment

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor) //creat the constructor take 4 arguments
        {
            _ClassName = className;
            _ClassNumber = classNumber;
            _RoomNumber = roomNumber;
            _Instructor = instructor;
            _ClassRoster = new List<Student>(); //Initialize the List of students inside the constructor
        }

        public string ClassName { get => _ClassName; set => _ClassName = value; }
        public string ClassNumber { get => _ClassNumber; set => _ClassNumber = value; }
        public string RoomNumber { get => _RoomNumber; set => _RoomNumber = value; }
        public Instructor Instructor { get => _Instructor; set => _Instructor = value; }

        public List<Student> ClassRoster { get => _ClassRoster; } //read only

        public void AddStudent(Student student) //Add a student object to the class student list
        {
            _ClassRoster.Add(student);
        }

        public void AddStudent(String fname, string lname, int csi, int genEd)
        {
            Student students = new Student(fname, lname, csi, genEd); //Create a new student object in the method, and add them to the classRoster list.
            _ClassRoster.Add(students);
        }

        public override string ToString()//display result
        {
            return $"{_ClassName} {_ClassNumber} {_RoomNumber} {_Instructor} - Number Of Student: {_ClassRoster.Count}";
        }
    }
}
