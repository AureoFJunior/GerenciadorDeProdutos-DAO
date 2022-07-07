using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDeProdutos.Model
{
    public class ProdutoDAO : GenericDAO<Produto>
    {
        public ProdutoDAO() {
        }

        /// <summary>
        /// Adiciona o produto.
        /// </summary>
        /// <param name="o">Objeto populado do produto a ser adicionado.</param>
        public virtual void Adicionar(Produto o)
        {
          Adiciona(o);
        }

        /// <summary>
        /// Busca o produto.
        /// </summary>
        /// <param name="id">Id do produto.</param>
        /// <returns>Retorna o produto com base no ID.</returns>
        public Produto Seleciona(int id)
        {
            Produto p = Selecionar(id);
            return p;
        }

        /// <summary>
        /// Atualiza o produto.
        /// </summary>
        /// <param name="o">Objeto populado do produto a ser atualizado.</param>
        public void Altera(Produto o)
        {
            Alterar(o);

        }

        /// <summary>
        /// Deleta o produto.
        /// </summary>
        /// <param name="id">ID do produto a ser deletado.</param>
        public void Deleta(long id)
        {
            Deletar(id);
        }

        /// <summary>
        /// Busca todos os produtos da base de dados.
        /// </summary>
        /// <returns>Retorna todos os produtos que encontrar.</returns>
        public List<Produto> ListarTodos()
        {
            return ListaTodos();
        }


    }
}