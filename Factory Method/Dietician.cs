using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    internal class Dietician
    {
        private DietFactory dietFactory;       
        public Dietician()
        {
           
        }

        public void DieticianAdjustPaleoDiet(Person person)
        {
            dietFactory = new PaleoDietAdjustment();
        }

        public void DieticianAdjustAtkinsDiet(Person person)
        {
            dietFactory = new AtkinsDietAdjustment();
        }

        public void DieticianAdjustVegetarianDiet(Person person)
        {
            dietFactory = new VegetarianDietAdjustment(person.InPregnant);
        }

        public void DieticianAdjustDietForPerson(Person person)
        {
            double bmi = CalcBMI(person);
            int level = 0;
            if (bmi > 18 && bmi < 25)
                level = 1;
            if (bmi > 25 && bmi < 30)
                level = 2;
            if (bmi > 30)
                level = 3;
            if (dietFactory == null)
            {
                Console.WriteLine("Please select the diet type first");
                return;
            }
            DietBase diet = dietFactory.GetDiet(level);
            Console.WriteLine(diet.GetMenu()); 
        }

        public double CalcBMI(Person person)
        {
            return person.Weight / (person.Height * person.Height);
        }

    }
}
