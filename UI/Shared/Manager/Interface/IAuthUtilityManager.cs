using UI.Shared.Models;

namespace UI.Shared.Manager.Interface
{
    public interface IAuthUtilityManager : IManager
    {
        Task<List<DropDownListModel>> GetDropDownListAsync(string DropDownType, string? Filter1 = null, string? Filter2 = null, int AllorSelect = 0);
    }
}
