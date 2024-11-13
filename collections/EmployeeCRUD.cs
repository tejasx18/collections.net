using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Manager {  get; set; }
        public override string ToString()
        {
            return $"{Id} , {Name} , {Salary} , {Manager}";
        }
    }
    // Manage Employees

    public class EmployeeCRUD
    {
        List<Employee> Employees;
        public EmployeeCRUD()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }
        public void ModifyEmployee(Employee emp)
        {

            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == emp.Id)
                {
                    Employees[i].Name = emp.Name;
                    Employees[i].Salary = emp.Salary;
                    Employees[i].Manager = emp.Manager;
                    break;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == id)
                {
                    Employees.Remove(Employees[i]);
                    break;
                }
            }
        }
        public List<Employee> EmployeeList()
        {
            return Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee e = new Employee();
            foreach (var item in Employees)
            {
                if (item.Id == id)
                {
                    e.Id = item.Id;
                    e.Name = item.Name;
                    e.Salary = item.Salary;
                    e.Manager = item.Manager;
                    break;
                }
            }
            return e;
        }

    }

    public class DemoMain
    {

        static void Main(string[] args)
        {
            EmployeeCRUD crud = new EmployeeCRUD();
            try
            {
                int a = 1;
                do
                {
                    Console.WriteLine("1.Employee List");
                    Console.WriteLine("2.Add Employee");
                    Console.WriteLine("3.Modify Employee");
                    Console.WriteLine("4.Delete Employee");
                    Console.WriteLine("5.Get Employee By Id");
                    Console.WriteLine("Select option from above");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Employee> Employees = crud.EmployeeList();
                            Console.WriteLine("Id    Name    Salary");
                            foreach (var item in Employees)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 2:
                            Employee e1 = new Employee();
                            Console.WriteLine("Enter Id");
                            e1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            e1.Name = Console.ReadLine();
                            Console.WriteLine("Enter Salary");
                            e1.Salary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Manager Name");
                            e1.Manager = Console.ReadLine();
                            crud.AddEmployee(e1);
                            Console.WriteLine("Added the Employee");
                            break;
                        case 3:
                            Employee e2 = new Employee();
                            Console.WriteLine("Enter existing Id");
                            e2.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Name");
                            e2.Name = Console.ReadLine();
                            Console.WriteLine("Enter new Salary");
                            e2.Salary = Convert.ToInt32(Console.ReadLine());
                            crud.ModifyEmployee(e2);
                            e2.Manager = Console.ReadLine();
                            crud.AddEmployee(e2);
                            Console.WriteLine("updated the Employee");
                            break;
                        case 4:
                            Console.WriteLine("Enter existing Id to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteEmployee(id);
                            Console.WriteLine("Deleted the Employee");
                            break;
                        case 5:
                            Console.WriteLine("Enter existing Id");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Employee e = crud.GetEmployeeById(id2);
                            Console.WriteLine(e);
                            break;
                    }
                    Console.WriteLine("Press 1 for continue or 0 to exit");
                    a = Convert.ToInt32(Console.ReadLine());
                }

                while (a == 1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


}
