using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class User
    {
        private string _uName;
        private string _uLoginName;

        public User(string uName, string uLoginName)
        {
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
    }
}
