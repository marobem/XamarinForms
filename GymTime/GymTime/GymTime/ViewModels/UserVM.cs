using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GymTime.ViewModels
{
    public class UserVM : BaseVM
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        private Interfaces.IMessageService _iMessageService;
        private Interfaces.INavigationService _iNavigationService;

        public ICommand RegisterCommand
        {
            get; set;
        }


        public UserVM()
        {
            this.RegisterCommand = new Command(this.Register);

            this._iMessageService = DependencyService.Get<Interfaces.IMessageService>();
            this._iNavigationService = DependencyService.Get<Interfaces.INavigationService>();
        }

        private void Register()
        {
            this._iNavigationService.NavigateToRegister();
        }
    }
}
