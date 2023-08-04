using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class EmpCollection
    {
        static List<Emp> empList = new List<Emp>()
        {
            new Emp{Id=1,Name="Viya",Salary=40000.00},
            new Emp{Id=2,Name="Sathish",Salary=35000.00},
            new Emp{Id=3,Name="Priya",Salary=22000.00},
            new Emp{Id=4,Name="Gandhi",Salary=60000.00},
            new Emp{Id=5,Name="Shalini",Salary=20800.00},
        };
        public static void AddEmp()
        {
            Emp emp = new Emp();
            Console.WriteLine("Enter Employee ID");
            emp.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            emp.Salary = double.Parse(Console.ReadLine());
            empList.Add(emp);
            Console.WriteLine("Added in Employee List");
        }
        public static void RemoveEmp()
        {
            Console.WriteLine("Enter Employee ID");
            int id = int.Parse(Console.ReadLine());
            Emp emp = empList.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                empList.Remove(emp);
                Console.WriteLine("Deleted!!");
            }
            else
            {
                Console.WriteLine("No such employee exist");
            }
        }
        public static void DisplayList()
        {
            foreach (Emp e in empList)
            {
                Console.WriteLine("ID:" + e.Id);
                Console.WriteLine("Name:" + e.Name);
                Console.WriteLine("Salary:" + e.Salary);

            }
        }
    }
}
