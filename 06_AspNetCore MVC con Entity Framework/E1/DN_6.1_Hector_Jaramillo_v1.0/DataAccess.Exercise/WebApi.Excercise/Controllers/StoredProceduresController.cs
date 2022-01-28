using DataAccess.Exercise;
using DataAccess.Exercise.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Excercise.Model;

namespace WebApi.Excercise.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoredProceduresController : Controller
    {
        StoredProcedures _stored;
        public StoredProceduresController()
        {
            _stored = new StoredProcedures();
        }
        // GET: StoredProceduresController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet(nameof(GetLastWeekMembers))]
        public IEnumerable<Member> GetLastWeekMembers()
        {
            var recentMembers = _stored.RecentRegisterMembers();
            return recentMembers;
        }

        [HttpPost(nameof(GetProductById) + "/{id}")]
        public IEnumerable<Product> GetProductById(int id)
        {
            var products = _stored.ProductsInStockForType(id);
            return products;
        }


        [HttpPost(nameof(GetSaleProducts))]
        public void GetSaleProducts([FromBody] GetSales getsales)
        {
           _stored.SaleProducts(getsales.IdInventory, getsales.IdUser, getsales.Amount);            
        }


        // GET: StoredProceduresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoredProceduresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoredProceduresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoredProceduresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoredProceduresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoredProceduresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoredProceduresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
