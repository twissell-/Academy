<%@ Page Language="C#" AutoEventWireup="true" CodeFile="docAluCom.aspx.cs" Inherits="docAluCom" MasterPageFile="~/Site.master"%>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <fieldset >
            <legend>Menu</legend>
                     <asp:HyperLink runat="server" NavigateUrl="docMaterias.aspx" id="Materias" target="_self">Materias</asp:HyperLink><br />
                    <asp:HyperLink runat="server" NavigateUrl="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</asp:HyperLink><br />
                    <asp:HyperLink runat="server" NavigateUrl="Salir.aspx" id="Salir" target="_self">Salir</asp:HyperLink>      
    </fieldset>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <form id="frmAluCom" runat="server">
    <asp:Label ID="noAlFound" runat="server"></asp:Label>
        <asp:GridView ID="dvgAluCom" runat="server" AutoGenerateColumns="False">
                <columns>
                   <asp:BoundField  HeaderText="Id" ReadOnly="true" DataField="id"/>
                   <asp:BoundField  HeaderText="Apellido" ReadOnly="true" DataField="apellido"/>
                   <asp:BoundField  HeaderText="Nombre" ReadOnly="true" DataField="nombre"/>
                  
                </columns>
            </asp:GridView><br />
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />   
    </form>
</asp:Content>
