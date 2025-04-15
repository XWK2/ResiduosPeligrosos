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
    public partial class GaylordDetails : BasePage
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
            ASPxComboBox cmbTipoManifiesto = ASPxNavBar2.Groups[0].FindControl("cmbTipoManifiesto") as ASPxComboBox;
            ASPxComboBox cmbTipoResiduoEdit = ASPxNavBar2.Groups[0].FindControl("cmbTipoResiduoEdit") as ASPxComboBox;

            var DA = new ContainerDetailsDa();
            var oListProd = DA.GetContainerDetails(xDateFechaIni.Date.ToString("yyyyMMdd"), xDateFechaFin.Date.ToString("yyyyMMdd"), cmbTipoManifiesto.SelectedItem.Value.ToString(), cmbTipoResiduoEdit.SelectedItem.Value.ToString());
            xgrdGaylords.DataSource = oListProd;
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

                ASPxComboBox cmbTipoManifiesto = ASPxNavBar2.Groups[0].FindControl("cmbTipoManifiesto") as ASPxComboBox;
                ASPxComboBox cmbTipoResiduoEdit = ASPxNavBar2.Groups[0].FindControl("cmbTipoResiduoEdit") as ASPxComboBox;

                // Tipo Manifiesto
                var DATM = new TipoManifiestoDa();
                List<TipoManifiesto> oListTipoManifiesto = new List<TipoManifiesto>();
                var itemTM = new TipoManifiesto();
                itemTM.Codigo = "Todos";
                itemTM.CodigoYNombre = "Todos";
                oListTipoManifiesto.Add(itemTM);
                var listTM = DATM.GetCombo();
                oListTipoManifiesto.AddRange(listTM);
                cmbTipoManifiesto.TextField = "CodigoYNombre";
                cmbTipoManifiesto.ValueField = "Codigo";
                cmbTipoManifiesto.DataSource = oListTipoManifiesto;
                cmbTipoManifiesto.DataBind();

                if (cmbTipoManifiesto.SelectedIndex == -1)
                {
                    cmbTipoManifiesto.SelectedIndex = 0;
                }

                // Tipo Residuo
                var DATR = new GruposDa();
                List<Grupos> oListGrupos = new List<Grupos>();
                var itemG = new Grupos();
                itemG.codigo = "Todos";
                itemG.codigoyNombre = "Todos";
                oListGrupos.Add(itemG);
                //var listG = DATR.GetCombo();
                var listG = DATR.GetCmbGruposbyTipoManifiesto(cmbTipoManifiesto.SelectedItem.Value.ToString(), true);
                oListGrupos.AddRange(listG);
                cmbTipoResiduoEdit.TextField = "codigoyNombre";
                cmbTipoResiduoEdit.ValueField = "codigo";
                cmbTipoResiduoEdit.DataSource = oListGrupos;
                cmbTipoResiduoEdit.DataBind();
                               

                if (cmbTipoResiduoEdit.SelectedIndex == -1)
                {
                    cmbTipoResiduoEdit.SelectedIndex = 0;
                }

                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdGaylords_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {          

            if (e.DataColumn.FieldName == "Actions")
            {
                if (e.GetValue("Actions").ToString() != "")
                {
                    sManifiestoId = e.GetValue("ManifiestoId").ToString();
                    if (sManifiestoId != "0")
                    {
                        sManifiestoId = utilities.Encryption.EncryptURL(sManifiestoId.ToString());
                        string sHTML = "";
                        sHTML += string.Format("<a href='{0}'> <img src='Assets/images/layout_edit.png'></a>", "manifiestos_det.aspx?sc=" + "rmc," + sManifiestoId);
                        e.Cell.Text = sHTML;
                    }
                    else {
                        string sHTML = "";
                        sHTML += string.Format("<a href='javascript:mensaje();'> <img src='Assets/images/layout_edit.png'></a>");
                        e.Cell.Text = sHTML;
                    }
                    
                }
            }
        }

        protected void xgrdGaylords_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            if (e.Expanded)
            {
                int indx = e.VisibleIndex;
                xgrdGaylords.DetailRows.CollapseAllRows();
                xgrdGaylords.DetailRows.ExpandRow(indx);

                string GaylordId = string.Empty;
                GaylordId = xgrdGaylords.GetRowValues(indx, new string[] { "contenedorID" }).ToString();

                var DA = new AltaMaterialDa();
                var oListD = DA.GetAltaMaterialxGaylordId(GaylordId);

                ASPxGridView xgrdDetalle = (ASPxGridView)xgrdGaylords.FindDetailRowTemplateControl(indx, "xgrdDetalle");
                xgrdDetalle.DataSource = oListD;
                xgrdDetalle.DataBind();
            }
        }

        protected void CallbackPanelDisable_Callback(object sender, CallbackEventArgsBase e)
        {
            string Valores = e.Parameter;
            Valores = utilities.Encryption.EncryptURL(Valores);

            ASPxComboBox cmbTipoManifiesto = ASPxNavBar2.Groups[0].FindControl("cmbTipoManifiesto") as ASPxComboBox;
            ASPxComboBox cmbTipoResiduoEdit = ASPxNavBar2.Groups[0].FindControl("cmbTipoResiduoEdit") as ASPxComboBox;
            string TipoManifiesto = cmbTipoManifiesto.Value.ToString();
            TipoManifiesto = utilities.Encryption.EncryptURL(TipoManifiesto);
            string TipoResiduo = cmbTipoResiduoEdit.Value.ToString();
            TipoResiduo = utilities.Encryption.EncryptURL(TipoResiduo);

            CallbackPanelDisable.JSProperties["cpAlertMessage"] = "Envio" + "/" + Valores + "/" + TipoManifiesto + "/" + TipoResiduo;

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
        }

        protected void imgNew_Click(object sender, ImageClickEventArgs e)
        {
            Session["ManifiestoId"] = 0;
            Response.Redirect("manifiestos_det.aspx");
        }

        protected void imgEditar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imgEditar = (ImageButton)sender;
            string arguments = imgEditar.CommandArgument;
            Session["ManifiestoId"] = arguments;
            Response.Redirect("manifiestos_det.aspx");
        }
        

        protected void cmbTipoResiduoEdit_Callback(object sender, CallbackEventArgsBase e)
        {
            var codigoTipoManifiesto = e.Parameter;

            ASPxComboBox cmbTipoResiduoEdit = ASPxNavBar2.Groups[0].FindControl("cmbTipoResiduoEdit") as ASPxComboBox;

            // Tipo Residuo
            var DATR = new GruposDa();
            List<Grupos> oListGrupos = new List<Grupos>();

            var itemG = new Grupos();
            itemG.codigo = "Todos";
            itemG.codigoyNombre = "Todos";
            oListGrupos.Add(itemG);

            var listG = DATR.GetCmbGruposbyTipoManifiesto(codigoTipoManifiesto, true);
            oListGrupos.AddRange(listG);
            cmbTipoResiduoEdit.TextField = "codigoyNombre";
            cmbTipoResiduoEdit.ValueField = "codigo";
            cmbTipoResiduoEdit.DataSource = oListGrupos;
            cmbTipoResiduoEdit.DataBind();

            if (oListGrupos.Count > 0)
            {
                if (cmbTipoResiduoEdit.SelectedIndex == -1)
                {
                    cmbTipoResiduoEdit.SelectedIndex = 0;
                }
            }
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            exportGrid.WriteXlsxToResponse();
        }
    }
}