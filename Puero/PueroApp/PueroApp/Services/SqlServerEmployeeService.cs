using PueroApp.Models;
using System.Data.SqlClient;

namespace PueroApp.Services
{
    public class SqlServerEmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployees(string query)
        {
            SqlConnection con;
            return null;
        }

        public void InsertEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
        public void RemoveEmployee(EmployeeId employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
