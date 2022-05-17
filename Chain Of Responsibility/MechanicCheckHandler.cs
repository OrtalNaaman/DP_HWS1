using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    internal class MechanicCheckHandler : CheckHandler
    {
        public override void HandleRequest(Car carToFix)
        {
            int status = RandomValuesForCar.GetCarStatus();
            if (status >= 6)
            {
                Console.WriteLine($"Mechanic check was successful! your car grade after fix : {status} and you can leave the garage.");
                carToFix.NeedsRepair = false;
            }
            else if (next != null)
            {
                Console.WriteLine($"Mechanic check grade was {status}, Your car needs an other check...");
                next.HandleRequest(carToFix);
            }
        }
    }
}
