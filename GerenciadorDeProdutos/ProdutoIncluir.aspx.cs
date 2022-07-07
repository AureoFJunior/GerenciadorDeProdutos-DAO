using GerenciadorDeProdutos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GerenciadorDeProdutos
{
    public partial class ProdutoIncluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            //Popula o produto com as informações da tela, tratando caso necessário.
            Produto p = new Produto();
            p.DESCRICAO = txtDescricao.Text;
            p.PRECO = Convert.ToDouble(txtPreco.Text.Replace(".", ","));

            ProdutoDAO servico = new ProdutoDAO();
            servico.Adiciona(p);

            //Mensagem de sucesso com a descrição do produto que foi incluido.
            lblResultado.Text = $"Produto: [{p.DESCRICAO}] incluido com sucesso.";
            lblResultado.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("/ProdutoListar");
        }
    }
}