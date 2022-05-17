using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    abstract class DietBase
    {
        public abstract string Name { get; }
        public string DietMenu { get; set; }
        public int Level { get; set; }
        public bool InPregnant { get; set; }

        public DietBase(string dietMenu, int level , bool inPregnant = false)
        {
            DietMenu = dietMenu;
            Level = level;
            InPregnant = inPregnant;
            if (Name == "Vegetarian" && InPregnant)
                DietMenu += "\nBe carfull and consult your doctor about this diet in pregnant. Good Luck!";
        }
        public string GetMenu()
        {
            switch (Level)
            {
                case 1: return  $"\nDietitian's recommendation: {Name} Diet for one week. \nMenu: {DietMenu}";
                case 2: return  $"\nDietitian's recommendation: {Name} Diet for two weeks. \nMenu: {DietMenu}";
                case 3: return  $"\nDietitian's recommendation: {Name} Diet for one month. \nMenu: {DietMenu}";
                default: return $"\nNo level found. \nThe menu for {Name} diet: {DietMenu}"; ;
            }               
        }      
    }
}
