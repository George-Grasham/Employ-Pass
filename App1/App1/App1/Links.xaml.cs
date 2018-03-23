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
    public partial class Links : ContentPage
    {
        public Links()
        {
            InitializeComponent();
        }
        private void Apprenticeship_help(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.gov.uk/topic/further-education-skills/apprenticeships"));
        }
        private void heta_clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.heta.co.uk/"));
        }
    }
}