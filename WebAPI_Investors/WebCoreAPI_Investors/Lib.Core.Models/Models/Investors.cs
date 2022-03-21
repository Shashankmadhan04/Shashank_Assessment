using System;
using System.Collections.Generic;

namespace Lib.Core.Models
{
    public partial class Investors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string ProfilePicture { get; set; }
        public decimal TotalInvestment { get; set; }
        public string Gender { get; set; }
    }
}
