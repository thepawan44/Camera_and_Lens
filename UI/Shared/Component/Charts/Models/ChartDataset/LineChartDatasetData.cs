namespace UI.Shared.Component.Charts.Models.ChartDataset;

public record LineChartDatasetData : ChartDatasetData
{
    #region Constructors

    public LineChartDatasetData(string? datasetLabel, double data) : base(datasetLabel, data) { }

    #endregion
}
