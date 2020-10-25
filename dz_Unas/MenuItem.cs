using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Unas
{
    abstract  class MenuItem
    {
    
       protected string name;
        public string Name { get { return name; } set { name = value; } }
        public abstract void Execute(List<int> list);
    }
}
