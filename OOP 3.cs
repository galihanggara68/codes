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
        private int nik;

        public int NIK {
            set
            {
                this.nik = value;
            }
            get
            {
                return this.nik;
            }
        }

        public void Work()
        {
            Console.WriteLine("I am working");
        }
    }

    class Student : Person
    {
        private int nis;

        public int NIS
        {
            set
            {
                this.nis = value;
            }
            get
            {
                return this.nis;
            }
        }

        public void Study()
        {
            Console.WriteLine("I am studying");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Person person;

            employee.NIK = 2045;
            employee.Name = "Jhon";
            employee.Address = "LA";
            employee.Age = 25;
            Console.WriteLine("{0} {1} {2} {3}", employee.NIK, employee.Name, employee.Address, employee.Age);

            person = employee;
            Console.WriteLine("{0} {1} {2}", person.Name, person.Address, person.Age);
            Employee empTmp = (Employee)person;
            Console.WriteLine("{0} {1} {2} {3}", empTmp.NIK, empTmp.Name, empTmp.Address, empTmp.Age);

            Console.ReadKey();
        }
    }