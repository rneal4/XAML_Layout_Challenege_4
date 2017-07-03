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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Stupendous_Styles_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        public CoffeePage()
        {
            this.InitializeComponent();

            ResetCoffee();
        }

        private void SetRoast(object sender, RoutedEventArgs e)
        {
            var roastOpt = sender as MenuFlyoutItem;
            currentRoast = roastOpt.Text;
            GenerateCoffee();
        }

        private void SetSweet(object sender, RoutedEventArgs e)
        {
            var sweetOpt = sender as MenuFlyoutItem;
            currentSweet = sweetOpt.Text;
            GenerateCoffee();
        }

        private void SetCreme(object sender, RoutedEventArgs e)
        {
            var cremeOpt = sender as MenuFlyoutItem;
            currentCreme = cremeOpt.Text;
            GenerateCoffee();
        }

        private void ResetCoffee()
        {
            currentRoast = "None";
            currentSweet = "None";
            currentCreme = "None";
        }

        private void GenerateCoffee()
        {
            if (currentRoast == "None")
            {
                CoffeeOrderDisplay.Text = "";
                ResetCoffee();
            }
            else
            {
                string temp = $"{currentRoast} + {currentSweet} + {currentCreme}";
                temp = temp.Replace(" + None", "");
                CoffeeOrderDisplay.Text = temp;
            }
        }

        public string currentRoast { get; set; }
        public string currentSweet { get; set; }
        public string currentCreme { get; set; }


    }
}
