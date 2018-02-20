using System;

using Xamarin.Forms;

namespace App1
{
    public class Step_6 : ContentPage
    {
        public Step_6()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

