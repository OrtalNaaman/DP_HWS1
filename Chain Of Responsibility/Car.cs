using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DP_HWS1
{
    public class Car
    {
        public int LicenseNumber { get; set; }   
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public bool NeedsRepair { get; set; }

        public Car(string brand)
        {
            LicenseNumber = RandomValuesForCar.CreateRandomLicense();   
            Brand = brand;
            Model = RandomValuesForCar.CreateRandomModel(brand);
            Year = RandomValuesForCar.CreateRandomYear();
            Color = RandomValuesForCar.CreateRandomColor();
            NeedsRepair = true;
        }
       public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }



}
