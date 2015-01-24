<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div align="left">
            <fieldset>
            <legend>Iniciar Sesion</legend>
                <form id="formLogin" class="form-signin" runat="server">
                <asp:TextBox ID="txtUss" type="text" class="form-control" placeholder="Usuario" runat="server" required="autofocus"></asp:TextBox><br />
                <asp:TextBox ID="txtPss" type="password" class="form-control" placeholder="Contraseña" runat="server" required="autofocus"></asp:TextBox>
                <asp:Button ID="btnIngresar" runat="server" onclick="btnIngresar_onclick" Text="INGRESAR" />
                </form>               
            </fieldset>
            <asp:Label ID="error" runat="server"></asp:Label>          
    </div>  
</asp:Content>
