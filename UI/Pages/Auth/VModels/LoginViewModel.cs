namespace UI.Pages.Auth.VModels
{
    public class LoginViewModel
    {
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int ExpiresIn { get; set; }
    }
}
