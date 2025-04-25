namespace UI.Shared.Models
{
    public class GenericApiParameterModel
    {
        public string ModuleName { get; set; } = string.Empty;
        public Dictionary<string, object> Parameter { get; set; } = new();
    }
}
