using Linter.Modelos.Modelos;
using Microsoft.AspNetCore.Identity;

namespace Linter.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<TAB001_Usuarios> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<TAB001_Usuarios> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
