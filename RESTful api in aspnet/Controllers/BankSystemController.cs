using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTful_api_in_aspnet.Models;

namespace RESTful_api_in_aspnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankSystemController : ControllerBase
    {
        public static List<BankSystem> listofBankSystems = new List<BankSystem>
        {
            new BankSystem {AccountId = 1, Name = "Ali", Surname = "Uzun", Age = 20 },
                new BankSystem {AccountId = 2, Name = "Rabia", Surname = "Beyaz", Age = 20 },
                    new BankSystem {AccountId = 3, Name = "Fatih", Surname = "Kaya", Age = 20 },
                        new BankSystem {AccountId = 4, Name = "Ayşe", Surname = "Kısa", Age = 20 },
        };
        [HttpGet]
        public IEnumerable<BankSystem> Get()
        {
            return listofBankSystems;
        }
        [HttpPost]
        public void post([FromBody]BankSystem bankSystem)
        {
            listofBankSystems.Add(bankSystem);
        }
        [HttpPut("{AccountId}")]
        public void Put(int id, BankSystem banksystem)
        {
            listofBankSystems[id] = banksystem;
        }
        [HttpDelete("{AccountId}")]
        public void delete(int id)
        {
            listofBankSystems.RemoveAt(id);
        }

    }
}
