	class DB
    {
        private SqlConnection connection;

        public SqlConnection Connection
        {
            get
            {
                return this.connection;
            }
        }

        public DB()
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=HR;Trusted_Connection=True;");
                this.connection = sqlConn;
            }catch(SqlException sqle)
            {
                Console.WriteLine("Connection Error");
            }
        }
    }
	
	class EmployeeCRUD
    {
        private SqlConnection connection;

        public EmployeeCRUD()
        {
            DB db = new DB();
            connection = db.Connection;
        }

        public List<Dictionary<string, string>> SelectEmployees() {
            List<Dictionary<string, string>> employees = new List<Dictionary<string, string>>();
            try
            {
                connection.Open();
            }
            catch(SqlException sqle) {
                Console.WriteLine("Connection error");
            }
            SqlCommand command = new SqlCommand("select * from hr.hr.copy_emp", connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Dictionary<string, string> employee = new Dictionary<string, string>();
                employee.Add("employee_id", reader["employee_id"].ToString());
                employee.Add("first_name", reader["first_name"].ToString());
                employee.Add("last_name", reader["last_name"].ToString());
                employee.Add("email", reader["email"].ToString());

                employees.Add(employee);
            }

            connection.Close();
            return employees;
        }

        public Dictionary<string, string> SelectEmployees(int employeeId) {
            Dictionary<string, string> employee = null;
            connection.Open();

            SqlCommand command = new SqlCommand("select * from hr.hr.copy_emp where employee_id = @empId", connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                employee = new Dictionary<string, string>();
                employee.Add("employee_id", reader["employee_id"].ToString());
                employee.Add("first_name", reader["first_name"].ToString());
                employee.Add("last_name", reader["last_name"].ToString());
                employee.Add("email", reader["email"].ToString());
            }

            connection.Close();
            return employee;
        }

        public void InsertEmployee(int employeeId, string firstName, string lastName, string email) {
            connection.Open();

            SqlCommand command = new SqlCommand("insert into hr.hr.copy_emp(employee_id, first_name, last_name, email) values(@empId, @firstName, @lastName, @email)", connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@email", email);
            command.ExecuteNonQuery();
            Console.WriteLine("Insert success with employee_id {0}", employeeId);

            connection.Close();
        }
		
		public void InsertEmployee(Dictionary<string, string> employee) {
            connection.Open();

            SqlCommand command = new SqlCommand("insert into hr.hr.copy_emp(employee_id, first_name, last_name, email) values(@empId, @firstName, @lastName, @email)", connection);
            command.Parameters.AddWithValue("@empId", employee["employee_id"]);
            command.Parameters.AddWithValue("@firstName", employee["first_name"]);
            command.Parameters.AddWithValue("@lastName", employee["last_name"]);
            command.Parameters.AddWithValue("@email", employee["email"]);
            command.ExecuteNonQuery();
            Console.WriteLine("Insert success with employee_id {0}", employee["employee_id"]);

            connection.Close();
        }

        public void Delete(int employeeId)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("delete from hr.copy_emp where employee_id = @empID", connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.ExecuteNonQuery();
            Console.WriteLine("Delete success with employee_id {0}", employeeId);

            connection.Close();
        }

        public void UpdateEmployee(int employeeId, string firstName, string lastName, string email)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("update hr.copy_emp set first_name = @firstName, last_name = @lastName, email = @email where employee_id = @empId", connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@email", email);
            if(command.ExecuteNonQuery() < 1)
            {
                Console.WriteLine("Data tidak ditemukan");
            }
            else {
                Console.WriteLine("Update success with employee_id {0}", employeeId);
            }

            connection.Close();
        }

        public void SelectByFirstName(string firstName) {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from hr.hr.copy_emp where first_name = @firstName", connection);
            command.Parameters.AddWithValue("@firstName", firstName);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("First Name : {0} - Last Name : {1} - Email : {2}", reader["first_name"], reader["last_name"], reader["email"]);
            }

            connection.Close();
        }
    }
	
	class Program
    {
        static void Main(string[] args)
        {
            EmployeeCRUD crud = new EmployeeCRUD();
            crud.InsertEmployee(1234, "Test", "Test 2", "test@mail.com");
            crud.SelectByFirstName("Test");
            crud.UpdateEmployee(1234, "Test Test", "Test 1", "test@mail.com");
            crud.SelectEmployees(1234);
            crud.Delete(1234);
			
			// Employees with Dictionary
            List<Dictionary<string, string>> employees = crud.SelectEmployees();
            foreach(Dictionary<string, string> employee in employees)
            {
                Console.WriteLine("Emp ID : {0}, Name : {1} {2}", employee["employee_id"], employee["first_name"], employee["last_name"]);
            }
			// Select Single Employee
			Dictionary<string, string> employee = crud.SelectEmployees(222);
            Console.WriteLine("{0} {1} {2}", employee["employee_id"], employee["first_name"], employee["last_name"]);
			
			// Insert Employee Using Dictionary
			Dictionary<string, string> employee = new Dictionary<string, string>();

            employee.Add("employee_id", "456");
            employee.Add("first_name", "Galih");
            employee.Add("last_name", "Anggara");
            employee.Add("email", "galih@mail.com");

            crud.InsertEmployee(employee);

            Dictionary<string, string> employee2 = crud.SelectEmployees(456);

            Console.WriteLine("{0} {1}", employee2["employee_id"], employee2["first_name"], employee2["last_name"]);
			
            Console.ReadKey();
        }
    }