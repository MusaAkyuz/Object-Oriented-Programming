using System.Linq;
using System.Web.Http;
using StoriAPI.Models;
using System.Security.Cryptography;
using System.Text;

namespace StoriAPI.Controllers
{
    public class LoginController : ApiController
    {
        private StoriDB2Entities _db = new StoriDB2Entities();

        [HttpPost]
        public int Post(Login loginInfo)
        {
            SHA256 sha256Hash = SHA256.Create();

            try
            {
                string username = loginInfo.Username;
                byte[] passwordHash = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(loginInfo.Password));

                // Check for Username Exist
                if (_db.Users.Select(t => t.Username).Contains(username))
                {
                    var dbUserInfo = _db.Users.Where(t => t.Username == username);

                    // Check for password matches
                    if (dbUserInfo.Select(a => a.PasswordHash).FirstOrDefault().SequenceEqual(passwordHash))
                    {
                        if (dbUserInfo.Select(a => a.Authority).FirstOrDefault().Equals(1)) return 2; // Author Authorirty
                        else return 1; // Reader Authority
                    }
                    else return -2; // If Password not matches
                }
                else return -1; // If Username not exist
            }
            catch
            {
                return 0;
            }
        }
    }
}
