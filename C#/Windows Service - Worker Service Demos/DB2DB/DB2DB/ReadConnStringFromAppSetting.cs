using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DB2DB
{
    public class ReadConnStringFromAppSetting
    {
        public static string GetConnString(string DatabaseName)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
            var builder = new ConfigurationBuilder().SetBasePath(projectPath).AddJsonFile("appSettings.json").Build();
            return builder.GetConnectionString(DatabaseName);
        }
    }
}
