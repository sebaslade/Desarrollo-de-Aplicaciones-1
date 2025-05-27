<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Evento.aspx.cs" Inherits="SitioWEB_LeonComputingGUI.Consultas.Evento" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div align="center">
    <div class="container padded">
    <h2>
        <asp:Label ID="Label1" runat="server" CssClass="labelTitulo" Text="Graficos estadisticos para eventos"></asp:Label>
    </h2>
    <div class="chart-container">
        <asp:GridView ID="grvPresupuestoMensual" runat="server" CssClass="GriedView text-center" AutoGenerateColumns="False" CellPadding="1">
            <Columns>
                <asp:BoundField DataField="Mes" HeaderText="Meses" />
                <asp:BoundField DataField="Presupuesto" HeaderText="Presupuesto (S/.)" />
                <asp:BoundField DataField="Cupos" HeaderText="Cupos Programados" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#1e434c" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#f1f1f2" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#f1f1f2" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </div>
    <br />
    <div class="chart-container">
        <asp:Chart ID="grafPresupuesto" runat="server" Height="332px" Width="800px" BackColor="Black" BackGradientStyle="Center" Palette="None" PaletteCustomColors="255, 212, 116">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
            <Titles>
                <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 8.25pt, style=Bold" Name="Title1" Text="Presupuesto Requerido">
                </asp:Title>
            </Titles>
        </asp:Chart>
    </div>
    <br />
    <div class="chart-container">
        <asp:Chart ID="grafCupos" runat="server" Height="332px" Width="800px" BackColor="Black" BackGradientStyle="Center" Palette="None" PaletteCustomColors="255, 212, 116">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
            <Titles>
                <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 8.25pt, style=Bold" Name="Title1" Text="Cupos Programados">
                </asp:Title>
            </Titles>
        </asp:Chart>
    </div>
    <p>
        <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
    </p>
        </div>
        </div>
</asp:Content>
