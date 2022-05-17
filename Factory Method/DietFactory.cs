using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    internal abstract class DietFactory
    {
        public abstract DietBase GetDiet(int level);
    }
}
