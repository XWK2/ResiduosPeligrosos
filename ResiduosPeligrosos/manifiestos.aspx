<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="manifiestos.aspx.cs" Inherits="ResiduosPeligrosos.manifiestos" %>
<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/jscript">
          function OnEndCallback(s, e) {              
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'Update') {
                    swal("Information", "The registry was updated successfully", "success");
                } else if (s.cpAlertMessage == 'Insert') {
                    swal("Information", "Record added successfully!", "success");
                } else if (s.cpAlertMessage == 'Delete') {
                    swal("Information", "Registration was successfully enabled / disabled!", "success");
                } else if (s.cpAlertMessage == 'Error') {
                    swal("Warning", "An error has occurred from the database");
                }
                grid.PerformCallback('Search');
            }
        }

        function raiseValidation() {
            if (ASPxClientEdit.ValidateEditorsInContainer(null))
                grid.UpdateEdit();            
        }

        function OnCallback() {
            grid.PerformCallback('Search');
        }

        function GetSelectedFieldValuesCallback(values) {
            var Valores = "";
            for (var i = 0; i < values.length; i++) {
                if (Valores == "") {
                    Valores = Valores + values[i];
                } else {
                    Valores = Valores + ", " + values[i];
                }
            }
        }

        function DisableSelected() {
            var Valores = "";
            $(".chk").each(function () {
                if (this.checked) {
                    if (Valores == "") {
                        Valores = this.id.substr(3);
                    } else {
                        Valores += "," + this.id.substr(3);
                    }
                }
            });

            if (Valores == "") {

                swal({
                    title: "Information",
                    text: "No records selected!",
                    type: "info"
                });
                return;
            }

            swal({
                title: "Are you sure?",
                text: "Are you sure you want to enable / disable all the selected records?",
                type: "warning",
                showCancelButton: true,
                confirmButtonClass: "btn-danger",
                confirmButtonText: "Yes",
                cancelButtonText: "No",
                closeOnConfirm: false,
                closeOnCancel: false
            },
              function (isConfirm) {
                  if (isConfirm) {
                      CallbackPanelDisable.PerformCallback(Valores);
                      grid.PerformCallback('Search');
                      swal("Deleted", "Records were successfully enabled / disabled", "success");
                  } else {
                      swal("Cancelled", "You canceled the operation", "error");
                  }
              });
        }

        function DisableAll() {

            swal({
                title: "Are you sure?",
                text: "Are you sure you want to enable / disable all registers?",
                type: "warning",
                showCancelButton: true,
                confirmButtonClass: "btn-danger",
                confirmButtonText: "Yes",
                cancelButtonText: "No",
                closeOnConfirm: false,
                closeOnCancel: false
            },
            function (isConfirm) {
                if (isConfirm) {
                    CallbackPanelDisableAll.PerformCallback();
                    grid.PerformCallback('Search');
                    swal("Deleted", "All logs were successfully enabled/disabled", "success");
                } else {
                    swal("Cancelled", "You canceled the operation", "error");
                }
            });
        }

        function DowloadFileXLS() {
            CallbackPanelDowload.PerformCallback();
        }

        function UploadFileXLS() {
            PanelUploadFile.SetVisible(true);
        }

        //Carga Archivo Excel de Lista Material con Precios.
        function UploaderReceipt_OnUploadStartExcel() {
            btnUploadReceiptExcel.SetEnabled(false);
        }

        function UploaderReceipt_OnFileUploadCompleteExcel(args) {
            if (args.isValid) {
                grid.PerformCallback('Search');
                swal("Satisfactoriamente!", "Archivo cargado satisfactoriamente", "success");
                PanelUploadFile.SetVisible(false);
            }
        }

        function UploaderReceipt_OnFilesUploadCompleteExcel(args) {
            UpdateUploadReceiptButtonExcel();
        }

        function UpdateUploadReceiptButtonExcel() {
            btnUploadReceiptExcel.SetEnabled(uploaderReceiptExcel.GetText(0) != "");
        }

        function OnEndReceiptCallbackExcel(s, e) {
            if (s.cpAlertMessage != '') {
                alert(s.cpAlertMessage)
                grid.PerformCallback('Search');
            }
        }

        function OnAppsEndCallback(s, e) {
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'SelectOne') {
                    swal("Information", "Select an application to add it to the list", "info");
                } else if (s.cpAlertMessage == 'Exist') {
                    swal("Information", "The selected application is already added to the list", "info");
                }
                //alert(s.cpAlertMessage);
            }
        }
                
        function onSelectedTipoManifiestoChanged(s, e) {            
            var valor = s.GetValue();            
            MainContent_ASPxNavBar2_GCTC0_cmbTipoResiduoEdit_0_DDD_L.PerformCallback(valor);
        }

         //BOTON: Click en Boton de Exportar
        function DivClickedExportar() {
            var btnNuevoExportar = $('#<%= btnExportar.ClientID %>');
            if (btnNuevoExportar != null) {
                btnNuevoExportar.click();
            }
        }

    </script>
    <style>
        .Campos {
            width:250px;
            background-color:white;
            margin:2px;
            padding:1px;
            border-color:darkgray;
            font-size:small;
        }
        .gblue{
            color:#337ab7;
        }
        .dot {
          height: 15px;
          width: 15px;
          border-radius: 50%;
          display: inline-block;
        }
    </style>
    <div id="Busqueda" runat="server">
        <dx:ASPxNavBar ID="ASPxNavBar2" runat="server" Theme="Metropolis" Width="100%" 
            Font-Bold="False">
            <Groups>
                <dx:NavBarGroup Text="Solicitud de Manifiesto \ Filtros">
                        <ContentTemplate>
                                <div id="Parametros" runat="server" visible="true">
                                            
                                <table style="float: left; width: 40%" class="OptionsTable BottomMargin">
                                    <tr>
                                        <td style="width:10%; text-align:left">
                                           <dx:ASPxLabel ID="lblFolio" runat="server" Text="Número de Manifiesto "></dx:ASPxLabel>
                                        </td>
                                        <td style="width:30%; text-align:left">
                                            <dx:ASPxTextBox runat="server" Theme="SoftOrange" Height="5px"  ID="xtxtFolio" Enabled="True" Width="100%" FocusedStyle-Border-BorderColor="#3399ff" FocusedStyle-Border-BorderStyle="Double"></dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                         <td style="width:10%; text-align:left">
                                            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Tipo Manifiesto "></dx:ASPxLabel>
                                         </td>
                                        <td style="width:30%; text-align:left">
                                               <dx:ASPxComboBox ID="cmbTipoManifiesto" ClientInstanceName="cmbTipoManifiesto" runat="server" FocusedStyle-Border-BorderColor="#3399ff" 
                                                Font-Names="Segoe UI" IncrementalFilteringMode="Contains" FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="10" Theme="SoftOrange" 
                                                PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true" Width="100%" Paddings-Padding="0px" >                                                    
                                                   <ClientSideEvents SelectedIndexChanged="onSelectedTipoManifiestoChanged" />
                                                <ButtonStyle BackColor="#0099FF"></ButtonStyle>
                                            </dx:ASPxComboBox>
                                        </td>
                                      </tr>
                                     <tr>
                                        <td style="width:10%; text-align:left">
                                            <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Grupo de Residuo ">
                                            </dx:ASPxLabel>
                                        </td>
                                        <td style="width:30%; text-align:left">                                        
                                           <dx:ASPxComboBox ID="cmbTipoResiduoEdit" ClientInstanceName="cmbTipoResiduoEdit" runat="server" FocusedStyle-Border-BorderColor="#3399ff" OnCallback="cmbTipoResiduoEdit_Callback" ClientEnabled="true"
                                                Font-Names="Segoe UI" IncrementalFilteringMode="Contains" FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="10" Theme="SoftOrange"
                                                PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true" Width="100%" Paddings-Padding="0px">                                                
                                                <ButtonStyle BackColor="#0099FF"></ButtonStyle>
                                            </dx:ASPxComboBox>
                                        </td>        
                                    </tr>
                                    <tr>
                                        <td style="width:10%; text-align:left">
                                             <dx:ASPxLabel ID="ASPxLblFechaIni" runat="server" Text="Fecha Inicial "></dx:ASPxLabel>
                                        </td>
                                        <td style="width:30%; text-align:left">
                                            <dx:ASPxDateEdit ID="xDateFechaIni" runat="server" Width="200px"  Theme="SoftOrange"
                                                DisplayFormatString="yyyy-MM-dd" EditFormatString="yyyy-MM-dd">                                                             
                                                <TimeSectionProperties>
                                                    <TimeEditProperties EditFormatString="hh:mm tt" />
                                                </TimeSectionProperties>
                                            </dx:ASPxDateEdit> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width:10%; text-align:left">
                                             <dx:ASPxLabel ID="ASPxLblFechaFin" runat="server" Text="Fecha Final "></dx:ASPxLabel>
                                        </td>
                                        <td style="width:30%; text-align:left">
                                            <dx:ASPxDateEdit ID="xDateFechaFin" runat="server" Width="200px"  Theme="SoftOrange"
                                                DisplayFormatString="yyyy-MM-dd" EditFormatString="yyyy-MM-dd">                                                             
                                                <TimeSectionProperties>
                                                    <TimeEditProperties EditFormatString="hh:mm tt" />
                                                </TimeSectionProperties>
                                            </dx:ASPxDateEdit> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width:20%; text-align:right">
                                            <dx:ASPxButton ID="btnBuscar" runat="server" Text="Buscar" Theme="SoftOrange" AutoPostBack="false" >
                                                <ClientSideEvents Click="OnCallback" />
                                            </dx:ASPxButton>                                             
                                        </td>                                                   
                                      </tr>
                                </table>
                                <table style="float: right; width: 20%" class="OptionsTable BottomMargin">
                                    <tr>
                                        <td>
                                            <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="+ Opciones" Theme="Metropolis" >
                                                <PanelCollection>
                                                <dx:PanelContent>
                                                    <div>
                                                        <table>
                                                            <tr>
                                                                <td style="width:100%">
                                                                    <div class="div-container" style="visibility:hidden">
                                                                        <div class="div-img" >
                                                                        <asp:ImageButton runat="server" id="imgNew" class="img" ImageUrl="Assets/Images/New.png" OnClick="imgNew_Click" alt="Nuevo" style="cursor:pointer" title="Nuevo"/>
                                                                        </div>
                                                                    </div>
                                                                </td> 
                                                                    <td style="width:20%">
                                                                        <div class="div-container">
                                                                        <div class="div-img" >
                                                                        <img class="img" src="Assets/Images/trash_can.png" alt="Elimina Seleccionados" style="cursor:pointer" onclick="return DisableSelected();" title="Elimina Seleccionados" />
                                                                        </div>
                                                                        </div>
                                                                </td>
                                                                <td style="width:20%" >
                                                                    <div class="div-container" style="visibility:hidden">
                                                                        <div class="div-img" >
                                                                            <img class="img" src="Assets/Images/delete_all.png" alt="Elimina Todos" style="cursor:pointer" onclick="return DisableAll();" title="Elimina Todos" /> 
                                                                        </div>
                                                                    </div>
                                                                </td>
                                                                    <td>
                                                                    <dx:ASPxCallbackPanel ID="CallbackPanelDisable" ClientInstanceName="CallbackPanelDisable" runat="server" Width="200px" oncallback="CallbackPanelDisable_Callback">
                                                                        <PanelCollection>
                                                                            <dx:PanelContent runat="server"></dx:PanelContent>
                                                                        </PanelCollection>
                                                                    </dx:ASPxCallbackPanel>
                                                                    <dx:ASPxCallbackPanel ID="CallbackPanelDisableAll" ClientInstanceName="CallbackPanelDisableAll" runat="server" Width="200px" oncallback="CallbackPanelDisableAll_Callback">
                                                                        <PanelCollection>
                                                                            <dx:PanelContent runat="server"></dx:PanelContent>
                                                                        </PanelCollection>
                                                                    </dx:ASPxCallbackPanel>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </dx:PanelContent>
                                                </PanelCollection>
                                            </dx:ASPxRoundPanel>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </ContentTemplate>                                
                </dx:NavBarGroup>                            
            </Groups>
        </dx:ASPxNavBar>
    </div>
    <div id="Detalle" runat="server">
        <div class="container-fluid" style="padding: 0px; padding-left: 1px; margin:0px;">
            <table>
                <tr>
                    <td>
                        <div style="background-image: url('../Assets/images/BtnExportar.png'); background-repeat: no-repeat; width: 150px; height: 30px; color: white; font-size: 12px; padding-left: 30px; padding-top: 5px; cursor: pointer;" runat="server" onclick="javascript:DivClickedExportar();">Exportar</div>
                        <asp:Button ID="btnExportar" runat="server" Text="Exportar" OnClick="btnExportar_Click" Style="display: none" />
                    </td>
                </tr>
            </table>
        </div>
        <dx:ASPxGridViewExporter ExportSelectedRowsOnly="false" GridViewID="xgrdProds" ID="exportGrid" runat="server"> </dx:ASPxGridViewExporter>
        <dx:ASPxGridView ID="xgrdProds" runat="server" AutoGenerateColumns="False" 
            Width="100%" Font-Names="Segoe UI" KeyFieldName="ManifiestoId" 
            OnHtmlDataCellPrepared="xgrdProds_HtmlDataCellPrepared"  OnDetailRowExpandedChanged="xgrdProds_DetailRowExpandedChanged"
            ClientInstanceName="grid" Theme="Metropolis">
            <SettingsBehavior ConfirmDelete="true" ColumnResizeMode="Control" EnableRowHotTrack="true" AllowEllipsisInText="True"/>
            <Settings HorizontalScrollBarMode="Auto" ShowFilterRow="True" ShowHeaderFilterButton="true" GridLines="Horizontal" 
                ShowFilterBar="Visible" ShowFilterRowMenu="true" ShowFooter="true" VerticalScrollBarMode="Hidden" ShowGroupPanel="true"/>
		    <SettingsPager Mode="ShowPager" PageSize="14" AllButton-Visible="true" Position="Bottom" ShowEmptyDataRows="true" EnableAdaptivity="True">
		        <AllButton Visible="true"/>
                <FirstPageButton Visible="true"/>
                <LastPageButton Visible="true"/>
                <PageSizeItemSettings ShowAllItem="true" Visible="true"/>
            </SettingsPager>
            <SettingsDetail ShowDetailRow="true" />
            <Columns>
                <dx:GridViewDataBinaryImageColumn Caption="Actions" FieldName="Actions" VisibleIndex="1" Width="25px" CellStyle-HorizontalAlign="Center">
                      <PropertiesBinaryImage DisplayFormatString="{0}"/>
                </dx:GridViewDataBinaryImageColumn> 
                <dx:GridViewDataTextColumn FieldName="ManifiestoId" Visible="false" Caption="Manifiesto" VisibleIndex="0"/>
                <dx:GridViewDataTextColumn Name="CheckID" VisibleIndex="1"  visible="false"/>
                <dx:GridViewDataTextColumn FieldName="numManifiesto" VisibleIndex="2" Caption="No. Documento" CellStyle-ForeColor="#FF0000"/>
                <dx:GridViewDataTextColumn FieldName="autor" VisibleIndex="3" Caption="Solicitante" CellStyle-ForeColor="#336600"/>
                <dx:GridViewDataTextColumn FieldName="fecha" VisibleIndex="4" Caption="Fecha Solicitud" CellStyle-ForeColor="#336600"/>
                <dx:GridViewDataTextColumn FieldName="tipoManifiestoDesc" VisibleIndex="5" Caption="Tipo Manifiesto" />
                <dx:GridViewDataTextColumn FieldName="tipoResiduoDesc" VisibleIndex="6" Caption="Tipo Residuo" />
                <dx:GridViewDataTextColumn FieldName="numFactura" VisibleIndex="7" Caption="No. Factura" CellStyle-ForeColor="#FF6600"/>
                <dx:GridViewDataTextColumn FieldName="numShipping" VisibleIndex="8" Caption="No. Shipping" CellStyle-ForeColor="#FF6600"/>
                <dx:GridViewDataTextColumn FieldName="estatus" VisibleIndex="8" Caption="Estatus" CellStyle-ForeColor="#0066FF"/>
                <dx:GridViewDataTextColumn FieldName="planta" VisibleIndex="9" Caption="Planta" />
                <dx:GridViewDataTextColumn FieldName="nombreGeneradorDesc" VisibleIndex="10" Caption="Cliente" visible="false"/>
                <dx:GridViewDataTextColumn FieldName="nombreTransportistaDesc" VisibleIndex="11" Caption="Transportista" />
                <dx:GridViewDataTextColumn FieldName="nombreDestinatarioDesc" VisibleIndex="12" Caption="Destinatario" />
                <dx:GridViewDataTextColumn FieldName="contenedores" VisibleIndex="13" Caption="Contenedores" CellStyle-HorizontalAlign="Center" />
                <dx:GridViewDataTextColumn FieldName="estatusPago" VisibleIndex="14" Caption="Estatus Pago" CellStyle-HorizontalAlign="Center" />
                
            </Columns>
            <GroupSummary>
                <dx:ASPxSummaryItem SummaryType="Count" />
            </GroupSummary>
            <Styles>
                <AlternatingRow BackColor="#F4F4F4"/>
                <RowHotTrack BackColor="#CEECF5"/>
                <Header BackColor="#F2F2F2" HorizontalAlign="Center" Font-Bold="true" CssClass="text-center"/>
                <GroupRow Font-Italic="true" ForeColor="#0066FF"/>
            </Styles>
            <Templates>
                <DetailRow>
                    <dx:ASPxGridView ID="xgrdDetalle" runat="server" AutoGenerateColumns="False" 
                        Width="100%" Font-Names="Segoe UI"
                        KeyFieldName="ManifiestoId"                         
                        ClientInstanceName="xgrdDetalle"
                        Theme="Metropolis" Settings-HorizontalScrollBarMode="Auto">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="ManifiestoId"  Caption="Manifiesto ID" VisibleIndex="1" Visible="false" />
                            <dx:GridViewDataTextColumn FieldName="NoDocumento"  Caption="NoDocumento" VisibleIndex="2"  Visible="false"  CellStyle-ForeColor="#FF0000" />
                            <dx:GridViewDataTextColumn FieldName="Solicitante" VisibleIndex="3" Caption="Solicitante"  Visible="false" /> 
                            <dx:GridViewDataTextColumn FieldName="FechaSolicitud" VisibleIndex="4" Caption="FechaSolicitud"  Visible="false"  /> 
                            <dx:GridViewDataTextColumn FieldName="tipoManifiesto" VisibleIndex="5" Caption="Tipo Manifiesto"  Visible="false"  />
                            <dx:GridViewDataTextColumn FieldName="tipoResiduo" VisibleIndex="6" Caption="Tipo Residuo"  Visible="false"  />
                            <dx:GridViewDataTextColumn FieldName="Generador" VisibleIndex="7" Caption="Generador"  Visible="false"  />
                            <dx:GridViewDataTextColumn FieldName="Transportista" VisibleIndex="8" Caption="Transportista"  Visible="false"  />
                            <dx:GridViewDataTextColumn FieldName="Destinatario" VisibleIndex="9" Caption="Destinatario"  Visible="false"  />
                            <dx:GridViewDataTextColumn FieldName="numFactura" VisibleIndex="10" Caption="No. Factura"  Visible="false"  />
                            <dx:GridViewDataTextColumn FieldName="numShipping" VisibleIndex="11" Caption="No. Shipping"  Visible="false"  />
                            <dx:GridViewDataTextColumn FieldName="EstatusGaylord" VisibleIndex="12" Caption="Estatus Contenedor"  Visible="false"  />
                            <dx:GridViewDataTextColumn FieldName="contenedorID" VisibleIndex="13" Caption="Contenedor" />
                            <dx:GridViewDataTextColumn FieldName="residuo" VisibleIndex="14" Caption="Residuo" />
                            <dx:GridViewDataTextColumn FieldName="noParte" VisibleIndex="15" Caption="No Parte" />
                            <dx:GridViewDataTextColumn FieldName="material" VisibleIndex="16" Caption="Parte Descripción" />
                            <dx:GridViewDataTextColumn FieldName="IEDescripcion" VisibleIndex="17" Caption="IE Descripción" />
                            <dx:GridViewDataTextColumn FieldName="peso" VisibleIndex="18" Caption="Peso" />
                            <dx:GridViewDataTextColumn FieldName="tipoEnvase" VisibleIndex="19" Caption="Tipo Envase" />
                            <dx:GridViewDataTextColumn FieldName="clasificaciones" VisibleIndex="20" Caption="Clasificaciones" />
                            <dx:GridViewDataTextColumn FieldName="almacen" VisibleIndex="21" Caption="Almacén" />
                            <dx:GridViewDataTextColumn FieldName="locacion" VisibleIndex="22" Caption="Locación" />
                            <dx:GridViewDataTextColumn FieldName="FechaAlta" VisibleIndex="23" Caption="Fecha Alta" />
                            <dx:GridViewDataTextColumn FieldName="UsuarioAlta" VisibleIndex="24" Caption="Usuario Alta" />
                            <dx:GridViewDataTextColumn FieldName="fechaLlenado" VisibleIndex="25" Caption="Fecha Llenado" />
                            <dx:GridViewDataTextColumn FieldName="UsuarioLlenado" VisibleIndex="26" Caption="Usuario Llenado" />
                            <dx:GridViewDataTextColumn FieldName="fechaPeso" VisibleIndex="27" Caption="Fecha Peso" />
                            <dx:GridViewDataTextColumn FieldName="UsuarioPeso" VisibleIndex="28" Caption="Usuario Peso" />
                            <dx:GridViewDataTextColumn FieldName="fechaEmbarcado" VisibleIndex="29" Caption="Fecha Peso" />
                            <dx:GridViewDataTextColumn FieldName="UsuarioEmbarcado" VisibleIndex="30" Caption="Usuario Peso" />
                             <dx:GridViewDataTextColumn FieldName="etiqueta" VisibleIndex="31" Caption="Usuario Peso" />
                             <dx:GridViewDataTextColumn FieldName="expira" VisibleIndex="32" Caption="Usuario Peso" />
                             <dx:GridViewDataTextColumn FieldName="tiempoExpiracion" VisibleIndex="33" Caption="Usuario Peso" />
                        </Columns>
                        <SettingsBehavior ConfirmDelete="true"/>
                        <SettingsPager Mode="ShowPager" PageSize="13" EnableAdaptivity="True" />
                        <Settings ShowFilterRow="True" />                        
                        <SettingsDetail ShowDetailRow="false" />
                        <Styles>
                            <AlternatingRow BackColor="#F4F4F4"/>
                            <RowHotTrack BackColor="#CEECF5"/>
                            <Header BackColor="#F2F2F2" HorizontalAlign="Center" Font-Bold="true" CssClass="text-center"/>                                           
                        </Styles>
                        <SettingsBehavior EnableRowHotTrack="true" />    
                    </dx:ASPxGridView> 
                </DetailRow>
            </Templates>                
        </dx:ASPxGridView>
    </div>
</asp:Content>
