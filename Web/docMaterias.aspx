<%@ Page Language="C#" AutoEventWireup="true" CodeFile="docMaterias.aspx.cs" Inherits="docMaterias" 
MasterPageFile="~/Site.master"%>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <fieldset >
            <legend>Menu</legend>
                     <asp:HyperLink runat="server" NavigateUrl="docMaterias.aspx" id="Materias" target="_self">Materias</asp:HyperLink><br />
                    <asp:HyperLink runat="server" NavigateUrl="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</asp:HyperLink><br />
                    <asp:HyperLink runat="server" NavigateUrl="Salir.aspx" id="Salir" target="_self">Salir</asp:HyperLink>      
    </fieldset>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="form1" runat="server">
   
    </form>
</asp:Content>