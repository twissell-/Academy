<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
<h1>Zahir Academia</h1>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function btnIngresar_onclick() {
            if (this.usuario == "admin" && this.pass == "admin") {
            Page.Respons
            }
        }

// ]]>
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div align="left">
        <form id="frmLogin" align="center" method="post" runat="server" action="~/About.aspx">
            <fieldset>
                    <legend>Iniciar Sesion</legend>
                    <div align="right">
                        <label>Usuario:</label>
                        <input id="usuario" type="text"  />
                        <br />
                        <label> Contraseña:</label>
                        <input id="pass" type="password" />
                        <br />
                        <input id="btnIngresar" type="button" value="Ingresar" onclick="return btnIngresar_onclick()" />
                    </div>
            </fieldset>
        </form>   
    </div>  
</asp:Content>
