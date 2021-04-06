<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Contacto.aspx.cs" Inherits="AplicacionASP.Contacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container margenSuperior">
            <div class="row align-items-center justify-content-center">
                <div class="col-4">
                    <h3>Contacto</h3>
                    <p>Complete los datos en el formulario y estaremos en contacto.</p>
                    <span class="labels">Nombre</span>
                    <asp:TextBox ID="txtNombreContacto" runat="server" ></asp:TextBox>
                    <span class="labels">Mail</span>
                    <asp:TextBox ID="txtMailcontacto" runat="server"></asp:TextBox>
                    <span class="labels">Mensaje</span>
                    <asp:TextBox ID="txtMensajeContacto" runat="server" TextMode="MultiLine" MaxLength="120"></asp:TextBox>                    
                    <asp:Label ID="lblGuardadoMensaje" runat="server" Text="" CssClass="labels"></asp:Label>    
                    
                    <asp:Button ID="btnEnviarContacto" runat="server" Text="Enviar" OnClick="btnEnviarContacto_Click" CssClass="botones" />
                 </div>
            </div>
      </div>
</asp:Content>
