﻿namespace Problem_6.Company_Roster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.age = -1;
            this.email = "n/a";
        }

        public int Age { set { this.age = value; } }

        public string Email { set { this.email = value; } }

        public string Department { get { return this.department; } }

        public decimal Salery { get { return this.salary; } }

        public string PrintEmployeeInfo()
        {
            return $"{this.name} {this.salary:f2} {this.email} {this.age}";
        }
    }
}