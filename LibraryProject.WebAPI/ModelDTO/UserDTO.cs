﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.WebAPI.ModelDTO
{
    public class UserDTO
    {
      public string username { get; set; }
      public string name { get; set; }
      public string surname { get; set; }
      public DateTime createdate { get; set; }
      public string password { get; set; }
   }
}
