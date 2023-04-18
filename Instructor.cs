using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Meili Zheng
//4/18/2023
//Practice Aggregation and Containment

namespace Practice___Aggregation_and_Containment
{
    public class Instructor
    {
        //creat the field;
        string _FirstName;
        string _LastName;

        public Instructor(string firstName, string lastName)//creat the constructor take two arguments
        {
            _FirstName = firstName;
            _LastName = lastName;
        }

        public string FirstName { get => _FirstName; set => _FirstName = value; }//creat the properties
        public string LastName { get => _LastName; set => _LastName = value; }

        public override string ToString() //use override to display imformation.
        {
            return $"Instructor: {_FirstName}  {_LastName}";
        }
    }
}
