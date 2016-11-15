using System.Configuration;

namespace Buceo.Web.Core
{
    public class ConfigurationAppSettings
    {
        public static string EmailFrom()
        {
            var email = ConfigurationManager.AppSettings.Get("EmailFrom");
            return email;
        }

        public static string EmailTo()
        {
            var email = ConfigurationManager.AppSettings.Get("EmailTo");
            return email;
        }
    }
}