using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface IAccountRepository
    {
        AccountMember GetAccountByEmail(string email);
    }
}
