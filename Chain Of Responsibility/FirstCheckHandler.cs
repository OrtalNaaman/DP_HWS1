using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    class FirstCheckHandler : CheckHandler
    {
        public override void HandleRequest(Car carToFix)
        {
            int status = RandomValuesForCar.GetCarStatus();
            Console.WriteLine($"\n{carToFix.Color} {carToFix.Brand}-{carToFix.Model}-{carToFix.Year} license number: {carToFix.LicenseNumber} is welcome to our garage!\n");
            if (status >= 6)
            {
                Console.WriteLine($"First check was successful!\nyour car grade : {status} and you can leave the garage");
                carToFix.NeedsRepair = false;
            }
            else if (next != null)
            {
                Console.WriteLine($"First check grade was {status}, Your car needs an other check...");
                next.HandleRequest(carToFix);
            }
        }

    }
}

