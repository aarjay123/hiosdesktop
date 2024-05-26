using HiOSDesktop.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace HiOSDesktop.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class SoonPage : Page
{
    public SoonViewModel ViewModel
    {
        get;
    }

    public SoonPage()
    {
        ViewModel = App.GetService<SoonViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
