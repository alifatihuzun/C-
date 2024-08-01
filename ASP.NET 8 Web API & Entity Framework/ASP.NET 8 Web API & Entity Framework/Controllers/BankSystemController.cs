using ASP.NET_8_Web_API___Entity_Framework.Data;
using ASP.NET_8_Web_API___Entity_Framework.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_8_Web_API___Entity_Framework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankSystemController : ControllerBase
    {
        private readonly DataContext _context;

        public BankSystemController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<BankAccount>>> GetAllBankAccounts()
        {
            var BankAccounts = await _context.BankAccounts.ToListAsync();
      
            return Ok(BankAccounts);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<BankAccount>>> GetBankAccount(int id)
        {
            var BankAccount = await _context.BankAccounts.FindAsync(id);
            if (BankAccount == null)
            {
                return NotFound("Not Found");
            }

            return Ok(BankAccount);
        }
        [HttpPost]
        public async Task<ActionResult<List<BankAccount>>> AddBankAccount(BankAccount bankAccount)
        {
            _context.BankAccounts.Add(bankAccount);
            await _context.SaveChangesAsync();
                
            return Ok(await _context.BankAccounts.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<BankAccount>>> UpdateAccount(BankAccount UpdatedBankAccount)
        {
            var dbBankAccount = await _context.BankAccounts.FindAsync(UpdatedBankAccount.Id);
            if (dbBankAccount == null)
            {
                return NotFound("Not Found");
            }
            dbBankAccount.BankName = UpdatedBankAccount.BankName;
            dbBankAccount.FirstName = UpdatedBankAccount.FirstName;
            dbBankAccount.LastName = UpdatedBankAccount.LastName;
            dbBankAccount.Password = UpdatedBankAccount.Password;
            
            await _context.SaveChangesAsync();  

            return Ok(await _context.BankAccounts.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<BankAccount>>> DeleteAccount(int id)
        {
            var dbBankAccount = await _context.BankAccounts.FindAsync(id);
            if (dbBankAccount == null)
            {
                return NotFound("Not Found");
            }
            _context.BankAccounts.Remove(dbBankAccount);
            await _context.SaveChangesAsync();

            return Ok(await _context.BankAccounts.ToListAsync());
        }
    }
}
