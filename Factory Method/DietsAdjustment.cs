using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    class PaleoDietAdjustment : DietFactory
    {
        public override DietBase GetDiet(int level)
        {
            return new PaleoDiet(level);
        }
    }
    class AtkinsDietAdjustment : DietFactory
    {
        public override DietBase GetDiet(int level)
        {
            return new AtkinsDiet(level);
        }
    }
    class VegetarianDietAdjustment : DietFactory
    {
        private bool inPregnant;

        public VegetarianDietAdjustment(bool inPregnant)
        {
            this.inPregnant = inPregnant;
        }

        public override DietBase GetDiet(int level)
        {
            return new VegetarianDiet(level, inPregnant);
        }
    }
}
//(double bmi, bool vegetarian)