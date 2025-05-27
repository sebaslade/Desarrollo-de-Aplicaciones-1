<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="TestFileUpLoad.aspx.cs" Inherits="DemoWEB_Sem10.DemoFileUpLoad.TestFileUpLoad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">EJEMPLOS DE ENVIO DE ARCHIVOS CON FILEUPLOAD</p>
    <p class="labelTitulo">Validando extension</p>
    <br />
    <asp:FileUpload ID="ful1" runat="server" Width="450px" />
&nbsp;<asp:Button ID="btnEnviar1" runat="server" Text="Enviar" CssClass="boton-new" OnClick="btnEnviar1_Click" />
    <br />
    <asp:Label ID="lblMensaje1" runat="server" Text="" CssClass="labelErrores"></asp:Label>
    <br />
    <br />
    <p class="labelTitulo">Validando extension y tamaño</p>
    <br />
    <asp:FileUpload ID="ful2" runat="server" Width="450px" />
&nbsp;<asp:Button ID="btnEnviar2" runat="server" Text="Enviar" CssClass="boton-new" OnClick="btnEnviar2_Click" />
    <br />
    <asp:Label ID="lblMensaje2" runat="server" Text="" CssClass="labelErrores"></asp:Label>
    <br />
</asp:Content>
