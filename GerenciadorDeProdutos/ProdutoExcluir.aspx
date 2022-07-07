<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdutoExcluir.aspx.cs" Inherits="GerenciadorDeProdutos.ProdutoExcluir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Exclusão de Produto</h3>

    <div  class="form-group">
        <asp:Label ID="lblCodigo" runat="server" CssClass="control-label" Text="Código:"></asp:Label>    
        <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server" Enabled="false" ></asp:TextBox>
    </div>
    <div  class="form-group">
        <asp:Label ID="lblDescricao" runat="server" CssClass="control-label" Text="Descrição:"></asp:Label>    
        <asp:TextBox ID="txtDescricao" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
    </div>

     <div  class="form-group">
        <asp:Label ID="lblPreco" runat="server" CssClass="control-label" Text="Preço:"></asp:Label>    
        <asp:TextBox ID="txtPreco" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
    </div>

    <div  class="form-group">
        <asp:Button ID="btnExcluir" runat="server" CssClass="btn btn-primary" Text="Excluir" OnClick="btnExcluir_Click"/>           
        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" OnClick="btnCancelar_Click" />
    </div>

    <div class="form-group">
            <asp:Label ID="lblResultado" runat="server" Text=""  Visible="false" CssClass="alert alert-success" ></asp:Label>
    </div>

</asp:Content>
