using Microsoft.AspNetCore.Http;
using System.Security.Claims;
namespace UI.Configuration.Extension
{
    internal static class ClaimsPrincipalExtensions
    {
        internal static string GetUserName(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.FindFirstValue("UserName") ?? string.Empty;

        internal static int GetUserId(this ClaimsPrincipal claimsPrincipal)
            => int.TryParse(claimsPrincipal.FindFirstValue("UserId"), out var id) ? id : 0;

        internal static string GetFullName(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.FindFirstValue("FullName") ?? string.Empty;

        internal static string GetEmail(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.FindFirstValue("Email") ?? string.Empty;

        internal static string GetGenderType(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.FindFirstValue("GenderType") ?? string.Empty;

        internal static int GetRoleId(this ClaimsPrincipal claimsPrincipal)
            => int.TryParse(claimsPrincipal.FindFirstValue("RoleId"), out var roleId) ? roleId : 0;

        internal static string GetRoleName(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.FindFirstValue("RoleName") ?? string.Empty;

    }
}
