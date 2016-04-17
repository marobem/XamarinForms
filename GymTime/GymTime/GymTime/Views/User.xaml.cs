using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GymTime.Views
{
    public partial class User : ContentPage
    {
        public User()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.UserVM();
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            //await Navigation.PopModalAsync();
            throw new NotImplementedException();
        }
    }
}
