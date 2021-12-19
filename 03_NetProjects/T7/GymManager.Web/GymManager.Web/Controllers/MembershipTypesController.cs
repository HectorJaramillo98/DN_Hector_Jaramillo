using GymManager.AplicationsServices.MembershipTypes;
using GymManager.Core.Members;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypeAppService _membershipTypesAppService;

        public MembershipTypesController(IMembershipTypeAppService membershipTypeAppService)
        {
            _membershipTypesAppService = membershipTypeAppService;
        }
        public IActionResult Index()
        {
            List<MembershipType> membershipTypes = _membershipTypesAppService.GetMembershipTypes();

            MembershipTypeListViewModel viewModel = new MembershipTypeListViewModel();
            viewModel.MembershipType = membershipTypes;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int membershipTypeId)
        {
            MembershipType membershipType = _membershipTypesAppService.GetMembershipType(membershipTypeId);

            return View(membershipType);
        }

        public IActionResult Delete(int membershipTypeId)
        {
            _membershipTypesAppService.DeleteMembershipTypes(membershipTypeId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(MembershipType membershipType)
        {
            _membershipTypesAppService.EditMembershipTypes(membershipType);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(MembershipType membershipType)
        {
            _membershipTypesAppService.AddMembershipTypes(membershipType);
            return RedirectToAction("Index");
        }
    }
}
