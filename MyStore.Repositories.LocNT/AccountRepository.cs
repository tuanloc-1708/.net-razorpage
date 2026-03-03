using Microsoft.EntityFrameworkCore;
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

        public async Task<AccountMember?> GetAccountByEmailAndPassWordAsync(string email, string password)
        {
            return await _context.AccountMembers.FirstOrDefaultAsync(a =>
                a.EmailAddress == email && a.MemberPassword == password);
        }
    }
}
