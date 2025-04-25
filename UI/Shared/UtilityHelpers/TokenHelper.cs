/*
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace UI.Shared.UtilityHelpers
{
    public class TokenHelper : ITokenHelper
    {
        private readonly ICacheService _cacheService;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ProtectedSessionStorage _sessionStorage;
        public TokenHelper(ProtectedSessionStorage sessionStorage, AuthenticationStateProvider authenticationStateProvider, ICacheService cacheService)
        {
            _authStateProvider = authenticationStateProvider;
            _cacheService = cacheService;
            _sessionStorage = sessionStorage;
        }

        public async Task<string> GetToken()
        {
            string savedToken = "";
            var authstate = await _authStateProvider.GetAuthenticationStateAsync();
            var UserName = authstate.User.GetUserName();
            if (string.IsNullOrEmpty(UserName))
            {
                return savedToken;
            }
            var SecurityStampFromToken = authstate.User.GetSecurityStamp();
            var SecurityStamp = await _cacheService.GetData<string>($"SecurityStamp-{UserName}");
            if (SecurityStampFromToken == SecurityStamp && !string.IsNullOrEmpty(SecurityStamp))
                savedToken = await _cacheService.GetData<string>($"Token-{UserName}");
            //var result =await _sessionStorage.GetAsync<LoginTokenModel>("InsuranceToken");
            //if (result.Success)
            //{
            //    savedToken= result.Value.JwtToken;
            //}
            return savedToken;
        }
    }

    public interface ITokenHelper : IManager
    {
        Task<string> GetToken();
    }
}
*/