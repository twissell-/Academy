<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EstadoAcademico.aspx.cs" Inherits="EstadoAcademico" MasterPageFile="~/Site.master" %>

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
        <asp:GridView ID="dvgEstadoAcademico" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Id" ReadOnly="true" DataField="materia.id" />
                <asp:BoundField HeaderText="Materia" ReadOnly="true" DataField="materia.descripcion" />   
            </Columns>  
        </asp:GridView>
       <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
      
    </form> 
</asp:Content>
