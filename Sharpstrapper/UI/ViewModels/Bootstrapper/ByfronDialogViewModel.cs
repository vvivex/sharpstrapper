using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Sharpstrapper.UI.ViewModels.Bootstrapper
{
    public class ByfronDialogViewModel : BootstrapperDialogViewModel
    {
        // Using dark theme for default values.
        // Use the bundled Sharpstrapper logo by default
        public ImageSource ByfronLogoLocation { get; set; } = new BitmapImage(new Uri("pack://application:,,,/SharpstrapperLogo.png"));
        public Thickness DialogBorder { get; set; } = new Thickness(0);
        // Default background uses the app's dark blue tone
        public Brush Background { get; set; } = new SolidColorBrush(Color.FromRgb(11, 32, 56));
        public Brush Foreground { get; set; } = new SolidColorBrush(Color.FromRgb(239, 239, 239));
        public Brush IconColor { get; set; } = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        public Brush ProgressBarBackground { get; set; } = new SolidColorBrush(Color.FromRgb(20, 45, 65));

        public Visibility VersionTextVisibility => CancelEnabled ? Visibility.Collapsed : Visibility.Visible;

        public string VersionText { get; init; }

        public ByfronDialogViewModel(IBootstrapperDialog dialog, string version) : base(dialog)
        {
            VersionText = version;
        }
    }
}

