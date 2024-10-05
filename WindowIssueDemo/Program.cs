using Avalonia;
using System;
using System.Collections.Generic;

namespace WindowIssueDemo {
    internal class Program {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .With(new Win32PlatformOptions() {
                RenderingMode = new List<Win32RenderingMode> { Win32RenderingMode.Vulkan, Win32RenderingMode.Wgl, Win32RenderingMode.Software },
                CompositionMode = new List<Win32CompositionMode> { Win32CompositionMode.LowLatencyDxgiSwapChain }
            }).StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace();
    }
}
