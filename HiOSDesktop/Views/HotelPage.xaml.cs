using HiOSDesktop.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace HiOSDesktop.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class HotelPage : Page
{
    public HotelViewModel ViewModel
    {
        get;
    }

    public HotelPage()
    {
        ViewModel = App.GetService<HotelViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
