using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Car
    {
        private String brand;
        private String modelName;
        private double horsePower;
        private double kmPerLiter;
        private int noOfSeats;
        private bool hasAC;

        // This constructor creates a Car object where all fields are set,
        // using the values provided in the parameter list
        public Car(String brand, String modelName, double horsePower, double kmPerLiter, int noOfSeats, bool hasAC)
        {
            this.brand = brand;
            this.modelName = modelName;
            this.horsePower = horsePower;
            this.kmPerLiter = kmPerLiter;
            this.noOfSeats = noOfSeats;
            this.hasAC = hasAC;
        }

        // Returns the brand of the Car
        public String GetBrand()
        {
            return brand;
        }

        // Returns the model name of the Car
        public String GetModelName()
        {
            return modelName;
        }

        // Returns the horse power value of the Car
        public double GetHorsePower()
        {
            return horsePower;
        }

        // Returns the number of kilometers the car can drive
        // using one liter of gas
        public double GetKmPerLiter()
        {
            return kmPerLiter;
        }

        // Returns the number of seats in the Car
        public double GetSetCount()
        {
            return noOfSeats;
        }

        // Returns whether the car has air conditioning (AC)
        public bool HasAC()
        {
            return hasAC;
        }

        // Returns whether the car is considered economic
        // NOTE: Do we really need the if-statement...?
        public bool IsEconomic()
        {
            bool isEconomic = false;

            if (kmPerLiter > 18.0)
            {
                isEconomic = true;
            }

            return isEconomic;
        }

        // Returns whether the car is considered a family car
        // NOTE: Do we need two if-statements for this...?
        public bool IsFamilyCar()
        {
            bool familyCar = false;

            if (noOfSeats >= 4)
            {
                if (hasAC)
                {
                    familyCar = true;
                }
            }

            return familyCar;
        }

        // Returns the suggested rental price (per day) for the car
        // NOTE: Could something go wrong here...?
        public int RentalPricePerDay()
        {
            int rentalPrice = 0;

            if (horsePower < 70.0)
            {
                rentalPrice = 400;
            }

            if ((horsePower > 70.0) && (horsePower < 120.0))
            {
                rentalPrice = 550;
            }

            if ((horsePower > 120.0) && (horsePower < 200.0))
            {
                rentalPrice = 700;
            }

            if (horsePower > 200.0)
            {
                rentalPrice = 1000;
            }

            return rentalPrice;
        }
    }
}
