using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoriAPI.Models
{
    public class BookGetModel
    {
        public string BookName { get; set; }
        public string CoverPath { get; set; }
        public string Author { get; set; }
    }
}