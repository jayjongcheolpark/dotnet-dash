using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    public class User
    {
        private int _uID;
        private string _uLoginName;
        private string _uName;
        private string _city;
        private string _phone;
        private string _email;
        private string _birthdate;
        private int _empID;
        private Employee _jobInfo;

        public User(int uID, string uName, string uLoginName, string city,
            string phone, string email, string birthdate, int empID, Employee jobInfo)
        {
            _uID = uID;
            _uName = uName;
            _uLoginName = uLoginName;
            _city = city;
            _phone = phone;
            _email = email;
            _birthdate = birthdate;
            _empID = empID;
            _jobInfo = jobInfo;
        }

        public User(int uID, string uName, string uLoginName, string city,
            string phone, string email, string birthdate, int empID)
        {
            _uID = uID;
            _uName = uName;
            _uLoginName = uLoginName;
            _city = city;
            _phone = phone;
            _email = email;
            _birthdate = birthdate;
            _empID = empID;
        }

        public string Name
        {
            get => _uName;
            set => _uName = value;
        }
        public string LoginName
        {
            get => _uLoginName;
            set => _uLoginName = value;
        }

        public int ID
        {
            get => _uID;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Birthdate
        {
            get => _birthdate;
            set => _birthdate = value;
        }

        public int EmployeeID
        {
            get => _empID;
            set => _empID = value;
        }

        public Employee JobInfo
        {
            get => _jobInfo;
            set => _jobInfo = value;
        }
    }
}
