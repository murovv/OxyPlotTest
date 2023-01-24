using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using OxyPlotTest.ViewModels;

namespace OxyPlotTest.Views;

public partial class PlotView : UserControl
{
    public PlotView()
    {
        InitializeComponent();
        DataContext = new PlotViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}