using UI.Pages.Auth.Manager.EndPoints;
using UI.Shared.Manager;

namespace UI.Shared.EndPointsManager
{
    public static class EndPointsManager
    {
        public static void InitializeAllEndPoints(string baseUrl)
        {
            AuthUtilityEndPoint.Initialize(baseUrl);
            LoginEndPoints.Initialize(baseUrl);
        }
    }
}
