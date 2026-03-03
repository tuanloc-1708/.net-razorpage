using MyStore.Business.LocNT;

namespace MyStore.Repositories.LocNT
{
    public interface IAccountRepository
    {
        Task<AccountMember?> GetAccountByEmailAndPassWordAsync(string email, string password);
    }
}
