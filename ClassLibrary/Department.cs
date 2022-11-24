using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Department
    {
        string _name;
        int _employeelimit;
        int _salarylimit;
        Employee[] Employees;
        byte EmployeeCount;
        public int Employeelimit
        {
            get { return _employeelimit; }
            set { if (value > 0) { _employeelimit = value; } }
        }
        public int Salarylimit
        {
            get { return _salarylimit; }
            set { if (value >= 250) { _salarylimit = value; } }
            }
        public string Name
        {
            get { return _name; }
            set 
            {
                value = value.Trim();
                if(value.Length > 0 && value.Length > 15)
                {
                    _name = value;
                } 
            }
        }
        public Department(string name, int employeeLimit, int salarylimit)
        {
            Employees = new Employee [0];
            Employeelimit = employeeLimit;
            Name = name;
            Salarylimit = salarylimit;
        }
        public void AddEmployee( Employee employee)
        {
            if (Employeelimit > EmployeeCount )
            {
                if (employee.Salary <= Salarylimit && employee.Salary >= 250)
                {
                    Array.Resize(ref Employees, Employees.Length + 1);
                    Employees[Employees.Length - 1] = employee;
                    EmployeeCount++;
                }
                else
                {
                Console.WriteLine(employee.Name + " " + employee.Surname + " " + "Couldn't added beacause you are out of the Salarylimit");

                }
            }
            else
            {
                Console.WriteLine(employee.Name + " " + employee.Surname + " " + "Couldn't added beacause you are out of the range employeelimit");
            }
        }
        public void GetDepartmentEmployeeInfo()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"{Employees[i].Name} {Employees[i].Surname}");
            }
        }
    }
}
