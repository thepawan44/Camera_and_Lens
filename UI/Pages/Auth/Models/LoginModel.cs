namespace UI.Pages.Auth.Models
{

    public class LoginModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
    public class LoginTokenModel
    {
        public string UserName { get; set; } = string.Empty;
        public string JwtToken { get; set; } = string.Empty;
        public int ExpiresIn { get; set; }
        public DateTime OperationDate { get; set; }
    }
}
