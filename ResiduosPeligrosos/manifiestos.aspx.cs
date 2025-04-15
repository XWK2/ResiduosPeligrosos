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


namespace ResiduosPeligrosos
{
    public partial class manifiestos : BasePage
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
            xgrdProds.BeginUpdate();
            try
            {
                xgrdProds.ClearSort();
            }
            finally
            {
                xgrdProds.EndUpdate();
            }
        }

        public string sManifiestoId
        {
            get { return (string)Session["sManifiestoId"]; }
            set { Session["sManifiestoId"] = value; }
        }
               
        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdProds.JSProperties["cpAlertMessage"] = string.Empty;
            
            if (!IsPostBack)
            {
                Session.Remove("ManifiestoId");
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                AllowBound = false;

                DateTime fActual = new DateTime();
                fActual = DateTime.Now;
                ASPxDateEdit xDateFechaFin = ASPxNavBar2.Groups[0].FindControl("xDateFechaFin") as ASPxDateEdit;
                ASPxDateEdit xDateFechaIni = ASPxNavBar2.Groups[0].FindControl("xDateFechaIni") as ASPxDateEdit;
                xDateFechaFin.Date = fActual;
                xDateFechaIni.Date = fActual.AddDays(-30);
                // xDateFechaIni.Date = fActual.AddDays(-200); //LHH solo pruebas.

                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;

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

                //Tipo Residuo
                var DATR = new GruposDa();
                List<Grupos> oListGrupos = new List<Grupos>();
                var itemG = new Grupos();
                itemG.codigo = "Todos";
                itemG.codigoyNombre = "Todos";
                oListGrupos.Add(itemG);

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
            }            
          
            fillGrid();
        }

        public void fillGrid()
        {
            xgrdProds.DetailRows.CollapseAllRows();

            ASPxTextBox xtxtFolio = ASPxNavBar2.Groups[0].FindControl("xtxtFolio") as ASPxTextBox;
            ASPxDateEdit xDateFechaFin = ASPxNavBar2.Groups[0].FindControl("xDateFechaFin") as ASPxDateEdit;
            ASPxDateEdit xDateFechaIni = ASPxNavBar2.Groups[0].FindControl("xDateFechaIni") as ASPxDateEdit;
            ASPxComboBox cmbTipoManifiesto = ASPxNavBar2.Groups[0].FindControl("cmbTipoManifiesto") as ASPxComboBox;
            ASPxComboBox cmbTipoResiduoEdit = ASPxNavBar2.Groups[0].FindControl("cmbTipoResiduoEdit") as ASPxComboBox;
            //cmbTipoResiduoEdit.SelectedItem.Value.ToString();

            var BManifiesto = new Manifiestoda();
            var oListProd = BManifiesto.GetManifiestos(xDateFechaIni.Text, xDateFechaFin.Text, xtxtFolio.Text, cmbTipoManifiesto.SelectedItem.Value.ToString(), cmbTipoResiduoEdit.SelectedItem.Value.ToString());
            xgrdProds.DataSource = oListProd;
            xgrdProds.DataBind();
        }

        protected void xgrdProds_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("ManifiestoId");
                sManifiestoId = e.GetValue("ManifiestoId").ToString();
                e.Cell.Text = string.Format("<input type='checkbox' class='chk' id='chk{0}'>", id);
            }

            if (e.DataColumn.FieldName == "fecha")
            {
                e.Cell.Text = e.GetValue("fecha").ToString().Substring(0, 10);
            }

            //if (e.DataColumn.FieldName == "sstatus")
            //{
            //    string sstatus = e.GetValue("sstatus").ToString();

            //    switch (sstatus)
            //    {
            //        case "Open":
            //        case "Pending to approve":
            //        case "Waiting Quote":
            //        case "Read":
            //            e.Cell.Style.Add("color", "#0099ff");
            //            break;
            //        case "Cancelled":
            //        case "Rejected":
            //            e.Cell.Style.Add("color", "#ff3300");
            //            break;
            //        case "Quote Done":
            //        case "Done Quote":
            //        case "Assigned":
            //            e.Cell.Style.Add("color", "#009933");
            //            break;
            //    }

            //}
            //if (e.DataColumn.Name == "sstatus")
            //{
            //    string sstatus = e.GetValue("sstatus").ToString();
            //    string background = "background-color:";
            //    switch (sstatus)
            //    {
            //        case "Open":
            //        case "Pending to approve":
            //        case "Waiting Quote":
            //        case "Read":
            //            background += "#0099ff";
            //            break;
            //        case "Cancelled":
            //        case "Rejected":
            //            background += "#ff3300";
            //            break;
            //        case "Quote Done":
            //        case "Done Quote":
            //        case "Assigned":
            //            background += "#009933";
            //            break;
            //    }
            //    e.Cell.Text = "<span class='dot' style='" + background + "'></span>";
            //}

            if (e.DataColumn.FieldName == "Actions")
            {
                if (e.GetValue("Actions").ToString() != "")
                {
                    sManifiestoId = e.GetValue("ManifiestoId").ToString();
                    sManifiestoId = utilities.Encryption.EncryptURL(sManifiestoId.ToString());
                    string sHTML = "";
                    sHTML += string.Format("<a href='{0}'> <img src='Assets/images/layout_edit.png'></a>", "manifiestos_det.aspx?sc=" + "rmc," + sManifiestoId);
                    e.Cell.Text = sHTML;
                }
            }
        }

        protected void xgrdProds_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
        {
            if (e.Expanded)
            {
                int indx = e.VisibleIndex;
                xgrdProds.DetailRows.CollapseAllRows();
                xgrdProds.DetailRows.ExpandRow(indx);

                string manifiestoId = string.Empty;
                manifiestoId = xgrdProds.GetRowValues(indx, new string[] { "ManifiestoId" }).ToString();

                var DA = new ContainerDetailsDa();
                var oListD = DA.GetContainerDetailsxManifiestoId(manifiestoId);
                ASPxGridView xgrdDetalle = (ASPxGridView)xgrdProds.FindDetailRowTemplateControl(indx, "xgrdDetalle");
                xgrdDetalle.DataSource = oListD;
                xgrdDetalle.DataBind();
            }
        }

        protected void CallbackPanelDisable_Callback(object sender, CallbackEventArgsBase e)
        {
        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
        }

        protected void imgNew_Click(object sender, ImageClickEventArgs e)
        {
            Session["ManifiestoId"] = 0;
            Response.Redirect("manifiestos_det.aspx?sc=");
        }

        protected void imgEditar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imgEditar = (ImageButton)sender;
            string arguments = imgEditar.CommandArgument;
            Session["ManifiestoId"] = arguments;
            Response.Redirect("manifiestos_det.aspx?sc=");
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