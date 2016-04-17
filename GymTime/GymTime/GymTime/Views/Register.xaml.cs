using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GymTime.Views
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.RegisterVM();
        }

        async void mButtonCreateContact_Click(object sender, EventArgs args)
        {
            //await Navigation.PopModalAsync();
            throw new NotImplementedException();
        }
    }
}
