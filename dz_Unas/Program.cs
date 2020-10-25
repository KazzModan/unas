using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Unas
{
    class Program
    {
        static void Main(string[] args)
        {
        MenuAdd add = new MenuAdd();
            MenuRemove rem = new MenuRemove();
            MenuSort sort = new MenuSort();
            MenuExit exit = new MenuExit();
            MenuShow show = new MenuShow();
            Menu menu = new Menu();
            menu.Add(add);
            menu.Add(rem);
            menu.Add(sort);
            menu.Add(exit);
            menu.Add(show);
            menu.WorkWithMenu();
            
        }
    }
}
