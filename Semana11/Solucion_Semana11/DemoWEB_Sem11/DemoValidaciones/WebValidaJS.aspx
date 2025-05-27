<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebValidaJS.aspx.cs" Inherits="DemoWEB_Sem10.DemoValidaciones.WebValidaJS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <script language="javascript" type="text/javascript">
        function solonumeros(e) {
            var key = window.Event ? e.which : e.keyCode
            return (key >= 48 && key <= 57) || (key == 8)
        }
        function sololetras(e) {
            var key = window.Event ? e.which : e.keyCode
            return (key >= 65 && key <= 90) || (key >= 97 && key <= 122) || (key == 8)
        }
    </script>
    <table width="60%">
                <tr>
                    <td colspan="2" class="tituloForm">Validando con JavaScript</td>
                </tr>
                <tr>
                    <td class="labelContenido">Solo numeros</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" onKeyPress="return solonumeros(event)" Height="16px" Width="140px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="labelContenido">Solo texto</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" onKeyPress="return sololetras(event)"></asp:TextBox>
                    </td>
                </tr>
            </table>
</asp:Content>
