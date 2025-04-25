namespace UI.Shared.Models
{
    public class UserDetailsModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public int BranchId { get; set; }
        public string BranchType { get; set; } = string.Empty;
    }
}
