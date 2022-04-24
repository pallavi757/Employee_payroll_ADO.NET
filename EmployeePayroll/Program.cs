using System;
namespace EmployeePayroll
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll ADO.NET Problem");
            Console.WriteLine("======================================");
            Employee empObj = new Employee();
            empObj.CheckConnection();

        }
    }
}