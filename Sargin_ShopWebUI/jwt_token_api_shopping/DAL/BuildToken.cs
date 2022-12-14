using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;


namespace jwt_token_api_shopping.DAL
{
    public class BuildToken
    {
        public string CreateToken()
        {
            var bytes = Encoding.UTF8.GetBytes("sarginshoppingcore");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost",audience: "http://localhost",notBefore:DateTime.Now,expires:DateTime.Now.AddMinutes(1),signingCredentials:credentials);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);
        }
    }
}
