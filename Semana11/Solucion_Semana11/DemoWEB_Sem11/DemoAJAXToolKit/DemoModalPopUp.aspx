<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="DemoModalPopUp.aspx.cs" Inherits="DemoWEB_AJAX.EjemplosAJAXToolkit.DemoModalPopUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    
    
    
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
    
    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" Runat="Server">

 

       
  <p class="tituloForm">
        Ejemplo de Modal PopUp AJAX</p>
    <br />
    <table width="600px" >
        <tr>
            <td class="labelContenido" >Ingrese Horas trabajadas</td>
            <td class="auto-style2" >
                <asp:TextBox ID="txtHoras" runat="server" CssClass="TextBoxDerecha" Width="30px"></asp:TextBox>
                <%--<ajaxToolkit:MaskedEditExtender ID="txtHoras_MaskedEditExtender" runat="server" BehaviorID="txtHoras_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Mask="99" MaskType="Number" TargetControlID="txtHoras" />--%>
            </td>
        </tr>
        <tr>
            <td class="labelContenido" >Tarifa horaria</td>
            <td >
                <asp:TextBox ID="txtTarifa" runat="server" CssClass="TextBoxDerecha" ReadOnly="True" Width="30px"></asp:TextBox>
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/Buscar.png" OnClick="btnBuscar_Click" style="width: 16px" />
            </td>
        </tr>
        <tr>
            <td class="labelContenido" >Ingrese tardanzas</td>
            <td class="auto-style2"  >
                <asp:TextBox ID="txtTardanzas" runat="server" CssClass="TextBoxDerecha" Width="30px"></asp:TextBox>
                &nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="labelContenido" >&nbsp;</td>
            <td  >
                <asp:Button ID="btnCalcular" runat="server" CssClass="boton-new" OnClick="btnCalcular_Click" style="height: 26px" Text="Calcular" />
            </td>
        </tr>
        <tr>
            <td class="labelContenido"  >Calculo del neto a pagar</td>
            <td  >
                <asp:TextBox ID="txtNeto" runat="server" CssClass="TextBoxDerecha" ReadOnly="True" Width="100px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
              
            </td>
            <td >
            </td>
        </tr>
    </table>
       
               <%--CONFIGURACION DEL MODALPOPUP DE MENSAJES --%>
                <%--Paso 1: Control target (puede ser cualquier control)--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 <%--Paso 2: El panel cuyo contenido se mostrara en el popup--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="auto-style1" > 
                                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table>
                    <div> 
                        <asp:Label ID="lblMensaje" runat="server" ForeColor ="Black" CssClass="labelTitulo" /> 
                    </div>
                     <div>
                         <br />
                     </div>
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="boton" /> 
                    </div> 
                  <div>
                         <br />
                     </div>
                </asp:Panel> 
          <%--Paso 3:  El ModalPopup de AJAX Toolkit que hace referencia al ID del control target del paso 1  (TargetControlID="lnkMensaje")
                    y al ID del panel definido en el paso 2 (PopupControlID="pnlMensaje")--%>
                <ajaxToolkit:ModalPopupExtender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar" />

    <%--CONFIGURACION DEL MODALPOPUP DE TARIFARIO--%>
              <%--Paso 1: Control target (puede ser cualquier control)--%>
              <asp:LinkButton ID="lnkTarifario"   runat="server" ></asp:LinkButton>
              <%--Paso 2:  El panel cuyo contenido se mostrara en el popup--%>
              <asp:Panel ID="pnlTarifario" runat="server" CssClass="CajaDialogo" Style="display:normal ;" Width ="300px"> 
                    <table border="0" width="300px" style="margin: 0px; padding: 0px; color: #FFFFFF;"> 
                        <tr style="background-color:darkred""> 
                            <td align="center" colspan="2"> 
                                <asp:Label ID="Label1" runat="server" Text="Tarifa" /> 
                                &nbsp;&nbsp;&nbsp;&nbsp;
                            </td> 
                        </tr> 
                         <tr>
                             <td class="auto-style4">
                                   <asp:Label ID="Label2" runat="server" Text="Seleccione tarifa:" CssClass="labelContenido" /> 
                             </td>
                             <td class="auto-style6">
                        <asp:DropDownList ID="cboCategoria" runat="server">
                        <asp:ListItem Value="0">--Seleccione--</asp:ListItem>
                        <asp:ListItem Value="50">Tiempo completo</asp:ListItem>
                        <asp:ListItem Value="30">Tiempo parcial</asp:ListItem>
                        <asp:ListItem Value="20">Jefe practica</asp:ListItem>
                        </asp:DropDownList>
                             </td>

                         </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblValidacion" runat="server" cssClass="labelContenido"></asp:Label>
                            </td>
                        </tr>
                    </table> 
                    
                    <div> 
                        <asp:Button ID="btnAceptarTarifa" runat="server" Text="Aceptar" OnClick="btnAceptarTarifa_Click" CssClass="boton" />  &nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="boton" /> 
                    </div> 
                  <div> 
                        <br />
                    </div> 
                </asp:Panel> 
              <%--Paso 3:  El ModalPopup de AJAX Toolkit que hace referencia al ID del control target del paso 1  (TargetControlID="lnkTarifario")
                    y al ID del panel definido en el paso 2 (PopupControlID="pnlTarifario)--%>
             <ajaxToolkit:ModalPopupExtender ID="mpTarifario" runat="server" TargetControlID="lnkTarifario" 
                    PopupControlID="pnlTarifario" BackgroundCssClass="FondoAplicacion"  />
                
    <br />
    <br />
     
</asp:Content>
