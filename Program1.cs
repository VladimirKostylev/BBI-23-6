using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public struct Employee
    {
        public string _name;
        public int _employeeId;
        public int _age;
        public int _yearOfJoining;
        public double _salary;
        public string Name { get { return _name; } }
        public int EmployeeId { get { return _employeeId; } }
        public int Age { get { return _age; } }
        public int Yearofjoining { get { return _yearOfJoining; } }
        public double Salary { get { return _salary; } }
        public Employee(string name, int employeeId, int age, int yearofjoining, double salary)
        {
            _name = name;
            _employeeId = employeeId;
            _age = age;
            _yearOfJoining = yearofjoining;
            _salary = salary;
        }
        public void Print()
        {
            Console.WriteLine($"ID {_employeeId}, Имя {_name}, Возраст {_age}, Начало работы {_yearOfJoining}, Зарплата {_salary}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Employee employee1 = new Employee { _name = "Иван Иванов", _employeeId = 1, _age = 30, _yearOfJoining = 2021, _salary = 100000 };
            Employee employee2 = new Employee { _name = "Петр Петров", _employeeId = 2, _age = 35, _yearOfJoining = 2022, _salary = 120000 };
            Employee employee3 = new Employee { _name = "Ольга Ольгина", _employeeId = 3, _age = 28, _yearOfJoining = 2023, _salary = 90000 };
            Employee employee4 = new Employee { _name = "Василий Васильев", _employeeId = 4, _age = 32, _yearOfJoining = 2024, _salary = 110000 };
            Employee employee5 = new Employee { _name = "Мария Маринина", _employeeId = 5, _age = 29, _yearOfJoining = 2025, _salary = 80000 };
            Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4, employee5 };
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Print();
            }
            Console.ReadKey();
        }
    }
}