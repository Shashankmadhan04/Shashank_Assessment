using Lib.Models.Models;
using Lib.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConsume_Investors.Controllers
{
    public class InvestorsController : Controller
    {
        private readonly IInvestorsService investorservice;
        public InvestorsController(IInvestorsService investor)
        {
            investorservice = investor;
        }

        public async Task<IActionResult> List()
        {
            var list = await investorservice.GetInvestors();
            return View(list);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Investors investor)
        {
            if (ModelState.IsValid)
            {
                bool response = await investorservice.SaveInvestors(investor);
                if (response)
                {
                    return RedirectToAction("List");
                }
            }
            return View(investor);
        }
    }
}
