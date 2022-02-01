using GymManager.AplicationsServices.MembershipTypes;
using GymManager.Core.Members;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypeAppService _membershipTypesAppService;

        public MembershipTypesController(IMembershipTypeAppService membershipTypeAppService)
        {
            _membershipTypesAppService = membershipTypeAppService;
        }
        public async Task<IActionResult> Index()
        {
            List<MembershipType> membershipTypes = await  _membershipTypesAppService.GetMembershipTypesAsync();

            MembershipTypeListViewModel viewModel = new MembershipTypeListViewModel();
            viewModel.MembershipType = membershipTypes;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int membershipTypeId)
        {
            MembershipType membership = await _membershipTypesAppService.GetMembershipTypeAsync(membershipTypeId);

            MembershipTypeViewModel viewModel = new MembershipTypeViewModel
            {
                Id=membership.Id,
                Name=membership.Name,
                Cost= (decimal)membership.Cost,
                Duration=membership.Duration
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Delete(int membershipTypeId)
        {
            await _membershipTypesAppService.DeleteMembershipTypesAsync(membershipTypeId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MembershipType membershipType)
        {
            await _membershipTypesAppService.EditMembershipTypesAsync(membershipType);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipType membershipType)
        {
            await _membershipTypesAppService.AddMembershipTypesAsync(membershipType);
            return RedirectToAction("Index");
        }
    }
}
