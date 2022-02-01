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
        public MembersController(IMembersAppService membersAppService, ILogger logger)
        {
            _membersAppService = membersAppService;
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {

            List<Member> members = await _membersAppService.GetMembersAsync();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            _logger.Information("Index in Members executed");

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Delete(int memberId)
        {
            await _membersAppService.DeleteMembersAsync(memberId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int memberId)
        {

            Member member = await _membersAppService.GetMemberAsync(memberId);

            MemberViewModel viewModel = new MemberViewModel
            {
                AllowNewsletter = member.AllowNewsletter,
                BirthDay = member.Birthday,
                CityId = member.City.Id,
                Email = member.Email,
                Id = member.Id,
                LastName = member.LastName,
                Name = member.Name,
                LastUpdate = DateTime.Now
                

            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MemberViewModel viewModel)
        {
            Member member = new Member
            {
                Name = viewModel.Name,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                City = new City
                {
                    Id = viewModel.CityId
                },
                Birthday = viewModel.BirthDay,
                AllowNewsletter = viewModel.AllowNewsletter,
                CreatedOn = DateTime.Now,
                LastUpdate= DateTime.Now
                

            };

            await _membersAppService.AddMembersAsync(member);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Member member)
        {
            await _membersAppService.EditMemberAsync(member);
            return RedirectToAction("Index");
        }


        public IActionResult Test()
        {
            return View();
        }
    }
}
