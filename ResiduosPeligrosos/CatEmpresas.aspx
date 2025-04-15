<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CatEmpresas.aspx.cs" Inherits="ResiduosPeligrosos.CatEmpresas" %>
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
    </script>
    <div id="Busqueda" runat="server">
        <dx:ASPxNavBar ID="ASPxNavBar2" runat="server" Theme="Metropolis" Width="100%" Font-Bold="False">
            <Groups>
                <dx:NavBarGroup Text="Empresas \ Filtros">
                        <ContentTemplate>
                                <div id="Parametros" runat="server" visible="true">
                                    <table style="float: left; width: 40%" class="OptionsTable BottomMargin">
                                        <tr>
                                            <td style="width:10%; text-align:left">
                                                <dx:ASPxLabel ID="lblCodigo" runat="server" Text="Código "></dx:ASPxLabel>
                                            </td>
                                            <td style="width:30%; text-align:left">
                                                <dx:ASPxTextBox runat="server" Theme="SoftOrange" Height="5px"  ID="xtxtCodigo" Enabled="True" Width="100%" FocusedStyle-Border-BorderColor="#3399ff" FocusedStyle-Border-BorderStyle="Double"></dx:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr style="height:5px"></tr>
                                        <tr>
                                            <td style="width:10%; text-align:left">
                                                <dx:ASPxLabel ID="lbltipo" runat="server" Text="Tipo "></dx:ASPxLabel>
                                            </td>
                                            <td style="width:30%; text-align:left">
                                                <dx:ASPxComboBox class="form-control input-sm Campos" ID="cmbtipoEmpresa" runat="server" IncrementalFilteringMode="Contains" 
                                                    FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="20"
                                                    PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true">
                                                    <ClientSideEvents/>
                                                    <ButtonStyle BackColor="#0099FF"></ButtonStyle>                                                                                                                       
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
         <dx:ASPxGridView ID="xgrdEmpresas" runat="server" AutoGenerateColumns="False" Width="100%" Font-Names="Segoe UI" KeyFieldName="EmpresaId" 
                    oncustomcallback="xgrdEmpresas_CustomCallback" ClientInstanceName="grid"                     
                    onrowvalidating="xgrdEmpresas_RowValidating" onrowinserting="xgrdEmpresas_RowInserting" onrowupdating="xgrdEmpresas_RowUpdating"
                    OnHtmlDataCellPrepared="xgrdEmpresas_HtmlDataCellPrepared" OnHtmlEditFormCreated="xgrdEmpresas_HtmlEditFormCreated" Theme="Metropolis">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="EmpresaId" Visible="false" Caption="Identifier" VisibleIndex="0"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Name="CheckID" VisibleIndex="1" Width="10px"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="codigoEmpresa" VisibleIndex="2" Caption="Código"  Width="5%"></dx:GridViewDataTextColumn>                     
                        <dx:GridViewDataTextColumn FieldName="TipoEmpresa" VisibleIndex="3" Caption="Tipo Empresa" Width="25%"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="NoRegistroAmbiental" VisibleIndex="4" Caption="No. Registro Ambiental" Width="15%"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="RazonSocial" VisibleIndex="5" Caption="Razón Social" Width="15%"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="RFC" VisibleIndex="6" Caption="RFC" Width="15%"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CodigoPostal" VisibleIndex="6" Caption="Codigo Postal" Width="15%"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="OpcionDefault" VisibleIndex="7" Caption="Default" Width="15%"></dx:GridViewDataTextColumn>
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
                                            <img src="Assets/Images/save.png" alt="Guardar" style="cursor:pointer" onclick="return raiseValidation();" />
                                        </td>
                                        <td style="height:22px; text-align:right">
                                            <img src="Assets/Images/Close.png" alt="Salir" style="cursor:pointer" onclick="return grid.CancelEdit();" />
                                        </td>
                                      </tr>
                                      <tr>
                                        <td style="vertical-align:top;" colspan="2">
                                            <table style="width:100%; padding-left:10px; padding-right:10px; padding-bottom:20px">
                                                <tr style="height:40px">
                                                    <td style="height:40px; padding-right:10px; text-align:right" colspan="2">
                                                        <dx:ASPxLabel runat="server" ID="ASPxLabel3" Text="Registro de Empresas" Font-Size="13pt" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" style="background-color:#E0E0E0; height:20px" >
                                                        <dx:ASPxLabel runat="server" ID="ASPxLabel2" Text="Descripción" Font-Size="12pt" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                    </td>
                                                </tr>  
                                                <tr>
                                                    <td style="width:30%;">
                                                        <table style="width:100%; padding-left:0px; padding-right:0px; padding-bottom:0px; padding-top:0px">
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblCodigo" Text="Código" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtCodigo" theme="SoftOrange" Width="100%" MaxLength="15" Text='<%# Eval("codigoEmpresa")%>' 
                                                                         Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff">
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
                                                                    <dx:ASPxLabel runat="server" ID="lblNoRegistroAmbiental" Text="No. Registro Ambiental" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtNoRegistroAmbiental" theme="SoftOrange" Width="100%" MaxLength="100" Text='<%# Eval("NoRegistroAmbiental")%>' 
                                                                         Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff">
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <%--<RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />--%>
                                                                            <RequiredField IsRequired="true" ErrorText="Campos requerido"/>
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px">
                                                                    <dx:ASPxLabel runat="server" ID="lblRFC" Text="RFC" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtRFC" theme="SoftOrange" MaxLength="20" Text='<%# Eval("RFC")%>' Font-Names="Segoe UI"
                                                                        FocusedStyle-Border-BorderColor="#3399ff">
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                          
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblNoExterior" Text="No. Exterior" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtNoExterior" theme="SoftOrange" Width="100%" MaxLength="250" Text='<%# Eval("NoExterior")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                           
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblResponsable" Text="Responsable" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtResponsable" theme="SoftOrange" Width="100%" MaxLength="250" Text='<%# Eval("Responsable")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>                                                           

                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;"></td>
                                                                <td style="padding-left: 10px;"></td>
                                                            </tr>
                                                             <tr style="height:25px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                     <dx:ASPxLabel runat="server" ID="lblNoAutorizacionSEMARNAT" Text="Aut. SEMARNAT" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                      <dx:ASPxTextBox runat="server" ID="txtNoAutorizacionSEMARNAT" theme="SoftOrange" Width="100%" MaxLength="250" Text='<%# Eval("NoAutorizacionSEMARNAT")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                             <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblRazonSocial" Text="Razon Social" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtRazonSocial" theme="SoftOrange" Width="250%" Height="35px" MaxLength="250" Text='<%# Eval("RazonSocial")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                             <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblCalle" Text="Calle" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtCalle" theme="SoftOrange" Width="250%" Height="35px" MaxLength="250" Text='<%# Eval("Calle")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>

                                                              <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblColonia" Text="Colonia" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtColonia" theme="SoftOrange" Width="100%" Height="35px" MaxLength="250" Text='<%# Eval("Colonia")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                             <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblMunicipio" Text="Municipio" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtMunicipio" theme="SoftOrange" Width="100%" Height="35px" MaxLength="250" Text='<%# Eval("Municipio")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                             <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblEstado" Text="Estado" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtEstado" theme="SoftOrange" Width="100%" Height="35px" MaxLength="250" Text='<%# Eval("Estado")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>     
                                                          
                                                                   
                                                        </table>
                                                    </td>
                                                    <td style="width:70%; vertical-align:top">
                                                        <table style="width:100%; padding-left:0px; padding-right:0px; padding-bottom:0px; padding-top:0px">
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblCodigoPostal" Text="Codigo Postal" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtCodigoPostal" theme="SoftOrange"  MaxLength="250" Text='<%# Eval("CodigoPostal")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>
                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px">
                                                                    <dx:ASPxLabel runat="server" ID="lbltipo" Text="Tipo" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <input type="hidden" id="hdnTipo" value='<%# Eval("TipoEmpresa")%>' runat="server"/>
                                                                    <dx:ASPxComboBox class="form-control input-sm Campos" ID="cmbtipo" runat="server" IncrementalFilteringMode="Contains" 
                                                                        FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="20" OnDataBound="cmbtipo_DataBound"
                                                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true">
                                                                        <ValidationSettings>
                                                                            <RequiredField  IsRequired="true" ErrorText="Selecciona una opción"/>
                                                                        </ValidationSettings>
                                                                        <ClientSideEvents/>
                                                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>                                                                                                                       
                                                                    </dx:ASPxComboBox>
                                                                </td>
                                                            </tr>

                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblTelefono" Text="Telefono" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtTelefono" theme="SoftOrange" Width="100%" MaxLength="250" Text='<%# Eval("Telefono")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>

                                                            <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblNoInterior" Text="No. Interior" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtNoInterior" theme="SoftOrange" Width="100%" MaxLength="250" Text='<%# Eval("NoInterior")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>

                                                           <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblNoPermisoSCT" Text="Permiso SCT" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtNoPermisoSCT" theme="SoftOrange" Width="100%" MaxLength="250" Text='<%# Eval("NoPermisoSCT")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                            </tr>

                                                             <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblOpcionDefault" Text="Opcion Default" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <input type="hidden" id="hdnOpcionDefault" runat="server" value='<%# Eval("OpcionDefault")%>' />
                                                                    <dx:ASPxRadioButtonList ID="rdbListOpcionDefault" ClientInstanceName="rdbListOpcionDefault" runat="server" 
                                                                        OnDataBound="rdbListOpcionDefault_DataBound"
                                                                        RepeatColumns="2" theme="SoftOrange" FocusedStyle-Border-BorderColor="#3399ff" Font-Names="Segoe UI">
                                                                        <CaptionSettings Position="Top" />                                                                                        
                                                                    </dx:ASPxRadioButtonList>
                                                               
                                                                </td>
                                                            </tr>

                                                             <tr style="height:5px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                  
                                                                </td>
                                                            </tr>

                                                            <tr style="height:80px"></tr>
                                                            <tr>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxLabel runat="server" ID="lblotrosDatos" Text="Otros Datos" Font-Names="Segoe UI"></dx:ASPxLabel>
                                                                </td>
                                                                <td style="padding-left: 10px;">
                                                                    <dx:ASPxTextBox runat="server" ID="txtOtrosDatos" theme="SoftOrange" Width="100%" MaxLength="80" Text='<%# Eval("otrosdatos")%>' 
                                                                            Font-Names="Segoe UI" FocusedStyle-Border-BorderColor="#3399ff" >
                                                                        <ValidationSettings SetFocusOnError="true" Display="Static" CausesValidation="true">
                                                                            <RegularExpression ValidationExpression="[A-Za-záéíóúñÑ,;:\.\/\_\-\s\d\(\)]+" ErrorText="Please enter just valid characters" />
                                                                        </ValidationSettings>                                                            
                                                                    </dx:ASPxTextBox>
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
