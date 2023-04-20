using System.Web.Http;
using StoriAPI.Models;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System;
using System.Linq;

namespace StoriAPI.Controllers
{
    public class CreateUserController : ApiController
    {
        private StoriDB2Entities _db = new StoriDB2Entities();

        [HttpPost]
        public async Task<int> Post(CreateUser userInfo)
        {
            // Kullanıcı giriş bilgileri web uygulaması tarafından kontrol ediliyor
            // Burada tekrar kontrol etmiyorum
            SHA256 sha256Hash = SHA256.Create();

            try
            {
                string nickname = userInfo.Nickname;
                string username = userInfo.Username;
                byte[] passwordHash = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(userInfo.Password));

                // Aynı kullanıcı adına sahip biri daha önce kayıtlı mı diye kontrol edilir
                if(!_db.Users.Any(t => t.Username == username) && !_db.Users.Any(t => t.Nickname == nickname))
                {
                    _db.Users.Add(new User
                    {
                        Username = username,
                        Nickname = nickname,
                        PasswordHash = passwordHash,
                        Authority = 0 // Reader authority
                    });
                    await _db.SaveChangesAsync();

                    return 1; //Success
                }
                else
                {
                    return -1; // Username or nickname already exist
                }   
            }
            catch
            {
                return 0; // Error
            }
            
        }
    }
}
