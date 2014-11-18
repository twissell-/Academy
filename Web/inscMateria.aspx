<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inscMateria.aspx.cs" Inherits="inscMateria" MasterPageFile="~/Site.master" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <fieldset>
        <legend>Menu</legend>
            <asp:HyperLink ID="linkInscMaterias" runat="server" NavigateUrl="~/Alumno.aspx">Inscribirse a una Materias</asp:HyperLink><br />
            <asp:HyperLink ID="linkEstadoAcademico" runat="server">Estado academico</asp:HyperLink><br />
            <asp:HyperLink ID="linkCambiarPass" runat="server">Cambiar Contraseña</asp:HyperLink><br />
            <asp:HyperLink ID="linkSalir" runat="server">Salir</asp:HyperLink><br />
    </fieldset>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
<form id="materia" runat="server">
 <asp:GridView ID="materiasGridView" AllowPaging="True" AutoGenerateColumns="False" runat="server">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" 
                    SortExpression="ID" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" 
                    SortExpression="descripcion" />
                <asp:CheckBoxField DataField="eleccion" HeaderText="Elegir" />
            </Columns>
        </asp:GridView>


    <asp:Table ID="tblMaterias" runat="server">
    <asp:TableHeaderRow><asp:TableHeaderCell>Materias</asp:TableHeaderCell></asp:TableHeaderRow>
    <asp:TableRow>
    <asp:TableCell>Nicolas</asp:TableCell>
    <asp:TableCell>hola</asp:TableCell>
    <asp:TableCell>aprendiendo</asp:TableCell>
    <asp:TableCell><asp:CheckBox ID="anotar" runat="server"/></asp:TableCell>
    </asp:TableRow>
    <asp:TableFooterRow><asp:TableCell>holis</asp:TableCell></asp:TableFooterRow>
    </asp:Table>
</form>

</asp:Content>
