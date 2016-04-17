using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.Interfaces
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
