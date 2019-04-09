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

        public void SelectEmployees() {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from hr.hr.copy_emp", connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("First Name : {0} - Last Name : {1} - Email : {2}", reader["first_name"], reader["last_name"], reader["email"]);
            }

            connection.Close();
        }

        public void SelectEmployees(int employeeId) {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from hr.hr.copy_emp where employee_id = @empId", connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("First Name : {0} - Last Name : {1} - Email : {2}", reader["first_name"], reader["last_name"], reader["email"]);
            }

            connection.Close();
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
            command.ExecuteNonQuery();
            Console.WriteLine("Update success with employee_id {0}", employeeId);

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
            crud.SelectEmployees();

            Console.ReadKey();
        }
    }