<%@ Page Language="C#" AutoEventWireup="true" CodeFile="docMaterias.aspx.cs" Inherits="docMaterias" 
MasterPageFile="~/Site.master"%>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <fieldset >
            <legend>Menu</legend>
                    <a href="inscMateria.aspx" id="Materias" target="_self">Materias</a><br />
                    <a href="EstadoAcademico.aspx" id="Estado" target="_self">Estado academico</a><br />
                    <a href="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</a><br />
                    <a href="inscMateria.aspx" id="Salir" target="_self">Salir</a>        
    </fieldset>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="form1" runat="server">
   
    </form>
</asp:Content>