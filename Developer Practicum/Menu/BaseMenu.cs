using System;
using System.Collections.Generic;
using System.Text;

namespace Developer_Practicum.Menu
{
    public abstract class BaseMenu
    {
        public string ERROR = "Error in Class BaseMenu";
        public abstract string Name { get; }

        public abstract MenuItem[] AvailableDishes { get; set; }

        protected abstract MenuItem[] GetAvailableDishes();

        public BaseMenu()
        {
            AvailableDishes = GetAvailableDishes();
        }

        public string Process(string[] input)
        {
            if (input != null)
            {
                var selectedDishes = new List<MenuItem>();
                foreach (var item in input)
                {
                    Console.WriteLine(item);
                    return item;
                }
            }
            else
            {
                return ERROR;
            }
        }
    }
}
