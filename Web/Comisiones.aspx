<%@ Page Title="Comisiones" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Comisiones.aspx.cs" Inherits="Comisiones" %>

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
     <form id="comisionesAlumnos" runat="server">
     <asp:Label ID="noComFound" runat="server"></asp:Label>
        <asp:GridView ID="dvgComisionesAlumnos" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Id Comision" ReadOnly="true" DataField="id" />
                <asp:BoundField HeaderText="Turno" ReadOnly="true" DataField="turno" />
                <asp:BoundField HeaderText="Materia" ReadOnly="true" DataField="materia" />
                <asp:CommandField HeaderText="Inscripcion" ButtonType="Link" ShowSelectButton="true" />
            </Columns>  
        </asp:GridView>
        <asp:Label ID="lblInscripto" runat="server" ></asp:Label> <br />
       <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
        
       </form>
</asp:Content>