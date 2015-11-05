using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    class Model
    {
        private int _id;
        private string _name;
        private int _age;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age 
        {
            get { return _age; }
            set { _age = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
