﻿using LibraryProject.DAL.Repository;
using LibraryProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.DAL.Abstract
{
    public interface IUserDAL:IRepositoryAccess<user>
    {
      long AddRole(int ID, string roleName);
      role GetUserRole(int userID);
      void DeleteUserRole(role r);
      user GetByUsername(string username);
   }
}
