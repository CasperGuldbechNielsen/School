using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Dice_Game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int rollOne;
        private int rollTwo;
        private int result;

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void rollButton_Click(object sender, RoutedEventArgs e)
        {
            DiceGame dice = new DiceGame();
            dice.play();

            rollOne = dice.DiceRollOne();
            rollTwo = dice.DiceRollTwo();

            result = rollOne + rollTwo;

            firstDiceRoll.Text = rollOne.ToString();
            secondDiceRoll.Text = rollTwo.ToString();

            if (result == 7)
            {
                resultTextBlock.Text = "You rolled: " + result + ". YOU WIN!";
            }
            else
            {
                resultTextBlock.Text = "You rolled: " + result + ". Please try again..";
            }



        }

    }
}
