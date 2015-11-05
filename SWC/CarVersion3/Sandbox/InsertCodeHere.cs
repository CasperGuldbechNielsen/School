using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Car car1 = new Car("Volvo", "V60", 165.0, 15.8, 5, true);
            Car car2 = new Car("BMW", "318i", 143.0, 18.2, 4, false);
            Car car3 = new Car("Skoda", "Fabia", 110.0, 19.8, 5, true);

            Console.WriteLine("The {0} {1} is a family car : {2}", car1.GetBrand(), car1.GetModelName(), car1.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car1.GetBrand(), car1.GetModelName(), car1.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car1.GetBrand(), car1.GetModelName(), car1.RentalPricePerDay());
            Console.WriteLine();

            Console.WriteLine("The {0} {1} is a family car : {2}", car2.GetBrand(), car2.GetModelName(), car2.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car2.GetBrand(), car2.GetModelName(), car2.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car2.GetBrand(), car2.GetModelName(), car2.RentalPricePerDay());
            Console.WriteLine();

            Console.WriteLine("The {0} {1} is a family car : {2}", car3.GetBrand(), car3.GetModelName(), car3.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car3.GetBrand(), car3.GetModelName(), car3.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car3.GetBrand(), car3.GetModelName(), car3.RentalPricePerDay());
            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}
