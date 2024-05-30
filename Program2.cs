using ConsoleApp17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp17
{
    public abstract class Company
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
        public Company(string name, int employeeId, int age, int yearofjoining, double salary)
        {
            _name = name;
            _employeeId = employeeId;
            _age = age;
            _yearOfJoining = yearofjoining;
            _salary = salary;
        }
        public void Print()
        {
            Console.WriteLine($"ID: {_employeeId}, Имя: {_name}, Возраст: {_age}, Начало работы: {_yearOfJoining}, Зарплата: {_salary}");
        }
    }
    class ITCompany : Company
    {
        public ITCompany(string name, int employeeId, int age, int yearofjoining, double salary) : base(name, employeeId, age, yearofjoining, salary) { }
        public bool CheckAge(int age)
        {
            if (age >= 25 && age <= 40)
                return true;
            else
                return false;
        }
    }
    class IndustrialCompany : Company
    {
        public IndustrialCompany(string name, int employeeId, int age, int yearofjoining, double salary) : base(name, employeeId, age, yearofjoining, salary) { }
        public bool CheckExperience(int yearOfJoining)
        {
            if (DateTime.Now.Year - yearOfJoining >= 5)
                return true;
            else
                return false;
        }
    }
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
            Console.WriteLine($"ID: {_employeeId}, Имя: {_name}, Возраст: {_age}, Начало работы: {_yearOfJoining}, Зарплата: {_salary}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Employee employee1 = new Employee { _name = "Иван Иванов", _employeeId = 1, _age = 30, _yearOfJoining = 2019, _salary = 100000 };
            Employee employee2 = new Employee { _name = "Петр Петров", _employeeId = 2, _age = 35, _yearOfJoining = 2010, _salary = 120000 };
            Employee employee3 = new Employee { _name = "Ольга Ольгина", _employeeId = 3, _age = 28, _yearOfJoining = 2023, _salary = 90000 };
            Employee employee4 = new Employee { _name = "Василий Васильев", _employeeId = 4, _age = 32, _yearOfJoining = 2024, _salary = 110000 };
            Employee employee5 = new Employee { _name = "Мария Маринина", _employeeId = 5, _age = 29, _yearOfJoining = 2018, _salary = 80000 };
            Employee employee6 = new Employee { _name = "Александр Александров", _employeeId = 6, _age = 31, _yearOfJoining = 2020, _salary = 105000 };
            Employee employee7 = new Employee { _name = "Елена Еленина", _employeeId = 7, _age = 27, _yearOfJoining = 2017, _salary = 85000 };
            Employee employee8 = new Employee { _name = "Михаил Михайлов", _employeeId = 8, _age = 33, _yearOfJoining = 2023, _salary = 115000 };
            Employee employee9 = new Employee { _name = "Анна Аннина", _employeeId = 9, _age = 29, _yearOfJoining = 2022, _salary = 95000 };
            Employee employee10 = new Employee { _name = "Сергей Сергеев", _employeeId = 10, _age = 30, _yearOfJoining = 2014, _salary = 100000 };
            Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            List<ITCompany> itCompanies = new List<ITCompany>();
            List<IndustrialCompany> industrialCompanies = new List<IndustrialCompany>();
            foreach (var employee in employees)
            {
                ITCompany itCompany = new ITCompany(employee._name, employee._employeeId, employee._age, employee._yearOfJoining, employee._salary);
                IndustrialCompany industrialCompany = new IndustrialCompany(employee._name, employee._employeeId, employee._age, employee._yearOfJoining, employee._salary);
                if (itCompany.CheckAge(employee._age))
                    itCompanies.Add(itCompany);
                if (industrialCompany.CheckExperience(employee._yearOfJoining))
                    industrialCompanies.Add(industrialCompany);
            }
            itCompanies = itCompanies.OrderByDescending(x => x.Salary).ToList();
            industrialCompanies = industrialCompanies.OrderByDescending(x => x.Salary).ToList();
            Console.WriteLine("IT-компании:");
            foreach (var company in itCompanies)
            {
                company.Print();
            }
            Console.WriteLine("Промышленные компании:");
            foreach (var company in industrialCompanies)
            {
                company.Print();
            }
            List<Company> companies = new List<Company>();
            companies.AddRange(itCompanies);
            companies.AddRange(industrialCompanies);
            companies = companies.OrderByDescending(x => x.Salary).ToList();
            Console.WriteLine("Все компании:");
            foreach (var company in companies)
            {
                company.Print();
            }
            Console.ReadKey();
        }
    }
}