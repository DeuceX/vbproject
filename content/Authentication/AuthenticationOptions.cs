using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Web.Authentication
{
    public class AuthenticationOptions
    {
        private const string TokenKey = "secretkey_tryunlock";

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(TokenKey));
        }
    }
}
