using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProdutos.Model
{
    public class GenericDAO<TEntity>
    where TEntity : class
    {


        public BancoDadosContexto Context;

        public GenericDAO()
        {
            Context = new BancoDadosContexto();
        }


        public virtual void Adiciona(TEntity o)
        {
            Context.Set<TEntity>().Add(o);
            Context.SaveChanges();
        }

        public void Alterar(TEntity o)
        {
            Context.Entry(o).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();

        }

        public void Deletar(long _cod)
        {
            var item = Context.Set<TEntity>().Find(_cod);
            Context.Set<TEntity>().Remove(item);
            Context.SaveChanges();
        }

        public List<TEntity> ListaTodos()
        {
            var todos = Context.Set<TEntity>().ToList();
            return todos;
        }

        public TEntity Selecionar(int id)
        {
            var todos = Context.Set<TEntity>().Find(id);
            return todos;
        }

    }
}