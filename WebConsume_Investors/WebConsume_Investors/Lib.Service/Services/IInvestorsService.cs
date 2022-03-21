using Lib.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service.Services
{
    public interface IInvestorsService
    {
        Task<List<Investors>> GetInvestors();
        Task<bool> SaveInvestors(Investors investor);
    }
}
