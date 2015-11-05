using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BodyAnalyser
    {
        // Given the weight and height of a person, return the BMI
        public double CalculateBMI(double heightInMeters, double weightInKilo)
        {
            double bmi = weightInKilo / (heightInMeters * heightInMeters);
            return bmi;
        }

        // Given the weight and height of a person, return a brief analysis
        // of the BMI of that person
        public String AnalyseBMI(double heightInMeters, double weightInKilo)
        {
            double bmi = CalculateBMI(heightInMeters, weightInKilo); 

            string analysis = "";

            if (bmi < 15)
            {
                analysis = "You are way too skinny";
            }
            else if (bmi >= 15 && bmi < 22)
            {
                analysis = "You are a bit skinny";
            }
            else if (bmi >= 22 && bmi < 28)
            {
                analysis = "You are just fine!";
            }
            else if (bmi >= 28 && bmi < 35)
            {
                analysis = "You are a bit overweight!";
            }
            else
            {
                analysis = "You are way too fat!";
            }

            return analysis;
        }

    }
}
