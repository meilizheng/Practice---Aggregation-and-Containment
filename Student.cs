using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Aggregation_and_Containment
{
    public class Student
    {
        //creat field
        string _FirstName;
        string _LastName;
        int _CsiGrade;
        int _GenEdGrade;

        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)//creat the constructor take all arguments.
        {
            _FirstName = firstName;
            _LastName = lastName;
            _CsiGrade = csiGrade;
            _GenEdGrade = genEdGrade;
        }

        public string FirstName { get => _FirstName; set => _FirstName = value; } //creat the properties.
        public string LastName { get => _LastName; set => _LastName = value; }
        public int CsiGrade { get => _CsiGrade; set => _CsiGrade = value; }
        public int GenEdGrade { get => _GenEdGrade; set => _GenEdGrade = value; }

        public override string ToString()//display 
        {
            return $"{_FirstName} {_LastName} CSI Grade: {_CsiGrade} GenEd Grade: {_GenEdGrade}";
        }
    }
}
