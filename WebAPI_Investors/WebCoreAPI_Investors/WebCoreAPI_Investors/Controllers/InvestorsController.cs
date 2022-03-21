using Microsoft.AspNetCore.Http;
using Lib.Core.Models;
using Lib.Core.Services.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Investors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorsController:ControllerBase
    {
        private readonly IInvestorsService investorservice;
        public InvestorsController(IInvestorsService investor)
        {
            investorservice = investor;
        }

        [HttpGet]
        public IEnumerable<Investors> GetInvestors()
        {
            return investorservice.GetInvestors();
        }

        [HttpPost]
        public Investors AddInvestors(Investors inv)
        {
            return investorservice.AddInvestors(inv);
        }

        [HttpPut]
        public Investors EditInvestors(Investors inv)
        {
            return investorservice.UpdateInvestors(inv);
        }

        [HttpDelete]
        public Investors DeleteInvestors(int id)
        {
            return investorservice.DeleteInvestors(id);
        }
    }
}
