using GymManager.AplicationsServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMembersAppService _membersAppService;

        public MembersController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }
        public IActionResult Index()
        {
            List<Member> members = _membersAppService.GetMembers();
            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members=members;


            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
