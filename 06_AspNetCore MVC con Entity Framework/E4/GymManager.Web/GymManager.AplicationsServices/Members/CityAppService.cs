using GymManager.Core.Members;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationsServices.Members
{
    public class CityAppService : ICityAppService
    {
        private readonly IRepository<int, City> _repository;

        public CityAppService(IRepository<int, City> repository)
        {
            _repository = repository;
        }
        public async Task<List<City>> GetCitiesAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<City> GetCityAsync(int cityId)
        {
            return await _repository.GetAsync(cityId);
        }

    }
}
