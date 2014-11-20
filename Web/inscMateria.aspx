<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inscMateria.aspx.cs" Inherits="inscMateria" 
MasterPageFile="~/Site.master"%>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
      <fieldset >
            <legend>Menu</legend>
                    <a href="inscMateria.aspx" id="Materias" target="_self">Materias</a><br />
                    <a href="EstadoAcademico.aspx" id="Estado" target="_self">Estado academico</a><br />
                    <a href="cambPass.aspx" id="Pass" target="_self">Cambiar Contraseña</a><br />
                    <a href="inscMateria.aspx" id="Salir" target="_self">Salir</a>        
        </fieldset>     
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="materia" runat="server">
        <asp:Table ID="tblMaterias" runat="server"></asp:Table>    
    </form>
</asp:Content>
