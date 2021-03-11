namespace People.Lib
{
    public class PersonFactory : IPersonFactory
    {
        string _name = string.Empty;

        public IPersonFactory SetName(string n)
        {
            _name = n;
            return this;
        }

        public Student MakeStudent()
        {
            if (string.IsNullOrWhiteSpace(_name))
                throw new StudentException("Student's name cannot be null");

            return new Student(_name);
        }

        public Teacher MakeTeacher()
        {
            if (string.IsNullOrWhiteSpace(_name))
                throw new TeacherException("Teacher's name cannot be null");

            return new Teacher(_name);
        }
    }
}
