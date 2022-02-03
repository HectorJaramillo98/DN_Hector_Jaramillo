using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationsServices.Members
{
    public interface ICityAppService
    {
        Task<List<City>> GetCitiesAsync();
        Task<City> GetCityAsync(int cityId);
    }
}
