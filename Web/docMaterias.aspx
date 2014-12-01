<%@ Page Title="Acerca de nosotros" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="docMaterias.aspx.cs" Inherits="docMaterias" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
      <fieldset >
            <legend>Menu</legend>
                    <asp:HyperLink runat="server" NavigateUrl="docMaterias.aspx" id="Materias" target="_self">Materias</asp:HyperLink><br />
                    <asp:HyperLink   runat="server" NavigateUrl="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</asp:HyperLink><br />
                    <asp:HyperLink ID="Salir" runat="server" NavigateUrl="Salir.aspx">Salir</asp:HyperLink> 
        </fieldset>     
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="frmMateriasDocentes" runat="server">
    <asp:Label ID="noMatFound" runat="server"></asp:Label>
        <asp:GridView ID="dvgMateriasDocentes" runat="server" AutoGenerateColumns="False">
                <columns>
                    <asp:BoundField  HeaderText="Id" ReadOnly="true" DataField="id"/>
                    <asp:BoundField  HeaderText="Descripcion" ReadOnly="true" DataField="descripcion"/>
                    <asp:CommandField HeaderText="Ver Comisiones" ButtonType="Link" ShowSelectButton="true" />
                </columns>
            </asp:GridView>
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />   
    </form>
</asp:Content>
