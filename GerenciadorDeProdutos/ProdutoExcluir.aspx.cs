using GerenciadorDeProdutos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GerenciadorDeProdutos
{
    public partial class ProdutoExcluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if ( Page.IsPostBack == false )
            {

                if ( Request["ID_PRODUTO"] != null && Request["ID_PRODUTO"] != "" )
                {
                    txtCodigo.Text = Request["ID_PRODUTO"].ToString();
                }

                ProdutoDAO servico = new ProdutoDAO();
                Produto p = servico.Selecionar(Convert.ToInt32(txtCodigo.Text));

                if (p != null)
                {
                    txtDescricao.Text = p.DESCRICAO;
                    txtPreco.Text = p.PRECO.ToString();
                }
            }

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

            ProdutoDAO servico = new ProdutoDAO();

            int cod = Convert.ToInt32(txtCodigo.Text);

            if (servico.Selecionar(cod) != null)
            {
                servico.Deletar(cod);
                lblResultado.Text = $"Produto: {cod} excluído com sucesso!";
                lblResultado.Visible = true;
            }
            else
            {

                lblResultado.Text = "Produto não encontrato!";
                lblResultado.Visible = true;
            }
            HttpContext.Current.Response.Redirect("/ProdutoListar");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("/ProdutoListar");
        }
    }
}