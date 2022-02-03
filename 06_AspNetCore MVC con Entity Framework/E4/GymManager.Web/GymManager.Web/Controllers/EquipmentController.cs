using GymManager.AplicationsServices.Equipmentss;
using GymManager.Core.Equipment;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly IEquipmentAppService _equipmentAppService;

        public EquipmentController(IEquipmentAppService equipmentAppService)
        {
            _equipmentAppService = equipmentAppService;
        }
        public async Task<IActionResult> Index()
        {
            List<Equipment> equipmentList = await _equipmentAppService.GetEquipmentsAsync();

            EquipmentListViewModel viewModel = new EquipmentListViewModel();
            viewModel.EquipmentViewList = equipmentList;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int equipmentId)
        {
            Equipment equip = await _equipmentAppService.GetEquipmentAsync(equipmentId);

            EquipmentViewModel viewModel = new EquipmentViewModel
            {
                Id = equipmentId,
                Name = equip.Name,
                Description = equip.Description
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Delete(int equipmentId)
        {
            await _equipmentAppService.DeleteEquipmentAsync(equipmentId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Equipment equipmentId)
        {
            await _equipmentAppService.EditEquipmentAsync(equipmentId);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Equipment equipment)
        {
            await _equipmentAppService.AddEquipmentAsync(equipment);
            return RedirectToAction("Index");
        }
    }
}
