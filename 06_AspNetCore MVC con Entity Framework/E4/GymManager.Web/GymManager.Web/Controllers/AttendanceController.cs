using GymManager.Core.AttendanceReport;
using GymManager.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.Web.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MemberIn()
        {

            return View();
        }

        public IActionResult MemberOut()
        {
            return View();
        }
    }
}
