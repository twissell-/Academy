<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Docente.aspx.cs" Inherits="Docente"
  MasterPageFile="~/Site.master" %>



<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <fieldset >
            <legend>Menu</legend>
                    <a href="docMaterias.aspx" id="Materias" target="_self">Materias</a><br />
                    <a href="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</a><br />
                    <a href="inscMateria.aspx" id="Salir" target="_self">Salir</a>        
    </fieldset>
</asp:Content>

