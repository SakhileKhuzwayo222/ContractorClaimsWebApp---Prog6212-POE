using System.Collections.Generic;
using Contractor_Claims.Models;

namespace Contractor_Claims.Services
{
    public interface IAccountService
    {
        void CreateAccount(Account account);
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountById(int id);
        void UpdateAccount(Account account);
        void DeleteAccount(int id);
        Account Authenticate(string username, string password); // Optional for authentication
    }
}
