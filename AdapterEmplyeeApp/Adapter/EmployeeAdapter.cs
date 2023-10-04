using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEmplyeeApp.Adapter
{
    internal class EmployeeAdapter : IEmployee
    {
        private readonly EmployeeSystem employeeSystem;

        public EmployeeAdapter(EmployeeSystem employeeSystem)
        {
            this.employeeSystem = employeeSystem;
        }

        public void HireEmployee(string fullName)
        {
            // Call the existing EmployeeSystem's method
            employeeSystem.AddEmployee(fullName);
        }
    }
}

