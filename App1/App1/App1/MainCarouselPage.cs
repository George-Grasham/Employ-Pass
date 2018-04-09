using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
	public class MainCarouselPage : CarouselPage
	{
        public List<ContentPage> Pages;

        public MainCarouselPage()
        {
            Pages = new List<ContentPage>
            {
                new Contents(this),
                new Introduction(),
                new Step_1()
            };

            foreach (ContentPage p in Pages)
            {
                Children.Add(p);
            }
        }
	}
}