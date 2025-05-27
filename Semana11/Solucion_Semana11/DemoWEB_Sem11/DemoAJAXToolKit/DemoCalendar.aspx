<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="DemoCalendar.aspx.cs" Inherits="DemoWEB_Sem11.DemoAJAXToolKit.DemoCalendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">EJEMPLO DE CALENDAR</p>
    <br />
    <p class="labelTitulo">Ingrese su fecha de nacimiento:</p>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBoxDerecha"></asp:TextBox>
    <ajaxToolkit:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="TextBox1" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Calcular Edad" CssClass="boton2" OnClick="Button1_Click"/>
    <br />
    <br />
    <p class="labelTitulo">La edad es...</p>
    <asp:Label ID="lblEdad" runat="server" Text="" CssClass="labelContenido"></asp:Label>
</asp:Content>
