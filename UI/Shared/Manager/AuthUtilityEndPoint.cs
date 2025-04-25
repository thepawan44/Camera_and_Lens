﻿namespace UI.Shared.Manager
{
    public static class AuthUtilityEndPoint
    {
        private static string _baseUrl;
        public static void Initialize(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public static string DropDownList => $"{_baseUrl}Utility/GetDropDownList";

        public static string DropDownListFilter(string DropDownType, string? Filter1 = null, string? Filter2 = null)
        {
            return $"{DropDownList}?DropDownType={DropDownType}&Filter1={Filter1}&Filter2={Filter2}";
        }
    }
}
