using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	
	public partial class Introduction : ContentPage
	{
		public Introduction ()
		{
			InitializeComponent ();
            //Shield.Source = ImageSource.FromResource("App1.Resources.HHSShield.jpg");
            HessleLogo.Source = ImageSource.FromResource("App1.Resources.HHSLogo.png");
            ConsortiumLogo.Source = ImageSource.FromResource("App1.Resources.TCATLogo.png");
        }
	}
}