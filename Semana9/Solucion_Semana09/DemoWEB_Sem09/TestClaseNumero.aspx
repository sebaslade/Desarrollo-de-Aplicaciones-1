<%@ Page Title="Clase Numero" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestClaseNumero.aspx.cs" Inherits="DemoWEB_Sem09.TestClaseNumero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ejemplo 1</h1>
    <h2>Test de la clase Numero</h2>
    <table style="width: 70%; border-style: solid; border-width: 1px">
        <tr>
            <td style="width: 185px">Ingrese numero:</td>
            <td>
                <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 185px">&nbsp;</td>
            <td>
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
            </td>
        </tr>
        <tr>
            <td style="width: 185px; height: 21px">Su factorial es:</td>
            <td style="height: 21px">
                <asp:Label ID="lblFactorial" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 185px">Es primo?</td>
            <td>
                <asp:Label ID="lblEsPrimo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 185px">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Volver al Menu</asp:HyperLink>
                </td>
            <td>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
