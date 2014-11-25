<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inscMateria.aspx.cs" Inherits="inscMateria" 
MasterPageFile="~/Site.master"%>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
      <fieldset >
            <legend>Menu</legend>
                    <asp:HyperLink runat="server" NavigateUrl="inscMateria.aspx" id="Materias" target="_self">Materias</asp:HyperLink><br />
                    <asp:HyperLink  runat="server" NavigateUrl="EstadoAcademico.aspx" id="Estado" target="_self">Estado academico</asp:HyperLink><br />
                    <asp:HyperLink   runat="server" NavigateUrl="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</asp:HyperLink><br />
                    <!-- <a href="Default.aspx" id="Salir" target="_self">Salir</a><br /> -->
                    <asp:HyperLink ID="Salir" runat="server" NavigateUrl="Salir.aspx">Salir</asp:HyperLink> 
        </fieldset>     
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="materia" runat="server">
        <asp:Table ID="tblMaterias" runat="server"></asp:Table>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
            onclick="btnGuardar_Click" />   
        <asp:Button ID="btnVolver" runat="server" Text="Volver" 
            onclick="btnVolver_Click" />    
    </form>
</asp:Content>
