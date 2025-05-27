<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="DemoHorasConAJAX.aspx.cs" Inherits="DemoWEB_Sem11.DemoAJAXBasico.DemoHorasConAJAX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">Ejemplo de carga horaria con AJAX</p>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Mostrar Hora" CssClass="boton2" OnClick="Button1_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
