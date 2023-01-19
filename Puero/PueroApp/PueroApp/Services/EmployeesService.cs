using PueroApp.Models;

namespace PueroApp.Services
{
    public class EmployeesService : IEmployeeService
    {
        private static List<Employee> _employees= new List<Employee>();

        static EmployeesService()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee
            {
                IdEmployee = 1,
                FirstName = "Jakub",
                LastName = "Skrok",
                Email = "skrok.jakub@o2.pl",
                Address = "Warsaw, Kieslowskiego 3"
            });
            _employees.Add(new Employee
            {
                IdEmployee = 2,
                FirstName = "Szymon",
                LastName = "Wujec",
                Email = "wujec.szymon@o2.pl",
                Address = "Warsaw, Wyszynskiego 3"
            });
            _employees.Add(new Employee
            {
                IdEmployee = 3,
                FirstName = "Krzysztof",
                LastName = "Janczewski",
                Email = "k.jan@o2.pl",
                Address = "Warsaw, Raymonta 92"
            });
            _employees.Add(new Employee
            {
                IdEmployee = 4,
                FirstName = "Igor",
                LastName = "Kunach",
                Email = "kunach.i@o2.pl",
                Address = "Warsaw, Bursztynowa 32"
            });
        }
        public List<Employee> GetEmployees(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return _employees;
            }

            return _employees.Where(e => e.LastName == query).ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public void RemoveEmployee(EmployeeId employeeId)
        {
            var recordId = employeeId.Id;
            var itemToRemove = _employees.Single(r => r.IdEmployee == recordId);
            _employees.Remove(itemToRemove);
        }

    }
}
