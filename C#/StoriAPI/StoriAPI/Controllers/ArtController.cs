using StoriAPI.Helper;
using StoriAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StoriAPI.Controllers
{
    public class ArtController : ApiController
    {
        private string _artFolder = ReadWebConfig.GetArtFolderPath();

        [HttpGet]
        public List<ArtGetModel> Get()
        {
            try
            {
                List<ArtGetModel> artGetModels = new List<ArtGetModel>();

                var arts = Directory.GetFiles(_artFolder);
                foreach (var art in arts)
                {
                    var filename = Path.GetFileName(art);
                    artGetModels.Add(new ArtGetModel
                    {
                        ArtId = filename.Split('-')[0],
                        Artist = filename.Split('-')[1],
                        ArtName = filename.Split('-')[2].Split('.')[0],
                        ArtPath = Path.Combine(_artFolder, filename)
                    });
                }

                return artGetModels;
            }
            catch 
            {
                return null;
            }
            
        }
    }
}
