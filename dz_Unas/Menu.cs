using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Unas
{
    class Menu
    {
        List<MenuItem> items = new List<MenuItem>();
        List<int> list = new List<int>();

        public void Show()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{items.IndexOf(item)}: {item.Name}");
            }
        }
        public void WorkWithMenu()
        {
            do
            { 
                Show();
                Console.Write("Enter index of option: ");
                string choise = Console.ReadLine();
                Console.Clear();
                int counter = 0;
                foreach (var item in items)
                {
                    if (choise == items.IndexOf(item).ToString())
                    {
                        item.Execute(list);
                        counter++;
                    }
                }
            } while (true);
        }
        public void Add(MenuItem item)
        {
            items.Add(item);
        }
    }
}
