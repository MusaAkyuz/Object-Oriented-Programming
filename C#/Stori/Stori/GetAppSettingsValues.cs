using Microsoft.Extensions.Configuration;

namespace Stori
{
    public static class GetAppSettingsValues
    {
        public static string? GetFolderPath()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["BooksFolder"].ToString();
        }
    }
}
