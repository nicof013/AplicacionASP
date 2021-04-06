<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Inicio.aspx.cs" Inherits="AplicacionASP.Inicio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    
        <div class="container margenSuperior">
            <div class="row align-items-center justify-content-center">
                <div class="col-4">
                    <span class="labels">Iniciar Sesion</span>
                    <asp:TextBox ID="txtMail" runat="server" placeholder="Email" CssClass="cajasTexto"></asp:TextBox>                     
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Contraseña" CssClass="cajasTexto"></asp:TextBox>
                    
                    <asp:Button ID="btnEnviar" runat="server" Text="Iniciar Sesion" OnClick="btnEnviar_Click" CssClass="botones" />                  
                    <asp:Label ID="lblAccesoDenegado" runat="server" Text="" ForeColor="red" CssClass="labels"></asp:Label>                            
                    <span class="labels">¿No estas registrado? <a href="Registrarse.aspx">Registrate</a></span>
                </div>
            </div>            
        </div>
    
</asp:Content>
