using MyStore.Business.LocNT;
using MyStore.Repositories.LocNT;

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
