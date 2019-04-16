using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                UpdateDataGrid();
        }

        private void UpdateDataGrid() {
            using(HREntities hr = new HREntities())
            {
                // Membuat Data Table untuk dijadikan DataSource GridView
                DataTable dataTable = new DataTable("employee");

                // Menambahkan colum/field ke Data Table
                dataTable.Columns.Add("EmployeeId");
                dataTable.Columns.Add("FirstName");
                dataTable.Columns.Add("LastName");
                dataTable.Columns.Add("Email");

                // Mengambil data Employee untuk dimasukan ke dalam Data Table
                List<COPY_EMP> employees = (from COPY_EMP emp in hr.COPY_EMP
                                            select emp).ToList();
                foreach(COPY_EMP emp in employees)
                {
                    dataTable.Rows.Add(emp.EMPLOYEE_ID, emp.FIRST_NAME, emp.LAST_NAME, emp.EMAIL);
                }

                // Set DataSource GridView 
                EmployeeGrid.DataSource = dataTable;
                EmployeeGrid.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                using(HREntities hr = new HREntities())
                {
                    int employeeId = int.Parse(txtEmployeeId.Text);
                    string firstName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    string email = txtEmail.Text;

                    COPY_EMP employee = new COPY_EMP
                    {
                        EMPLOYEE_ID = employeeId,
                        FIRST_NAME = firstName,
                        LAST_NAME = lastName,
                        EMAIL = email
                    };

                    hr.COPY_EMP.Add(employee);
                    hr.SaveChanges();
                }
                UpdateDataGrid();
            }
        }

        protected void EmployeeGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using(HREntities hr = new HREntities())
            {
                GridViewRow row = EmployeeGrid.Rows[e.RowIndex];
                int employeeId = int.Parse(row.Cells[1].Text);
                COPY_EMP emp = hr.COPY_EMP.Find(employeeId);
                hr.COPY_EMP.Remove(emp);
                hr.SaveChanges();
            }
            UpdateDataGrid();
        }

        protected void EmployeeGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            EmployeeGrid.EditIndex = e.NewEditIndex;
            UpdateDataGrid();
        }

        protected void EmployeeGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            EmployeeGrid.EditIndex = -1;
            UpdateDataGrid();
        }

        protected void EmployeeGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            using(HREntities hr = new HREntities())
            {
                GridViewRow row = EmployeeGrid.Rows[e.RowIndex];
                TextBox textmployeeId = row.Cells[1].Controls[0] as TextBox;
                int employeeId = int.Parse(textmployeeId.Text);
                TextBox textFirstName = row.Cells[2].Controls[0] as TextBox;
                string firstName = textFirstName.Text;
                TextBox textLastName = row.Cells[3].Controls[0] as TextBox;
                string lastName = textLastName.Text;
                TextBox textEmail = row.Cells[4].Controls[0] as TextBox;
                string email = textEmail.Text;

                COPY_EMP employee = new COPY_EMP {
                    EMPLOYEE_ID = employeeId,
                    FIRST_NAME = firstName,
                    LAST_NAME = lastName,
                    EMAIL = email
                };
                hr.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                hr.SaveChanges();
            }
            EmployeeGrid.EditIndex = -1;
            UpdateDataGrid();
        }

        protected void txtEmpValid_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            try
            {
                int employeeId = int.Parse(args.Value);
            }catch(FormatException e)
            {
                args.IsValid = false;
            }
        }
    }
}