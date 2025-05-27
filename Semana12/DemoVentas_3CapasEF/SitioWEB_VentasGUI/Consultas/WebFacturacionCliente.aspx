<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebFacturacionCliente.aspx.cs" Inherits="SitioWEB_VentasGUI.Consultas.WebFacturacionCliente" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 27px;
        }
        .auto-style4 {
        text-align: center;
        height: 20px;
    }
        .auto-style5 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
        }
        .auto-style7 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 27px;
        }
        .auto-style8 {
            text-align: left;
            height: 27px;
        }
    .auto-style9 {
        font-family: Verdana;
        font-size: 10pt;
        color: #993366;
        height: 20px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
  
    <p class="tituloForm">
        <br />
        CONSULTA DE FACTURACION POR CLIENTE ENTRE FECHAS</p>
       <asp:UpdatePanel runat="server" ID="UpdatePanel1">
         <ContentTemplate >            
    <table width="1000px">
        <tr>
            <td class="auto-style9" >Ingrese cliente:</td>
            <td width="150px" class="auto-style9">
                <asp:TextBox ID="txtCod" runat="server" CssClass="TextBoxDerecha" MaxLength="4" Width="70px"></asp:TextBox>
            &nbsp;
                <asp:RequiredFieldValidator ID="rqf1" runat="server" ControlToValidate="txtCod" CssClass="labelErrores" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
                </td>
            <td class="auto-style4">
                </td>
            <td class="auto-style4">
                </td>
        </tr>
         <tr>
            <td class="auto-style7">Fecha inicio:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtFecIni" runat="server" CssClass="TextBoxDerecha" Width="100px"></asp:TextBox>
                
             
                
            &nbsp;
                <asp:RequiredFieldValidator ID="rqf2" runat="server" ControlToValidate="txtFecIni" CssClass="labelErrores" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
                
            </td>
            <td class="auto-style7" >Fecha fin:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtFecFin" runat="server" CssClass="TextBoxDerecha" Width="100px"></asp:TextBox>
            
                
            &nbsp;
                <asp:RequiredFieldValidator ID="rqf3" runat="server" ControlToValidate="txtFecFin" CssClass="labelErrores" ErrorMessage="Obligatorio"></asp:RequiredFieldValidator>
                
            </td>
        </tr>
    
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style8">
                <asp:Button ID="btnConsultar" runat="server" CssClass="boton2" Text="Consultar" OnClick="btnConsultar_Click"   />
            </td>
            <td class="auto-style2">
                </td>
            <td class="auto-style2">
                </td>
        </tr>
        <tr>
            <td class="labelContenido">Razon Social</td>
            <td>
                <asp:TextBox ID="txtRazSoc" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="labelContenido">RUC:</td>
            <td>
                <asp:TextBox ID="txtRUC" runat="server" CssClass="TextBoxDerecha" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="labelContenido">Direccion:</td>
            <td>
                <asp:TextBox ID="txtDir" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="labelContenido">Ubigeo:</td>
            <td>
                <asp:TextBox ID="txtUbicacion" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Telefono:</td>
            <td class="auto-style6" >
                <asp:TextBox ID="txtTel" runat="server" CssClass="TextBoxDerecha" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style5">Estado:</td>
            <td class="auto-style6" >
                <asp:TextBox ID="txtEstado" runat="server" CssClass="TextBoxDerecha" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="labelContenido">Deuda:</td>
            <td >
                <asp:TextBox ID="txtDeuda" runat="server" CssClass="TextBoxDerecha" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="labelContenido"></td>
            <td ></td>
        </tr>
       
        <tr>
            <td colspan="3" class="center">
                <asp:Label ID="lblRegistros" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
            <td >
                <asp:Button ID="btnDescargar" runat="server" CssClass="boton-new"  Text="Descargar Excel" Width="150px" OnClick="btnDescargar_Click" />
                </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
        
                <asp:GridView ID="grvFacturas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="1155px" CssClass="GriedView" ShowHeaderWhenEmpty="True">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Num_fac" HeaderText="Nro. factura" NullDisplayText="--" />
                        <asp:BoundField DataField="Fec_fac" DataFormatString="{0:d}" HeaderText="Fec. facturacion" />
                        <asp:BoundField DataField="Fec_can" DataFormatString="{0:d}" HeaderText="Fec. cancelacion" NullDisplayText="--" />
                        <asp:BoundField DataField="Total" DataFormatString="{0:n}" HeaderText="Total (S/.)" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="ApellNom_ven" HeaderText="Vendedor" />
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
              <%--Este es el modal popup  que contiene los mensajes --%>
                <%--1. Control target (cualquier control)--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 <%--2. El panel que se mostrara en el popup--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
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
                        <asp:Label ID="lblMensajePopup" runat="server" CssClass="labelTitulo"  /> 
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
                <ajaxToolkit:modalpopupextender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar" />

           </ContentTemplate>
           <Triggers>
        <asp:PostBackTrigger ControlID="btnDescargar" />
    </Triggers>
 </asp:UpdatePanel>
  <%--  Aqui configuramos el UpdateProgress para que muestre el contenido del ProgressTemplate todo el tiempo que demore en actualizarse
           el UpdatePanel definido en la propiedad AssociatedUpdatePanelID (en este caso el UpdatePanel1.
          NOTA: Recuerde descomentar el codigo contenido dentro del  ProgressTemplate antes de probar el formulario --%>
  <asp:UpdateProgress ID="UpdateProgress1" runat="server" 
      DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
          <ProgressTemplate>
              <div  class="overlay">
                <div class="overlayContent">
                  <h2>Espere un momento....</h2>  
                  <img src ="../Images/loading.gif" alt ="Loading" border="0"/>      
               </div>
              </div>
          </ProgressTemplate>
   </asp:UpdateProgress>
          
</asp:Content>
