using HiOSDesktop.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace HiOSDesktop.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class RoomkeyPage : Page
{
    public RoomkeyViewModel ViewModel
    {
        get;
    }

    public RoomkeyPage()
    {
        ViewModel = App.GetService<RoomkeyViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
