﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pagAlumno.aspx.cs" Inherits="pagAlumno" MasterPageFile="~/Site.master" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="Menu">
    <form id="form1" runat="server">
    <fieldset  >
            <legend>Menu</legend>
                    <asp:HyperLink CssClass="btn btn-primary btn-xs"  runat="server" NavigateUrl="inscMateria.aspx" id="Materias" target="_self">Materias</asp:HyperLink><br />
                    <asp:HyperLink  runat="server" CssClass="btn btn-primary btn-xs" NavigateUrl="EstadoAcademico.aspx" id="Estado" target="_self">Estado academico</asp:HyperLink><br />
                    <asp:HyperLink  runat="server" CssClass="btn btn-primary btn-xs" NavigateUrl="cambPass.aspx" id="CambPass" target="_self">Cambiar Contraseña</asp:HyperLink><br />
                    <asp:HyperLink ID="Salir" CssClass="btn btn-primary btn-xs" runat="server" NavigateUrl="Salir.aspx">Salir</asp:HyperLink>
    </fieldset>
    </form>
</asp:Content>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent"> 
    <asp:Label ID="lblNombre" runat="server"></asp:Label>
</asp:Content>
 