<%@ Page Title="Acerca de nosotros" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Comisiones.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
      <fieldset >
            <legend>Menu</legend>
                    <asp:HyperLink runat="server" NavigateUrl="inscMateria.aspx" id="Materias" target="_self">Materias</asp:HyperLink><br />
                    <asp:HyperLink  runat="server" NavigateUrl="EstadoAcademico.aspx" id="Estado" target="_self">Estado academico</asp:HyperLink><br />
                    <asp:HyperLink   runat="server" NavigateUrl="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</asp:HyperLink><br />
                    <asp:HyperLink ID="Salir" runat="server" NavigateUrl="Salir.aspx">Salir</asp:HyperLink> 
        </fieldset>     
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="comisiones" runat="server">
        <asp:RadioButtonList ID="rblComisiones" runat="server"></asp:RadioButtonList>
        <asp:Button ID="btnInscribirse" runat="server" OnClick="btnInscribirse_Click" Text="Inscribirse" />    
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />     
    </form>
</asp:Content>
