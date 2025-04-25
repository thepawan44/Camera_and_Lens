using Microsoft.AspNetCore.Components;
using UI.Shared.Component.Charts.Models;
using UI.Shared.Component.Charts.Models.ChartDataset;
using UI.Shared.Component.Charts.Models.ChartOptions;
using UI.Shared.Models;

namespace UI.Shared.Component.Charts
{
    public partial class ChartComponent
    {
        [Parameter] public int height { get; set; } = 350;

        [Parameter] public int width { get; set; } 
        [Parameter] public string? Chart { get; set; }

        [Parameter] public List<ChartViewModel> chartViewModels { get; set; } = default!;

        private List<IChartDataset> datasets = new List<IChartDataset>();
        private ChartData chartData { get; set; } = new();
        private BarChartOptions barChartOptions { get; set; } = new BarChartOptions();
        private LineChartOptions lineChartOptions { get; set; } = new LineChartOptions();
        private PieChartOptions pieChartOptions { get; set; } = new PieChartOptions();
        private DoughnutChartOptions doughnutChartOptions { get; set; } = new DoughnutChartOptions();
        private BarChart barchart { get; set; } = new();
        private LineChart lineChart { get; set; } = default!;
        private PieChart pieChart { get; set; } = default!;
        private DoughnutChart donutChart { get; set; } = default!;

/*        protected async override Task OnInitializedAsync()
        {
            var _currentUser = await _customAuthStateProvider.CurrentUser();
        }*/
        public async Task getChart()
        {
            _loading.Show();
            if (Chart == "BarChart")
            {
                await BarChart();
            }
            else if (Chart == "LineChart")
            {
                await LineChart();
            }
            else if (Chart == "MultipleLine")
            {
                await MultipleLineChart();
            }
            else if (Chart == "Pie")
            {
                await PieChart();
            }
            else if (Chart == "Donut")
            {
                await DonutChart();
            }
            
            else
            {

            }
            _loading.Hide();
            //if (chartViewModels != null && chartViewModels.Count > 0)
            //{
            //    
            //}
            //else
            //{
            //    _loading.Hide();
            //    return;
            //}
        }
        private async Task BarChart()
        {

            try
            {
                List<string> labels = new List<string>();
                var distinctGroup = chartViewModels
                .GroupBy(x => x.Identity)
                .Select(group => group.ToList())
                .ToList();
                datasets.Clear();
                foreach (var DistinctGroupViewModel in distinctGroup)
                {
                    labels = DistinctGroupViewModel.Select(x => x.Xaxis).ToList();
                    var dataset1 = new BarChartDataset()
                    {
                        Data = DistinctGroupViewModel.Select(x => x.Value).ToList(),
                        Label = DistinctGroupViewModel.FirstOrDefault(x => x.Identity != null)?.Identity
                    };
                    datasets.Add(dataset1);
                }
                chartData = new ChartData
                {
                    Labels = labels,
                    Datasets = datasets
                };

                barChartOptions = new BarChartOptions();
                barChartOptions.Responsive = true;
                barChartOptions.Interaction = new Interaction { Mode = InteractionMode.X };
                barChartOptions.IndexAxis = "x";

                barChartOptions.Scales.X.Title.Text = chartViewModels.Select(x => x.Type).FirstOrDefault();
                barChartOptions.Scales.X.Title.Display = true;

                barChartOptions.Scales.Y.Title.Text = chartViewModels.Select(x => x.IndicatorName).FirstOrDefault();
                barChartOptions.Scales.Y.Title.Display = true;
                barChartOptions.Scales.Y.BeginAtZero = true ;

                await barchart.InitializeAsync(chartData, barChartOptions);
                if (barchart != null)
                {
                    await barchart.UpdateAsync(chartData, barChartOptions);
                }

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return;
            
        }



       


        private async Task LineChart()
        {
            try
            {
                datasets = new();
                var labels = chartViewModels.Select(x => x.Xaxis).ToList();
                var dataset1 = new LineChartDataset()
                {
                    Data = chartViewModels.Select(x => x.Value).ToList(),
                    Label = chartViewModels.FirstOrDefault(x => x.Identity != null)?.Identity,
                };
                datasets.Add(dataset1);
                chartData = new ChartData
                {
                    Labels = labels,
                    Datasets = datasets
                };

                lineChartOptions = new LineChartOptions();
                lineChartOptions.Responsive = true;
                lineChartOptions.Interaction = new Interaction { Mode = InteractionMode.X };
                lineChartOptions.IndexAxis = "x";

                lineChartOptions.Scales.X.Title.Text = chartViewModels.Select(x => x.Type).FirstOrDefault();
                lineChartOptions.Scales.X.Title.Display = true;

                lineChartOptions.Scales.Y.Title.Text = chartViewModels.Select(x => x.IndicatorName).FirstOrDefault();
                lineChartOptions.Scales.Y.Title.Display = true;
                lineChartOptions.Scales.Y.BeginAtZero = false;



                await lineChart.InitializeAsync(chartData, lineChartOptions);
                if (lineChart != null)
                {
                    await lineChart.UpdateAsync(chartData, lineChartOptions);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        private async Task PieChart()
        {
            try
            {
                var indicatorName = chartViewModels.FirstOrDefault()?.IndicatorName;

                var labels = chartViewModels.Select(x => x.Xaxis).ToList();

                var datasets = new List<IChartDataset>();
                var dataset1 = new PieChartDataset()
                {
                    Data = chartViewModels.Select(x => x.Value).ToList(),
                };
                datasets.Add(dataset1);

                var chartData = new ChartData
                {
                    Labels = labels,
                    Datasets = datasets
                };

                pieChartOptions = new PieChartOptions();
                pieChartOptions.Responsive = true;
                pieChartOptions.Plugins.Title.Text = indicatorName;
                pieChartOptions.Plugins.Title.Display = true;

                pieChartOptions.Plugins.Legend.Position = "right";

                await pieChart.InitializeAsync(chartData, pieChartOptions);

                if (pieChart != null)
                {
                    await pieChart.UpdateAsync(chartData, pieChartOptions);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        private async Task DonutChart()
        {
            try
            {
                var indicatorName = chartViewModels.FirstOrDefault()?.IndicatorName;
                var labels = chartViewModels.Select(x => x.Xaxis).ToList();
                var datasets = new List<IChartDataset>();
                var dataset1 = new DoughnutChartDataset()
                {
                    Data = chartViewModels.Select(x => x.Value).ToList(),
                };
                datasets.Add(dataset1);

                var chartData = new ChartData
                {
                    Labels = labels,
                    Datasets = datasets
                };

                doughnutChartOptions = new DoughnutChartOptions();
                doughnutChartOptions.Responsive = true;
                doughnutChartOptions.Plugins.Title.Text = indicatorName;
                doughnutChartOptions.Plugins.Title.Display = true;

                doughnutChartOptions.Plugins.Legend.Position = "right";

                await donutChart.InitializeAsync(chartData, doughnutChartOptions);
                if (donutChart != null)
                {
                    await donutChart.UpdateAsync(chartData, doughnutChartOptions);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        private async Task MultipleLineChart()
        {
            var distinctGroup = chartViewModels
            .GroupBy(x => x.Identity)
            .Select(group => group.ToList())
            .ToList();
            datasets.Clear();
            foreach (var DistinctGroupViewModel in distinctGroup)
            {
                try
                {
                    var labels = DistinctGroupViewModel.Select(x => x.Xaxis).ToList();

                    var dataset1 = new LineChartDataset()
                    {
                        Data = DistinctGroupViewModel.Select(x => x.Value).ToList(),
                        Label = DistinctGroupViewModel.FirstOrDefault(x => x.Identity != null)?.Identity
                    };
                    datasets.Add(dataset1);

                    chartData = new ChartData
                    {
                        Labels = labels,
                        Datasets = datasets
                    };

                    lineChartOptions = new LineChartOptions();
                    lineChartOptions.Responsive = true;
                    lineChartOptions.Interaction = new Interaction { Mode = InteractionMode.X };
                    //lineChartOptions.IndexAxis = "x";

                    lineChartOptions.Scales.X.Title.Text = DistinctGroupViewModel.Select(x => x.Type).FirstOrDefault();
                    lineChartOptions.Scales.X.Title.Display = true;

                    lineChartOptions.Scales.Y.Title.Text = DistinctGroupViewModel.Select(x => x.IndicatorName).FirstOrDefault();
                    lineChartOptions.Scales.Y.Title.Display = true;
                    lineChartOptions.Scales.Y.BeginAtZero = false;

                    await lineChart.InitializeAsync(chartData, lineChartOptions);
                    if (lineChart != null)
                    {
                        await lineChart.UpdateAsync(chartData, lineChartOptions);
                    }

                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        public async Task ClearDataSet()
        {
            datasets.Clear();
        }



    }
}