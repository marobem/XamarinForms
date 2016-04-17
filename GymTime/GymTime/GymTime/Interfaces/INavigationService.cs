using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.Interfaces
{
    public interface INavigationService
    {
        //Task NavigateTo(string viewName, object param);  //este é um método de fazer
        Task NavigateToLogin();
        Task NavigateToLoginFacebook();
        Task NavigateToRegister();
        Task NavigateToMain();
        Task NavigateToUserProfile();
        Task NavigateToGymList();
        Task NavigateToGymProfile();
        Task NavigateToGymRegister();
        Task NavigateToExerciseList();
    }
}
