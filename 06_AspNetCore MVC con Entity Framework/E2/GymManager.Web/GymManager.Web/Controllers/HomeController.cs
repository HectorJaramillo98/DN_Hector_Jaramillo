using GymManager.AplicationsServices.Members;
using GymManager.Core.Members;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMembersAppService _membersAppService;

        public HomeController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }
        public IActionResult Index()
        {
            var members = _membersAppService.GetMembersAsync();
            return View(members);
        }
    }
}
