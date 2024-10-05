using Avalonia.Controls;
using Avalonia.Platform;

namespace WindowIssueDemo {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            SystemDecorations = SystemDecorations.Full;
            Width = 420; Height = 160;
        }

        private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            SystemDecorations = SystemDecorations.BorderOnly;
            Width = 420; Height = 160;
        }

        private void Button_Click_2(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            SystemDecorations = SystemDecorations.None;
            Width = 420; Height = 160;
        }

        private void Button_Click_3(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            ExtendClientAreaToDecorationsHint = false;
            Width = 420; Height = 160;
        }

        private void Button_Click_4(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            ExtendClientAreaToDecorationsHint = true;
            Width = 420; Height = 160;
        }

        private void Button_Click_5(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            this.ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.NoChrome;
            Width = 420; Height = 160;
        }

        private void Button_Click_6(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            this.ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.PreferSystemChrome;
            Width = 420; Height = 160;
        }

        private void Button_Click_7(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            this.ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.SystemChrome;
            Width = 420; Height = 160;
        }

        private void Button_Click_8(object? sender, Avalonia.Interactivity.RoutedEventArgs e) {
            this.ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.Default;
            Width = 420; Height = 160;
        }
    }
}