<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdutoListar.aspx.cs" Inherits="GerenciadorDeProdutos.ProdutoListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Lista de Produtos</h1>
        <table class="table">

            <tr>
                <th>Código</th>
                <th>Descrição</th>
               <th>Preço</th>
                <th>Ações</th>
            </tr>

            <%
                var list= new produtolistar_aspx().GetListaProdutos();
                foreach (var item in list)
                {
                %> 
                <tr>
                    <td><%=item.ID_PRODUTO %></td>
                    <td><%=item.DESCRICAO %></td>
                    <td><%=String.Format("{0:C2}", item.PRECO) %></td>
                    
                    <td><a href="ProdutoAlterar.aspx?ID_PRODUTO=<%=item.ID_PRODUTO %>">editar</a>&nbsp;&nbsp;
                        <a href="ProdutoExcluir.aspx?ID_PRODUTO=<%=item.ID_PRODUTO %>">excluir</a></td>
                     
                </tr>
                <% } %>
        </table>
        <div  class="form-group">
            <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-primary" Text="Incluir" OnClick="btnSalvar_Click" />
           
        </div>
    </div>


</asp:Content>
