using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class Contents : ContentPage
    {
        MainCarouselPage Page;
        public Contents(MainCarouselPage page)
        {
            InitializeComponent();
            Page = page;
        }

        private void Intro_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[1]; 
        }

        private void Step_1_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[2];
        }

        private void Step_2_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[3];
        }

        private void Step_3_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[4];
        }

        private void Step_4_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[5];
        }

        private void Step_5_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[6];
        }

        private void Preping_a_CV_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[7];
        }

        private void Application_Forms_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[8];
        }

        private void Preparation_for_Interview_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[9];
        }

        private void Employability_Skills_Framework_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[10];
        }
        private void Useful_Links_Clicked(object sender, EventArgs e)
        {
            Page.CurrentPage = Page.Pages[11];
        }
    }
}
