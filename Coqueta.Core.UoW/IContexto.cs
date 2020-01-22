using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Coqueta.Core.UoW
{
    public interface IContexto : IDisposable
    {
        #region Métodos

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbRawSqlQuery<TEntity> SqlQuery<TEntity>(string sql, params object[] parameters);

        int SaveChanges();

        #endregion
    }
}
