<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Docente.aspx.cs" Inherits="Docente"
  MasterPageFile="~/Site.master" %>



<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <fieldset>
        <legend>Menu</legend>
            <asp:HyperLink ID="linkMaterias" runat="server">Materias</asp:HyperLink><br />
            <asp:HyperLink ID="linkCambiarPass" runat="server">Cambiar Contraseña</asp:HyperLink><br />
            <asp:HyperLink ID="linkSalir" runat="server">Salir</asp:HyperLink><br />
    </fieldset>
</asp:Content>

