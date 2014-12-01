<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pagDocente.aspx.cs" Inherits="pagDocente"
  MasterPageFile="~/Site.master" %>



<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <fieldset >
            <legend>Menu</legend>
                    <asp:HyperLink runat="server" NavigateUrl="docComisiones.aspx" id="Materias" target="_self">Comisiones</asp:HyperLink><br />
                    <asp:HyperLink runat="server" NavigateUrl="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</asp:HyperLink><br />
                    <asp:HyperLink runat="server" NavigateUrl="Salir.aspx" id="Salir" target="_self">Salir</asp:HyperLink>                          
    </fieldset>
</asp:Content>

<asp:Content ID="MenuContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>

