<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebGraficosFacturacion.aspx.cs" Inherits="SitioWEB_VentasGUI.Consultas.WebGraficosFacturacion" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" CssClass="labelTitulo" Text="GENERACION DE GRAFICOS ESTADISTICOS CON SP"></asp:Label>
    </p>
    <table align="center">
        <asp:GridView ID="grvFacturacion" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" CssClass="GriedView CenterGridView">
                <AlternatingRowStyle BackColor="White" />
                <Columns>

                    <asp:BoundField DataField="Año" HeaderText="Año" />
                    <asp:BoundField DataField="TotalAnual" HeaderText="Total facturado (S/.)" />
                    <asp:BoundField DataField="CantFacturas" HeaderText="Cantidad facturas" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
    </table>
    <tr align="center">
        <td align="center">
            <asp:Chart ID="grafTotales" runat="server" Height="408px" Width="570px">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
                <Titles>
                    <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 8.25pt, style=Bold" Name="Title1" Text="Total de ventas anual">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
        <td align="center">
            <asp:Chart ID="grafCantidad" runat="server" Height="408px" Width="570px">
                <Series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
                <Titles>
                    <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 8.25pt, style=Bold" Name="Title1" Text="Cantidad de facturas anual">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
    </tr>
    <p>
        <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
</p>
</asp:Content>
