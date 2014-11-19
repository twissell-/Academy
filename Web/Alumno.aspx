<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alumno.aspx.cs" Inherits="Alumno"
  MasterPageFile="~/Site.master" %>



<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <form runat="server" id="Form1" padding=0>
    <fieldset >
        <legend>Menu</legend>
        <asp:Menu ID="Menu1" runat="server" >
        <Items><asp:MenuItem NavigateUrl="~/inscMateria.aspx" Text="Materias"></asp:MenuItem></Items>
        <Items><asp:MenuItem NavigateUrl="~/inscMateria.aspx" Text="Estado academico"></asp:MenuItem></Items>
        <Items><asp:MenuItem NavigateUrl="~/inscMateria.aspx" Text="Cambiar Contraseña"></asp:MenuItem></Items>
        <Items><asp:MenuItem NavigateUrl="~/inscMateria.aspx" Text="Salir"></asp:MenuItem></Items>        
        </asp:Menu>      
    </fieldset>
    </form>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Table ID="tblMaterias" runat="server">

    </asp:Table>
</asp:Content>