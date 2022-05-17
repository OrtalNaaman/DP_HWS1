using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS1
{
    public class RandomValuesForCar
    {
        public static int CreateRandomYear()
        {
            Random r = new Random();
            return r.Next(2000, 2022);
        }
        public static string CreateRandomColor()
        {
            Random r = new Random();
            return Enum.GetName(typeof(ColorsTypes), r.Next(Enum.GetValues(typeof(ColorsTypes)).Length)).ToString();
        }
        public static string CreateRandomBrand()
        {
            Random r = new Random();
            return Enum.GetName(typeof(BrandTypes), r.Next(Enum.GetValues(typeof(BrandTypes)).Length)).ToString();
        }
        public static string CreateRandomModel(string brand)
        {
            Random r = new Random();
            switch (brand)
            {
                case "Mazda":
                    return Enum.GetName(typeof(MazdaModels), r.Next(Enum.GetValues(typeof(MazdaModels)).Length)).ToString();
                case "Mercedes":
                    return Enum.GetName(typeof(MercedesModels), r.Next(Enum.GetValues(typeof(MercedesModels)).Length)).ToString();
                case "Toyota":
                    return Enum.GetName(typeof(ToyotaModels), r.Next(Enum.GetValues(typeof(ToyotaModels)).Length)).ToString();
                default:
                    return null;
            }
        }
        public static int CreateRandomLicense()
        {
            Random r = new Random();
            return r.Next(1111111, 9999999);
        }

        public static int GetCarStatus()
        {
            Random status = new Random();
            return status.Next(1, 11);
        }
    }


    public enum ColorsTypes
    {
        Black,
        White,
        Red,
        Blue,
        Green,
        Silver
    }
    public enum BrandTypes
    {
        Mazda,
        Mercedes,
        Toyota,

    }
    public enum MazdaModels
    {
        Mazda2,
        Mazda3,
        CX5
    }
    public enum MercedesModels
    {
        Sprinter,
        GLE,
        Maybach
    }
    public enum ToyotaModels
    {
        Corolla,
        Prius,
        Yaris
    }
}
