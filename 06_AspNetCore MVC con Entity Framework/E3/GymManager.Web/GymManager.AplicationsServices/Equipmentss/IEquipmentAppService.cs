using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManager.Core.Equipment;
using System.Threading.Tasks;
namespace GymManager.AplicationsServices.Equipmentss
{
    public interface IEquipmentAppService
    {
        Task<List<Equipment>> GetEquipmentsAsync();

        Task<int> AddEquipmentAsync(Equipment equipment);

        Task EditEquipmentAsync(Equipment equipment);

        Task DeleteEquipmentAsync(int equipmentId);

        Task<Equipment> GetEquipmentAsync(int equipmentId);
    }
}
