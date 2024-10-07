using System.Threading.Tasks;
using Ursa.Controls;

namespace Ursa.Demo.Views;

public partial class MainWindow : UrsaWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    protected override async Task<bool> CanClose()
    {
        var result = await MessageBox.ShowOverlayAsync("Are you sure you want to exit?", "Exit", button: MessageBoxButton.YesNo);
        return result == MessageBoxResult.Yes;
    }
}