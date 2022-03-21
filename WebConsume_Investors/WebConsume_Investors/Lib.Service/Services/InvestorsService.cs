using Lib.Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service.Services
{
    public class InvestorsService : IInvestorsService
    {
        public async Task<List<Investors>> GetInvestors()
        {
            var investorlist = new List<Investors>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44326/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("api/Investors");
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;
                    investorlist = JsonConvert.DeserializeObject<List<Investors>>(readTask);
                    return investorlist;
                }

                return investorlist;
            }
        }

        public async Task<bool> SaveInvestors(Investors investor)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://https://localhost:44326/");
                client.DefaultRequestHeaders.Clear();
                string jsonData = JsonConvert.SerializeObject(investor);
                var content = new StringContent(jsonData, UnicodeEncoding.UTF8, "application/json");

                var response = await client.PostAsync("api/Investors", content);
                if (response.IsSuccessStatusCode)
                {
                    var readTask = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<bool>(readTask);
                    return result;
                }
                return false;

            }
        }
    }
}
