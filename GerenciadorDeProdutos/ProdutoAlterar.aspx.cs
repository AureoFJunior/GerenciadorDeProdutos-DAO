using GerenciadorDeProdutos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GerenciadorDeProdutos
{
    public partial class ProdutoAlterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                //Carrega as informações do produto que vai ser alterado.
                if (!String.IsNullOrEmpty(Request["ID_PRODUTO"]))
                {
                    txtCodigo.Text = Request["ID_PRODUTO"].ToString();

                    ProdutoDAO servico = new ProdutoDAO();
                    Produto p = servico.Selecionar(Convert.ToInt32(txtCodigo.Text));

                    if (p != null)
                    {
                        txtDescricao.Text = p.DESCRICAO;
                        txtPreco.Text = p.PRECO.ToString();
                    }

                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoDAO servico = new ProdutoDAO();

            Produto p = servico.Seleciona(Convert.ToInt32(txtCodigo.Text));

            //Só atualiza caso achar o produto.
            if (p != null)
            {

                p.DESCRICAO = txtDescricao.Text;
                p.PRECO = Convert.ToDouble(txtPreco.Text);

                servico.Alterar(p);

                //Mostra mensagem na tela
                lblResultado.Text = "Alterou";
                lblResultado.Visible = true;

            }
            else
            {
                //Mostra a mensagem de erro caso não encontre o produto.
                lblResultado.Text = "Produto não encontrado!";
                lblResultado.CssClass = "alert alert-danger";
                lblResultado.Visible = true;
            }

            //Assim que finalizar tudo, redireicona pra tela de produtos.
            HttpContext.Current.Response.Redirect("/ProdutoListar");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("/ProdutoListar");
        }
    }
}