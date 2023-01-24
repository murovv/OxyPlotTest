using System;
using System.Collections.Generic;
using System.Linq;
using OxyPlot;

namespace OxyPlotTest.ViewModels;

public class PlotViewModel:ViewModelBase
{
    public PlotViewModel()
    {
        Items = Enumerable.Range(0, 3000).Select(x => new DataPoint(x / 10.0, Math.Sin(x / 10.0))).ToList();
    }

    public List<DataPoint> Items { get; set; }
}