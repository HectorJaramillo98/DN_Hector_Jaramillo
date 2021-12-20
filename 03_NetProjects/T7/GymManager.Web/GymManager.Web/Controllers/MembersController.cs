using GymManager.AplicationsServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private readonly IMembersAppService _membersAppService;
        private readonly ILogger _logger;

        public MembersController(IMembersAppService membersAppService, 
            ILogger logger)
        {
            _membersAppService = membersAppService;
            _logger = logger;
        }
        public IActionResult Index()
        {
           
            List<Member> members = _membersAppService.GetMembers();
            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            _logger.Information("Index executed");
            return View(viewModel);
        }

        public IActionResult Create()
        {

            return View();
        }

        public IActionResult Delete(int memberId)
        {
            _membersAppService.DeleteMembers(memberId);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int memberId)
        {
            Member member = _membersAppService.GetMember(memberId);

            return View(member);

        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            _membersAppService.AddMembers(member);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            _membersAppService.EditMember(member);
            return RedirectToAction("Index");
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
