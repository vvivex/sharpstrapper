namespace Sharpstrapper.UI.ViewModels.Installer
{
    public class WelcomeViewModel : NotifyPropertyChangedViewModel
    {
        // Make MainText editable from the UI and avoid automatic formatting or network checks.
        public string MainText { get; set; } = string.Empty;

        // Keep VersionNotice editable but do not populate it automatically.
        public string VersionNotice { get; set; } = string.Empty;

        // Allow UI to control continuation; default to true so the page is usable by default.
        public bool CanContinue { get; set; } = true;

        public event EventHandler? CanContinueEvent;

        // called by codebehind on page load - intentionally a no-op so UI edits aren't overwritten
        public void DoChecks()
        {
            // intentionally left blank
        }
    }
}

