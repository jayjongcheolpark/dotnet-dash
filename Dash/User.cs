using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class User
    {
        private int _uID;
        private string _uLoginName;
        private string _uName;

        public User(int uID, string uName, string uLoginName)
        {
            _uID = uID;
            _uName = uName;
            _uLoginName = uLoginName;
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
    }
}
