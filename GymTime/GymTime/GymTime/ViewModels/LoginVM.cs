using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GymTime.ViewModels
{
    public class LoginVM : BaseVM
    {
        string email;
        string password;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                this.Notify("Email");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                this.Notify("Password");
            }
        }

        #region ICommand Methods
        public ICommand LoginCommand
        {
            get; set;
        }
        public ICommand LoginFacebookCommand
        {
            get; set;
        }

        public ICommand RegisterCommand
        {
            get; set;
        }

        public ICommand GymListCommand
        {
            get; set;
        }
        public ICommand ExerciseListCommand
        {
            get; set;
        }
        #endregion

        private Interfaces.IMessageService _messageService;
        private Interfaces.INavigationService _navigationService;

        public LoginVM()
        {
            this.LoginCommand = new Command(this.Login);
            this.RegisterCommand = new Command(this.Register);
            this.LoginFacebookCommand = new Command(this.LoginFacebook);
            this.GymListCommand = new Command(this.GymList);
            this.ExerciseListCommand = new Command(this.ExerciseList);

            this._messageService = DependencyService.Get<Interfaces.IMessageService>();
            this._navigationService = DependencyService.Get<Interfaces.INavigationService>();
        }

        private void Login()
        {
            if (this.Email == "adm" && this.Password == "123")
            {
                this._navigationService.NavigateToUserProfile();

            }
            else {
                this._messageService.ShowAsync("Dados Inválidos");
            }

        }

        #region Navigation Methods
        private void Register()
        {
            this._navigationService.NavigateToRegister();
        }

        private void LoginFacebook()
        {
            this._navigationService.NavigateToLoginFacebook();
        }

        private void GymList()
        {
            this._navigationService.NavigateToGymList();
        }
        private void ExerciseList()
        {
            this._navigationService.NavigateToExerciseList();
        }
        #endregion
    }
}