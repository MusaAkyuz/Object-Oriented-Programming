using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stori.Data;
using Stori.Models;
using System.IO;
using System;

namespace Stori.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public List<Book> Get()
        {
            var folderPath = GetAppSettingsValues.GetFolderPath();
            var files = Directory.GetDirectories(folderPath);

            List<Book> bookNames = new List<Book>();
            foreach (var path in files)
            {
                string fileName;
                if(path != null)
                {
                    fileName = Path.GetFileName(path).ToString();
                    bookNames.Add(new Book { BookName = fileName});
                }           
            }

            return bookNames;
        }


    }
}
