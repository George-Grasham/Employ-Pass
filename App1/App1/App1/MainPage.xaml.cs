using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Shield.Source = ImageSource.FromResource("App1.hessle_high_shield.jpg");
            HessleLogo.Source = ImageSource.FromResource("App1.hessle_academy_logo_and_text.png");
            ConsortiumLogo.Source = ImageSource.FromResource("App1.consortium_logo.jpg");
            
        }

        async private void Intro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IntroPage());
        }

        private void Step_1_Clicked(object sender, EventArgs e)
        {

        }

        private void Step_2_Clicked(object sender, EventArgs e)
        {

        }
        
        private void Step_3_Clicked(object sender, EventArgs e)
        {

        }

        private void Step_4_Clicked(object sender, EventArgs e)
        {

        }

        private void Step_5_Clicked(object sender, EventArgs e)
        {

        }

        private void Preping_a_CV_Clicked(object sender, EventArgs e)
        {

        }

        private void Application_Forms_Clicked(object sender, EventArgs e)
        {

        }
    }
}
