using Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Core.Services.Services
{
    public interface IInvestorsService
    {
        IEnumerable<Investors> GetInvestors();
        Investors AddInvestors(Investors investor);
        Investors UpdateInvestors(Investors investor);
        Investors DeleteInvestors(int id);
    }
}
