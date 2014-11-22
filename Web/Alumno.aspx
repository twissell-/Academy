<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alumno.aspx.cs" Inherits="Alumno" MasterPageFile="~/Site.master" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <form id="form1" runat="server">
    <fieldset >
            <legend>Menu</legend>
                    <a href="inscMateria.aspx" id="Materias" target="_self">Materias</a><br />
                    <a href="EstadoAcademico.aspx" id="Estado" target="_self">Estado academico</a><br />
                    <a href="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</a><br />
                    <!-- <a href="Default.aspx" id="Salir" target="_self">Salir</a><br /> -->
                    <asp:HyperLink ID="Salir" runat="server" NavigateUrl="Default.aspx">Salir</asp:HyperLink>
    </fieldset>
    </form>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent"> 
<asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>
 