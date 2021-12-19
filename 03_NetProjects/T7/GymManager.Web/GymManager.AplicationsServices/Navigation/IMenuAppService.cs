using GymManager.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationsServices.Navigation
{
    public interface IMenuAppService
    {
        List<UserMenuItem> GetMenu();
    }
}
