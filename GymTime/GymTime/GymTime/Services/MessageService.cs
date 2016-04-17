using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.Services
{
    public class MessageService : Interfaces.IMessageService
    {
        public async Task ShowAsync(string message)
        {
            //throw new NotImplementedException();
            await GymTime.App.Current.MainPage.DisplayAlert("GymTime", message, "Ok");
        }

        public MessageService() { }
    }
}