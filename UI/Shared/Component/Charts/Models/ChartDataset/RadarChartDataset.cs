﻿using System.Text.Json.Serialization;

namespace UI.Shared.Component.Charts.Models.ChartDataset;

public class RadarChartDataset : ChartDataset
{
    #region Properties, Indexers

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public new string? BackgroundColor { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public new string? BorderColor { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public new double BorderWidth { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public new string? HoverBackgroundColor { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public new string? HoverBorderColor { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public new string? HoverBorderWidth { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] public string? Label { get; set; }

    #endregion
}
