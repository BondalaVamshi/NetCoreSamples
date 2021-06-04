using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingDataToView.Models
{
    public class MockEmployeeRepository: IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Shiva", Department = "HR", EMail = "Shiva@gmail.comm" },
                new Employee() { Id = 2, Name = "Ram", Department = "Manager", EMail = "Ram@gmail.comm" },
                new Employee() { Id = 3, Name = "Laxman", Department = "TL", EMail = "Laxman@gmail.comm" },
                new Employee() { Id = 4, Name = "Sita", Department = "HR", EMail = "Sita@gmail.comm" }
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
