using UI.Pages.Auth.Models;
using UI.Pages.Auth.VModels;
using UI.Shared.Manager.Interface;
using UI.Shared.UtilityHelpers.Wrapper;

namespace UI.Pages.Auth.Manager.Interface
{
    public interface ILoginManager : IManager
    {
        Task<IResponse<LoginViewModel>> CreateToken(LoginModel model);
    }
}
