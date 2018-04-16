using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _hireDate;
        private decimal _salary;
        private string _phone;
        private int _position;
        private int _department;

        public Employee(int id, string name, string hireDate, decimal salary, string phone, int position, int department)
        {
            _id = id;
            _name = name;
            _hireDate = hireDate;
            _salary = salary;
            _phone = phone;
            _position = position;
            _department = department;
        }

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public string name
        {
            get => _name;
            set => _name = value;
        }

        public string HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }

        public decimal Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public int Position
        {
            get => _position;
            set => _position = value;
        }

        public int Department
        {
            get => _department;
            set => _department = value;
        }
    }
}
