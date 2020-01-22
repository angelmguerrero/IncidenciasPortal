using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Coqueta.Core.UoW
{
    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : class
    {
        #region Campos

        private IContexto contexto;

        #endregion

        #region Constructores

        public Repositorio(IContexto contexto)
        {
            this.contexto = contexto;
        }

        #endregion

        #region Propiedades

        protected IContexto Contexto
        {
            get { return this.contexto; }
        }

        #endregion

        #region Métodos Públicos

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.contexto != null)
                {
                    this.contexto.Dispose();
                    this.contexto = null;
                }
            }
        }

        public List<TEntidad> SelectAll()
        {
            return this.entidad.ToList();
        }

        public TEntidad Single(Expression<Func<TEntidad, bool>> expresion)
        {
            return this.entidad.SingleOrDefault(expresion);
        }

        public List<TEntidad> Select(Expression<Func<TEntidad, bool>> expresion)
        {
            return this.entidad.Where(expresion).ToList();
        }

        public IQueryable<TResult> Columns<TResult>(Expression<Func<TEntidad, TResult>> expresion)
        {
            return this.entidad.Select(expresion);
        }

        public void Create(TEntidad entity)
        {
            this.entidad.Add(entity);
        }

        public void Create(List<TEntidad> lista)
        {
            foreach (TEntidad entidad in lista)
            {
                this.Create(entidad);
            }
        }

        public void Update(TEntidad source)
        {
            ((DbContext)this.contexto).Entry(source).State = EntityState.Modified;
        }

        public void Delete(Expression<Func<TEntidad, bool>> expresion)
        {
            List<TEntidad> lista = this.Select(expresion);
            foreach (TEntidad entidad in lista)
            {
                this.entidad.Remove(entidad);
            }
        }

        public TResult Max<TResult>(Expression<Func<TEntidad, TResult>> expresion)
        {
            return this.entidad.Max(expresion);
        }

        public long Count(Expression<Func<TEntidad, bool>> expresion)
        {
            return this.entidad.Count(expresion);
        }


        #endregion

        #region Métodos Privados

        private IDbSet<TEntidad> entidad
        {
            get { return this.contexto.Set<TEntidad>(); }
        }

        #endregion
    }
}
