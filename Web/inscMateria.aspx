<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inscMateria.aspx.cs" Inherits="inscMateria" 
MasterPageFile="~/Site.master"%>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
      <fieldset >
            <legend>Menu</legend>
                   
                    <asp:HyperLink CssClass="btn btn-default btn-lg active"  runat="server" NavigateUrl="inscMateria.aspx" id="Materias" target="_self">Materias</asp:HyperLink><br />
                    <asp:HyperLink  runat="server" CssClass="btn btn-default btn-lg active" NavigateUrl="EstadoAcademico.aspx" id="Estado" target="_self">Estado academico</asp:HyperLink><br />
                    <asp:HyperLink  runat="server" CssClass="btn btn-default btn-lg active" NavigateUrl="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</asp:HyperLink><br />
                    <asp:HyperLink ID="Salir" CssClass="btn btn-default btn-lg active" runat="server" NavigateUrl="Salir.aspx">Salir</asp:HyperLink>
   
        </fieldset>     
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="materia" runat="server">
    <asp:Label ID="noMatFound" runat="server"></asp:Label>
            <asp:GridView ID="dvgMaterias" runat="server" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <columns>
                   <asp:BoundField  HeaderText="Id" ReadOnly="true" DataField="id"/>
                   <asp:BoundField  HeaderText="Descripcion" ReadOnly="true" DataField="descripcion"/>
                   <asp:CommandField HeaderText="Inscripcion" ButtonType="Link" ShowSelectButton="true" />
                </columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
        <asp:Label ID="das" runat="server"></asp:Label>     
    </form>
</asp:Content>
