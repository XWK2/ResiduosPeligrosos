<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CatRelacionGaylords.aspx.cs" Inherits="ResiduosPeligrosos.CatRelacionGaylords" %>
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

        function valChange() {
            var tdFechaExp = document.getElementById("MainContent_xgrdType_DXPEForm_efnew_tdFechaExp");
            if (rblExpira.valueInput.value == "no") {
                tdFechaExp.style.display = "none";
            }
            else {
                tdFechaExp.style.display = "table-row";
            }
        }
    </script>
    <div id="Busqueda" runat="server">
        <dx:ASPxNavBar ID="ASPxNavBar2" runat="server" Theme="Metropolis" Width="100%" Font-Bold="False">
            <Groups>
                <dx:NavBarGroup Text="Relación de Contenedores \ Filtros">
                        <ContentTemplate>
                                <div id="Parametros" runat="server" visible="true">
                                    <table style="float: left; width: 40%" class="OptionsTable BottomMargin">
                                        <tr>
                                            <td style="width:10%; text-align:left">
                                                    <dx:ASPxLabel ID="lblCodigo" runat="server" Text="Código ">
                                            </dx:ASPxLabel>
                                            </td>
                                            <td style="width:30%; text-align:left">
                                                <dx:ASPxTextBox runat="server" Theme="SoftOrange" Height="5px"  ID="xtxtCodigo" Enabled="True" Width="100%" FocusedStyle-Border-BorderColor="#3399ff" FocusedStyle-Border-BorderStyle="Double">
                                                </dx:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr style="height:10px"></tr> 
                                        <tr>
                                            <td style="width:10%; text-align:left">
                                                <dx:ASPxLabel ID="lblTipo" runat="server" Text="Tipo "/>
                                            </td>
                                            <td style="width:30%; text-align:left">
                                                <dx:ASPxComboBox  ID="cmbTipo" runat="server" CssClass="labelGral" Width="200px" FocusedStyle-Border-BorderColor="#3399ff"
                                                    Font-Names="Segoe UI"  IncrementalFilteringMode="Contains" FilterMinLength="0" 
                                                    EnableCallbackMode="True" CallbackPageSize="20"  Theme="SoftOrange" >
                                                </dx:ASPxComboBox>
                                            </td>
                                        </tr>
                                        <tr style="height:5px"></tr>
                                        <tr>
                                            <td style="width:10%; text-align:left">
                                                <dx:ASPxCheckBox ID="chkActive" runat="server" Theme="SoftOrange" Text="Registros Activos" Checked="true" TextAlign="Left"></dx:ASPxCheckBox>
                                            </td>
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
                                                                            <div class="div-container">
                                                                                <div class="div-img" >
                                                                                    <img class="img" src="Assets/Images/New.png" alt="Nuevo" style="cursor:pointer" onclick="return grid.AddNewRow();" title="Nuevo"/>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td style="width:20%">
                                                                            <div class="div-container">
                                                                                <div class="div-img" >
                                                                                    <img class="img" src="Assets/Images/trash_can.png" alt="Eliminar Seleccionados" style="cursor:pointer" onclick="return DisableSelected();" title="Eliminar Seleccionados" />
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td style="width:20%" >
                                                                        <div class="div-container">
                                                                            <div class="div-img" >
                                                                                <img class="img" src="Assets/Images/delete_all.png" alt="Eliminar Todos" style="cursor:pointer" onclick="return DisableAll();" title="Eliminar Todos" /> 
                                                                            </div>
                                                                        </td>
                                                                        <td>
                                                                            <dx:ASPxCallbackPanel ID="CallbackPanelDisable" ClientInstanceName="CallbackPanelDisable" runat="server" Width="200px" oncallback="CallbackPanelDisable_Callback"></dx:ASPxCallbackPanel>
                                                                            <dx:ASPxCallbackPanel ID="CallbackPanelDisableAll" ClientInstanceName="CallbackPanelDisableAll" runat="server" Width="200px" oncallback="CallbackPanelDisableAll_Callback"></dx:ASPxCallbackPanel>
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
         <dx:ASPxGridView ID="xgrdRelacion" runat="server" AutoGenerateColumns="False" Width="100%" Font-Names="Segoe UI" KeyFieldName="RelacionId" 
                    oncustomcallback="xgrdRelacion_CustomCallback" ClientInstanceName="grid" 
                    onrowvalidating="xgrdRelacion_RowValidating" onrowinserting="xgrdRelacion_RowInserting" onrowupdating="xgrdRelacion_RowUpdating"
                    OnHtmlDataCellPrepared="xgrdRelacion_HtmlDataCellPrepared" OnHtmlEditFormCreated="xgrdRelacion_HtmlEditFormCreated" Theme="Metropolis">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="RelacionId" Visible="false" Caption="Identifier" VisibleIndex="0"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Name="CheckID" VisibleIndex="1" Width="10px"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CodigoParte" VisibleIndex="2" Caption="No. Parte" Width="15%"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Parte" VisibleIndex="3" Caption="Parte"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="numParteImportExport" VisibleIndex="4" Caption="No. Parte IE"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CodigoResiduo" VisibleIndex="5" Caption="Coóigo Residuo"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Residuo" VisibleIndex="6" Caption="Residuo"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CodigoTipoEnvase" VisibleIndex="7" Caption="Código Tipo Envase"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="TipoEnvase" VisibleIndex="8" Caption="Tipo Envase"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="tiempoExpiracion" VisibleIndex="9" Caption="Días de Expiración"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="expira" VisibleIndex="10" Caption="Expira"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="venta" VisibleIndex="11" Caption="Venta"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="etiqueta" VisibleIndex="12" Caption="Etiqueta"></dx:GridViewDataTextColumn>
                    </Columns>
                     <SettingsBehavior ConfirmDelete="true"/>
                    <SettingsPager Mode="ShowPager" PageSize="13"/>                    
                    <SettingsEditing Mode="PopupEditForm">                                            
                    </SettingsEditing>
                    <SettingsPopup >
                            <EditForm Width="600"  Modal="true" HorizontalAlign="WindowCenter" VerticalAlign="WindowCenter" ShowHeader="false"/>
                    </SettingsPopup>
                    <Settings ShowFilterRow="True" />
                    <SettingsText ConfirmDelete="Estás seguro de habilitar/deshabilitar el registro"/>
                    <Styles>
                        <AlternatingRow BackColor="#F2F2F2"></AlternatingRow>
                        <RowHotTrack BackColor="#CEECF5"></RowHotTrack>   
                        <Header BackColor="#F2F2F2"></Header>                                           
                    </Styles>
                    <SettingsBehavior EnableRowHotTrack="true" />             
                    <ClientSideEvents EndCallback="OnEndCallback"  RowDblClick="function(s, e){                                                                                                        
                                s.StartEditRow(e.visibleIndex);  
                    }"/>       
                    <Templates>
                        <EditForm>
                            <div style="margin:1px 1px 1px 1px; background-color:#F2F2F2" >
                                  <table style="width:100%; height:100px;">
                                     <tr style="background-repeat:repeat-x; background-image:url('Images/GreenBar.png'); vertical-align:middle">
                                        <td style="height:22px; text-align:left">
                                            <img src="Assets/Images/save.png" alt="" style="cursor:pointer" onclick="return raiseValidation();" />
                                        </td>
                                        <td style="height:22px; text-align:right">
                                            <img src="Assets/Images/Close.png" alt="" style="cursor:pointer" onclick="return grid.CancelEdit();" />
                                        </td>
                                      </tr>
                                      <tr>
                                        <td style="vertical-align:top;" colspan="2">
                                            <table style="width:100%; padding-left:10px; padding-right:10px; padding-bottom:20px">
                                                <tr style="height:40px">
                                                    <td style="height:40px; padding-right:10px; text-align:right" colspan="2">
                                                        <dx:ASPxLabel runat="server" ID="ASPxLabel3" Text="Reegistro de Relación de Contenedores" Font-Size="13pt" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" style="background-color:#E0E0E0; height:20px" >
                                                        <dx:ASPxLabel runat="server" ID="ASPxLabel2" Text="Descripción" Font-Size="12pt" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                    </td>
                                                </tr>  
                                                <tr>
                                                    <td style="width:50%;">
                                                        <table style="width:100%; padding-left:0px; padding-right:0px; padding-bottom:0px; padding-top:0px">
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblPartes" Text="Parte" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td>
                                                                    <input type="hidden" id="hdnParte" runat="server" value='<%# Eval("codigoParte")%>' />
                                                                    <dx:ASPxComboBox class="form-control input-sm" ID="cmbParte" runat="server" IncrementalFilteringMode="Contains" 
                                                                        FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="20" OnDataBound="cmbParte_DataBound"
                                                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true">
                                                                        <ClientSideEvents/>
                                                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>                                                                                                                       
                                                                    </dx:ASPxComboBox>
                                                                </td>
                                                            </tr>
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblCodigo" Text="No. Parte IE" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td>
                                                                    <dx:ASPxTextBox runat="server" ID="xtxtnumParteImportExportEdit" theme="SoftOrange" MaxLength="30" Text='<%# Eval("numParteImportExport")%>' Font-Names="Segoe UI"
                                                                        FocusedStyle-Border-BorderColor="#3399ff">
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                            <RequiredField IsRequired="true" ErrorText="Campos requerido"/>
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                              <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblResiduo" Text="Residuo" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td>
                                                                    <input type="hidden" id="hdnResiduo" runat="server" value='<%# Eval("codigoResiduo")%>' />
                                                                    <dx:ASPxComboBox class="form-control input-sm" ID="cmbResiduo" runat="server" IncrementalFilteringMode="Contains" 
                                                                        FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="20" OnDataBound="cmbResiduo_DataBound"
                                                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true">
                                                                        <ClientSideEvents/>
                                                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>                                                                                                                       
                                                                    </dx:ASPxComboBox>
                                                                </td>
                                                            </tr>
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblTipoEnvase" Text="Tipo Envase" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td>
                                                                    <input type="hidden" id="hdnTipoEnvase" runat="server" value='<%# Eval("codigoTipoEnvase  ")%>' />
                                                                    <dx:ASPxComboBox class="form-control input-sm" ID="cmbTipoEnvase" runat="server" IncrementalFilteringMode="Contains" 
                                                                        FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="20" OnDataBound="cmbTipoEnvase_DataBound"
                                                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true">
                                                                        <ClientSideEvents/>
                                                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>                                                                                                                       
                                                                    </dx:ASPxComboBox>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                    <td style="width:50%;">
                                                        <table style="width:100%; padding-left:0px; padding-right:0px; padding-bottom:0px; padding-top:0px">
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblTiempoExpiracion" Text="Días de Expiración" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxSpinEdit runat="server" ID="xSpinTiempoExpiracion" theme="SoftOrange" MaxLength="15" Text='<%# Eval("tiempoExpiracion")%>' Font-Names="Segoe UI"
                                                                        FocusedStyle-Border-BorderColor="#3399ff"></dx:ASPxSpinEdit>
                                                                </td>
                                                            </tr>
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblExpira" Text="Expira" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td>
                                                                    <input type="hidden" id="hdnExpira" runat="server" value='<%# Eval("expira")%>' />
                                                                    <dx:ASPxRadioButtonList ID="rblExpira" ClientInstanceName="rblExpira" runat="server" 
                                                                        OnDataBound="rblExpira_DataBound"
                                                                        RepeatColumns="2" theme="SoftOrange" FocusedStyle-Border-BorderColor="#3399ff" Font-Names="Segoe UI">
                                                                        <CaptionSettings Position="Top" />
                                                                        <ClientSideEvents ValueChanged="valChange" />
                                                                    </dx:ASPxRadioButtonList>
                                                                </td>                                                                
                                                            </tr>
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblVenta" Text="Venta" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td>
                                                                    <input type="hidden" id="hdnVenta" runat="server" value='<%# Eval("venta")%>' />
                                                                    <dx:ASPxRadioButtonList ID="rblVenta" ClientInstanceName="rblExpira" runat="server" 
                                                                        OnDataBound="rblVenta_DataBound"
                                                                        RepeatColumns="2" theme="SoftOrange" FocusedStyle-Border-BorderColor="#3399ff" Font-Names="Segoe UI">
                                                                        <CaptionSettings Position="Top" />
                                                                        <ClientSideEvents ValueChanged="valChange" />
                                                                    </dx:ASPxRadioButtonList>
                                                                </td>                                                                
                                                            </tr>
                                                             <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblEtiqueta" Text="Etiqueta" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td>
                                                                    <input type="hidden" id="hdnEtiqueta" runat="server" value='<%# Eval("etiqueta")%>' />
                                                                    <dx:ASPxRadioButtonList ID="rblEtiqueta" ClientInstanceName="rblExpira" runat="server" 
                                                                        OnDataBound="rblEtiqueta_DataBound"
                                                                        RepeatColumns="2" theme="SoftOrange" FocusedStyle-Border-BorderColor="#3399ff" Font-Names="Segoe UI">
                                                                        <CaptionSettings Position="Top" />
                                                                        <ClientSideEvents ValueChanged="valChange" />
                                                                    </dx:ASPxRadioButtonList>
                                                                </td>                                                                
                                                            </tr>
                                                            
                                                          
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table> 
                                        </td>
                                    </tr>
                                </table>
                                </div>
                        </EditForm>
                    </Templates>                   
               </dx:ASPxGridView>
    </div>
</asp:Content>
