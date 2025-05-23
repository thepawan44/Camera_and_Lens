﻿namespace UI.Shared.Component.Charts.Models.ChartDataset;

public record BarChartDatasetData : ChartDatasetData
{
    #region Constructors

    public BarChartDatasetData(string? datasetLabel, double data) : base(datasetLabel, data) { }

    #endregion
}
