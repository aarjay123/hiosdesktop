using HiOSDesktop.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace HiOSDesktop.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class FoodPage : Page
{
    public FoodViewModel ViewModel
    {
        get;
    }

    public FoodPage()
    {
        ViewModel = App.GetService<FoodViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
