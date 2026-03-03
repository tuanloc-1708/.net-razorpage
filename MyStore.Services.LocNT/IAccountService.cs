using MyStore.Business.LocNT;

namespace MyStore.Services.LocNT
{
    public interface IAccountService
    {
        AccountMember Login(string email, string password);
    }
}
