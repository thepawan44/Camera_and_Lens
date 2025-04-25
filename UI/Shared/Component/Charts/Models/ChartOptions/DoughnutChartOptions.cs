using UI.Shared.Component.Charts.Models.ChartPlugins;

namespace UI.Shared.Component.Charts.Models.ChartOptions;

public class DoughnutChartOptions : ChartOptions
{
    #region Properties, Indexers

    public DoughnutChartPlugins Plugins { get; set; } = new();

    #endregion
}
