using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyStore.Services.LocNT; 
using System.Security.Claims;

namespace MyStoreRazorPage.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IAccountService _accountService;

        public LoginModel(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [BindProperty]
        public string Email { get; set; } = default!;

        [BindProperty]
        public string Password { get; set; } = default!;

        public string ErrorMessage { get; set; } = "";

        public IActionResult OnGet()
        {
            
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Products/Index");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
          
            var account = _accountService.Login(Email, Password);

            if (account == null)
            {
                ErrorMessage = "Wrong Email or Password!";
                return Page();
            }

           
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, account.FullName ?? "User"),
                new Claim(ClaimTypes.Email, account.EmailAddress),
                new Claim(ClaimTypes.Role, account.MemberRole.ToString()) 
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true 
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

        
            return RedirectToPage("/Products/Index");
        }
    }
}