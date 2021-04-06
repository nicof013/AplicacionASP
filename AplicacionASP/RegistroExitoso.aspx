<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RegistroExitoso.aspx.cs" Inherits="AplicacionASP.RegistroExitoso" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">    
        <div class="container margenSuperior">
            <div class="row align-items-center justify-content-center">
                <div class="col-4">
                    <h3>Se registro existosamente.</h3>
                    <asp:HyperLink ID="hlInicio" runat="server" NavigateUrl="~/Inicio.aspx" Text="Ir a la pagina de inicio"></asp:HyperLink>
                </div>
            </div>
        </div>
</asp:Content>

