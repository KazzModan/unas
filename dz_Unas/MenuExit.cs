using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Unas
{
    class MenuExit : MenuItem
    {
        public MenuExit() 
        {
            name = "Exit";
        }
        public override void Execute(List<int> list)
        {
            Environment.Exit(0);
        }
    }
    class MenuAdd : MenuItem
    {
        public MenuAdd()
        {
            name = "Add";
        }
        public override void Execute(List<int> list)
        {
            Console.Write("Enter number: ");
            int item = Int32.Parse(Console.ReadLine());
            list.Add(item);
        }
    }
    class MenuRemove : MenuItem
    {
        public MenuRemove()
        {
            name = "Remove";
        }
        public override void Execute(List<int> list)
        {
            Console.Write("Enter number: ");
            int item = Int32.Parse(Console.ReadLine());
            list.Remove(item);
        }
    }
    class MenuSort : MenuItem
    {
        public MenuSort()
        {
            name = "Sort";
        }
        public override void Execute(List<int> list)
        {
            list.Sort();
        }
    }
    class MenuShow : MenuItem
    {
        public MenuShow()
        {
            name = "Show";
        }
        public override void Execute(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
