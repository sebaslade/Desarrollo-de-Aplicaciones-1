<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="SitioVentasWEB_GUI.Consultas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 308px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" Runat="Server">
    <p class="tituloForm">CONSULTAS DEL SISTEMA</p>
   <table >
       
        <tr>
            <td class="style2">
                <asp:Image ID="Image1" runat="server" Height="315px" 
                    ImageUrl="~/Images/Consultas.jpg" Width="429px" />
            </td>
            <td class="auto-style1">
                
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Consultas/WebListarVendedores.aspx">Listado de Vendedores</asp:HyperLink>
                <br />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/WebFacturacionCliente.aspx">Facturacion del cliente</asp:HyperLink>
                <br />
                <br />
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Consultas/WebFacturacionPaginada.aspx">Facturacion Paginada</asp:HyperLink>
                <br />
                <br />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Consultas/WebGraficosFacturacion.aspx">Graficos Estadisticos</asp:HyperLink>
                
            </td>
        </tr>
    </table>
&nbsp;
</asp:Content>


