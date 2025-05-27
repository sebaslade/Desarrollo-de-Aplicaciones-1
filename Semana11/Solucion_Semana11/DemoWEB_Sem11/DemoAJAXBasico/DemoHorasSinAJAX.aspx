<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="DemoHorasSinAJAX.aspx.cs" Inherits="DemoWEB_Sem11.DemoAJAXBasico.DemoHorasSinAjax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class:"tituloForm">Ejemplo de carga horaria sin AJAX</p>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Mostrar Hora" CssClass="boton-new" OnClick="Button1_Click" />
</asp:Content>
