<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Destino1.aspx.cs" Inherits="DemoWEB_Sem10.PasandoDatos.Destino1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 262px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
        Recibiendo datos con QueryString
    </p>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="labelTitulo">Nombre obtenido:</td>
            <td>
                <asp:Label ID="lblNombre" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="labelTitulo">Apellido obtenido:</td>
            <td>
                <asp:Label ID="lblApellido" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PasandoDatos/Origen.aspx">Retornar</asp:HyperLink>
</asp:Content>
