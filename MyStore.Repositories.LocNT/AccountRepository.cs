using MyStore.Business.LocNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
