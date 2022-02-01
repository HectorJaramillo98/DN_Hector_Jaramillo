using GymManager.AplicationsServices.Members;
using GymManager.AplicationsServices.MembershipTypes;
using GymManager.Core.Members;
using GymManager.Core.MembershipTypes;
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
        private readonly IMembershipTypeAppService _membershipTypeAppService;
        private readonly ILogger _logger;
        public MembersController(IMembersAppService membersAppService, ILogger logger, IMembershipTypeAppService membershipTypesAppService)
        {
            _membershipTypeAppService = membershipTypesAppService;
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
                LastUpdate = DateTime.Now


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

        public async Task<IActionResult> Renewal()
        {
            List<Member> members = await _membersAppService.GetMembersAsync();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.Members = members;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Renewal(string searchByName)
        {
            List<Member> members = await _membersAppService.GetMembersAsync(searchByName);

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.Members = members;

            return View(viewModel);
        }

        public async Task<IActionResult> ChangeRenewal(int memberId)
        {
            Member member = await _membersAppService.GetMemberAsync(memberId);
            List<MembershipType> membershipTypes = await _membershipTypeAppService.GetMembershipTypesAsync();

            RenewalViewModel viewModel = new RenewalViewModel
            {
                IdMember = memberId,
                Member = member,
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeRenewal(RenewalViewModel renewalViewModel)
        {
            Member member = await _membersAppService.GetMemberAsync(renewalViewModel.IdMember);
            MembershipType membershipType = await _membershipTypeAppService.GetMembershipTypeAsync(renewalViewModel.IdMembershipType);
            member.Membershiptype = membershipType;
            membershipType.Members.Add(member);
            member.LastUpdate = DateTime.Now;

            await _membersAppService.EditMemberAsync(member);
            await _membershipTypeAppService.EditMembershipTypesAsync(membershipType);
            return RedirectToAction("Renewal");
        }


    }
}
