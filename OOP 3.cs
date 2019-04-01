class Person {
        private string name;
        private string address;
        private int age;

        public string Name {
            set {
                this.name = value;
            }
            get {
                return this.name;
            }
        }

        public string Address
        {
            set
            {
                this.address = value;
            }
            get
            {
                return this.address;
            }
        }

        public int Age {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }

        public void Eat() {
            Console.WriteLine("I am eating");
        }

        public void Sleep() {
            Console.WriteLine("I am sleeping");
        }
    }

    class Employee : Person
    {

    }

    class Student : Person
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Person();
            Student student2 = new Student();
            student.Eat();
            student.Sleep();


            Console.ReadKey();
        }
    }