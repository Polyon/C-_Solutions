namespace UseStudent
{
    public class Student
    {
        private string _name;
        private int _rollno;
        private string _course;
        private double _serviceTax;
        private double _feepaid;

        public Student(string name, int rollno, string course)
        {
            this._name = name;
            this._rollno = rollno;
            this._course = course;
        }

        public double dueAmount
        {
            get{
                return this._feepaid;
            }
            set{
                if(this._course == "C#")
                    this._feepaid = 2000.00;
                else if(this._course == "ASP.NET")
                    this._feepaid = 3000.00;
                else
                    this._feepaid = 5000.00;
            }
        }
        public double tax
        {
            get
            {
                return this._serviceTax;
            }
            set
            {
                this._serviceTax = 12.3;
            }
        }

        public double totalfee
        {
            get
            {
                return this._feepaid;
            }

            set
            {
                this._feepaid = this._feepaid*this._serviceTax/100.00;
            }

        }

        public string payment()
        {
            return "Total Amount:"+this._feepaid;
        }
        public void print()
        {
            Console.WriteLine("Name: {0}\nCourse: {1}\nFee: {3}",this._name,this._course,payment());
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter roll:");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter course:");
            string course = Console.ReadLine();

            Student student = new Student(name,roll,course);
            student.print();
        }
    }
}