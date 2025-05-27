<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Asociado.aspx.cs" Inherits="SitioWEB_LeonComputingGUI.Consultas.Asociado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div align="center" class="padded">
        <div class="container">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table class="auto-style2">
                        <tr>
                            <td>
                                <h1 class="labelTitulo">Ingrese un código:</h1>
                            </td>
                            <td class="input-group mb-3">
                                <asp:TextBox type="text" class="form-control" placeholder="A001" ID="txtFiltro" runat="server" aria-describedby="button-addon1"></asp:TextBox>
                                <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-success" type="button"/>
                            </td>
                        </tr>
                    </table>
                    <br />


                    <asp:GridView ID="grvAsociados" runat="server" CellPadding="4" CssClass="GriedView text-center" ForeColor="#333333" GridLines="None" Width="915px" AllowPaging="True" OnPageIndexChanging="grvAsociados_PageIndexChanging" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Cod_asociado" HeaderText="Codigo" />
                            <asp:BoundField DataField="Ape_paterno" HeaderText="Apellido Paterno" />
                            <asp:BoundField DataField="Ape_materno" HeaderText="Apellido Materno" />
                            <asp:BoundField DataField="Nom_aso" HeaderText="Nombres" />
                            <asp:BoundField DataField="Dni" DataFormatString="{0:d}" HeaderText="DNI" />
                            <asp:BoundField DataField="Tlf_celular" DataFormatString="{0:d}" HeaderText="Supervisor" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Left" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>

                    <%--Este es el modal popup  que contiene los mensajes --%>
                    <%--1. Control target (cualquier control)--%>
                    <asp:LinkButton ID="lnkMensaje" runat="server"></asp:LinkButton>
                    <%--2. El panel que se mostrara en el popup--%>
                    <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500">
                        <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color: darkred; color: #FFFFFF;">
                            <tr>
                                <td align="center">
                                    <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" />
                                </td>
                                <td width="12%" class="center">
                                    <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;"
                                        ImageAlign="Right" />
                                </td>
                            </tr>

                        </table>
                        <div>
                            <br />
                        </div>
                        <div>
                            <asp:Label ID="lblMensajePopup" runat="server" CssClass="labelTitulo" />
                        </div>
                        <div>
                            <br />
                        </div>
                        <div>
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CausesValidation="False" CssClass="boton-new" />
                        </div>
                        <div>
                            <br />
                        </div>
                    </asp:Panel>
                    <%--3.El Modal popup que hace referencia al control target  (1) y al panel (2)--%>
                    <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje"
                        PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <%--  Aqui configuramos el UpdateProgress para que muestre el contenido del ProgressTemplate todo el tiempo que demore en actualizarse
           el UpdatePanel1 definido en la propiedad AssociatedUpdatePanelID .
          NOTA: Recuerde descomentar el codigo contenido dentro del  ProgressTemplate antes de probar el formulario --%>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
                <ProgressTemplate>
                    <div class="overlay">
                        <div class="overlayContent ">
                            <img src="../Images/cargando.gif" alt="Loading" border="0" />
                            <h2>Buscando</h2>
                        </div>
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
    </div>
</asp:Content>

