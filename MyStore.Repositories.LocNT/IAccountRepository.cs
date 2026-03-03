using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface IAccountRepository
    {
        AccountMember GetAccountByEmailAndPassWord(string email, string password);
    }
}
