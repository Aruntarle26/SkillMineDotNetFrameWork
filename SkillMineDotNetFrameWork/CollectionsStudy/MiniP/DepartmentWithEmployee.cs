using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.CollectionsStudy.MiniP
{
    public class Employeep
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public override string ToString()
        {
            return $"Employee Id : {EmpId},Employee Name: {EmpName},Salary Is: {EmpSalary}";
        }
    }
    public class Deparment
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public List<Employeep> l = new List<Employeep>();
      
        public override string ToString()
        {
            return $"Department Id : {DeptId},Department Name: {DeptName},\nEmployees Are: ";
        }

    }
    class DepartmentWithEmployee
    {
       /* static void Main(string[] args)
        {
            List<Deparment> d = new List<Deparment>();
            d.Add(
                new Deparment
                {
                    DeptId = 100,
                    DeptName = "Development",
                    l = { new Employeep { EmpId = 200, EmpName = "Syam Kumar", EmpSalary = 50000.00 } ,
                          new Employeep { EmpId = 201, EmpName = "Aarav Shete", EmpSalary = 40000.00 },
                          new Employeep { EmpId = 202, EmpName = "Nandu sharma", EmpSalary = 30000.00 },
                          new Employeep { EmpId = 203, EmpName = "sarala Kovet", EmpSalary = 60000.00 }
                    }
                }
                );
            d.Add(
                new Deparment
                {
                    DeptId = 101,
                    DeptName = "HR",
                    l = { new Employeep { EmpId = 204, EmpName = "Swapnil Kumar", EmpSalary = 55000.00 } ,
                          new Employeep { EmpId = 206, EmpName = "tarak Mehta", EmpSalary = 38000.00 },
                          new Employeep { EmpId = 207, EmpName = "Shaktiman", EmpSalary = 87000.00 },
                          new Employeep { EmpId = 208, EmpName = "Javed", EmpSalary = 56000.00 }
                    }
                }
                );
            d.Add(
                new Deparment
                {
                    DeptId = 102,
                    DeptName = "Testing",
                    l = { new Employeep { EmpId = 210, EmpName = "khali Kumar", EmpSalary = 55000.00 } ,
                          new Employeep { EmpId = 224, EmpName = "vishal Mehta", EmpSalary = 38000.00 },
                          new Employeep { EmpId = 234, EmpName = "virat Kohli", EmpSalary = 87000.00 },
                          new Employeep { EmpId = 276, EmpName = "Rohit rao", EmpSalary = 56000.00 }
                    }
                }
                );
            foreach (Deparment d2 in d)
            {
                Console.WriteLine(d2);
                foreach (Employeep m in d2.l)
                {
                    Console.WriteLine(m);
                }
                Console.WriteLine("-----------------------------------");
            }

        }*/
    }
}
