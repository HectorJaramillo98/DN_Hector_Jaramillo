using GymManager.Core.Equipment;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationsServices.Equipmentss
{
    public class EquipmentsAppService
    {
        public class EquipmentAppService : IEquipmentAppService
        {
            private readonly IRepository<int, Equipment> _repository;

            public EquipmentAppService(IRepository<int, Equipment> repository)
            {
                _repository = repository;
            }

            public async Task<int> AddEquipmentAsync(Equipment equip)
            {
                await _repository.AddAsync(equip);
                return equip.Id;
            }

            public async Task DeleteEquipmentAsync(int equipId)
            {
                await _repository.DeleteAsync(equipId);
            }

            public async Task EditEquipmentAsync(Equipment equip)
            {
                await _repository.UpdateAsync(equip);
            }

            public async Task<Equipment> GetEquipmentAsync(int memberId)
            {
                return await _repository.GetAsync(memberId);
            }

            public async Task<List<Equipment>> GetEquipmentsAsync()
            {
                return await _repository.GetAll().ToListAsync();
            }
        }
    }
}
