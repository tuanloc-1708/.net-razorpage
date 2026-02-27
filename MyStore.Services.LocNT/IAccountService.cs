using MyStore.Business.LocNT;

namespace MyStore.Services.LocNT
{
    public interface IAccountService
    {
        AccountMember GetAccountByEmail(string email);
    }
}
