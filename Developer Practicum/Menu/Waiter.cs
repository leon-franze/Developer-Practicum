using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Developer_Practicum.Menu
{
    public class Waiter
    {
        List<BaseMenu> _availableMenus;

        public Waiter()
        {
            _availableMenus = new List<BaseMenu>();
            _availableMenus.Add(new NightMenu());
            _availableMenus.Add(new MorningMenu());
        }

        string ERROR = "Error";
        public string FindMenu(string input)
        {            
            if (!string.IsNullOrEmpty(input)) // !IsValid(input)
            {
                var inputarray = input.Split(',');
                var foundMenu = SelectMenu(inputarray[0]);
                if (foundMenu!=null)
                {
                    return foundMenu.Process(inputarray.Skip(1));
                }
                

                // return BaseMenu.Process(selectMenu)

            }
            else {
                return ERROR;
            }
        }

        private BaseMenu SelectMenu(string name)
        {
            return _availableMenus.FirstOrDefault((menu) => string.Compare(menu.Name, name) == 0);
        }
    }
}
