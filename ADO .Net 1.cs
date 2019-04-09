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

            SqlCommand command = new SqlCommand("select * from hr.copy_emp", connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("First Name : {0} - Last Name : {1}", reader["first_name"], reader["last_name"]);
            }

            connection.Close();
        }
		
		public void SelectEmployees(int employeeId) {
            connection.Open();

            SqlCommand command = new SqlCommand("select * from hr.copy_emp where employee_id = @empId", connection);
            command.Parameters.AddWithValue("@empId", employeeId);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("First Name : {0} - Last Name : {1}", reader["first_name"], reader["last_name"]);
            }

            connection.Close();
        }
    }
	
	class Program
    {
        static void Main(string[] args)
        {
            EmployeeCRUD crud = new EmployeeCRUD();
            crud.SelectEmployees();

            Console.ReadKey();
        }
    }