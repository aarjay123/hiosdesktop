using HiOSDesktop.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace HiOSDesktop.Views;

// TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
public sealed partial class SettingsPage : Page
{
    public SettingsViewModel ViewModel
    {
        get;
    }

    public SettingsPage()
    {
        ViewModel = App.GetService<SettingsViewModel>();
        InitializeComponent();
    }

    private async void about_hioswebcore(object sender, RoutedEventArgs e)
    {
        // Create a new window
        Window about = new Window();
        about.Title = "About HiOSWebCore";
        about.SetIsResizable(false);
        about.SetWindowSize(width: 800, height: 600);
        about.SetIsAlwaysOnTop(true);
        about.SetIcon("assets/WindowIcon.ico");

        // Create a new WebView2 control
        Microsoft.UI.Xaml.Controls.WebView2 webView = new Microsoft.UI.Xaml.Controls.WebView2();

        // Initialise the WebView2 control
        await webView.EnsureCoreWebView2Async(null);

        // Set the source for the WebView2 control
        webView.Source = new Uri("https://thehighlandcafe.github.io/hioswebcore/helpcenter/more/about.html");

        // Set the content of the new window to the WebView2 control
        about.Content = webView;

        // Activate the new window
        about.Activate();
    }
}
