<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Usuario.Master" CodeBehind="UsuarioVerUsuarios.aspx.cs" Inherits="AplicacionASP.UsuarioVerUsuarios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container margenSuperior">
            <div class="row align-items-center justify-content-center">
                <div class="col-6">  
                    <h4>Listado de Usuarios</h4>
                    <asp:GridView ID="gvUsuarios" runat="server" CssClass="table table-primary table-bordered table-hover"></asp:GridView>
                    <br />
                    <br />
                    <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />
                </div>
            </div>
        </div>
</asp:Content>
