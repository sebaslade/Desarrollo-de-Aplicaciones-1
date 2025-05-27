﻿<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="TestCustomValidator.aspx.cs" Inherits="DemoWEB_Sem10.DemoValidaciones.TestCustomValidator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 92%;
        }
        .auto-style2 {
            width: 253px;
        }
        .auto-style3 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 22px;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style5 {
            height: 17px;
        }
        .auto-style7 {
            height: 22px;
            width: 273px;
        }
        .auto-style8 {
            width: 273px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
        <br />
        Ejemplo de CustomValidator</p>
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Ingrese codigo afiliacion:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
            </td>
            <td>
                
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtCod" CssClass="labelErrores" ErrorMessage="El codigo debe empezar con A y terminar en 0" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Ingrese DNI:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">
                
                <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="txtDNI" CssClass="labelErrores" ErrorMessage="El DNI debe tener 8 caracteres" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style8">
                <asp:Button ID="btnValidar" runat="server"  Text="Validar" OnClick="btnValidar_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" class="auto-style5">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
