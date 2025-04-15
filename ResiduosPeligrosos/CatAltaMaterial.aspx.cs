using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ResiduosPeligrosos.dataAccess;
using ResiduosPeligrosos.Entity;
using System.Web.UI.HtmlControls;
using System.Data;
using DevExpress.Spreadsheet;
using System.IO;
using DevExpress.XtraPrinting;
using ResiduosPeligrosos.utilities;

namespace ResiduosPeligrosos
{
    public partial class CatAltaMaterial : BasePage
    {
        public bool AllowBound
        {
            get
            {
                return (bool)Session["AllowBound"];
            }
            set
            {
                Session["AllowBound"] = value;
            }
        }
        private void ApplyLayout()
        {
            xgrdGaylords.BeginUpdate();
            try
            {
                xgrdGaylords.ClearSort();
            }
            finally
            {
                xgrdGaylords.EndUpdate();
            }
        }

        public string sManifiestoId
        {
            get { return (string)Session["sManifiestoId"]; }
            set { Session["sManifiestoId"] = value; }
        }

        public void fillGrid()
        {
            ASPxDateEdit xDateFechaFin = ASPxNavBar2.Groups[0].FindControl("xDateFechaFin") as ASPxDateEdit;
            ASPxDateEdit xDateFechaIni = ASPxNavBar2.Groups[0].FindControl("xDateFechaIni") as ASPxDateEdit;
            ASPxComboBox cmbAlmacen = ASPxNavBar2.Groups[0].FindControl("cmbAlmacen") as ASPxComboBox;
            ASPxComboBox cmbLocacion = ASPxNavBar2.Groups[0].FindControl("cmbLocacion") as ASPxComboBox;

            string valLocacion = "";
            if (cmbLocacion.SelectedItem != null)
            {
                valLocacion = cmbLocacion.SelectedItem.Value.ToString();
            }

            var DA = new AltaMaterialDa();
            var oListAM = DA.GetAltaMaterial(xDateFechaIni.Date.ToString("yyyyMMdd"), xDateFechaFin.Date.ToString("yyyyMMdd"), cmbAlmacen.SelectedItem.Value.ToString(), valLocacion);
            xgrdGaylords.DataSource = oListAM;
            xgrdGaylords.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdGaylords.JSProperties["cpAlertMessage"] = string.Empty;


            if (!IsPostBack)
            {
                Session.Remove("GaylordID");
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                AllowBound = false;

                DateTime fActual = new DateTime();
                fActual = DateTime.Now;
                ASPxDateEdit xDateFechaFin = ASPxNavBar2.Groups[0].FindControl("xDateFechaFin") as ASPxDateEdit;
                ASPxDateEdit xDateFechaIni = ASPxNavBar2.Groups[0].FindControl("xDateFechaIni") as ASPxDateEdit;
                xDateFechaFin.Date = fActual;
                xDateFechaIni.Date = fActual.AddDays(-30);

                ASPxComboBox cmbAlmacen = ASPxNavBar2.Groups[0].FindControl("cmbAlmacen") as ASPxComboBox;
                ASPxComboBox cmbLocacion = ASPxNavBar2.Groups[0].FindControl("cmbLocacion") as ASPxComboBox;

                // Almacen
                var DAA = new AlmacenDa();
                List<Almacen> oListAlmacen = new List<Almacen>();
                var itemA = new Almacen();
                itemA.Codigo = "Todos";
                itemA.CodigoYNombre = "Todos";
                oListAlmacen.Add(itemA);
                var listTM = DAA.GetCombo();
                oListAlmacen.AddRange(listTM);
                cmbAlmacen.TextField = "CodigoYNombre";
                cmbAlmacen.ValueField = "Codigo";
                cmbAlmacen.DataSource = oListAlmacen;
                cmbAlmacen.DataBind();

                if (cmbAlmacen.SelectedIndex == -1)
                {
                    cmbAlmacen.SelectedIndex = 0;
                }

                // Locacion
                var DAL = new LocacionesDa();
                List<Locaciones> oListLocaciones = new List<Locaciones>();
                var itemL = new Locaciones();
                itemL.Codigo = "Todos";
                itemL.CodigoYNombre = "Todos";
                oListLocaciones.Add(itemL);
                var listG = DAL.GetCmbLocacionbyalmacen(cmbAlmacen.SelectedItem.Value.ToString());
                oListLocaciones.AddRange(listG);
                cmbLocacion.TextField = "CodigoYNombre";
                cmbLocacion.ValueField = "Codigo";
                cmbLocacion.DataSource = oListLocaciones;
                cmbLocacion.DataBind();

              

                if (cmbLocacion.SelectedIndex == -1)
                {
                    cmbLocacion.SelectedIndex = 0;
                }

                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdGaylords_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
           
        }

        protected void xgrdGaylords_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            //if (e.Expanded)
            //{
            //    int indx = e.VisibleIndex;
            //    xgrdGaylords.DetailRows.CollapseAllRows();
            //    xgrdGaylords.DetailRows.ExpandRow(indx);

            //    string GaylordId = string.Empty;
            //    GaylordId = xgrdGaylords.GetRowValues(indx, new string[] { "contenedorID" }).ToString();

            //    var DA = new AltaMaterialDa();
            //    var oListD = DA.GetAltaMaterialxGaylordId(GaylordId);

            //    ASPxGridView xgrdDetalle = (ASPxGridView)xgrdGaylords.FindDetailRowTemplateControl(indx, "xgrdDetalle");
            //    xgrdDetalle.DataSource = oListD;
            //    xgrdDetalle.DataBind();
            //}
        }

        protected void CallbackPanelDisable_Callback(object sender, CallbackEventArgsBase e)
        {
            //string Valores = e.Parameter;
            //Valores = utilities.Encryption.EncryptURL(Valores);

            //ASPxComboBox cmbAlmacen = ASPxNavBar2.Groups[0].FindControl("cmbAlmacen") as ASPxComboBox;
            //ASPxComboBox cmbLocacion = ASPxNavBar2.Groups[0].FindControl("cmbLocacion") as ASPxComboBox;
            //string TipoManifiesto = cmbAlmacen.Value.ToString();
            //TipoManifiesto = utilities.Encryption.EncryptURL(TipoManifiesto);
            //string TipoResiduo = cmbLocacion.Value.ToString();
            //TipoResiduo = utilities.Encryption.EncryptURL(TipoResiduo);

            //CallbackPanelDisable.JSProperties["cpAlertMessage"] = "Envio" + "/" + Valores + "/" + TipoManifiesto + "/" + TipoResiduo;

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
        }

        protected void imgNew_Click(object sender, ImageClickEventArgs e)
        {
            //Session["ManifiestoId"] = 0;
            //Response.Redirect("manifiestos_det.aspx");
        }

        protected void imgEditar_Click(object sender, ImageClickEventArgs e)
        {
            //ImageButton imgEditar = (ImageButton)sender;
            //string arguments = imgEditar.CommandArgument;
            //Session["ManifiestoId"] = arguments;
            //Response.Redirect("manifiestos_det.aspx");
        }

        protected void cmbLocacion_Callback(object sender, CallbackEventArgsBase e)
        {
            var codigoTipoManifiesto = e.Parameter;
            ASPxComboBox cmbLocacion = ASPxNavBar2.Groups[0].FindControl("cmbLocacion") as ASPxComboBox;

            // Tipo Residuo
            var DA = new LocacionesDa();
            List<Locaciones> oListGrupos = new List<Locaciones>();

            var itemL = new Locaciones();
            itemL.Codigo = "Todos";
            itemL.CodigoYNombre = "Todos";
            oListGrupos.Add(itemL);

            var listG = DA.GetCmbLocacionbyalmacen(codigoTipoManifiesto);
            oListGrupos.AddRange(listG);
            cmbLocacion.TextField = "codigoyNombre";
            cmbLocacion.ValueField = "codigo";
            cmbLocacion.DataSource = oListGrupos;
            cmbLocacion.DataBind();

            if (oListGrupos.Count > 0)
            {
                if (cmbLocacion.SelectedIndex == -1)
                {
                    cmbLocacion.SelectedIndex = 0;
                }
            }
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            exportGrid.WriteXlsxToResponse();
        }
    }
}