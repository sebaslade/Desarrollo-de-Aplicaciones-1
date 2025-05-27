<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Origen.aspx.cs" Inherits="DemoWEB_Sem10.PasandoDatos.Origen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 245px;
        }
        .auto-style3 {
            width: 391px;
        }
        .auto-style4 {
            width: 245px;
            height: 30px;
        }
        .auto-style5 {
            width: 391px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
        Ejemplo de pase de datos entre formularios WEB
    </p>
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Ingrese nombre:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="TextBox" Width="267px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Ingrese apellido:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtApellido" runat="server" CssClass="TextBox" Width="267px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5">
                <asp:Button ID="btnDestino1" runat="server" CssClass="boton-new" OnClick="Button1_Click" Text="Con QueryString" Width="215px" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="btnDestino2" runat="server" CssClass="boton2" OnClick="btnDestino2_Click" Text="Con variables de sesion" Width="215px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />

</asp:Content>
