﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivony.Data
{
  public abstract class ParameterizedQueryExecuteContext : IDbExecuteContext
  {
    public abstract IDbResult Execute();
  }
}
