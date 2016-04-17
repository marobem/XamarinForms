using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.Services
{
    public class NavigationService : Interfaces.INavigationService
    {
        public async Task NavigateToLogin()
        {
            await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.Login());
        }
        public async Task NavigateToLoginFacebook()
        {
            //await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.LoginFacebook());
        }
        public async Task NavigateToMain()
        {
            //await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.MainPage());
        }
        public async Task NavigateToRegister()
        {
            await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.Register());
        }
        public async Task NavigateToGymList()
        {
            await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.GymList());
        }
        public async Task NavigateToGymProfile()
        {
            //await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.GymProfile());
        }
        public async Task NavigateToGymRegister()
        {
            //await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.GymRegister());
        }
        public async Task NavigateToUserProfile()
        {
            await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.User());
        }
        public async Task NavigateToExerciseList()
        {
            //await GymTime.App.Current.MainPage.Navigation.PushAsync(new Views.ExerciseList());
        }

        public NavigationService() { }
    }
}
