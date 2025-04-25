namespace UI.Shared.Models
{
    public class GenericApiModel
    {
        public string ModuleName { get; set; } = string.Empty;
        public string Flag { get; set; } = string.Empty;
        public object Model { get; set; } = default!;
    }
}
