using StoriAPI.Helper;
using System;
using StoriAPI.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StoriAPI.Controllers
{
    public class BookController : ApiController
    {
        private string _bookFolder = ReadWebConfig.GetBookFolderPath();
        [HttpGet]
        public List<BookGetModel> Get()
        {
            try
            {
                StoriDB2Entities _db = new StoriDB2Entities();
                List<BookGetModel> bookGetModels= new List<BookGetModel>();
                var books = Directory.GetDirectories(_bookFolder);

                BookGetModel bgm = new BookGetModel();

                foreach (var book in books)
                {
                    // Getting bookName
                    bgm.BookName = Path.GetFileName(book);
                    // Getting author
                    bgm.Author = _db.Users.Where(a => a.UserId == _db.Books.Where(b => b.Bookname == bgm.BookName).Select(c => c.Author).FirstOrDefault()).
                                       Select(d => d.Username).FirstOrDefault();

                    var relatedFiles = Directory.GetFiles(book);
                    foreach (var file in relatedFiles)
                    {   
                        // Eğer dosyanın ismi "cover" ise bu kitapın kapak resmidir.
                        if (file.Contains("cover"))
                        {
                            // Getting coverPath
                            bgm.CoverPath = Path.GetFullPath(file);
                        }
                    }

                    bookGetModels.Add(bgm);
                }
                return bookGetModels;
            }
            catch
            {
                return null;
            }          
        }
    }
}
