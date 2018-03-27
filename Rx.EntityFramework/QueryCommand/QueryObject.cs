﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rx.EntityFramework
{
    public abstract class QueryObject<TEntity>
    {
        public abstract IQueryable<TEntity> ToQuery(IQueryable<TEntity> queryableEntity);
    }
}
