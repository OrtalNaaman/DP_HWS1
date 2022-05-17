using System;
using System.Text;

namespace DP_HWS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            Console.ForegroundColor = ConsoleColor.Blue;
            Clock clock = Clock.GetInstance();
            Console.WriteLine(clock.GetTime());

            Thread.Sleep(2000);
            Clock clock1 = Clock.GetInstance();
            Console.WriteLine(clock1.GetTime());

            if (clock == clock1)
            {
                Console.WriteLine("Singleton works!\n");
            }
            else
            {
                Console.WriteLine("Ooops .... try again ...");
            }

            #endregion

            #region Chain of Responsibility
            Console.ForegroundColor = ConsoleColor.Red;
            CheckHandler firstCheck = new FirstCheckHandler();
            CheckHandler mechanicCheck = new MechanicCheckHandler();
            CheckHandler electricianCheck = new ElectricianCheckHandler();
            CheckHandler expertCheck = new OverallExpertCheckHanler();
                    
            firstCheck.SetNext(mechanicCheck).SetNext(electricianCheck).SetNext(expertCheck).SetNext(null);

            Car car1 = new Car(RandomValuesForCar.CreateRandomBrand());
            Car car2 = new Car(RandomValuesForCar.CreateRandomBrand());

            firstCheck.HandleRequest(car1);
            firstCheck.HandleRequest(car2);
            #endregion

            #region Factory Method
            Console.ForegroundColor = ConsoleColor.Green;
            Person p1 = new Person(false);
            Person p2 = new Person(true);
            Person p3 = new Person(false);

            Dietician dietician = new Dietician();

            Console.WriteLine(p1);
            dietician.DieticianAdjustPaleoDiet(p1);
            dietician.DieticianAdjustDietForPerson(p1);

            Console.WriteLine(p2);
            dietician.DieticianAdjustVegetarianDiet(p2);
            dietician.DieticianAdjustDietForPerson(p2);
          

            Console.WriteLine(p3);
            dietician.DieticianAdjustAtkinsDiet(p3);
            dietician.DieticianAdjustDietForPerson(p3);

            Console.ResetColor();
            #endregion
        } 
    }
}

