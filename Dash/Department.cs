using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash
{
    class Department
    {
        private string _did;
        private string _dname;
        private string _daddress;
        private static int _objId;


        public Department(string id, string name, string address)
        {
            this._did = id;
            this._dname = name;
            this._daddress = address;
            _objId++;
        }

        public override string ToString()
        {
            return _dname;
        }

        public string Name
        {
            get => _dname;
            set => _dname = value;
        }

        public int ObjID
        {
            get => _objId;
        }

        public string Address
        {
            get => _daddress;
            set => _daddress = value;
        }
    }
}
