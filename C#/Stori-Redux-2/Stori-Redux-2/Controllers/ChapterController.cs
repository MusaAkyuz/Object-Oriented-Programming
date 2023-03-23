using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stori_Redux_2.Models;

namespace Stori_Redux_2.Controllers
{
    [Route("api/chapter")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        [HttpPost]
        public List<Chapter> Post([FromBody] BookNameToPost filePath)
        {
            // main folder BOOKS
            var folderPath = GetAppSettingsValue.GetFolderPath();

            // selected chapter folder
            folderPath += "\\" + filePath.FilePath;

            // getting directory names
            var files = Directory.GetDirectories(folderPath);

            List<Chapter> chapter = new List<Chapter>();
            foreach (var file in files)
            {
                if (!file.Contains("jpg"))
                {
                    var titlePath = Directory.GetFiles(file);
                    Chapter chp = new Chapter();
                    foreach(var data in titlePath)
                    {
                        if(!data.Contains("jpg"))
                        {
                            var title = Path.GetFileName(data).Split(".")[0];
                            chp.Title = title;
                            chp.ChapterNo = Convert.ToInt32(Path.GetFileName(file));
                            chp.ChapterText = System.IO.File.ReadAllText(data);
                        }
                        else
                        {
                            // GetAppSettings path : .//ClientApp//public//Books//
                            // Delete first section
                            chp.ChapterCover = data.Split("public\\")[1];
                        }
                    }
                    chapter.Add( chp );
                }
            }

            return chapter;
        }
    }
}
