using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    internal class PaleoDiet : DietBase
    {
        public override string Name => "Paleo";
        public PaleoDiet(int level) : base("Meat, Egges, Vegetables, No sugar or carbohydrates", level)
        {
                
        }        
    }

    internal class AtkinsDiet : DietBase
    {
        public override string Name => "Atkins";
        public AtkinsDiet(int level) : base("Only Meat, Egges, Vegetables, Fat cheeses", level)
        {
        }
    }

    internal class VegetarianDiet : DietBase
    {    
        public override string Name => "Vegetarian";
        public VegetarianDiet(int level, bool inPregnant) : base("Egges, Fish, Vegetables, Legumes ", level , inPregnant)
        {
        }
    }
}
