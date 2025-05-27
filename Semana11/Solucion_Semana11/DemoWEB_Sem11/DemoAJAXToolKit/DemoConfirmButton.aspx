<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="DemoConfirmButton.aspx.cs" Inherits="DemoWEB_Sem11.DemoAJAXToolKit.DemoConfirmButton" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">EJEMPLO DE CONFIRM BUTTON</p>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Limpiar texto" CssClass="boton" OnClick="Button1_Click"/>
    <ajaxToolkit:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" BehaviorID="Button1_ConfirmButtonExtender" ConfirmText="¿Seguro de limpiar texto?" TargetControlID="Button1" />
</asp:Content>
