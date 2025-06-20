using Microsoft.Web.WebView2.WinForms;

namespace src
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            webView.Source = new Uri("https://devscafe.org/radio/desktop");

            // Resize with the window
            webView.Dock = DockStyle.Fill;

            // Enable the WebView2 control
            webView.CoreWebView2InitializationCompleted += (sender, e) =>
            {
                if (e.IsSuccess)
                {
                    Console.WriteLine("WebView2 initialized successfully.");
                }
                else
                {
                    Console.WriteLine($"WebView2 initialization failed: {e.InitializationException}");
                }
            };
        }
    }
}