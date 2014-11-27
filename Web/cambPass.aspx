<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cambPass.aspx.cs" Inherits="cambPass" MasterPageFile="~/Site.master" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="frmCambPass" runat="server" method="post">
        <asp:Label ID="lblPassV" runat="server" Text="Ingrese Contraseña actual:"></asp:Label>
        <asp:TextBox ID="txtPassV" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Label ID="lblPassN" runat="server" Text="Ingrese Contraseña nueva:"></asp:Label>
        <asp:TextBox ID="txtPassN" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Label ID="lblPassNR" runat="server" Text="Repita Contraseña nueva :"></asp:Label>
        <asp:TextBox ID="txtPassNR" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Button ID="btnCambiar" Text="Cambiar" runat="server" OnClick="cambPass_Click" />
        <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" OnClick="cancelar_Click" />  
    </form>
    <asp:Label ID="lblFailPN" runat="server"></asp:Label>
    <asp:Button ID="btnVolver" runat="server" OnClick="cancelar_Click" Text="Volver" />   
</asp:Content>
