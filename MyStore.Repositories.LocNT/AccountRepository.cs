using MyStore.Business.LocNT;
using MyStore.DBContext.LocNT;

namespace MyStore.Repositories.LocNT
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MyStoreContext _context;

        public AccountRepository(MyStoreContext context)
        {
            _context = context;
        }

        public AccountMember GetAccountByEmail(string email)
        {
            return _context.AccountMembers.FirstOrDefault(e => e.EmailAddress == email);
        }
    }
}
