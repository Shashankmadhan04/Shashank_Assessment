using Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib.Core.Services.Services
{
    public class InvestorsService : IInvestorsService
    {
        API_InvestorsContext dbContext;

        public InvestorsService(API_InvestorsContext db)
        {
            dbContext = db;
        }
        public Investors AddInvestors(Investors investor)
        {
            dbContext.Investors.Add(investor);
            dbContext.SaveChanges();
            return investor;
        }

        public Investors DeleteInvestors(int id)
        {
            var inv = dbContext.Investors.Find(id);
            dbContext.Investors.Remove(inv);
            dbContext.SaveChanges();
            return inv;
        }

        public IEnumerable<Investors> GetInvestors()
        {
            return dbContext.Investors.ToList();
        }

        public Investors UpdateInvestors(Investors investor)
        {
            dbContext.Entry(investor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return investor;
        }
    }
}
