using MyStore.Business.LocNT;
using MyStore.Repositories.LocNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Services.LocNT
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public AccountMember GetAccountByEmail(string email)
        {
            return _accountRepository.GetAccountByEmail(email);
        }
    }
}
