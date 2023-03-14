using Microsoft.Extensions.Configuration;

namespace Stori_Redux
{
    public class GetAppSettingsValue
    {
        public static string? GetFolderPath()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["BooksFolder"].ToString();
        }
    }
}
