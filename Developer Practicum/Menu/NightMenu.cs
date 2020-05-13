using System;
using System.Collections.Generic;
using System.Text;

namespace Developer_Practicum.Menu
{
    public class NightMenu : BaseMenu
    {
        public override MenuItem[] AvailableDishes => new[] {
            new MenuItem() { Name = "Steak", Type = MenuItemType.Entree},
            new MenuItem() { Name = "Potato", Type = MenuItemType.Side},
            new MenuItem() { Name = "Wine", Type = MenuItemType.Drink},
            new MenuItem() { Name = "Cake", Type = MenuItemType.Desert }};

        public override string Name => "Night";
    }
}
