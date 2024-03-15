namespace iOSLibWarnings
{
    public class ApplicationThemeHelper
    {
        public static bool IsDarkThemeEnabled()
        {
            if (OperatingSystem.IsIOSVersionAtLeast(13, 0))
            {
                if (UITraitCollection.CurrentTraitCollection.UserInterfaceStyle == UIUserInterfaceStyle.Dark)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
