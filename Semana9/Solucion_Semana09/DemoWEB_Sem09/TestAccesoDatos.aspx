<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestAccesoDatos.aspx.cs" Inherits="DemoWEB_Sem09.TestAccesoDatos" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        
        <h1>
            <span>Test Ejemplo 2</span>
        </h1>
        <br />
        <p>
            Ejemplo con Acceso a Datos
        </p>
        <table style="width: 709px" >
            <caption style="text-align: left">
                <strong><span>Ejemplos con Acceso a Datos</span></strong></caption>
            <tr>
                <td  >
                    <asp:DropDownList ID="cbo1" runat="server" Width="450px">
                    </asp:DropDownList></td>
                <td class="auto-style3" style="height: 29px">
                    <asp:Button ID="btnVer" runat="server" Text="Ver" Width="94px" 
                        onclick="btnVer_Click" /></td>
            </tr>
            <tr>
                <td style="height: 20px" >
                    <strong>Valor Seleccionado :</strong></td>
                <td class="auto-style2" style="height: 20px">
                    <asp:Label ID="lblcod1" runat="server" BorderStyle="None" Width="92px"></asp:Label></td>
            </tr>
            <tr>
                <td style="height: 22px" >
                    <asp:DropDownList ID="cbo2" runat="server" Width="350px" 
                        onselectedindexchanged="cbo2_SelectedIndexChanged">
                    </asp:DropDownList></td>
                <td class="auto-style2" style="height: 22px">
                    </td>
            </tr>
             
            <tr>
                <td >
                    <strong>Valor Seleccionado :</strong></td>
                <td class="auto-style2">
                    <asp:Label ID="lblcod2" runat="server" BorderStyle="None" Width="92px"></asp:Label></td>
            </tr>
              </table>
        <table>
            <tr>
                <td >
                    <asp:GridView ID="grv1" runat="server" BackColor="LightGoldenrodYellow" 
                        BorderColor="Tan" BorderWidth="1px" CellPadding="2" Width="901px" GridLines="None" ForeColor="Black">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <PagerStyle ForeColor="DarkSlateBlue" HorizontalAlign="Center" BackColor="PaleGoldenrod" />
                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                        <SortedAscendingCellStyle BackColor="#FAFAE7" />
                        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                        <SortedDescendingCellStyle BackColor="#E1DB9C" />
                        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="height: 31px;" colspan="2">
                    <asp:Label ID="lblMensaje" runat="server" BorderStyle="None" Width="721px" style="color: #FF0000"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Volver al Menu</asp:HyperLink>
        <br />
        <br />
            

</asp:Content>
