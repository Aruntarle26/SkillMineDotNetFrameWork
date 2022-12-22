using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.CollectionsStudy.MiniP
{
    public enum Department
    {
        Development,
        Testing,
        Hr
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }
        public Department dept;
        public override string ToString()
        {
            return $"Id:{EmployeeId},  Name: {EmployeeName}, Salary: {EmployeeSalary},Deapartment: {dept}";
        }

    }
    
    class EmployeeWithDepartment
    {
        /*static void Main(string[] args)
        {
            List<Employee> e = new List<Employee>();
            e.Add(new Employee {EmployeeId=100,EmployeeName="Pranit Kumar",EmployeeSalary=30000.00,dept=Department.Development });
            e.Add(new Employee { EmployeeId = 101, EmployeeName = "Arun Tarle", EmployeeSalary = 40000.00, dept = Department.Hr });
            e.Add(new Employee { EmployeeId = 102, EmployeeName = "Shalan pawar", EmployeeSalary = 50000.00, dept = Department.Testing });
            *//*foreach  (Employee emp in e)
            {
                Console.WriteLine($"Id:{emp.EmployeeId},Name: {emp.EmployeeName}, Salary: {emp.EmployeeSalary} Department: {emp.dept}");

            }*//*//if toString is not avalable
            foreach (Employee e2 in e)
            {
                
                Console.WriteLine(e2);
            }
        }*/
    }
}
