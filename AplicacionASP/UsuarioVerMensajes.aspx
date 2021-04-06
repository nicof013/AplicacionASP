<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Usuario.Master" CodeBehind="UsuarioVerMensajes.aspx.cs" Inherits="AplicacionASP.UsuarioVerMensajes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container margenSuperior">
            <div class="row align-items-center justify-content-center">
                <div class="col-6">
                    <h3>Listado de Mensajes</h3>
                    <asp:GridView ID="gvMensajes" runat="server" CssClass="table table-primary table-bordered table-hover"></asp:GridView> 
                    <br />
                    <asp:Label ID="lblFiltroMensajes" runat="server" Text="Filtro por mail"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtFiltroMensajes" runat="server"></asp:TextBox>
                    <asp:Button ID="btnFiltrarMensajes" runat="server" Text="Filtrar" OnClick="btnFiltrarMensajes_Click" />                    
                 </div>
            </div>
        </div>
</asp:Content>


