using System.Collections.Generic;
using System.Linq;
using Contractor_Claims.Models;

namespace Contractor_Claims.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;

        public AccountService(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public void CreateAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }

        public Account GetAccountById(int id)
        {
            return _context.Accounts.FirstOrDefault(a => a.Id == id);
        }

        public void UpdateAccount(Account account)
        {
            var existingAccount = _context.Accounts.FirstOrDefault(a => a.Id == account.Id);
            if (existingAccount != null)
            {
                existingAccount.Username = account.Username;
                existingAccount.Password = account.Password; // Consider encryption
                existingAccount.Email = account.Email;
                existingAccount.IsActive = account.IsActive;
                _context.SaveChanges();
            }
        }

        public void DeleteAccount(int id)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Id == id);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                _context.SaveChanges();
            }
        }

        public Account Authenticate(string username, string password)
        {
            return _context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password); // Hashing/encryption recommended
        }
    }
}
