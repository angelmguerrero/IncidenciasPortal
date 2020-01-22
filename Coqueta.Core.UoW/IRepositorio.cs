using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Coqueta.Core.UoW
{
    public interface IRepositorio<TEntidad> where TEntidad : class
    {
        #region Métodos

        List<TEntidad> SelectAll();

        TEntidad Single(Expression<Func<TEntidad, bool>> expresion);

        List<TEntidad> Select(Expression<Func<TEntidad, bool>> expresion);

        IQueryable<TResult> Columns<TResult>(Expression<Func<TEntidad, TResult>> expresion);

        void Create(TEntidad entidad);

        void Create(List<TEntidad> lista);

        void Update(TEntidad source);

        void Delete(Expression<Func<TEntidad, bool>> expresion);

        TResult Max<TResult>(Expression<Func<TEntidad, TResult>> expresion);

        long Count(Expression<Func<TEntidad, bool>> expresion);

        #endregion
    }
}
