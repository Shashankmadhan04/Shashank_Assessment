using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Models.Models
{
    public class Investors
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
