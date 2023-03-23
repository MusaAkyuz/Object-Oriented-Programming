namespace Stori_Redux_2
{
    public class GetAppSettingsValue
    {
        public static string? GetFolderPath()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["BooksFolder"].ToString();
        }
    }
}
