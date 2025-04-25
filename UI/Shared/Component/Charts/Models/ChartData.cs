using System.Text.Json.Serialization;
using UI.Shared.Component.Charts.Models.ChartDataset;

namespace UI.Shared.Component.Charts.Models;

public class ChartData
{
    #region Properties, Indexers

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public List<IChartDataset>? Datasets { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public List<string>? Labels { get; set; }

    #endregion
}
