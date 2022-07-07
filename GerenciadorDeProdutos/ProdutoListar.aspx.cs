using GerenciadorDeProdutos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GerenciadorDeProdutos
{
    public partial class ProdutoListar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<Produto> GetListaProdutos()
        {
            //Pega todos os produtos da base de dados para mostrar na tela.
            ProdutoDAO servico = new ProdutoDAO();
            return servico.ListaTodos();

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("/ProdutoIncluir");
        }
    }
}