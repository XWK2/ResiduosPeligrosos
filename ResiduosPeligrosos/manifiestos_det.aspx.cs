using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using DevExpress.Spreadsheet;
using System.IO;
using DevExpress.XtraPrinting;
using ResiduosPeligrosos.Entity;
using ResiduosPeligrosos.dataAccess;

namespace ResiduosPeligrosos
{
    public partial class manifiestos_det : BasePage
    {
        public List<_Residuos> residuos
        {
            get
            {
                return (List<_Residuos>)Session["CurrentResiduos"];
            }
            set
            {
                Session["CurrentResiduos"] = value;
            }
        }

        public List<_Gaylords> gaylords
        {
            get
            {
                return (List<_Gaylords>)Session["CurrentGaylords"];
            }
            set
            {
                Session["CurrentGaylords"] = value;
            }
        }

        public List<Aprobacion> aprbnes
        {
            get
            {
                return (List<Aprobacion>)Session["Currentaprbnes"];
            }
            set
            {
                Session["Currentaprbnes"] = value;
            }
        }

        public List<Residuos> tResiduos
        {
            get
            {
                return (List<Residuos>)Session["CurrenttResiduos"];
            }
            set
            {
                Session["CurrenttResiduos"] = value;
            }
        }

        public List<MttoAlmn> tMttoAlmn
        {
            get
            {
                return (List<MttoAlmn>)Session["CurrentTMttoAlmn"];
            }
            set
            {
                Session["CurrentTMttoAlmn"] = value;
            }
        }

        public List<historial> hist
        {
            get
            {
                return (List<historial>)Session["Currenthist"];
            }
            set
            {
                Session["Currenthist"] = value;
            }
        }

        public void ApplyLayoutTipoArticulo()
        {
            //xgrdTipoArticuloMDL.DataSource = tResiduos;
            //xgrdTipoArticuloMDL.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {        
            int CotizacionSolID = 0;
            string sid = Request.QueryString["sc"].ToString();
            string ResiduosIds = string.Empty;
            string tipoManifiesto = string.Empty;
            string tipoResiduo = string.Empty;
            if (sid != "")
            {
                if (sid.Contains("rmc,"))
                {
                    sid = sid.Replace("rmc,", "");
                    sid = sid.Replace(" ", "+");
                    sid = utilities.Encryption.DecryptURL(sid.ToString());
                    CotizacionSolID = int.Parse(sid.ToString());
                    Session["ManifiestoId"] = CotizacionSolID;
                                       
                }
                else
                {
                    sid = sid.Replace(" ", "+");
                    //string[] parametros = sid.Split('/');
                    string[] parametros = sid.Split('*');

                    string id_s = parametros[0];
                    string tipoManifiesto_s = parametros[1];
                    string tipoResiduos_s = parametros[2];

                    string id = utilities.Encryption.DecryptURL(id_s);
                    tipoManifiesto = utilities.Encryption.DecryptURL(tipoManifiesto_s);
                    tipoResiduo = utilities.Encryption.DecryptURL(tipoResiduos_s);
                   
                    ResiduosIds = id;

                    Session["ManifiestoId"] = 0;
                }
            }
            else {
                Response.Redirect("manifiestos.aspx");
            }
            Session["ResiduosIds"] = ResiduosIds;
            init(ResiduosIds, tipoManifiesto, tipoResiduo);

            //Pruebas xtraReport
            var BManifiesto = new Manifiestoda();
            List<Entity.Manifiestos> oList = BManifiesto.GetManifiesto(CotizacionSolID.ToString());
            foreach (Entity.Manifiestos manifiesto in oList)
            {
                if (CotizacionSolID == manifiesto.ManifiestoId)
                {
                    //Pasamos Datos xReport.
                    PasarDatosReport(manifiesto);
                }
            }


        }

        private void init(string ResiduosIds, string tipoManifiesto, string tipoResiduo)
        {
            List<Unico> lUnico = new List<Unico>();
            Unico item = new Unico();
            item.value = true;
            item.text = "Si";
            Unico item2 = new Unico();
            item2.value = true;
            item2.text = "Si";
            lUnico.Add(item);
            lUnico.Add(item2);

            // Tipo Manifiesto
            var DATM = new TipoManifiestoDa();
            List<TipoManifiesto> oListTipoManifiesto = DATM.GetCombo();
            cmbTipoManifiesto.TextField = "Nombre";
            cmbTipoManifiesto.ValueField = "Codigo";
            cmbTipoManifiesto.DataSource = oListTipoManifiesto;
            cmbTipoManifiesto.DataBind();

            // Tipo Residuo
            var DATR = new GruposDa();
            List<Grupos> oListGrupos = DATR.GetCombo();
            cmbTipoResiduo.TextField = "Nombre";
            cmbTipoResiduo.ValueField = "codigo";
            cmbTipoResiduo.DataSource = oListGrupos;
            cmbTipoResiduo.DataBind();

            ListEditItem oItm = cmbTipoManifiesto.Items.FindByValue(tipoManifiesto);
            if (oItm != null)
            {
                oItm.Selected = true;
            }

            ListEditItem oItme = cmbTipoResiduo.Items.FindByValue(tipoResiduo);
            if (oItme != null)
            {
                oItme.Selected = true;
            }

            //1) Empresa Solicitante ahora Cliente (antes Generadora o solicitante)
            var DAES = new EmpresasDa();
            List<Empresas> oListEmpresaSolicitante = DAES.GetCatalog("", "C", true); //Cliente  antes generadora G
            cmbEmpresaSolicitud.TextField = "RazonSocial";
            cmbEmpresaSolicitud.ValueField = "codigoEmpresa";
            cmbEmpresaSolicitud.DataSource = oListEmpresaSolicitante;
            cmbEmpresaSolicitud.DataBind();
            
            //2) Empresa Transportista                    
            List<Empresas> oListEmpresaTransportista = DAES.GetCatalog("", "T", true); //Transportista
            cmbEmpresaTransportista.TextField = "RazonSocial";
            cmbEmpresaTransportista.ValueField = "codigoEmpresa";
            cmbEmpresaTransportista.DataSource = oListEmpresaTransportista;
            cmbEmpresaTransportista.DataBind();
            
            //3) Empresa Destinatario
            List<Empresas> oListEmpresaDestinatario = DAES.GetCatalog("", "D", true); //Transportista
            cmbEmpresaDestinatario.TextField = "RazonSocial";
            cmbEmpresaDestinatario.ValueField = "codigoEmpresa";
            cmbEmpresaDestinatario.DataSource = oListEmpresaDestinatario;
            cmbEmpresaDestinatario.DataBind();

            var monEs = new MonedaDa();
            List<Moneda> oListMoneda = monEs.GetCombo();
            cmbTipoMoneda.TextField = "CodigoYNombre";
            cmbTipoMoneda.ValueField = "Codigo";
            cmbTipoMoneda.DataSource = oListMoneda;
            cmbTipoMoneda.DataBind();


            if (!IsPostBack)
            {
                refreshData();

            }
            else
            {
                xgrdTipoArticulo.DataSource = residuos;
                xgrdTipoArticulo.DataBind();

                xgrdHistorial.DataSource = hist;
                xgrdHistorial.DataBind();
                ApplyLayoutTipoArticulo();

            }
        }
        
        private void refreshData()
        {

            string ResiduosIds = Session["ResiduosIds"].ToString();

            //1) Empresa Solicitante ahora Cliente (antes Generadora o solicitante)
            var DAES = new EmpresasDa();
            List<Empresas> oListEmpresaSolicitante = DAES.GetCatalog("", "C", true); //Cliente  antes generadora G
            cmbEmpresaSolicitud.TextField = "RazonSocial";
            cmbEmpresaSolicitud.ValueField = "codigoEmpresa";
            cmbEmpresaSolicitud.DataSource = oListEmpresaSolicitante;
            cmbEmpresaSolicitud.DataBind();

            //2) Empresa Transportista                    
            List<Empresas> oListEmpresaTransportista = DAES.GetCatalog("", "T", true); //Transportista
            cmbEmpresaTransportista.TextField = "RazonSocial";
            cmbEmpresaTransportista.ValueField = "codigoEmpresa";
            cmbEmpresaTransportista.DataSource = oListEmpresaTransportista;
            cmbEmpresaTransportista.DataBind();

            //3) Empresa Destinatario
            List<Empresas> oListEmpresaDestinatario = DAES.GetCatalog("", "D", true); //Transportista
            cmbEmpresaDestinatario.TextField = "RazonSocial";
            cmbEmpresaDestinatario.ValueField = "codigoEmpresa";
            cmbEmpresaDestinatario.DataSource = oListEmpresaDestinatario;
            cmbEmpresaDestinatario.DataBind();

            var monEs = new MonedaDa();
            List<Moneda> oListMoneda = monEs.GetCombo();
            cmbTipoMoneda.TextField = "CodigoYNombre";
            cmbTipoMoneda.ValueField = "Codigo";
            cmbTipoMoneda.DataSource = oListMoneda;
            cmbTipoMoneda.DataBind();

            int ManifiestoId = Convert.ToInt32(Session["ManifiestoId"]);

            var BManifiesto = new Manifiestoda();

            if (ManifiestoId > 0)
            {
                //ya guardo ya puede imprimir
                //btnImprimir2.Style.Add("display", "block");

                List<Entity.Manifiestos> oList = BManifiesto.GetManifiesto(ManifiestoId.ToString());
                foreach (Entity.Manifiestos manifiesto in oList)
                {
                    if (ManifiestoId == manifiesto.ManifiestoId)
                    {
                        //Pasamos Datos xReport.
                        //PasarDatosReport(manifiesto);

                        lblcodigoSts.Text = manifiesto.codigoEstatus;
                        switch (manifiesto.codigoEstatus)
                        {
                            case "0015":  //Manifiesto Creado
                                ltlSts.Text = "<span id='spanStatus' class='alert btn-info docEstatus'><i class='glyphicon glyphicon-edit' style='padding-right:5px;'></i>" + manifiesto.estatus + "</span><span style='position: absolute; left: 250px; color:#FBFBFB;padding:2px 0px;'>:Manifiesto Creado</span>";
                                btnSave1.Style.Add("display", "block");
                                btnImprimir2.Style.Add("display", "block");
                                //btnImprimirFisico.Style.Add("display", "block");
                                btnCompletar1.Style.Add("display", "none");
                                break;
                            case "0016": //Manifiesto Impreso
                                ltlSts.Text = "<span id='spanStatus' class='alert btn-info docEstatus'><i class='glyphicon glyphicon-eye-open' style='padding-right:5px;'></i>" + manifiesto.estatus + "</span><span style='position: absolute; left: 250px; color:#FBFBFB;padding:2px 0px;'>:Manifiesto Impreso</span>";
                                btnSave1.Style.Add("display", "none");
                                btnImprimir2.Style.Add("display", "none");
                                btnImprimirFisico.Style.Add("display", "none");
                                btnCompletar1.Style.Add("display", "block");
                                break;
                            case "0017": //Manifiesto Entregado
                                ltlSts.Text = "<span id='spanStatus' class='alert btn-info docEstatus'><i class='glyphicon glyphicon-lock' style='padding-right:5px;'></i>" + manifiesto.estatus + "</span><span style='position: absolute; left: 250px; color:#FBFBFB;padding:2px 0px;'>:Manifiesto entregado por " + manifiesto.usuario + " el " + manifiesto.ModFecha + "</span>";
                                btnSave1.Style.Add("display", "none");
                                btnImprimir2.Style.Add("display", "none");
                                btnImprimirFisico.Style.Add("display", "none");
                                btnCompletar1.Style.Add("display", "block");
                                break;
                            case "0018": //Manifiesto Pendiente por Documentacion
                                ltlSts.Text = "<span id='spanStatus' class='alert btn-info docEstatus'><i class='glyphicon glyphicon-lock' style='padding-right:5px;'></i>" + manifiesto.estatus + "</span><span style='position: absolute; left: 250px; color:#FBFBFB;padding:2px 0px;'>:Manifiesto Pendiente por Documentacion por " + manifiesto.usuario + " el " + manifiesto.ModFecha + "</span>";
                                btnSave1.Style.Add("display", "none");
                                btnImprimir2.Style.Add("display", "none");
                                btnImprimirFisico.Style.Add("display", "none");
                                btnCompletar1.Style.Add("display", "none");
                                break;
                        }

                        lblNoDocumento.Text = manifiesto.numManifiesto;
                        lblDocSolicitante.Text = manifiesto.usuario;
                        //lblDocFechaSol.Text = manifiesto.fechaSolicitud;

                        lblNoFactura.Text = manifiesto.numFactura;
                        lblNoShipping.Text = manifiesto.numShipping;
                        lblEstatusPago.Text = manifiesto.estatusPago;
                        lblDocSolicitante.Text = manifiesto.autor.ToString();

                        DateTime fecha = DateTime.Now;
                        fecha = DateTime.Parse(manifiesto.fecha);
                        lblDocFechaSol.Text = fecha.ToString();
                        lblPlanta.Text = manifiesto.planta;

                        ListEditItem oItmi = cmbTipoManifiesto.Items.FindByValue(manifiesto.tipoManifiesto);
                        if (oItmi != null)
                        {
                            oItmi.Selected = true;
                        }

                        ListEditItem oItem = cmbTipoResiduo.Items.FindByValue(manifiesto.tipoResiduo);
                        if (oItem != null)
                        {
                            oItem.Selected = true;
                        }

                        ListEditItem oItemG = cmbEmpresaSolicitud.Items.FindByValue(manifiesto.nombreGenerador);
                        if (oItemG != null)
                        {
                            oItemG.Selected = true;
                        }

                        ListEditItem oItemT = cmbEmpresaTransportista.Items.FindByValue(manifiesto.nombreTransportista);
                        if (oItemT != null)
                        {
                            oItemT.Selected = true;
                        }

                        ListEditItem oItemD = cmbEmpresaDestinatario.Items.FindByValue(manifiesto.nombreDestinatario);
                        if (oItemD != null)
                        {
                            oItemD.Selected = true;
                        }

                        ListEditItem oItemMon = cmbTipoMoneda.Items.FindByValue(manifiesto.codigoMoneda);
                        if (oItemMon != null)
                        {
                            oItemMon.Selected = true;
                        }

                        if (manifiesto.esVenta == "SI")
                        {
                            rbSi.Checked = true;
                            rbNo.Checked = false;
                        }
                        else
                        {
                            rbSi.Checked = false;
                            rbNo.Checked = true;
                        }

                        txtNoRegistroHambiental.Text = manifiesto.numRegistroAmbiental;
                        txtPagina.Text = manifiesto.paginaNumero.ToString("0.##");

                        txtCPGenerador.Text = manifiesto.cpGen;
                        txtCalleGenerador.Text = manifiesto.direccion;
                        txtNoExteriorGenerador.Text = manifiesto.numeroExterior;
                        xtxtNoInteriorGenerador.Text = manifiesto.numeroInterior;
                        txtColoniaGenerador.Text = manifiesto.colonia;
                        txtMunicipioGenerador.Text = manifiesto.municipio;
                        txtEstadoGenerador.Text = manifiesto.estado;
                        txtTelefonoGenerador.Text = manifiesto.tel;
                        txtCorreoElectronico.Text = manifiesto.correoElectronico;
                        txtInstruccionesGenerador.Text = manifiesto.instrucciones;
                        txtResponsableGenerador.Text = manifiesto.responsable;
                        //xDateGenerador.Value = manifiesto.fechaGenerador;

                        if (manifiesto.fechaGenerador != "")
                        {
                            DateTime fechaGenerador = DateTime.Now;
                            fechaGenerador = DateTime.Parse(manifiesto.fechaGenerador);
                            //DateTime fechaGenerador = new DateTime(Convert.ToInt32(manifiesto.fechaGenerador.Substring(6, 4)), Convert.ToInt32(manifiesto.fechaGenerador.Substring(3, 2)), Convert.ToInt32(manifiesto.fechaGenerador.Substring(0, 2)));
                            xDateGenerador.Date = fechaGenerador;
                        }

                        txtCPTrans.Text = manifiesto.cpTrans;
                        txtCalleTrans.Text = manifiesto.direccionTrans;
                        txtNoExteriorTrans.Text = manifiesto.numeroExteriorTrans;
                        txtNoInteriorTrans.Text = manifiesto.numeroInteriorTrans;
                        txtColoniaTrans.Text = manifiesto.coloniaTrans;
                        txtxMunicipioTrans.Text = manifiesto.municipioTrans;
                        txtEstadoTrans.Text = manifiesto.estadoTrans;
                        txtTelefonoTrans.Text = manifiesto.telTrans;
                        txtcorreoElectronicoTrans.Text = manifiesto.correoElectronicoTrans;
                        txtNoSMARNATTrans.Text = manifiesto.numeroAutorizacionSemarnatTrans;
                        txtNoPermisoSCTTrans.Text = manifiesto.numeroPermisoSCTTrans;
                        txtTipoVehiculoTrans.Text = manifiesto.tipoVehiculoTrans;
                        txtNoPlacaTrans.Text = manifiesto.placasTrans;
                        txtRutaEmpresaTrans.Text = manifiesto.rutaEmpresaTrans;
                        txtResponsableTrans.Text = manifiesto.responsableTrans;
                        //xDateTrans.Value = manifiesto.fechaTrans;

                        if (manifiesto.fechaTrans != "")
                        {
                            DateTime fechaTrans = DateTime.Now;
                            fechaTrans = DateTime.Parse(manifiesto.fechaTrans);
                            //DateTime fechaTrans = new DateTime(Convert.ToInt32(manifiesto.fechaTrans.Substring(6, 4)), Convert.ToInt32(manifiesto.fechaTrans.Substring(3, 2)), Convert.ToInt32(manifiesto.fechaTrans.Substring(0, 2)));
                            xDateTrans.Date = fechaTrans;
                        }

                        txtCPDest.Text = manifiesto.cpDes;
                        txtCalleDest.Text = manifiesto.direccionDes;
                        txtNoExteriorDest.Text = manifiesto.numeroExteriorDes;
                        txtNoInteriorDest.Text = manifiesto.numeroInteriorDes;
                        txtColoniaDest.Text = manifiesto.coloniaDes;
                        txtMunicipioDest.Text = manifiesto.municipioDes;
                        txtEstadoDest.Text = manifiesto.estadoDes;
                        txtTelefonoDest.Text = manifiesto.telDes;
                        txtCorreoElectronicoDest.Text = manifiesto.correoElectronicoDes;
                        txtNoSEMARNATDest.Text = manifiesto.numeroAutorizacionSemarnatDes;
                        txtPersonaRecibeReciduosDest.Text = manifiesto.nomnbrePersonaRecibeDes;
                        txtResponsableDest.Text = manifiesto.responsableDes;
                        //xDateFechaDest.Value = manifiesto.fechaDes;

                        if (manifiesto.fechaDes != "")
                        {
                            DateTime fechaDes = DateTime.Now;
                            fechaDes = DateTime.Parse(manifiesto.fechaDes);

                            //DateTime fechaDes = new DateTime(Convert.ToInt32(manifiesto.fechaDes.Substring(6, 4)), Convert.ToInt32(manifiesto.fechaDes.Substring(3, 2)), Convert.ToInt32(manifiesto.fechaDes.Substring(0, 2)));
                            xDateFechaDest.Date = fechaDes;
                        }

                        gaylords = new List<_Gaylords>();
                        gaylords = manifiesto.gaylords;
                        xgrdTipoArticulo.DataSource = manifiesto.gaylords;
                        xgrdTipoArticulo.DataBind();

                        cmbTipoMoneda.SelectedItem.Value = manifiesto.codigoMoneda;
                        if (manifiesto.esVenta == "SI")
                        {
                            rbSi.Checked = true;
                            rbNo.Checked = false;
                        }
                        else
                        {
                            rbSi.Checked = false;
                            rbNo.Checked = true;
                        }

                        aprbnes = new List<Aprobacion>();
                        aprbnes = manifiesto.aprobaciones;

                        hist = new List<historial>();
                        hist = manifiesto.historial;
                        xgrdHistorial.DataSource = hist;
                        xgrdHistorial.DataBind();

                        xgrdHistorial.DataSource = hist;
                        xgrdHistorial.DataBind();

                        break;
                    }
                }

                if (lblcodigoSts.Text != "0015" && lblcodigoSts.Text != "0001")
                {

                    cmbTipoManifiesto.ClientEnabled = false;
                    cmbTipoResiduo.ClientEnabled = false;
                    cmbEmpresaSolicitud.ClientEnabled = false;
                    cmbEmpresaTransportista.ClientEnabled = false;
                    cmbEmpresaDestinatario.ClientEnabled = false;
                    cmbTipoMoneda.ClientEnabled = false;
                    rbSi.Enabled = false;
                    rbNo.Enabled = false;
                    txtNoRegistroHambiental.Enabled = false;
                    txtPagina.Enabled = false;
                    txtCPGenerador.Enabled = false;
                    txtCalleGenerador.Enabled = false;
                    txtNoExteriorGenerador.Enabled = false;
                    xtxtNoInteriorGenerador.Enabled = false;
                    txtColoniaGenerador.Enabled = false;
                    txtMunicipioGenerador.Enabled = false;
                    txtEstadoGenerador.Enabled = false;
                    txtTelefonoGenerador.Enabled = false;
                    txtCorreoElectronico.Enabled = false;
                    txtInstruccionesGenerador.Enabled = false;
                    txtResponsableGenerador.Enabled = false;
                    xDateGenerador.ClientEnabled = false;
                    txtCPTrans.Enabled = false;
                    txtCalleTrans.Enabled = false;
                    txtNoExteriorTrans.Enabled = false;
                    txtColoniaTrans.Enabled = false;
                    txtxMunicipioTrans.Enabled = false;
                    txtEstadoTrans.Enabled = false;
                    txtTelefonoTrans.Enabled = false;
                    txtcorreoElectronicoTrans.Enabled = false;
                    txtNoSMARNATTrans.Enabled = false;
                    txtNoPermisoSCTTrans.Enabled = false;
                    txtTipoVehiculoTrans.Enabled = false;
                    txtNoPlacaTrans.Enabled = false;
                    txtRutaEmpresaTrans.Enabled = false;
                    txtResponsableTrans.Enabled = false;
                    xDateTrans.ClientEnabled = false;
                    txtCPDest.Enabled = false;
                    txtCalleDest.Enabled = false;
                    txtNoExteriorDest.Enabled = false;
                    txtNoInteriorDest.Enabled = false;
                    txtColoniaDest.Enabled = false;
                    txtMunicipioDest.Enabled = false;
                    txtEstadoDest.Enabled = false;
                    txtTelefonoDest.Enabled = false;
                    txtCorreoElectronicoDest.Enabled = false;
                    txtNoSEMARNATDest.Enabled = false;
                    txtPersonaRecibeReciduosDest.Enabled = false;
                    txtResponsableDest.Enabled = false;
                    xDateFechaDest.ClientEnabled = false;
                    xgrdTipoArticulo.Enabled = false;
                }
            }
            else
            {
                string newFolio = BManifiesto.GetConsecutivosolicitud();

                DateTime date = new DateTime();
                date = DateTime.Now;
                lblcodigoSts.Text = "0001";
                ltlSts.Text = "<span id='spanStatus' class='alert btn-info docEstatus'><i class='glyphicon glyphicon-edit' style='padding-right:5px;'></i>Abierto</span><span style='position: absolute; left: 250px; color:#FBFBFB;padding:2px 0px;'>:Pendiente por el autor para terminar la captura</span>";
                lblNoDocumento.Text = newFolio;
                lblNoFactura.Text = "S/N";
                lblNoShipping.Text = "S/N";
                lblEstatusPago.Text = "";
                lblDocSolicitante.Text = LoginInfo.CurrentUsuario.NombreCompleto;
                lblDocFechaSol.Text = date.ToString("yyyy/MM/dd HH:mm:ss");

                cmbEmpresaSolicitud.SelectedIndex = 1;

                txtNoRegistroHambiental.Text = oListEmpresaSolicitante[0].NoRegistroAmbiental;

                txtCPGenerador.Text = oListEmpresaSolicitante[0].CodigoPostal;
                txtCalleGenerador.Text = oListEmpresaSolicitante[0].Calle;
                txtColoniaGenerador.Text = oListEmpresaSolicitante[0].Colonia;
                xtxtNoInteriorGenerador.Text = oListEmpresaSolicitante[0].NoInterior;
                txtNoExteriorGenerador.Text = oListEmpresaSolicitante[0].NoExterior;
                txtColoniaGenerador.Text = oListEmpresaSolicitante[0].Colonia;
                txtMunicipioGenerador.Text = oListEmpresaSolicitante[0].Municipio;
                txtEstadoGenerador.Text = oListEmpresaSolicitante[0].Estado;
                txtTelefonoGenerador.Text = oListEmpresaSolicitante[0].Telefono;
                txtResponsableGenerador.Text = oListEmpresaSolicitante[0].Responsable;
                txtCorreoElectronico.Text = "";

                xDateGenerador.Value = DateTime.Today.ToString("yyyy/MM/dd HH:mm:ss");

                cmbEmpresaTransportista.SelectedIndex = 1;

                txtCPTrans.Text = oListEmpresaTransportista[0].CodigoPostal;
                txtNoInteriorTrans.Text = oListEmpresaTransportista[0].NoInterior;
                txtNoExteriorTrans.Text = oListEmpresaTransportista[0].NoExterior;
                txtColoniaTrans.Text = oListEmpresaTransportista[0].Colonia;
                txtCalleTrans.Text = oListEmpresaTransportista[0].Calle;
                txtxMunicipioTrans.Text = oListEmpresaTransportista[0].Municipio;
                txtEstadoTrans.Text = oListEmpresaTransportista[0].Estado;
                txtTelefonoTrans.Text = oListEmpresaTransportista[0].Telefono;
                txtNoSMARNATTrans.Text = oListEmpresaTransportista[0].NoAutorizacionSEMARNAT;
                txtNoPermisoSCTTrans.Text = oListEmpresaTransportista[0].NoPermisoSCT;
                txtTipoVehiculoTrans.Text = oListEmpresaTransportista[0].TipoVehiculo; // colocar un combo.
                txtNoPlacaTrans.Text = oListEmpresaTransportista[0].Placas;
                txtRutaEmpresaTrans.Text = oListEmpresaTransportista[0].Rutas;
                txtResponsableTrans.Text = oListEmpresaTransportista[0].Responsable;

                xDateTrans.Value = DateTime.Today.ToString("yyyy/MM/dd HH:mm:ss");

                cmbEmpresaDestinatario.SelectedIndex = 1;

                txtCPDest.Text = oListEmpresaDestinatario[0].CodigoPostal;
                txtCalleDest.Text = oListEmpresaDestinatario[0].Calle;
                txtNoInteriorDest.Text = oListEmpresaDestinatario[0].NoInterior;
                txtNoExteriorDest.Text = oListEmpresaDestinatario[0].NoExterior;
                txtColoniaDest.Text = oListEmpresaDestinatario[0].Colonia;
                txtMunicipioDest.Text = oListEmpresaDestinatario[0].Municipio;
                txtEstadoDest.Text = oListEmpresaDestinatario[0].Estado;
                txtTelefonoDest.Text = oListEmpresaDestinatario[0].Telefono;
                txtNoSEMARNATDest.Text = oListEmpresaDestinatario[0].NoAutorizacionSEMARNAT;
                //txtNoPermisoSCTTrans.Text = oListEmpresaDestinatario[0].NoPermisoSCT;

                //txtTipoVehiculoTrans.Text = oListEmpresaDestinatario[0].TipoVehiculo; // colocar un combo.
                //txtNoPlacaTrans.Text = oListEmpresaDestinatario[0].Placas;
                //txtRutaEmpresaTrans.Text = oListEmpresaTransportista[0].Rutas;
                txtResponsableDest.Text = oListEmpresaDestinatario[0].Responsable;

                xDateFechaDest.Value = DateTime.Today.ToString("yyyy/MM/dd HH:mm:ss");

                //Nueva forma
                var DaGaylords = new GaylordsDa();
                gaylords = new List<_Gaylords>();
                List<Entity.Gaylords> List = DaGaylords.GetGaylordsxIds(ResiduosIds);
                foreach (Entity.Gaylords itemG in List)
                {
                    _Gaylords n = new _Gaylords();
                    n.noDocumento = "D0001";
                    n.GaylordID = itemG.GaylordID;
                    n.codigo = itemG.codigo;
                    n.codigoTipoEnvase = itemG.codigoTipoEnvase;
                    n.codigoMaterial = itemG.codigoMaterial;
                    n.codigoLocacion = itemG.codigoLocacion;
                    n.capacidad = itemG.capacidad;
                    n.Material = itemG.Material;
                    n.locacion = itemG.locacion;
                    n.TipoEnvase = itemG.TipoEnvase;
                    n.clasificaciones = itemG.clasificaciones;
                    n.IEDescripcion = itemG.IEDescripcion;
                    n.residuo = itemG.residuo;
                    n.peso = itemG.peso;
                    gaylords.Add(n);
                }

                xgrdTipoArticulo.DataSource = gaylords;
                xgrdTipoArticulo.DataBind();

                aprbnes = new List<Aprobacion>();

                rbSi.Checked = false;
                rbNo.Checked = true;

                cmbTipoMoneda.SelectedIndex = 1;
               
            }
                        
            cmbTipoManifiesto.ClientEnabled = false;
            cmbTipoResiduo.ClientEnabled = false;
            
        }

        private void PasarDatosReport(Manifiestos manifiesto)
        {
            if (manifiesto.tipoManifiesto == "M01")
            {
                //M01: Residuos peligrosos
                XtraReport1 report = new XtraReport1(manifiesto);
                xReportViewer.Report = report;
            }
            else{
                //M02 : Residuos no peligrosos.

                //Cliente 
                EmpresasDa EmpresaClienteDa = new EmpresasDa();
                List<Empresas> ListEmpresa = EmpresaClienteDa.GetCatalog("CL-001", "C", true);
                if(ListEmpresa.Count > 0)
                {
                    //Tomaremos el primero.
                    Empresas Empresa = ListEmpresa[0];
                    XtraReport2 report = new XtraReport2(manifiesto, Empresa);
                    xReportViewer.Report = report;
                }

                
            }
         
        }

        //public void limpiarModalAprnes()
        //{
        //    txtCodigoAprobacionAdd.Text = "";
        //    txtPasoAdd.Text = "";
        //    txtTituloAdd.Text = "";
        //    txtAccionAdd.Text = "";
        //    txtComentarioAdd.Text = "";

        //    var BPosicion = new PosicionDa();
        //    cmbPuestoAdd.TextField = "Descripcion";
        //    cmbPuestoAdd.ValueField = "Codigo";
        //    List<Posicion> posiciones = BPosicion.GetCombo(true);
        //    cmbPuestoAdd.DataSource = posiciones;
        //    cmbPuestoAdd.DataBind();

        //    if (posiciones.Count > 0)
        //    {
        //        ListEditItem iPuesto = cmbPuestoAdd.Items.FindByValue(posiciones[0].Codigo);
        //        if (iPuesto != null)
        //        {
        //            iPuesto.Selected = true;
        //        }
        //        var BEmpleado = new EmpleadosDa();
        //        cmbEmpleadoAdd.TextField = "NombreCompleto";
        //        cmbEmpleadoAdd.ValueField = "EmpleadoId";
        //        cmbEmpleadoAdd.DataSource = BEmpleado.GetCombo(posiciones[0].Codigo);
        //        cmbEmpleadoAdd.DataBind();

        //        if (cmbEmpleadoAdd.Items.Count > 0)
        //        {
        //            ListEditItem iEmp = cmbEmpleadoAdd.Items.FindByValue(cmbEmpleadoAdd.Items[0].Value);
        //            if (iEmp != null)
        //            {
        //                iEmp.Selected = true;
        //            }
        //        }
        //    }

        //    DateTime fechaActual = DateTime.Now;
        //    xDateFechaNotAdd.Date = fechaActual;
        //    xDateFechaAccionAdd.Date = fechaActual;
        //}

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("manifiestos.aspx");
        }

        protected void btnSave_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if(cmbTipoMoneda.SelectedItem == null)
                {
                    string info = "swal('Information', 'Please select Currency!', 'info');";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "InsertMissed", info, true);
                    return;
                }

                int ManifiestoId = Convert.ToInt32(Session["ManifiestoId"]);
                Entity.Manifiestos manifiesto = new Entity.Manifiestos();
                manifiesto.ManifiestoId = ManifiestoId;
                manifiesto.numManifiesto = lblNoDocumento.Text;
                manifiesto.usuario = lblDocSolicitante.Text;
                manifiesto.fechaSolicitud = lblDocFechaSol.Text; //no se usa.

                manifiesto.numFactura = lblNoFactura.Text;
                manifiesto.numShipping = lblNoShipping.Text;
                manifiesto.autor = LoginInfo.CurrentUsuario.Codigo;

                DateTime fecha = DateTime.Now;
                if (lblDocFechaSol.Text != "") {
                    fecha =Convert.ToDateTime(String.Format("{0:dd-MM-yyyy HH:mm:ss}", lblDocFechaSol.Text));
                }
                manifiesto.fecha = fecha.ToString();

                manifiesto.planta = lblPlanta.Text;

                if (cmbTipoManifiesto.SelectedIndex != -1)
                {
                    manifiesto.tipoManifiesto = cmbTipoManifiesto.SelectedItem.Value.ToString();
                }
                else {
                    manifiesto.tipoManifiesto = "";
                }

                if (cmbTipoResiduo.SelectedIndex != -1)
                {
                    manifiesto.tipoResiduo = cmbTipoResiduo.SelectedItem.Value.ToString();
                }else
                {
                    manifiesto.tipoResiduo = "";
                }
                               

                manifiesto.numRegistroAmbiental = txtNoRegistroHambiental.Text;
                manifiesto.paginaNumero = (txtPagina.Text == "") ? 0 : Convert.ToInt32(txtPagina.Text);

                //manifiesto.nombreGenerador = xtxtRazonSocialGenerador.Text;
                if (cmbEmpresaSolicitud.SelectedIndex != -1)
                {

                    manifiesto.nombreGenerador = cmbEmpresaSolicitud.SelectedItem.Value.ToString();
                }
                else {
                    manifiesto.nombreGenerador = "";
                }

                manifiesto.cpGen = txtCPGenerador.Text;
                manifiesto.direccion = txtCalleGenerador.Text;
                manifiesto.numeroExterior = txtNoExteriorGenerador.Text;
                manifiesto.numeroInterior = xtxtNoInteriorGenerador.Text;
                manifiesto.colonia = txtColoniaGenerador.Text;
                manifiesto.municipio = txtMunicipioGenerador.Text;
                manifiesto.estado = txtEstadoGenerador.Text;
                manifiesto.tel = txtTelefonoGenerador.Text;
                manifiesto.correoElectronico = txtCorreoElectronico.Text;
                manifiesto.instrucciones = txtInstruccionesGenerador.Text;
                manifiesto.responsable = txtResponsableGenerador.Text;
                DateTime fechaGenerador = DateTime.Now;
                if (xDateGenerador.Value != null)
                {
                    fechaGenerador = DateTime.Parse(xDateGenerador.Value.ToString());
                }
                manifiesto.fechaGenerador = fechaGenerador.ToString();
                
                //manifiesto.nombreTransportista = txtRazonSocialTrans.Text;
                if (cmbEmpresaTransportista.SelectedIndex != -1)
                {
                    manifiesto.nombreTransportista = cmbEmpresaTransportista.SelectedItem.Value.ToString();
                }
                else
                {
                    manifiesto.nombreTransportista = "";
                }

                manifiesto.cpTrans = txtCPTrans.Text;
                manifiesto.direccionTrans = txtCalleTrans.Text;
                manifiesto.numeroExteriorTrans = txtNoExteriorTrans.Text;
                manifiesto.numeroInteriorTrans = txtNoInteriorTrans.Text;
                manifiesto.coloniaTrans = txtColoniaTrans.Text;
                manifiesto.municipioTrans = txtxMunicipioTrans.Text;
                manifiesto.estadoTrans = txtEstadoTrans.Text;
                manifiesto.telTrans = txtTelefonoTrans.Text;
                manifiesto.correoElectronicoTrans = txtcorreoElectronicoTrans.Text;
                manifiesto.numeroAutorizacionSemarnatTrans = txtNoSMARNATTrans.Text;
                manifiesto.numeroPermisoSCTTrans = txtNoPermisoSCTTrans.Text;
                manifiesto.tipoVehiculoTrans = txtTipoVehiculoTrans.Text;
                manifiesto.placasTrans = txtNoPlacaTrans.Text;
                manifiesto.rutaEmpresaTrans = txtRutaEmpresaTrans.Text;
                manifiesto.responsableTrans = txtResponsableTrans.Text;
                DateTime fechaTrans = DateTime.Now;
                if (xDateTrans.Value != null)
                {
                    fechaTrans = DateTime.Parse(xDateTrans.Value.ToString());
                }
                manifiesto.fechaTrans = fechaTrans.ToString();
                //manifiesto.nombreDestinatario = txtRazonSocialDest.Text;
                if (cmbEmpresaDestinatario.SelectedIndex != -1)
                {
                    manifiesto.nombreDestinatario = cmbEmpresaDestinatario.SelectedItem.Value.ToString();
                }
                else
                {
                    manifiesto.nombreDestinatario = "";
                }
                manifiesto.cpDes = txtCPDest.Text;
                manifiesto.direccionDes = txtCalleDest.Text;
                manifiesto.numeroExteriorDes = txtNoExteriorDest.Text;
                manifiesto.numeroInteriorDes = txtNoInteriorDest.Text;
                manifiesto.coloniaDes = txtColoniaDest.Text;
                manifiesto.municipioDes = txtMunicipioDest.Text;
                manifiesto.estadoDes = txtEstadoDest.Text;
                manifiesto.telDes = txtTelefonoDest.Text;
                manifiesto.correoElectronicoDes = txtCorreoElectronicoDest.Text;
                manifiesto.numeroAutorizacionSemarnatDes = txtNoSEMARNATDest.Text;
                manifiesto.nomnbrePersonaRecibeDes = txtPersonaRecibeReciduosDest.Text;
                manifiesto.responsableDes = txtResponsableDest.Text;
                DateTime fechaDes = DateTime.Now;
                if (xDateFechaDest.Value != null)
                {
                    fechaDes = DateTime.Parse(xDateFechaDest.Value.ToString());
                }
                manifiesto.fechaDes = fechaDes.ToString();
                
               

                manifiesto.codigo_sts_Prods = lblcodigoSts.Text;

              

                manifiesto.gaylords = gaylords;


                List<Aprobacion> aprbInsert = new List<Aprobacion>();

                foreach (Aprobacion prb in aprbnes)
                {
                    Aprobacion nuevo = new Aprobacion();
                    nuevo = prb;
                    nuevo.fechaNotificacion = prb.fechaNotificacion.Substring(6, 4) + prb.fechaNotificacion.Substring(3, 2) + prb.fechaNotificacion.Substring(0, 2);
                    nuevo.fechaAccion = prb.fechaAccion.Substring(6, 4) + prb.fechaAccion.Substring(3, 2) + prb.fechaAccion.Substring(0, 2);
                    aprbInsert.Add(nuevo);
                }

                manifiesto.aprobaciones = aprbInsert;
                manifiesto.codigoMoneda = cmbTipoMoneda.SelectedItem.Value.ToString();
                if (rbSi.Checked)
                {
                    manifiesto.esVenta = "SI";
                }
                else
                {
                    manifiesto.esVenta = "NO";
                }

                var BManifiesto = new Manifiestoda();
                string strScript;
                if (ManifiestoId == 0)                
                {
                    var regreso = BManifiesto.InsManifiesto(manifiesto, LoginInfo.CurrentUsuario.UsuarioId.ToString());
                    if (regreso > 0)
                    {
                        Session["ManifiestoId"] = regreso;
                        refreshData();

                        ltlSts.Text = "<span id='spanStatus' class='alert btn-info docEstatus'><i class='glyphicon glyphicon-edit' style='padding-right:5px;'></i>" + "manifiesto creado" + "</span><span style='position: absolute; left: 250px; color:#FBFBFB;padding:2px 0px;'>:Manifiesto Creado</span>";
                        //btnSave1.Style.Add("display", "none");
                        btnImprimir2.Style.Add("display", "block");
                        //btnImprimirFisico.Style.Add("display", "block");
                        btnCompletar1.Style.Add("display", "none");

                        strScript = "swal('Information', 'The Doc has been success registered!', 'success');";
                    }
                    else
                    {
                        strScript = "swal('Information', 'There Doc an error registering the product!', 'error');";
                    }
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "InsertSucces", strScript, true);
                    return;
                }
                else
                {
                    var regreso = BManifiesto.UpdManifiesto(manifiesto, LoginInfo.CurrentUsuario.UsuarioId.ToString());
                    if (regreso > 0)
                    {
                        refreshData();
                        strScript = "swal('Information', 'The product has been success updated!', 'success');";
                    }
                    else
                    {
                        strScript = "swal('Information', 'There was an error updating the product!', 'error');";
                    }
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdateSucces", strScript, true);
                    return;
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        protected void xgrdTipoArticulo_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            xgrdTipoArticulo.JSProperties["cpAlertMessage"] = string.Empty;
            var pars = e.Parameters;

            if (pars == "Delete")
            {
                xgrdTipoArticulo.DataSource = null;
                residuos.Clear();
            }
            else
            {
                if (pars != "Save")
                {
                    var Valores = e.Parameters;
                    string[] data = Valores.Split(',');

                    foreach (string d in data)
                    {
                        string valor = d.Replace("chk", "");
                        string[] datos = valor.Split('-');
                        string idtipoarticulo = datos[0];
                        string folio = datos[1];
                        residuos = residuos.FindAll(p => p.CodigoResiduo != folio);
                    }
                }

                xgrdTipoArticulo.DataSource = residuos;
            }

            xgrdTipoArticulo.DataBind();
        }

        protected void xgrdTipoArticulo_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                //var id = e.GetValue("manifiestoTipoArticuloID").ToString() + "-" + e.GetValue("codigoTipoArticulo").ToString();
                var id = e.GetValue("codigo").ToString();
                e.Cell.Text = string.Format("<input type='checkbox' class='chkArt' id='chk{0}'>", id);
            }
        }

        protected void xgrdMtto_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void xgrdMtto_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("manifiestoMantenimientoID").ToString() + "-" + e.GetValue("codigoMttoAlmn").ToString();

                e.Cell.Text = string.Format("<input type='checkbox' class='chkMtto' id='chk{0}'>", id);
            }
        }

        protected void xgrdAlmacen_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void xgrdAlmacen_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("manifiestoMantenimientoID").ToString() + "-" + e.GetValue("codigoMttoAlmn").ToString();

                e.Cell.Text = string.Format("<input type='checkbox' class='chkAlmn' id='chk{0}'>", id);
            }
        }

        //protected void xgrdAprobaciones_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        //{
        //    xgrdAprobaciones.JSProperties["cpAlertMessage"] = string.Empty;
        //    var pars = e.Parameters;

        //    string EmpleadoId = cmbEmpleadoAdd.SelectedItem.Value.ToString();
        //    string code = "";
        //    string user = "";
        //    var BEmpleado = new EmpleadosDa();
        //    List<Empleados> empleados = BEmpleado.GetCatalog(cmbPuestoAdd.SelectedItem.Value.ToString(), "", "", "", true);
        //    foreach (Empleados item in empleados)
        //    {
        //        if (item.EmpleadoId.ToString() == EmpleadoId)
        //        {
        //            code = item.Codigo;
        //            user = item.NombreCompleto;
        //            break;
        //        }
        //    }

        //    TextBox txtCode = (TextBox)ASPxCallbackPanel1.FindControl("txtCodigoAprobacionAdd");

        //    string noDocumento = lblNoDocumento.Text;
        //    string codigo = txtCodigoAprobacionAdd.Text;
        //    string paso = txtPasoAdd.Text;
        //    string titulo = txtTituloAdd.Text;
        //    string codigoEmpleado = code;
        //    string usuario = user;
        //    string puesto = cmbPuestoAdd.SelectedItem.Value.ToString();
        //    string fechaNotificacion = xDateFechaNotAdd.Date.ToString("dd-MM-yyyy");
        //    string fechaAccion = xDateFechaAccionAdd.Date.ToString("dd-MM-yyyy");
        //    string accion = txtAccionAdd.Text;
        //    string coment = txtComentarioAdd.Text;

        //    if (pars == "Save" && (titulo != "" && codigo != ""))
        //    {
        //        bool bFound = false;
        //        Aprobacion aprb = new Aprobacion();

        //        foreach (Aprobacion item in aprbnes)
        //        {
        //            if (item.codigoAprobaciones == codigo)
        //            {
        //                bFound = true;
        //                break;
        //            }
        //        }

        //        if (bFound == true)
        //        {
        //            xgrdAprobaciones.JSProperties["cpAlertMessage"] = "Exist";
        //        }
        //        else
        //        {
        //            aprb.AprobacionesID = 0;
        //            aprb.noDocumento = noDocumento;
        //            aprb.codigoAprobaciones = codigo;
        //            aprb.paso = paso;
        //            aprb.titulo = titulo;
        //            aprb.codigoEmpleado = codigoEmpleado;
        //            aprb.usuario = usuario;
        //            aprb.puesto = puesto;
        //            aprb.fechaNotificacion = fechaNotificacion;
        //            aprb.fechaAccion = fechaAccion;
        //            aprb.accion = accion;
        //            aprb.comentario = coment;
        //            aprbnes.Add(aprb);
        //        }
        //    }
        //    else if (pars == "Save" && (titulo == "" && codigo == ""))
        //    {
        //        xgrdAprobaciones.JSProperties["cpAlertMessage"] = "SelectOne";
        //    }

        //    if (pars == "Delete")
        //    {
        //        xgrdAprobaciones.DataSource = null;
        //        aprbnes.Clear();
        //    }
        //    else
        //    {
        //        if (pars != "Save")
        //        {
        //            var Valores = e.Parameters;
        //            string[] data = Valores.Split(',');

        //            foreach (string d in data)
        //            {
        //                string valor = d.Replace("chk", "");
        //                string[] datos = valor.Split('-');
        //                string idaprb = datos[0];
        //                string folio = datos[1];
        //                aprbnes = aprbnes.FindAll(p => p.codigoAprobaciones != folio);
        //            }
        //        }

        //        xgrdAprobaciones.DataSource = aprbnes;
        //    }
        //    xgrdAprobaciones.DataBind();
        //}

        //protected void xgrdAprobaciones_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        //{
        //    if (e.DataColumn.Name == "CheckID")
        //    {
        //        var id = e.GetValue("AprobacionesID").ToString() + "-" + e.GetValue("codigoAprobaciones").ToString();

        //        e.Cell.Text = string.Format("<input type='checkbox' class='chkAprb' id='chk{0}'>", id);
        //    }
        //}

        protected void ASPxCallbackPanel1_Callback(object sender, CallbackEventArgsBase e)
        {
            var param = e.Parameter;
            var pS = param.Split(',');
            string CodigodPuestoSelected = "";

            if (pS.Length > 0)
            {
                if (pS[0] == "filterPuesto")
                {
                    CodigodPuestoSelected = pS[1];
                    var BEmpleado = new EmpleadosDa();
                    //cmbEmpleadoAdd.TextField = "NombreCompleto";
                    //cmbEmpleadoAdd.ValueField = "EmpleadoId";
                    //cmbEmpleadoAdd.DataSource = BEmpleado.GetCombo(CodigodPuestoSelected);
                    //cmbEmpleadoAdd.DataBind();
                }
                if (pS[0] == "Limpiar")
                {
                    //limpiarModalAprnes();
                }
            }
            else
            {
                //ASPxCallbackPanel1.JSProperties["cpAlertMessage"] = "errror";
            }
        }

        protected void xgrdTipoArticuloMDL_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            //xgrdTipoArticuloMDL.JSProperties["cpAlertMessage"] = string.Empty;
            //var pars = e.Parameters;

            //var Valores = e.Parameters;
            //string[] data = Valores.Split(',');

            //residuos.Clear();
            //foreach (string d in data)
            //{
            //    string valor = d.Replace("chk", "");
            //    string[] datos = valor.Split('-');
            //    string codigo = datos[0];
            //    List<Residuos> t = tResiduos.FindAll(p => p.CodigoResiduo == codigo);
            //    foreach (Residuos item in t)
            //    {
            //        List<_Residuos> t2 = residuos.FindAll(p => p.CodigoResiduo == item.CodigoResiduo);
            //        if (t2.Count == 0)
            //        {
            //            _Residuos n = new _Residuos();
            //            //n.ctrlPTipoArticuloID = 0;
            //            //n.noDocumento = "";
            //            //n.codigoTipoArticulo = item.CodigoResiduo;
            //            //n.tipoArticulo = item.Nombre;
            //            //n.M = item.Clasificaciones;
            //            //n.N = item.CodigoTipoManifiesto;
            //            //n.comentarios = item.CodigoGrupo;

            //            n.ResiduoId = 0;
            //            n.NoDocumento = "";
            //            n.CodigoResiduo = item.CodigoResiduo;
            //            n.Nombre = item.Nombre;
            //            n.Clasificaciones = item.Clasificaciones;
            //            n.CodigoTipoManifiesto = item.CodigoTipoManifiesto;
            //            n.TipoManifiesto = item.TipoManifiesto;
            //            n.CodigoGrupo = item.CodigoGrupo;
            //            n.Grupo = item.Grupo;
            //            n.ValorizableConBeneficio = item.ValorizableConBeneficio;
            //            n.ValorizableConGasto = item.ValorizableConGasto;
            //            n.Tipo = item.Tipo;
            //            residuos.Add(n);
            //        }
            //    }
            //}

            //xgrdTipoArticuloMDL.JSProperties["cpAlertMessage"] = "Add";
        }

        protected void xgrdTipoArticuloMDL_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("CodigoResiduo").ToString();
                //bool rel = false;
                //List<_tipoArticulo> tipos = tiposArticulo.FindAll(item => item.codigoTipoArticulo == id);
                //if (tipos.Count > 0)
                //{
                //    rel = true;
                //}

                //if (rel)
                //{
                    e.Cell.Text = string.Format("<input type='checkbox' class='chkArtMDL' id='chk{0}' checked>", id);
                //}
                //else
                //{
                //    e.Cell.Text = string.Format("<input type='checkbox' class='chkArtMDL' id='chk{0}'>", id);
                //}
            }
        }

        protected void xgrdMttoMDL_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void xgrdMttoMDL_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {

        }

        protected void xgrdAlmacenMDL_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void xgrdAlmacenMDL_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {

        }

        protected void cbChangeEmpresas_Callback(object source, CallbackEventArgs e)
        {
            var parametros = e.Parameter;
            var valores = parametros.Split(';');
            string codigoEmpresa = valores[0].ToString();
            string tipo = valores[1].ToString();

            //Obtenemos la descripcion, responsables y planta del job
            var DAEmpresas = new EmpresasDa();
            var list = DAEmpresas.GetCatalog(codigoEmpresa, "", true);

            string cp = string.Empty;
            string calle = string.Empty;
            string noInterior = string.Empty;
            string noExterior = string.Empty;
            string colonia = string.Empty;
            string municipio = string.Empty;
            string estado = string.Empty;
            string telefono = string.Empty;
            string eMail = string.Empty;
            
            cp = list[0].CodigoPostal;
            calle = list[0].Calle;
            noInterior = list[0].NoInterior;
            noExterior = list[0].NoExterior;
            colonia = list[0].Colonia;
            municipio = list[0].Municipio;
            estado = list[0].Estado;
            telefono = list[0].Telefono;
            
            cbChangeEmpresas.JSProperties["cpAlertMessage"] = tipo + ";" + cp + ";" + calle + ";" + noInterior + ";" + noExterior + ";" + colonia + ";" + municipio + ";" + estado + ";" + telefono;

        }

        protected void btnImprimir_Click(object sender, ImageClickEventArgs e)
        {
            string NoDocumento = lblNoDocumento.Text;
            string Estatus = "0016";
            string strScript;

            var BManifiesto = new Manifiestoda();
            var regreso = BManifiesto.UpdManifiestoEstatus(NoDocumento, Estatus, LoginInfo.CurrentUsuario.UsuarioId.ToString());
            if (regreso > 0)
            {
                refreshData();
                ltlSts.Text = "<span id='spanStatus' class='alert btn-info docEstatus'><i class='glyphicon glyphicon-eye-open' style='padding-right:5px;'></i>" + "Manifiesto Impreso" + "</span><span style='position: absolute; left: 250px; color:#FBFBFB;padding:2px 0px;'>:Manifiesto Impreso</span>";
                btnSave1.Style.Add("display", "none");
                btnImprimir2.Style.Add("display", "none");
                btnImprimirFisico.Style.Add("display", "none");
                btnCompletar1.Style.Add("display", "none");

                strScript = "swal('Information', 'The Doc. has been success updated!', 'success');";
            }
            else
            {
                strScript = "swal('Information', 'There was an error updating the product!', 'error');";
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdateSucces", strScript, true);
            return;
        }

        protected void btnCompletar_Click(object sender, ImageClickEventArgs e)
        {            

            string NoDocumento = lblNoDocumento.Text;
            string Estatus = "0018";
            string strScript;

            var BManifiesto = new Manifiestoda();
            var regreso = BManifiesto.UpdManifiestoEstatus(NoDocumento, Estatus, LoginInfo.CurrentUsuario.UsuarioId.ToString());
            if (regreso > 0)
            {
                ltlSts.Text = "<span id='spanStatus' class='alert btn-info docEstatus'><i class='glyphicon glyphicon-lock' style='padding-right:5px;'></i>" + "Pendiente por Documentación" + "</span><span style='position: absolute; left: 250px; color:#FBFBFB;padding:2px 0px;'>:Manifiesto Pendiente por Documentacion</span>";
                btnSave1.Style.Add("display", "none");
                btnImprimir2.Style.Add("display", "none");
                btnImprimirFisico.Style.Add("display", "none");
                btnCompletar1.Style.Add("display", "none");
                strScript = "swal('Information', 'The Doc. has been success updated!', 'success');";
            }
            else
            {
                strScript = "swal('Information', 'There was an error updating the product!', 'error');";
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdateSucces", strScript, true);
            return;


        }

        protected void btnImprimirFisico_Click(object sender, ImageClickEventArgs e)
        {
                       
        }
    }
}