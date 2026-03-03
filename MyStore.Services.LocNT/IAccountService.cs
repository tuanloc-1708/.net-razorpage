using MyStore.Business.LocNT;

namespace MyStore.Services.LocNT
{
    public interface IAccountService
    {
        Task<AccountMember?> Login(string email, string password);
    }
}
