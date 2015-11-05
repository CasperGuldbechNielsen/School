using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This class represents a simple box of fruit - it can only contain
    // Bananas and Apples. It also represents the price of each item. 
    class FruitBox
    {
        private int numberOfBananas;
        private int numberOfApples;
        private double totalPrice;
        private double priceForOneBanana;
        private double priceForOneApple;

        // Create the fruit box - it is empty to start with, but the prices must
        // be specified
        public FruitBox(double priceForOneBanana, double priceForOneApple)
        {
            this.priceForOneBanana = priceForOneBanana;
            this.priceForOneApple = priceForOneApple;
            this.numberOfBananas = 0;
            this.numberOfApples = 0;
        }

        // set new prices for bannas and apples

        public void NewFruitPrices(double priceForOneBanana, double PriceForOneApple)
        {
            this.priceForOneBanana = priceForOneBanana;
            this.priceForOneApple = PriceForOneApple;
        }

        public void AddApples(int numberOfApples)
        {
            this.numberOfApples = this.numberOfApples + numberOfApples;
        }

        public void AddBananas(int numberOfBananas)
        {
            this.numberOfBananas = this.numberOfBananas + numberOfBananas;
        }

        // Note that this method just returns a string describing the box content.
        // It does NOT print anything on the screen!
        public string GetBoxContentDescription()
        {
            string description = "The box contains " + numberOfBananas + " bananas and " + numberOfApples + " apples";
            return description;
        }

        public double getTotalPrice()
        {
            totalPrice = priceForOneApple*numberOfApples + priceForOneBanana*numberOfBananas;

            return totalPrice;
        }
    }
}
