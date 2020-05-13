using System;
using System.Collections.Generic;
using System.Text;

namespace Developer_Practicum.Menu
{
    public class MorningMenu : BaseMenu
    {
        public override MenuItem[] AvailableDishes => new[] {
            new MenuItem() { Name = "Eggs", Type = MenuItemType.Entree},
            new MenuItem() { Name = "Toast", Type = MenuItemType.Side},
            new MenuItem() { Name = "Coffee", Type = MenuItemType.Drink}};

        public override string Name => "Morning";
    }
}
