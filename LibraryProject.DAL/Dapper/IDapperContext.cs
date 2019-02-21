﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryProject.DAL.Dapper
{
   public interface IDapperContext
   {
      IDbConnection Connection { get; }
      T Transaction<T>(Func<IDbTransaction,T> query);
   }
}
