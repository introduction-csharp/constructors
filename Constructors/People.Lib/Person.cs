using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Lib
{
    public abstract class Person
    {
        protected readonly string _name;
        protected Person(string name)
        {
            _name = name;
        }
    }

    public class Student : Person 
    {
        // if we're only interested in students having a date of birth 
        DateTime _dateOfBirth;

        // by making the constructor internal, the code that uses this class will be restricted to this library
        // this helps validate the data, controlling how objects are created 

        // the base() function calls the Person constructor _before_ the rest of the block is called 
        internal Student(string name) : base(name) {
            _dateOfBirth = DateTime.MinValue; // this seems a good, not null, default value - a very long time ago 
        }

        // the this(string) function calls the only Student constructor _before_ the rest of the block is called 
        internal Student(string name, DateTime dob) : this(name)
        {
            _dateOfBirth = dob;
        }
    }
    public class Teacher : Person 
    {
        internal Teacher(string name) : base(name) { }
    }


    public abstract class PersonException : Exception
    {
        protected PersonException(string msg) : base(msg) { }
    }

    public class StudentException : PersonException
    {
        public StudentException(string msg) : base(msg) { }
    }

    public class TeacherException : PersonException
    {
        public TeacherException(string msg) : base(msg) { }
    }
}
