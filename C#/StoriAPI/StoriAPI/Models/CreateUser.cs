using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoriAPI.Models
{
    public class CreateUser
    {
        public string Nickname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}