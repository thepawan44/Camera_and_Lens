using UI.Shared.Component.Charts.Models.ChartPlugins;

namespace UI.Shared.Component.Charts.Models.ChartOptions;

public class PieChartOptions : ChartOptions
{
    #region Properties, Indexers

    public PieChartPlugins Plugins { get; set; } = new();

    #endregion
}
