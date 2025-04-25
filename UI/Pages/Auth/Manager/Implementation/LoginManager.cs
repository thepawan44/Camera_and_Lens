using UI.Configuration.Extension;
using UI.Pages.Auth.Manager.EndPoints;
using UI.Pages.Auth.Manager.Interface;
using UI.Pages.Auth.Models;
using UI.Pages.Auth.VModels;
using UI.Shared.UtilityHelpers.Wrapper;

namespace UI.Pages.Auth.Manager.Implementation
{
    public class LoginManager : ILoginManager
    {
        readonly HttpClient _httpClient = new();
        readonly private IHttpClientFactory _httpClientFactory = default!;
        public LoginManager(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient("ApiGateway");
        }

        public async Task<IResponse<LoginViewModel>> CreateToken(LoginModel model)
        {
            var res = await _httpClient.PostAsJsonAsync(LoginEndPoints.CreateToken, model);
            var data = await res.ToResult<LoginViewModel>();
            return data;
        }
    }
}
