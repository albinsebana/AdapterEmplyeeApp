using AdapterEmplyeeApp.Adapter;

namespace AdapterEmplyeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeSystem employeeSystem = new EmployeeSystem();


            // Adapter to make EmployeeSystem compatible with IEmployee
            EmployeeAdapter employeeAdapter = new EmployeeAdapter(employeeSystem);


            // Client code can now work with IEmployee interface
            employeeAdapter.HireEmployee("Albin");
        }
    }
}