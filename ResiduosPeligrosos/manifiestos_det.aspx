<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="manifiestos_det.aspx.cs" Inherits="ResiduosPeligrosos.manifiestos_det" %>
<%@ Register Assembly="DevExpress.XtraReports.v15.2.Web, Version=15.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server" Visible="false">
    <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">--%>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">   
    <!--Formateo de tablas-->
    <link href="https://unpkg.com/bootstrap-table@1.18.0/dist/bootstrap-table.min.css" rel="stylesheet">
    <script src="https://unpkg.com/bootstrap-table@1.18.0/dist/bootstrap-table.min.js"></script>
    <!--Tabla resize, borrar si no se necesita-->
    <script src="https://unpkg.com/jquery-resizable-columns@0.2.3/dist/jquery.resizableColumns.min.js"></script>
    <link href="https://unpkg.com/jquery-resizable-columns@0.2.3/dist/jquery.resizableColumns.css" rel="stylesheet">
    <script src="https://unpkg.com/bootstrap-table@1.18.0/dist/extensions/resizable/bootstrap-table-resizable.min.js"></script>
    <!-- jQuery  -->
    <script src="Assets/plugins/sweetalert/dist/sweetalert.min.js"></script>
    <script src="Assets/pages/jquery.sweet-alert.init.js"></script> <!--prueba github-->
    <script type="text/jscript">
        function HabilitaCambio() {
            var btn = document.getElementById("BtnUploadFile");
            var srcdesc = btn.src;
            var expresionRegular = "/";
            var listaNombres = srcdesc.split(expresionRegular);
            var namebtn = listaNombres[6].toString();

            if (namebtn == "BtnUploadFile.png") {
                btn.setAttribute('src', 'Assets/Images/BtnUploadFileCancel.png');
            } else {
                btn.setAttribute('src', 'Assets/Images/BtnUploadFile.png');
            }

            var x = document.getElementById("myDIV");
            var y = document.getElementById("divBotonesPart");
            if (x.style.display === "none") {
                x.style.display = "block";
                y.style.display = "none";
            } else {
                x.style.display = "none";
                y.style.display = "block";
            }
        }

        function OnTipoArticuloEndCallback(s, e) {
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'SelectOne') {
                    swal("Information", "Type and code cannot be empty!", "info");
                } else if (s.cpAlertMessage == 'Exist') {
                    swal({
                        title: "Information",
                        text: "Type and code already exist",
                        type: "info",
                        timer: 2000,
                        showConfirmButton: false
                    });
                }
            }
            s.cpAlertMessage = "";
        }

        function AddedTiposArticulos() {
            var Valores = "";
            $(".chkArtMDL").each(function () {
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
            xgrdTipoArticuloMDL.PerformCallback(Valores);
        }

        function OnTipoArticuloMDLEndCallback(s, e) {
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'Add') {
                    xgrdTipoArticulo.PerformCallback('Save');
                }
            }
            s.cpAlertMessage = "";
        }

        function DisableSelectedTipoArt() {

            var Valores = "";
            $(".chkArt").each(function () {
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

            xgrdTipoArticulo.PerformCallback(Valores);
        }

        function OnMttoEndCallback(s, e) {
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'SelectOne') {
                    swal("Information", "Specification and code are empty!", "info");
                } else if (s.cpAlertMessage == 'Exist') {
                    swal({
                        title: "Information",
                        text: "Specification and code already exist",
                        type: "info",
                        timer: 2000,
                        showConfirmButton: false
                    });
                }
            }
            s.cpAlertMessage = "";
        }

        function DisableSelectedMtto() {

            var Valores = "";
            $(".chkMtto").each(function () {
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

            xgrdMtto.PerformCallback(Valores);
        }

        function AddedMttos() {
            var Valores = "";
            $(".chkMttoMDL").each(function () {
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
            xgrdMttoMDL.PerformCallback(Valores);
        }

        function OnMttoxgrdMttoMDLEndCallback(s, e) {
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'Add') {
                    xgrdMtto.PerformCallback('Save');
                }
            }
            s.cpAlertMessage = "";
        }

        function OnAlmacenEndCallback(s, e) {
            document.getElementById("MainContent_txtCodigoAlmacenAdd").value = "";
            document.getElementById("MainContent_txtEspecificacionAlMAdd").value = "";
            document.getElementById("MainContent_txtResponsableALMAdd").value = "";
            document.getElementById("MainContent_txtCasificacionALMAdd").value = "";
            document.getElementById("MainContent_txtNotasALMAdd").value = "";
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'SelectOne') {
                    swal("Information", "Specification and code are empty!", "info");
                } else if (s.cpAlertMessage == 'Exist') {
                    swal({
                        title: "Information",
                        text: "Specification and code already exist",
                        type: "info",
                        timer: 2000,
                        showConfirmButton: false
                    });
                }
            }
            s.cpAlertMessage = "";
        }

        function AddedAlmnes() {
            var Valores = "";
            $(".chkAlmnMDL").each(function () {
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
            xgrdAlmacenMDL.PerformCallback(Valores);
        }

        function OnAlmacenMDLEndCallback(s, e) {
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'Add') {
                    xgrdAlmacen.PerformCallback('Save');
                }
            }
            s.cpAlertMessage = "";
        }

        function DisableSelectedAlmacen() {

            var Valores = "";
            $(".chkAlmn").each(function () {
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

            xgrdAlmacen.PerformCallback(Valores);
        }

        function OnAprobacionesEndCallback(s, e) {
            CallbackPanel.PerformCallback("Limpiar");
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'SelectOne') {
                    swal("Information", "The title is empty!", "info");
                } else if (s.cpAlertMessage == 'Exist') {
                    swal({
                        title: "Information",
                        text: "Specification and code already exist",
                        type: "info",
                        timer: 2000,
                        showConfirmButton: false
                    });
                }
            }
            s.cpAlertMessage = "";
        }

        function DisableSelectedAprobacion() {

            var Valores = "";
            $(".chkAprb").each(function () {
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

            xgrdAprobaciones.PerformCallback(Valores);
        }

        function recalcular() {
            cantidad = parseFloat(document.getElementById("MainContent_txtCantidad").value);
            precio = parseFloat(document.getElementById("MainContent_txtPrecioU").value);
            total = cantidad * precio;
            document.getElementById("MainContent_lblTotal").innerHTML = (Math.round(total * 100) / 100).toString();
        }

        function OnPanel1EndCallback(s, e) {
            if (s.cpAlertMessage != '') {
                if (s.cpAlertMessage == 'errror') {
                    swal("Information", "There was an error", "info");
                }
            }
        }


        $(document).ready(function () {
            // Muestra las teclas rápidas
            $("span.badge").hide(); //Se puso aquí para que no cambara de lugar los botones
            $("body").keydown(function (e) {
                if (e.which == 17) {
                    $("span.badge").toggle();
                }
                if (e.altKey) {
                    if (e.altKey && e.which == 49) { //1
                        alert('boton 1');
                    }
                    if (e.altKey && e.which == 50) {//2
                        alert('boton 2');
                    }
                    if (e.altKey && e.which == 51) {//3
                        alert('boton 3');
                    }
                    if (e.altKey && e.which == 52) {//4
                        alert('boton 4');
                    }
                    if (e.altKey && e.which == 53) {//5
                        alert('boton 5');
                    }
                    if (e.altKey && e.which == 54) {//6
                        alert('boton 6');
                    }
                    if (e.altKey && e.which == 55) {//7
                        alert('boton 7');
                        $(".clickable").click();
                    }
                    if (e.altKey && e.which == 56) {//8
                        $(".clickable").click();
                    }
                    if (e.altKey && e.which == 57) {//9
                        $("#BtnInicio").get(0).click();
                    }
                    if (e.altKey && e.which == 48) {//0
                        $("#BtnFinal").get(0).click();
                    }
                };
            });
            // Funcionalidad de los paneles colapsables
            $(document).on('click', '.panel-heading span.clickable', function (e) {
                var $this = $(this);
                if (!$this.hasClass('panel-collapsed')) {
                    $this.parents('.panel').find('.panel-body').slideUp();
                    $this.addClass('panel-collapsed');
                    $this.find('i').removeClass('glyphicon-chevron-up').addClass('glyphicon-chevron-down');
                } else {
                    $this.parents('.panel').find('.panel-body').slideDown();
                    $this.removeClass('panel-collapsed');
                    $this.find('i').removeClass('glyphicon-chevron-down').addClass('glyphicon-chevron-up');
                }
            });
            // Colapsa y expande todos a la vez
            $("#btnColapsable").click(function () {
                $(".clickable").click();
            });
        });
        //Rota los iconos de inicio y fin, va fuera del ready
        function rotate(imgName) {
            var elm = document.getElementById(imgName);
            var className = elm.className;
            if (className.indexOf('BtnRotar') === -1) {
                elm.className = elm.className + ' BtnRotar';
            } else {
                elm.className = elm.className.replace(' BtnRotar', '');
            };
        };
        //Quita los checked de default de las tablas de bootstrap
        function quitaChecked(value) {
            return {
                checked: false
            }
            return value
        };

        function openModal(opcion) {
            switch (opcion) {
                case 'TipoArticulo':
                    $('#mdlTipoArticulo').modal('show');
                    break;
                case 'Mantenimiento':
                    $('#mdlMtto').modal('show');
                    break;
                case 'Almacen':
                    $('#mdlAlmacen').modal('show');
                    break;
                case 'Aprobaciones':
                    $('#mdlAprobaciones').modal('show');
                    break;
            }
        }
        
        function ActualizarValoresEmpresaSolicitante(s, e) {            
            var codigoEmpresa = cmbEmpresaSolicitud.GetValue();
            var tipo = "C";
            var valores = codigoEmpresa + ";" + tipo;
            cbChangeEmpresas.PerformCallback(valores);
        }

        function ActualizarValoresEmpresaTransportista(s,e){
            var codigoEmpresa = cmbEmpresaTransportista.GetValue();
            var tipo = "T";
            var valores = codigoEmpresa + ";" + tipo;
            cbChangeEmpresas.PerformCallback(valores);
        }

        function ActualizarValoresEmpresaDestinatario(s, e) {
            var codigoEmpresa = cmbEmpresaDestinatario.GetValue();
            var tipo = "D";
            var valores = codigoEmpresa + ";" + tipo;
            cbChangeEmpresas.PerformCallback(valores);
        }


        function cbChangeEmpresas_Complete(s, e) {
            if (s.cpAlertMessage != '') {

                var parametros = s.cpAlertMessage;
                var listaNombres = parametros.split(';');

                console.log(listaNombres);

                var tipo = listaNombres[0].toString();                
                var cp = listaNombres[1].toString();
                var calle = listaNombres[2].toString();
                var noInterior = listaNombres[3].toString();
                var noExterior = listaNombres[4].toString();
                var colonia = listaNombres[5].toString();
                var municipio = listaNombres[6].toString();
                var estado = listaNombres[7].toString();
                var telefono = listaNombres[8].toString();

                if (tipo == "C") {
                    MainContent_txtCPGenerador.value = cp;
                    MainContent_txtCalleGenerador.value = calle;
                    MainContent_txtNoExteriorGenerador.value = noInterior;
                    MainContent_xtxtNoInteriorGenerador.value = noExterior;
                    MainContent_txtColoniaGenerador.value = colonia;
                    MainContent_txtMunicipioGenerador.value = municipio;
                    MainContent_txtEstadoGenerador.value = estado;
                    MainContent_txtTelefonoGenerador.value = telefono;
                } else if (tipo == "T") {
                    MainContent_txtCPTrans.value = cp;
                    MainContent_txtCalleTrans.value = calle;
                    MainContent_txtNoExteriorTrans.value = noInterior;
                    MainContent_txtNoInteriorTrans.value = noExterior;
                    MainContent_txtColoniaTrans.value = colonia;
                    MainContent_txtxMunicipioTrans.value = municipio;
                    MainContent_txtEstadoTrans.value = estado;
                    MainContent_txtTelefonoTrans.value = telefono;
                }else if(tipo == "D"){
                    MainContent_txtCPDest.value = cp;
                    MainContent_txtCalleDest.value = calle;
                    MainContent_txtNoExteriorDest.value = noInterior;
                    MainContent_txtNoInteriorDest.value = noExterior;
                    MainContent_txtColoniaDest.value = colonia;
                    MainContent_txtMunicipioDest.value = municipio;
                    MainContent_txtEstadoDest.value = estado;
                    MainContent_txtTelefonoDest.value = telefono;
                }

              
            }
        }

        function Guardar() {
            
            //para agregar o cambiar un atributo
            //MainContent_btnImprimir1.setAttribute('visibility', 'visible');
            //para agregar o cambiar un estilo.
            //MainContent_btnImprimir1.style.visibility = "visible";
            MainContent_btnSave.click();
        }

        function Imprimir() {
            MainContent_btnCompletar.style.visibility = "visible";
            MainContent_btnSave.click();
        }

    </script>
    <style>
        html {
            scroll-behavior: smooth;
        }

        body {
            background-color: #FBFBFB;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            /*font-size: 12px;*/
        }

        label {
            font-size: 12px;
        }

        .jumbotron {
            background-color: #FBFBFB;
        }

        .CeroPM {
            padding: 0px;
            margin: 0px;
        }

        .BGFormularioTitulo {
            margin-top: 5px;
            padding-bottom: 18px;
            background-image: url('./Assets/images/IconoFormulario.png');
            background-repeat: no-repeat;
            background-position: left top;
        }

        .HeaderSpanNombreFormulario {
            text-align: left;
            color: #355D87;
            margin: 0px;
            margin-left: 35px;
        }

        .RowsControl {
            margin: 0px;
            padding: 0px;
            border: 0px;
            border-bottom: 1px;
            border-bottom-color: #BCE8F1;
            border-bottom-style: dashed;
        }

        .clickable {
            cursor: pointer;
        }

        .panel {
            margin-bottom: 15px;
        }

        .panel-heading {
            height: 25px;
            font-weight: 400;
            padding:0px 15px;

        }

            .panel-heading span {
                margin-top: -20px;
                font-size: 15px;
            }

        .panel-title {
            font-size: 14px;
            font-weight: normal;
            height: 25px;
        }

        .text-form {
            color: #585858;
            font-weight: normal;
            padding: 5px;
            vertical-align: central;
        }

        .Campos {
            height: 25px;
            background-color: white;
            margin: 1px;
            padding: 2px;
            border: 1px dashed #D9D9D9;
            border-radius: 3px;
            color: black;
        }

        .nav-tabs > li.active > a, .nav-tabs > li.active > a:focus, .nav-tabs > li.active > a:hover {
            color: #fff;
            background-color: #337AB7;
        }

        .BtnGpoIniFin {
            background-color: white;
            vertical-align: central;
            text-align: center;
            height: 81px;
            width: 35px;
            top: 50vh;
            right: 0px;
            position: fixed;
            z-index: 1;
            border-radius: 4px 0 0 4px;
            box-shadow: 0 2px 5px 0 rgba(0,0,0,0.16), 0 2px 10px 0 rgba(0,0,0,0.12);
        }

        .BtnIniFin {
            display: block;
            height: 40px;
            font-size: x-large;
            padding-top: 5px;
        }

        .BtnRotar {
            animation-name: rotarImagen;
            animation-duration: 1s;
            animation-iteration-count: infinite;
        }

        @keyframes rotarImagen {
            100% {
                color: forestgreen;
                left: 0px;
                top: 0px;
                transform: rotate(360deg);
            }
        }

        #spanStatus {
            width: 190px;
            transition-property: width;
            transition-duration: 1s;
        }

            #spanStatus:hover {
                width: 390px;
            }

        .docEstatus {
            position: absolute;
            left: 60px;
            font-weight: bold;
            padding: 1px 10px;
            margin: 0px;
        }

        .fixed-table-toolbar {
            width: 100%;
        }

        .bootstrap-table bootstrap3 {
            width: 100%;
        }

        .badge {
            font-size: 9px;
            font-weight: normal;
            transform: translate(5px, -8px);
            padding: 2px 2px;
        }

        .hidden {
            display: none;
        }
    </style>
    <div class="CeroPM" id="Inicio">
    <div class="container-fluid CeroPM"  style="padding: 15px;font-size: 12px;" >
        <div id="divBotones" class="col-xs-12 btn-group CeroPM" data-spy="affix" data-offset-top="100" style="color:white;width:100%;z-index:1 !important;background-color:#EFEFEF;">
            <img ID="btnSave1" runat="server" class="btn" Style="margin: 0px; padding: 0px; display:block" onclick="Guardar();" src="Assets/images/BtnGuardar.png" />             
            <asp:ImageButton ID="btnImprimir2" class="btn" Style="margin: 0px; padding: 0px; display:none" runat="server" ImageUrl="~/Assets/images/BtnImprimir.png" OnClick="btnImprimir_Click" />
            <asp:ImageButton ID="btnImprimirFisico" class="btn" Style="margin: 0px; padding: 0px; display:none" runat="server" ImageUrl="~/Assets/images/BtnImprimir.png" OnClick="btnImprimirFisico_Click" />
            <img id="imbExport" class="btn" alt="Modo Impresión" style="margin: 0px; padding: 0px; display:block;cursor:pointer" onclick="return pcReport.Show();" src="Assets/images/Export.png" />                         
            <asp:ImageButton ID="btnCompletar1" class="btn" Style="margin: 0px; padding: 0px; display:none" runat="server" OnClick="btnCompletar_Click" ImageUrl="~/Assets/images/BtnCompletar.png"  />
            <asp:ImageButton ID="btnSave" class="btn" Style="margin: 0px; padding: 0px; display:none" runat="server" OnClick="btnSave_Click" ImageUrl="~/Assets/images/BtnGuardar.png"  />
            <asp:ImageButton ID="btnRegresar" class="btn" Style="margin: 0px; padding: 0px;" runat="server" ImageUrl="~/Assets/images/BtnSalir.png" OnClick="btnRegresar_Click" />
            <div class="BtnGpoIniFin">
                <a class="BtnIniFin" id="BtnInicio" href="#Inicio" title="Inicio" onmouseover="rotate('imgaRotarI');" onmouseout="rotate('imgaRotarI');"><i id="imgaRotarI" class="glyphicon glyphicon glyphicon-circle-arrow-up"></i><span class="badge badge-xs badge-danger">Alt+9</span></a>
                <a class="BtnIniFin" id="BtnFinal" href="#pieForma" title="Historial" onmouseover="rotate('imgaRotarF');" onmouseout="rotate('imgaRotarF');"><i id="imgaRotarF" class="glyphicon glyphicon glyphicon-circle-arrow-down"></i><span class="badge badge-xs badge-danger">Alt+0</span></a>
            </div>
        </div>
        <div class="jumbotron CeroPM" style="padding: 5px;">
            <div class="row CeroPM">
                <div class="col-xs-12">
                    <div class="col-xs-12 col-sm-8 form-group BGFormularioTitulo">
                        <h2 class="HeaderSpanNombreFormulario">SOLICITUD DE MANIFIESTO  </h2>
                        <asp:Label ID="lblcodigoSts" runat="server" CssClass="hidden"></asp:Label>
                        <asp:Literal ID="ltlSts" runat="server"></asp:Literal>
                    </div>
                    <div class="col-xs-12 col-sm-4 CeroPM" style="padding-top:3px;">
                        <div class="row form-group RowsControl">
                            <label class="text-form col-xs-4" style="padding: 1px;margin: 0px;">No. Documento</label>
                            <div class="col-xs-4 " style="color:red; font-weight:800;">
                                <asp:Label ID="lblNoDocumento" runat="server"></asp:Label>
                            </div>
                        </div>
                           <div class="row form-group RowsControl">
                            <label class="text-form col-xs-4" style="padding: 1px;margin: 0px;">No. Factura</label>
                            <div class="col-xs-4 " style="color:#FF6600;">
                                <%--<asp:TextBox ID="xtxtNoFactura" runat="server"></asp:TextBox>--%>
                                <asp:Label ID="lblNoFactura" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row form-group RowsControl">
                            <label class="text-form col-xs-4" style="padding: 1px;margin: 0px;">No. Shipping</label>
                            <div class="col-xs-4 " style="color:#FF6600;">
                                <%--<asp:TextBox ID="xtxtNoShipping" runat="server"></asp:TextBox>--%>
                                <asp:Label ID="lblNoShipping" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row form-group RowsControl">
                            <label class="text-form col-xs-4" style="padding: 1px;margin: 0px;">Estatus Pago</label>
                            <div class="col-xs-4 " style="color:#0066FF;">                                
                                <asp:Label ID="lblEstatusPago" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row form-group RowsControl">
                            <label class="text-form col-xs-4" style="padding: 1px;margin: 0px;">Solicitante</label>
                            <div class="col-xs-8" style="color:limegreen;">
                                <asp:Label ID="lblDocSolicitante" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row form-group RowsControl">
                            <label class="text-form col-xs-4" style="padding: 1px;margin: 0px;">Fecha de solicitud</label>
                            <div class="col-xs-8" style="color:limegreen;">
                                <asp:Label ID="lblDocFechaSol" runat="server"></asp:Label>
                            </div>
                        </div>
                          <div class="row form-group RowsControl">
                            <label class="text-form col-xs-4" style="padding: 1px;margin: 0px;">Planta</label>
                            <div class="col-xs-8" style="color:limegreen;">
                                <asp:Label ID="lblPlanta" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <form class="container-fluid">
            <section id="sSolicitante" class="row CeroPM">
                <div class="col-xs-12">
                    <div class="panel panel-info" id="infoSolicitante">
                        <div class="panel-heading">
                            <h3 class="panel-title">Información del Solicitante</h3>
                            <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                            <span class="pull-right" id="btnColapsable" style="padding-right: 10px;cursor: pointer;"><i class="glyphicon glyphicon glyphicon-sort"></i><span class="badge badge-xs badge-info" style="font-size:9px;">Alt+8</span></span>
                        </div>
                        <div class="panel-body">
                            <div class="row form-group CeroPM">
                                <label class="text-form col-sm-2">Tipo Manifiesto</label>
                                <div class="col-sm-2">
                                       <dx:ASPxComboBox CssClass="form-control input-sm Campos" ID="cmbTipoManifiesto" ClientInstanceName="cmbTipoManifiesto" runat="server" FocusedStyle-Border-BorderColor="#3399ff"
                                        Font-Names="Segoe UI" IncrementalFilteringMode="Contains" FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="10" Theme="SoftOrange"
                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true" Width="100%" Paddings-Padding="0px">
                                        <ClientSideEvents TextChanged="function(s, e) { ActualizarValoresEmpresaSolicitante(); }" />
                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>
                                    </dx:ASPxComboBox>
                                </div>   
                                <label class="text-form col-sm-2">Tipo de Residuo</label>
                                <div class="col-sm-2">
                                       <dx:ASPxComboBox CssClass="form-control input-sm Campos" ID="cmbTipoResiduo" ClientInstanceName="cmbTipoResiduo" runat="server" FocusedStyle-Border-BorderColor="#3399ff"
                                        Font-Names="Segoe UI" IncrementalFilteringMode="Contains" FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="10" Theme="SoftOrange"
                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true" Width="100%" Paddings-Padding="0px">
                                        <ClientSideEvents TextChanged="function(s, e) { ActualizarValoresEmpresaSolicitante(); }" />
                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>
                                    </dx:ASPxComboBox>
                                </div>       
                                <label class="text-form col-sm-2">Moneda</label>  
                                <div class="col-sm-2">
                                       <dx:ASPxComboBox CssClass="form-control input-sm Campos" ID="cmbTipoMoneda" ClientInstanceName="cmbTipoMoneda" runat="server" FocusedStyle-Border-BorderColor="#3399ff"
                                        Font-Names="Segoe UI" IncrementalFilteringMode="Contains" FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="10" Theme="SoftOrange"
                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true" Width="100%" Paddings-Padding="0px">
                                        <ClientSideEvents />
                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>
                                    </dx:ASPxComboBox>
                                </div>                                                   
                            </div>
                             <div class="row form-group CeroPM">
                                <%--<label class="text-form col-sm-2">Empresa Solicitante</label>
                                <div class="col-sm-2">
                                      <asp:TextBox ID="xtxtRazonSocialGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>   --%>                     
                                <label class="text-form col-sm-2" style="display:none;">Numero de Registro Hambiental</label>
                                <div class="col-sm-2" style="display:none;">
                                    <asp:TextBox ID="txtNoRegistroHambiental" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>                              
                                   <label class="text-form col-sm-1">Pagina</label>
                                   <div class="col-sm-3">
                                   <asp:TextBox ID="txtPagina" TextMode="Number" step="0.1" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>
                                <label class="text-form col-sm-2">Es para Venta</label> 
                                <asp:RadioButton ID="rbSi" runat="server" GroupName="esVenta" Text="&nbsp;Si"/>&nbsp;
                                <asp:RadioButton ID="rbNo" runat="server" GroupName="esVenta" Text="&nbsp;No"/>&nbsp;
                             </div>
                            <div class="row form-group CeroPM" style="display:none;">
                                <label class="text-form col-sm-2">Nombre o Razon Social del Cliente</label>
                                <div class="col-sm-6">                              
                                     <dx:ASPxComboBox CssClass="form-control input-sm Campos" ID="cmbEmpresaSolicitud" ClientInstanceName="cmbEmpresaSolicitud" runat="server" FocusedStyle-Border-BorderColor="#3399ff"
                                        Font-Names="Segoe UI" IncrementalFilteringMode="Contains" FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="10" Theme="SoftOrange"
                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true" Width="100%" Paddings-Padding="0px">
                                        <ClientSideEvents TextChanged="function(s, e) { ActualizarValoresEmpresaSolicitante(); }" />
                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>
                                    </dx:ASPxComboBox>
                                </div>
                            
                            </div>
                            <fieldset style="padding:10px;border: 1px solid #B5D2EA;border-radius:5px; display:none;">
                                <legend style="font-size:12px;font-weight:600;border:none;width: auto;padding:2px;color:#8CBADF;margin-bottom:0px;">Domicilio</legend>
                                 <div class="row form-group CeroPM">
                                    <label class="text-form col-sm-1">Codigo Postal</label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtCPGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                     <label class="text-form col-sm-1">Calle</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtCalleGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                    <label class="text-form col-sm-1">Núm. Exterior</label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtNoExteriorGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                    <label class="text-form col-sm-1">Núm. Interior </label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="xtxtNoInteriorGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="row form-group CeroPM">                                     
                                    <label class="text-form col-sm-1">Colonia</label>
                                    <div class="col-sm-3">
                                        <asp:TextBox ID="txtColoniaGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>     
                                    <label class="text-form col-sm-1">Municipio / Deleg.</label>
                                    <div class="col-sm-3">
                                        <asp:TextBox ID="txtMunicipioGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>   
                                    <label class="text-form col-sm-1">Estado</label>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtEstadoGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>                  
                                </div>
                                <div class="row form-group CeroPM"> 
                                    <label class="text-form col-sm-1">Teléfono</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtTelefonoGenerador" runat="server" CssClass="form-control input-sm Campos"/>
                                    </div>      
                                     <label class="text-form col-sm-2">Correo Electrónico</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="form-control input-sm Campos" ToolTip="Podra incluir varios correos separados por coma." />
                                    </div>
                                </div>
                                 <div class="row form-group" style="margin: 0px; margin-top: 5px;">
                                 <div class="col-md-2">
                                    <dx:ASPxCallback runat="server" ID="cbChangeEmpresas" ClientInstanceName="cbChangeEmpresas" 
                                        oncallback="cbChangeEmpresas_Callback">
                                        <ClientSideEvents EndCallback="function(s,e){ cbChangeEmpresas_Complete(s,e);}" />
                                    </dx:ASPxCallback>
                                </div>
                            </div>
                            </fieldset>
                            <div class="row form-group CeroPM" style="padding-top:10px;">
                                <label class="text-form col-sm-2" style="font-size:12px;font-weight:600;color:#8CBADF;">Identificacion de los Residuos </label>
                            </div>
                            <%--<img src="Assets/Images/New.png" alt="add without file" title="add" style="cursor: pointer;" onclick="openModal('TipoArticulo');" />
                            <img class="img" src="Assets/Images/trash_can.png" alt="Eliminar Seleccionados" style="cursor: pointer" onclick="return DisableSelectedTipoArt();" />
                            <img class="img" src="Assets/Images/delete_all.png" alt="Remove  Selected" style="cursor: pointer" onclick="return xgrdTipoArticulo.PerformCallback('Delete');" />--%>
                            <!--***************************TIPOS ARTICULO*********************************************************-->
                            <dx:ASPxGridView ID="xgrdTipoArticulo" runat="server" AutoGenerateColumns="true"
                                Width="100%" Font-Names="Segoe UI"
                                OnCustomCallback="xgrdTipoArticulo_CustomCallback"
                                OnHtmlDataCellPrepared="xgrdTipoArticulo_HtmlDataCellPrepared"
                                ClientInstanceName="xgrdTipoArticulo" Theme="Metropolis">
                                <Columns>
                                   <dx:GridViewDataTextColumn Name="CheckID" VisibleIndex="0" Width="10px"/>
                                        <dx:GridViewDataTextColumn FieldName="GaylordID" Caption="Contenedor ID" VisibleIndex="1" Width="10%"/>
                                        <dx:GridViewDataTextColumn FieldName="codigo" Caption="Código" VisibleIndex="2" Width="10%"/>
                                        <dx:GridViewDataTextColumn FieldName="residuo" Caption="Residuo" VisibleIndex="3" Width="10%" />
                                        <dx:GridViewDataTextColumn FieldName="codigoTipoEnvase" Visible="false" Caption="codigoTipoEnvase" VisibleIndex="3" Width="10%"/>
                                        <dx:GridViewDataTextColumn FieldName="codigoMaterial" Caption="No.Parte" VisibleIndex="4" Width="10%"/>
                                        <dx:GridViewDataTextColumn FieldName="codigoLocacion" Visible="false" Caption="codigoLocacion" VisibleIndex="5" Width="10%"/>
                                        <dx:GridViewDataTextColumn FieldName="capacidad" Caption="Capacidad" VisibleIndex="5" Width="10%"/>
                                        <dx:GridViewDataTextColumn FieldName="Material" Caption="Material" VisibleIndex="5" Width="10%"/>
                                        <dx:GridViewDataTextColumn FieldName="locacion" visible="false" Caption="locación" VisibleIndex="5" Width="10%" />
                                        <dx:GridViewDataTextColumn FieldName="IEDescripcion" Caption="Descripcion IE" VisibleIndex="6" Width="10%" />
                                        <dx:GridViewDataTextColumn FieldName="clasificaciones" Caption="Clasificaciones" VisibleIndex="7" Width="10%" />
                                        <dx:GridViewDataTextColumn FieldName="TipoEnvase" Caption="Tipo Envase" VisibleIndex="5" Width="10%" />
                                        <dx:GridViewDataTextColumn FieldName="peso" Caption="Peso" VisibleIndex="5" Width="10%" />                                </Columns>
                                <Styles>
                                    <AlternatingRow BackColor="#F2F2F2"/>
                                    <RowHotTrack BackColor="#CEECF5"/>
                                    <Header BackColor="#F2F2F2" HorizontalAlign="Center" Font-Bold="true" CssClass="text-center"/>
                                </Styles>
                                <SettingsPager Mode="ShowPager" PageSize="20" />
                                <Settings ShowFilterRow="True" />
                                <ClientSideEvents EndCallback="OnTipoArticuloEndCallback" />
                            </dx:ASPxGridView>
                            <br/>
                             <fieldset style="padding:10px;border: 1px solid #B5D2EA;border-radius:5px;">
                                <legend style="font-size:12px;font-weight:600;border:none;width: auto;padding:2px;color:#8CBADF;margin-bottom:0px;">Instrucciones Especiales</legend>
                                 <div class="row form-group CeroPM">
                                    <label class="text-form col-sm-4">Instrucciones especiales e informacion adicional para el manejo seguro</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtInstruccionesGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="row form-group CeroPM">
                                   <label class="text-form col-sm-1">Nombre del responsable</label>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="txtResponsableGenerador" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                      <label class="text-form col-sm-1">Fecha</label>
                                        <div class="col-sm-2">
                                            <dx:ASPxDateEdit ID="xDateGenerador" runat="server" Width="200px"  CssClass="form-control input-sm Campos"
                                                DisplayFormatString="yyyy-MM-dd" EditFormatString="yyyy-MM-dd">                                                             
                                                <TimeSectionProperties>
                                                    <TimeEditProperties EditFormatString="hh:mm tt" />
                                                </TimeSectionProperties>
                                            </dx:ASPxDateEdit> 
                                        </div>
                                 </div>
                             </fieldset>
                        </div>
                    </div>
                </div>
            </section>        
            <section id="sComprador" class="row CeroPM">
                <div class="col-xs-12">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <h3 class="panel-title">Información del Transportista</h3>
                            <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                        </div>
                        <div class="panel-body">
                            <div class="row form-group CeroPM">
                              <%--  <label class="text-form col-sm-2">Empresa Transportista</label>
                                <div class="col-sm-2">
                                     <asp:TextBox ID="txtRazonSocialTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>        --%>
                                <label class="text-form col-sm-3">Nombre o Razon Social del transportista</label>
                                <div class="col-sm-6">
                                    <dx:ASPxComboBox CssClass="form-control input-sm Campos" ID="cmbEmpresaTransportista" ClientInstanceName="cmbEmpresaTransportista" runat="server" FocusedStyle-Border-BorderColor="#3399ff"
                                        Font-Names="Segoe UI" IncrementalFilteringMode="Contains" FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="10" Theme="SoftOrange"
                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true" Width="100%" Paddings-Padding="0px">
                                        <ClientSideEvents TextChanged="function(s, e) { ActualizarValoresEmpresaTransportista(); }" />
                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>
                                    </dx:ASPxComboBox>
                                </div>
                            </div>
                            <fieldset style="padding:10px;border: 1px solid #B5D2EA;border-radius:5px;">
                                <legend style="font-size:12px;font-weight:600;border:none;width: auto;padding:2px;color:#8CBADF;margin-bottom:0px;">Domicilio</legend>
                                 <div class="row form-group CeroPM">
                                    <label class="text-form col-sm-1">Codigo Postal</label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtCPTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                     <label class="text-form col-sm-1">Calle</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtCalleTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                    <label class="text-form col-sm-1">Núm. Exterior</label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtNoExteriorTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                    <label class="text-form col-sm-1">Núm. Interior </label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtNoInteriorTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="row form-group CeroPM">                                     
                                    <label class="text-form col-sm-1">Colonia</label>
                                    <div class="col-sm-3">
                                        <asp:TextBox ID="txtColoniaTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>     
                                    <label class="text-form col-sm-1">Municipio / Deleg.</label>
                                    <div class="col-sm-3">
                                        <asp:TextBox ID="txtxMunicipioTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>   
                                    <label class="text-form col-sm-1">Estado</label>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtEstadoTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>                  
                                </div>
                               
                                <div class="row form-group CeroPM"> 
                                    <label class="text-form col-sm-1">Teléfono</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtTelefonoTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>      
                                     <label class="text-form col-sm-2">Correo Electrónico</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtcorreoElectronicoTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>       
                                    <label class="text-form col-sm-3">Podra incluir varios correos separados por coma.</label>
                                </div>                               
                               
                            </fieldset>
                            <div class="row form-group CeroPM">
                                <label class="text-form col-sm-2">Núm de Autorizacion del SEMARNAT</label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtNoSMARNATTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>
                                <label class="text-form col-sm-2">Núm de Permiso S.C.T</label>
                               <div class="col-sm-3">
                                   <asp:TextBox ID="txtNoPermisoSCTTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                               </div>
                            </div>         
                            <div class="row form-group CeroPM">
                                <label class="text-form col-sm-2">Tipo de Vehículo</label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtTipoVehiculoTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>
                                <label class="text-form col-sm-2">Núm de Placa</label>
                               <div class="col-sm-3">
                                   <asp:TextBox ID="txtNoPlacaTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                               </div>
                            </div>  
                            <div class="row form-group CeroPM">
                                <label class="text-form col-sm-2">Ruta de la empresa generadora hasta su empresa</label>                                
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtRutaEmpresaTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row form-group CeroPM">
                            <label class="text-form col-sm-1">Nombre del responsable</label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtResponsableTrans" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                            </div>
                                <label class="text-form col-sm-1">Fecha</label>
                                <div class="col-sm-2">
                                    <dx:ASPxDateEdit ID="xDateTrans" runat="server" Width="200px"  CssClass="form-control input-sm Campos"
                                        DisplayFormatString="yyyy-MM-dd" EditFormatString="yyyy-MM-dd">                                                             
                                        <TimeSectionProperties>
                                            <TimeEditProperties EditFormatString="hh:mm tt" />
                                        </TimeSectionProperties>
                                    </dx:ASPxDateEdit> 
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
               <section id="sDestinatario" class="row CeroPM">
                <div class="col-xs-12">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <h3 class="panel-title">Información del Destinatario</h3>
                            <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                        </div>
                        <div class="panel-body">
                            <div class="row form-group CeroPM">
                              <%--  <label class="text-form col-sm-2">Empresa Destinatario</label>
                                <div class="col-sm-2">
                                      <asp:TextBox ID="txtRazonSocialDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>  --%>
                                <label class="text-form col-sm-3">Nombre o Razon Social del transportista</label>
                                <div class="col-sm-8">
                                    
                                     <dx:ASPxComboBox CssClass="form-control input-sm Campos" ID="cmbEmpresaDestinatario" ClientInstanceName="cmbEmpresaDestinatario" runat="server" FocusedStyle-Border-BorderColor="#3399ff"
                                        Font-Names="Segoe UI" IncrementalFilteringMode="Contains" FilterMinLength="0" EnableCallbackMode="True" CallbackPageSize="10" Theme="SoftOrange"
                                        PopupVerticalAlign="Above" PopupHorizontalAlign="Center" ItemStyle-SelectedStyle-Font-Italic="true" Width="100%" Paddings-Padding="0px">
                                        <ClientSideEvents TextChanged="function(s, e) { ActualizarValoresEmpresaDestinatario(); }" />
                                        <ButtonStyle BackColor="#0099FF"></ButtonStyle>
                                    </dx:ASPxComboBox>
                                </div>
                            </div>
                              <fieldset style="padding:10px;border: 1px solid #B5D2EA;border-radius:5px;">
                                <legend style="font-size:12px;font-weight:600;border:none;width: auto;padding:2px;color:#8CBADF;margin-bottom:0px;">Domicilio</legend>
                                 <div class="row form-group CeroPM">
                                    <label class="text-form col-sm-1">Codigo Postal</label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtCPDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                     <label class="text-form col-sm-1">Calle</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtCalleDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                    <label class="text-form col-sm-1">Núm. Exterior</label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtNoExteriorDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                    <label class="text-form col-sm-1">Núm. Interior </label>
                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtNoInteriorDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="row form-group CeroPM">                                     
                                    <label class="text-form col-sm-1">Colonia</label>
                                    <div class="col-sm-3">
                                        <asp:TextBox ID="txtColoniaDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>     
                                    <label class="text-form col-sm-1">Municipio / Deleg.</label>
                                    <div class="col-sm-3">
                                        <asp:TextBox ID="txtMunicipioDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>   
                                    <label class="text-form col-sm-1">Estado</label>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtEstadoDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>                  
                                </div>
                               
                                <div class="row form-group CeroPM"> 
                                    <label class="text-form col-sm-1">Teléfono</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtTelefonoDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>      
                                     <label class="text-form col-sm-2">Correo Electrónico</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtCorreoElectronicoDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                    </div>       
                                    <label class="text-form col-sm-3">Podra incluir varios correos separados por coma.</label>
                                </div>                               
                               
                            </fieldset>
                            <div class="row form-group CeroPM">
                                <label class="text-form col-sm-3">Núm de Autorizacion del SEMARNAT</label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtNoSEMARNATDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                                </div>                             
                            </div>
                           <div class="row form-group CeroPM">
                                 <label class="text-form col-sm-3">Nombre y cargo de la persona que recibe los residuos</label>
                               <div class="col-sm-8">
                                   <asp:TextBox ID="txtPersonaRecibeReciduosDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                               </div>
                           </div>
                          <div class="row form-group CeroPM">
                            <label class="text-form col-sm-1">Nombre del responsable</label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtResponsableDest" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox>
                            </div>
                                <label class="text-form col-sm-1">Fecha</label>
                                <div class="col-sm-2">
                                    <dx:ASPxDateEdit ID="xDateFechaDest" runat="server" Width="200px"  CssClass="form-control input-sm Campos"
                                        DisplayFormatString="dd-MM-yyyy" EditFormatString="dd-MM-yyyy">                                                             
                                        <TimeSectionProperties>
                                            <TimeEditProperties EditFormatString="hh:mm tt" />
                                        </TimeSectionProperties>
                                    </dx:ASPxDateEdit> 
                                </div>
                            </div>
                        </div>
                         
                    </div>
                </div>
            </section>
        </form>
        <div id="pieForma">
            <div class="col-xs-12" style="background-color:dimgray;height:25px;font-weight:600;color:white;text-align:center;font-size:16px;">
                Historal del documento
            </div>
            <ul class="nav nav-tabs" style="padding-left:5px;">
                <li class="active"><a data-toggle="tab" href="#home">Historial</a></li>
                <li><a data-toggle="tab" href="#menu1">Comentarios adicionales</a></li>
            </ul>
            <div class="tab-content" style="padding:15px;">
                <div id="home" class="tab-pane fade in active">
                    <h3>Historial</h3>
                    <dx:ASPxGridView ID="xgrdHistorial" runat="server" AutoGenerateColumns="true" Width="100%" Font-Names="Segoe UI"
                        ClientInstanceName="xgrdHistorial" Theme="Metropolis">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="fecha" Caption="Fecha" VisibleIndex="0" Width="15%"/>
                            <dx:GridViewDataTextColumn FieldName="NombreCompleto" Caption="Usuario" VisibleIndex="1" Width="25%"/>
                            <dx:GridViewDataTextColumn FieldName="accion" Caption="" VisibleIndex="2" Width="10%"/>
                            <dx:GridViewDataTextColumn FieldName="comentarios" Caption="Comentarios" VisibleIndex="3" Width="50%"/>
                        </Columns>
                        <Styles>
                            <AlternatingRow BackColor="#F2F2F2"/>
                            <RowHotTrack BackColor="#CEECF5"/>
                            <Header BackColor="#F2F2F2" HorizontalAlign="Center" Font-Bold="true" CssClass="text-center"/>
                        </Styles>
                        <SettingsPager Mode="ShowPager" PageSize="20" />
                        <Settings ShowFilterRow="True" />
                        <ClientSideEvents/>
                    </dx:ASPxGridView>
                </div>
                <div id="menu1" class="tab-pane fade">
                    <h3>Comentarios Adicionales</h3>
                    <p><asp:TextBox ID="txtComentarios" TextMode="MultiLine" Rows="3" runat="server" CssClass="form-control input-sm Campos"></asp:TextBox></p>
                </div>
            </div>
        </div>

        <div class="row" style="align-content: center; position: center;">
                         <div>
                                <dx:ASPxPopupControl ID="pcReport" runat="server" CloseAction="CloseButton" Modal="True" ShowHeader="false"
                                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcReport"
                                    HeaderText="Login" AllowDragging="True" PopupAnimationType="None" EnableViewState="False" Width="1000px">
                                    <ContentCollection>
                                        <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                                            <div style="border-style: solid; border-color: Black; border-width: 1px;">
                                                <table style="width: 100%; height: 600px; padding: 0; border-spacing: 0;">
                                                    <tr style="background-repeat: repeat-x; background-image: url('Assets/images/GreenBar.png');">
                                                        <td style="height: 40px; float:right;">
                                                            <img src="Assets/images/Close.png" alt="" style="cursor: pointer" onclick="return pcReport.Hide();" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="display: flex;justify-content: center; text-align:center">
                                                            <table style="width: 100%; padding-left: 10px; padding-right: 10px; padding-bottom: 20px;">
                                                                <tr style="height: 30px">
                                                                    <td style="height: 100%; width: 100%;">
                                                                        <dx:ReportToolbar ID="tbReportViewer" runat="server" ReportViewerID="xReportViewer" EnableViewState="False">
                                                                            <Items>
                                                                                <dx:ReportToolbarButton ItemKind='Search' ToolTip='Display the search window' />
                                                                                <dx:ReportToolbarSeparator />
                                                                                <dx:ReportToolbarButton ItemKind='PrintReport' ToolTip='Print the report' />
                                                                                <dx:ReportToolbarButton ItemKind='PrintPage' ToolTip='Print the current page' />
                                                                                <dx:ReportToolbarSeparator />
                                                                                <dx:ReportToolbarButton Enabled='False' ItemKind='FirstPage' ToolTip='First Page' />
                                                                                <dx:ReportToolbarButton Enabled='False' ItemKind='PreviousPage' ToolTip='Previous Page' />
                                                                                <dx:ReportToolbarLabel Text='Page' />
                                                                                <dx:ReportToolbarComboBox ItemKind='PageNumber' Width='65px' />
                                                                                <dx:ReportToolbarLabel Text="of" />
                                                                                <dx:ReportToolbarTextBox IsReadOnly='True' ItemKind='PageCount' />
                                                                                <dx:ReportToolbarButton ItemKind='NextPage' ToolTip='Next Page' />
                                                                                <dx:ReportToolbarButton ItemKind='LastPage' ToolTip='Last Page' />
                                                                                <dx:ReportToolbarSeparator />
                                                                                <dx:ReportToolbarButton ItemKind='SaveToDisk' ToolTip='Export a report and save it to the disk' />
                                                                                <dx:ReportToolbarButton ItemKind='SaveToWindow' ToolTip='Export a report and show it in a new window' />
                                                                                <dx:ReportToolbarComboBox ItemKind='SaveFormat' Width='70px'>
                                                                                    <Elements>
                                                                                        <dx:ListElement Text='Pdf' Value='pdf' />
                                                                                        <dx:ListElement Text='Xls' Value='xls' />
                                                                                        <dx:ListElement Text='Xlsx' Value='xlsx' />
                                                                                        <dx:ListElement Text='Rtf' Value='rtf' />
                                                                                        <dx:ListElement Text='Mht' Value='mht' />
                                                                                        <dx:ListElement Text='Html' Value='html' />
                                                                                        <dx:ListElement Text='Text' Value='txt' />
                                                                                        <dx:ListElement Text='Image' Value='png' />
                                                                                        <dx:ListElement Text='Csv' Value='csv' />
                                                                                    </Elements>
                                                                                </dx:ReportToolbarComboBox>
                                                                            </Items>
                                                                        </dx:ReportToolbar>
                                                                    </td>
                                                                </tr>
                                                                <tr style="height: 500px">
                                                                    <td style="height: 100%; width: 100%; background-color: #505050;">
                                                                        <div style="width: 100%; height: 500px; overflow-y: scroll; overflow-x:scroll; border: 1px; align-content: center">
                                                                            <dx:ReportViewer ID="xReportViewer" Style="width: 100%; height: 100%; text-align: center"
                                                                                runat="server" ClientInstanceName="xReportViewer" EnableViewState="False">
                                                                            </dx:ReportViewer>
                                                                        </div>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </dx:PopupControlContentControl>
                                    </ContentCollection>
                                    <ContentStyle>
                                        <Paddings Padding="0px"></Paddings>
                                    </ContentStyle>
                                </dx:ASPxPopupControl>
                            </div>
                    </div>
    </div>
    </div>
</asp:Content>
