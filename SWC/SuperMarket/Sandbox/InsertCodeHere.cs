using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            FruitBox fruitBox = new FruitBox(2, 1.5);

            Console.WriteLine(fruitBox.GetBoxContentDescription());

            fruitBox.AddApples(10);
            fruitBox.AddBananas(5);

            Console.WriteLine(".....................");
            Console.WriteLine(fruitBox.GetBoxContentDescription());
            Console.WriteLine("The content of the box costs a total of {0}kr", fruitBox.getTotalPrice());

            Console.WriteLine(".....................");
            Console.WriteLine("Now we are changing prices to 3kr pr. banana and 2kr pr. apple...");

            fruitBox.NewFruitPrices(3, 2);
            Console.WriteLine("The content of the box costs a total of {0}kr", fruitBox.getTotalPrice());

            // The LAST line of code should be ABOVE this line
        }
    }
}
