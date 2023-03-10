using System.Text;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stori.Models;

namespace Stori.Controllers
{
    [Route("api/selectedbookname")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        [HttpPost]
        public List<Chapter> Post([FromBody] BookNameToPost bookName)
        {
            // main folder BOOKS
            string folderPath = GetAppSettingsValues.GetFolderPath();

            // selected chapter folder
            folderPath += "\\" + bookName.BookName;

            // getting directory names
            var files = Directory.GetDirectories(folderPath);

            List<Chapter> chapter = new List<Chapter>();
            foreach (var file in files)
            {
                if (!file.Contains("jpg"))
                {
                    var titlePath = Directory.GetFiles(file).First();
                    var title = Path.GetFileName(titlePath).Split(".")[0];
                    chapter.Add(new Chapter
                    {
                        Title = title,
                        ChapterNo = Path.GetFileName(file),
                        ChapterText = System.IO.File.ReadAllText(titlePath)
                    });
                }
            }

            return chapter;
        }
    }
}
