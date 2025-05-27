<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="SitioWEB_LeonComputingGUI.Consultas.Curso" %>

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
                                <h1 class="labelTitulo">Ingrese una dificultad:</h1>
                            </td>
                            <td class="input-group mb-3">
                                <asp:TextBox type="text" class="form-control" placeholder="Alta - Media - Baja" ID="txtFiltro" runat="server" aria-describedby="button-addon1"></asp:TextBox>
                                <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-success" type="button" />
                            </td>
                        </tr>
                    </table>
                    <br />


                    <asp:GridView ID="grvCursos" runat="server" CellPadding="4" CssClass="GriedView" ForeColor="#333333" GridLines="None" Width="915px" AllowPaging="True" OnPageIndexChanging="grvCursos_PageIndexChanging" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="descripcion" HeaderText="Curso" />
                            <asp:BoundField DataField="nivel_dificultad" HeaderText="Dificultad" />
                            <asp:BoundField DataField="horas_teoria" DataFormatString="{0:d}" HeaderText="Horas Teoriacas" />
                            <asp:BoundField DataField="horas_practica" DataFormatString="{0:d}" HeaderText="Horas Practicas" />
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

            <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
                <ProgressTemplate>
                    <div class="overlay">
                        <div class="overlayContent">   
                            <img src="../Images/cargando.gif" alt="Loading" border="0" />
                            <h2>Buscando</h2>
                        </div>
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
    </div>
</asp:Content>
