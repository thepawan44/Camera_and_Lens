namespace UI.Pages.Auth.Manager.EndPoints
{
    public static class LoginEndPoints
    {
        private static string _baseUrl;
        public static void Initialize(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public static string CreateToken => $"{_baseUrl}Token/GetToken";
    }
}
