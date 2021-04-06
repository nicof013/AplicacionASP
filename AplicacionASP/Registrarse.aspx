<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Registrarse.aspx.cs" Inherits="AplicacionASP.Registrarse" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container margenSuperior">
            <div class="row align-items-center justify-content-center">
                <div class="col-4">
                    <h3>Registrarse</h3>                                            
                    <span class="labels">Nombre</span>
                    <asp:TextBox ID="txtNombre" runat="server" ></asp:TextBox>
                    <span class="labels">Apellido</span>                    
                    <asp:TextBox ID="txtApellido" runat="server" ></asp:TextBox>
                    <span class="labels">Mail</span>
                    <asp:TextBox ID="txtMail" runat="server" ></asp:TextBox><br />
                    <span class="labels">Contraseña</span>
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" ></asp:TextBox>
                    <span class="labels">Confirmar Contraseña</span>
                    <asp:TextBox ID="txtPass2" runat="server" TextMode="Password" ></asp:TextBox>
                    
                    <asp:Label ID="lblDatosIncompletos" runat="server" Text="" ForeColor="red" CssClass="labels"></asp:Label>
                    <asp:Label ID="lblClavesDiferentes" runat="server" Text="" ForeColor="red" CssClass="labels"></asp:Label>
                    <asp:Label ID="lblEmailExistente" runat="server" Text="" ForeColor="red" CssClass="labels"></asp:Label>
                    
                    <asp:Button ID="btnRegistro" runat="server" Text="Registrarse" OnClick="btnRegistro_Click" CssClass="botones" />
                </div>
            </div>
        </div>
</asp:Content>
