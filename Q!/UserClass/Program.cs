namespace UserClass
{
    public class Person
    {
        private String _name;
        public Person(String name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return "Name: "+ this._name;
        }

    }

    public class Student : Person
    {
        public Student(String name):base(name)
        {   
        }

        public void study()
        {
            Console.WriteLine("{0}\nStudent is studying.",base.ToString());
        }
    }

    public class Teacher : Person
    {
        public Teacher(String name):base(name)
        {
        }

        public void explain()
        {
            Console.WriteLine("{0}\nTeacher is explaining.",base.ToString());
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person[] person = new Person[3];
            for(int i=0; i<3; i++)
            {
                if(i == 0)
                {
                    Console.Write(">> Enter teacher name: ");
                    person[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    Console.Write(">> Enter student name: ");
                    person[i] = new Student(Console.ReadLine());
                }
            }

            for(int i=0; i<3; i++)
            {
                if(i == 0)
                    ((Teacher)person[i]).explain();
                else
                    ((Student)person[i]).study();
            }
        }
    }
}