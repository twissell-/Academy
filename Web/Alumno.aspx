<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alumno.aspx.cs" Inherits="Alumno"
  MasterPageFile="~/Site.master" %>



<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <fieldset>
        <legend>Menu</legend>
            <asp:HyperLink ID="linkInscMaterias" runat="server" NavigateUrl="~/inscMateria.aspx">Inscribirse a una Materias</asp:HyperLink><br />
            <asp:HyperLink ID="linkEstadoAcademico" runat="server">Estado academico</asp:HyperLink><br />
            <asp:HyperLink ID="linkCambiarPass" runat="server">Cambiar Contraseña</asp:HyperLink><br />
            <asp:HyperLink ID="linkSalir" runat="server">Salir</asp:HyperLink><br />
    </fieldset>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Table ID="tblMaterias" runat="server">

    </asp:Table>
</asp:Content>