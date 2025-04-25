using Microsoft.AspNetCore.Components;
using UI.Pages.Auth.Manager.Interface;
using UI.Pages.Auth.Models;
using UI.Shared.Component.Enums;

namespace UI.Pages.Auth.Pages
{
    public partial class LoginPage
    {
        private LoginModel login = new ();
        private bool showPassword;
        [Inject] public ILoginManager loginManager { get; set; } = default!;
        private void TogglePasswordVisibility()
        {
            showPassword = !showPassword;
        }
        private async Task HandleLogin()
        {
            _loading.Show();
            try
            {
                var response = await loginManager.CreateToken(login);
                if (response != null)
                {
                    await _customAuthStateProvider.UpadteAuthenticationState(response.Data);
                    if (response.Succeeded)
                    {
                        if (response.Data.RoleId == 1)
                        {
                            _toastMessage.Notify(new(ToastType.Success, "Login Successful!!"));
                           // _navigationManager.NavigateTo("/admin-dashboard", true);
                        }
                        else if (response.Data.RoleId != 1)
                        {
                            _navigationManager.NavigateTo("/", true);
                        }
                    }
                    else if (response.Messages != null)
                    {
                        _toastMessage.Notify(new(ToastType.Danger, response.Messages.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                _toastMessage.Notify(new(ToastType.Warning, ex.Message));
            }
            finally
            {
                _loading.Hide();
            }
        }
        public async Task Navigatetoregister()
        {
            try
            {
                _navigationManager.NavigateTo("/usersetup");
            }
            catch (Exception ex)
            {
                _toastMessage.Notify(new(ToastType.Warning, ex.Message));
            }
        }
    }
}