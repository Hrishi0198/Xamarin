using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoProject
{
    public partial class QuotesPage : ContentPage
    {
        string[] quotes =
        {
            "1. Pursue Passion More Than Profit.",
            "2. If I cannot do great things, I can do small things in a great way.",
            "3. The bad news is time flies. The good news is you’re the pilot.",
            "4. Don’t wait. The time will never be just right.",
            "5. No matter what people tell you, words and ideas can change the world..", };
     
        static int i = 0;
        public QuotesPage()
        {
            InitializeComponent();
            MainLabel.Text = quotes[0];

        }
        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MainLabel.FontSize = (int)e.NewValue;
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (i == quotes.Length - 1)
                i = -1;
            MainLabel.Text = quotes[++i];
        }
    }
}

