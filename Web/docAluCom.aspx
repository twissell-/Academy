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
            <asp:GridView ID="dvgAluCom" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" GridLines="Horizontal">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" ReadOnly="True" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" />
                    <asp:TemplateField HeaderText="Regular">
                        <ItemTemplate>
                            <asp:CheckBox ID="cbRegular" runat="server" Checked='<%# Bind("Regular") %>' 
                                Enabled="true" AutoPostBack="true" OnCheckedChanged="validar" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="cbRegular" runat="server" Checked='<%# Bind("Regular") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Aprobado">
                        <ItemTemplate>
                            <asp:CheckBox ID="cbAprobado" runat="server" Checked='<%# Bind("Aprobado") %>' 
                                Enabled="true" AutoPostBack="true" OnCheckedChanged="validar"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="cbAprobado" runat="server" Checked='<%# Bind("Aprobado") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
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
        <br />
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" /><br />
        <asp:Label ID="lblAct" runat="server"></asp:Label>   
    </form>
</asp:Content>
