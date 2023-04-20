using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StoriAPI.Helper
{
    public class ReadWebConfig
    {
        public static string GetBookFolderPath()
        {
            return WebConfigurationManager.AppSettings["BooksFolder"];
        }

        public static string GetArtFolderPath()
        {
            return WebConfigurationManager.AppSettings["ArtFolder"];
        }
    }
}