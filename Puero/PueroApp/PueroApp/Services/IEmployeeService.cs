using PueroApp.Models;

namespace PueroApp.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees(string query);
        void InsertEmployee(Employee employee);
        void RemoveEmployee(EmployeeId employeeId);
    }
}
