using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Core
{
    public interface IRepository<TEntity> where TEntity:Entity
    {
        void Add(TEntity entity);
        void Remove(string id);
        void Update(TEntity entity);
        TEntity Find(string id);
        IQueryable<TEntity> GetQuery();
        IQueryable GetSqlRawQuery(string query);
        void Save();
    }
}
