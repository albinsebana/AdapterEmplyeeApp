using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEmplyeeApp
{
    internal class EmployeeSystem
    {
        public void AddEmployee(string name)
        {
            Console.WriteLine($"Added employee: {name}");
        }
    }
}
