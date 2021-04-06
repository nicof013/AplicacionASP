<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Usuario.Master" CodeBehind="UsuarioInicio.aspx.cs" Inherits="AplicacionASP.UsuarioInicio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container margenSuperior">
            <div class="row align-items-center justify-content-center">
                <div class="col-6">    
                    <h4>Informacion General de Usuario</h4>
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre" Font-Bold="true" CssClass="labels" ></asp:Label>    
                    <asp:Label ID="lblNombreUsuario" runat="server" Text="" CssClass="labels" ></asp:Label>
    
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido" Font-Bold="true" CssClass="labels"></asp:Label>    
                    <asp:Label ID="lblApellidoUsuario" runat="server" Text="" CssClass="labels" ></asp:Label>
    
                    <asp:Label ID="lblMail" runat="server" Text="Mail" Font-Bold="true" CssClass="labels"></asp:Label>    
                    <asp:Label ID="lblMailUsuario" runat="server" Text="" CssClass="labels" ></asp:Label>
    
                    <asp:Label ID="lblUltimaConexion" runat="server" Text="Ultima Conexion" Font-Bold="true" CssClass="labels"></asp:Label>    
                    <asp:Label ID="lblUltimaConexionUsuario" runat="server" Text="" CssClass="labels" ></asp:Label>    
    
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" CssClass="botones" />
                 </div>
            </div>
        </div>
</asp:Content>
