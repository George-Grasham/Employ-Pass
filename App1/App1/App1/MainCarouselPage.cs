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
                new Step_1(),
                new Step_2(),
                new Step_3(),
                new Step_4(),
                new Step_5(),
                new Step_6(),
                new Step_7(),
                new Step_8(),
                new Links()
            };

            foreach (ContentPage p in Pages)
            {
                Children.Add(p);
            }
        }
	}
}