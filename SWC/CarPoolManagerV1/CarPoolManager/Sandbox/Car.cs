using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Car
    {
        private String licensePlate;
        private String brand;
        private String model;

        public Car(String plate, String brand, String model)
        {
            this.licensePlate = plate;
            this.brand = brand;
            this.model = model;
        }

        public String GetLicensePlate() 
        {
            return licensePlate;
        }

        public String GetBrand()
        {
            return brand;
        }

        public String GetModel()
        {
            return model;
        }
    }
}
