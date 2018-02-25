using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Step_5 : ContentPage
	{
		public Step_5 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://drive.google.com/file/d/0B3iCZ9SZooRddF9ibVhMdUx2N214Um9MOUNqUE5mVVNyeXpV/view?usp=sharing"));
        }

        


    }
}