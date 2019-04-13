﻿using LibraryProject.Entity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.WebAPI.Helpers
{
    public class TokenHelper
    {
      private readonly AppSettings appSettings;
      public TokenHelper(IOptions<AppSettings> settings)
      {
         this.appSettings = settings.Value;
      }
      public TokenHelper()
      {
         
      }
      public string GenerateToken(user user,string roleName)
      {
         var tokenHandler = new JwtSecurityTokenHandler();
         var key = Encoding.ASCII.GetBytes(appSettings.Secret);
         var tokenDescriptor = new SecurityTokenDescriptor
         {
            Subject = new System.Security.Claims.ClaimsIdentity(
               new Claim[]
               {
                  new Claim(ClaimTypes.Name,user.id.ToString()),
                  new Claim(ClaimTypes.Role,roleName)
               }),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
         };
         var token = tokenHandler.CreateToken(tokenDescriptor);

         return tokenHandler.WriteToken(token);
      }
   }
}
