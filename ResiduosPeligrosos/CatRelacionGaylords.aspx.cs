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

namespace ResiduosPeligrosos
{
    public partial class CatRelacionGaylords : BasePage
    {
        private void ApplyLayout()
        {
            xgrdRelacion.BeginUpdate();
            try
            {
                xgrdRelacion.ClearSort();
            }
            finally
            {
                xgrdRelacion.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            //ASPxTextBox xtxtCodigoTipo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigoTipo") as ASPxTextBox;
            ASPxComboBox cmbTipo = ((ASPxComboBox)ASPxNavBar2.Groups[0].FindControl("cmbTipo"));
            string Tipo = "";
            if (cmbTipo.SelectedIndex > 0)
            {
                Tipo = cmbTipo.Value.ToString();
            }
                

            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BA = new RelacionGaylordsDa();
            var oList = BA.GetRelacionGaylords(xtxtCodigo.Text.Trim(), Tipo, chkActive.Checked);
            xgrdRelacion.DataSource = oList;
            xgrdRelacion.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdRelacion.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;

                var DAEnvase = new TiposEnvaseDa();
                var cmbTipo = ((ASPxComboBox)ASPxNavBar2.Groups[0].FindControl("cmbTipo"));
                cmbTipo.TextField = "material";
                cmbTipo.ValueField = "codigo";
                cmbTipo.DataSource = DAEnvase.GetCombo();
                cmbTipo.DataBind();
                                
            }
            fillGrid();
        }

        protected void xgrdRelacion_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }
        
        protected void xgrdRelacion_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int RelacionId = int.Parse(e.Keys[0].ToString());
            string CodigoParte = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbParte")).SelectedItem.Value.ToString();
            string CodigoResiduo = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbResiduo")).SelectedItem.Value.ToString();
            string CodigoTipoEnvase = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbTipoEnvase")).SelectedItem.Value.ToString();
            string numParteImportExport = ((ASPxTextBox)xgrdRelacion.FindEditFormTemplateControl("xtxtnumParteImportExportEdit")).Text;
            string stiempoExpiracion = ((ASPxSpinEdit)xgrdRelacion.FindEditFormTemplateControl("xSpinTiempoExpiracion")).Text;
            ASPxRadioButtonList expira = ((ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblExpira"));
            ASPxRadioButtonList venta = ((ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblVenta"));
            ASPxRadioButtonList etiqueta = ((ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblEtiqueta"));


            int tiempoExpiracion = 0;
            if (stiempoExpiracion != "")
            {
                tiempoExpiracion = int.Parse(stiempoExpiracion);
            }          

            try
            {
                var BA = new RelacionGaylordsDa();
                var res = BA.UpdateRelacionGaylords(RelacionId, CodigoParte, numParteImportExport, CodigoResiduo, CodigoTipoEnvase, expira.Value.ToString(), tiempoExpiracion, venta.Value.ToString(), etiqueta.Value.ToString(), LoginInfo.CurrentUsuario.UsuarioId);
                if (res == 1)
                    xgrdRelacion.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdRelacion.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdRelacion.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdRelacion.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdRelacion_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string CodigoParte = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbParte")).SelectedItem.Value.ToString();
            string CodigoResiduo = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbResiduo")).SelectedItem.Value.ToString();
            string CodigoTipoEnvase = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbTipoEnvase")).SelectedItem.Value.ToString();
            string numParteImportExport = ((ASPxTextBox)xgrdRelacion.FindEditFormTemplateControl("xtxtnumParteImportExportEdit")).Text;
            string stiempoExpiracion = ((ASPxSpinEdit)xgrdRelacion.FindEditFormTemplateControl("xSpinTiempoExpiracion")).Text;
            ASPxRadioButtonList expira = ((ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblExpira"));
            ASPxRadioButtonList venta = ((ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblVenta"));
            ASPxRadioButtonList etiqueta = ((ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblEtiqueta"));

            int tiempoExpiracion = 0;
            if (stiempoExpiracion != "")
            {
                tiempoExpiracion = int.Parse(stiempoExpiracion);
            }
         
            try
            {
                var BA = new RelacionGaylordsDa();
                var res = BA.InsertRelacionGaylords(CodigoParte, numParteImportExport, CodigoResiduo, CodigoTipoEnvase, expira.Value.ToString(), tiempoExpiracion, venta.Value.ToString(), etiqueta.Value.ToString(), LoginInfo.CurrentUsuario.UsuarioId);
                if (res == 1)
                    xgrdRelacion.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdRelacion.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdRelacion.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdRelacion.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdRelacion_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string CodigoParte = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbParte")).SelectedItem.Value.ToString();
            string CodigoResiduo = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbResiduo")).SelectedItem.Value.ToString();
            string CodigoTipoEnvase = ((ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbTipoEnvase")).SelectedItem.Value.ToString();
            string numParteImportExport = ((ASPxTextBox)xgrdRelacion.FindEditFormTemplateControl("xtxtnumParteImportExportEdit")).Text;

            int RelacionId = 0;

            if (!e.IsNewRow)
                RelacionId = (int)e.Keys[0];
            try
            {
                var DA = new RelacionGaylordsDa();
                var res = DA.ValRelacionGaylords(RelacionId, CodigoParte, numParteImportExport, CodigoResiduo, CodigoTipoEnvase);
                if (res == 1)
                    e.RowError = "A Record with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdRelacion_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("RelacionId");

                e.Cell.Text = string.Format("<input type='checkbox' class='chk' id='chk{0}'>", id);
            }
        }

        protected void CallbackPanelDisable_Callback(object sender, CallbackEventArgsBase e)
        {
            var Valores = e.Parameter;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //Enviamos a la base de datos los Valores y desabilitamos con un update masivo.
            try
            {
                var DA = new RelacionGaylordsDa();
                var res = DA.DelRelacionGaylordsSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdRelacion.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdRelacion.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdRelacion.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var DA = new RelacionGaylordsDa();
                var res = DA.DelRelacionGaylordsAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdRelacion.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdRelacion.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdRelacion.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }

        protected void xgrdRelacion_HtmlEditFormCreated(object sender, ASPxGridViewEditFormEventArgs e)
        {
            ASPxComboBox cmbParte = (ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbParte");
            var DaM = new MaterialesDa();
            var oListM = DaM.GetCombo();
            cmbParte.ValueField = "Codigo";
            cmbParte.TextField = "CodigoYNombre";
            cmbParte.DataSource = oListM;
            cmbParte.DataBind();

            ASPxComboBox cmbResiduo = (ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbResiduo");
            var DATM = new ResiduosDa();
            var oListTM = DATM.GetCombo();
            cmbResiduo.ValueField = "CodigoResiduo";
            cmbResiduo.TextField = "Nombre";
            cmbResiduo.DataSource = oListTM;
            cmbResiduo.DataBind();

            ASPxComboBox cmbTipoEnvase = (ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbTipoEnvase");
            var DATE = new TiposEnvaseDa();
            var oListTE = DATE.GetCombo();
            cmbTipoEnvase.ValueField = "Codigo";
            cmbTipoEnvase.TextField = "CodigoYNombre";
            cmbTipoEnvase.DataSource = oListTE;
            cmbTipoEnvase.DataBind();

            ASPxRadioButtonList rblExpira = (ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblExpira");
            ASPxRadioButtonList rblVenta = (ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblVenta");
            ASPxRadioButtonList rblEtiqueta = (ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblEtiqueta");

            List<Expira> lexp = new List<Expira>();
            Expira exp = new Expira();
            Expira exp2 = new Expira();
            exp.value = "si";
            exp.text = "Yes";
            exp2.value = "no";
            exp2.text = "No";
            lexp.Add(exp);
            lexp.Add(exp2);

            rblExpira.DataSource = lexp;
            rblExpira.DataBind();

            rblVenta.DataSource = lexp;
            rblVenta.DataBind();

            rblEtiqueta.DataSource = lexp;
            rblEtiqueta.DataBind();
        }

        protected void cmbParte_DataBound(object sender, EventArgs e)
        {
            ASPxComboBox cmbParte = (ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbParte");
            HtmlInputHidden hdnParte = (HtmlInputHidden)xgrdRelacion.FindEditFormTemplateControl("hdnParte");
            
            ListEditItem oItem = cmbParte.Items.FindByValue(hdnParte.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
        }

        protected void cmbResiduo_DataBound(object sender, EventArgs e)
        {
            ASPxComboBox cmbResiduo = (ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbResiduo");
            HtmlInputHidden hdnResiduo = (HtmlInputHidden)xgrdRelacion.FindEditFormTemplateControl("hdnResiduo");

            ListEditItem oItem = cmbResiduo.Items.FindByValue(hdnResiduo.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
        }

        protected void cmbTipoEnvase_DataBound(object sender, EventArgs e)
        {
            ASPxComboBox cmbTipoEnvase = (ASPxComboBox)xgrdRelacion.FindEditFormTemplateControl("cmbTipoEnvase");
            HtmlInputHidden hdnTipoEnvase = (HtmlInputHidden)xgrdRelacion.FindEditFormTemplateControl("hdnTipoEnvase");

            ListEditItem oItem = cmbTipoEnvase.Items.FindByValue(hdnTipoEnvase.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
        }

        protected void rblExpira_DataBound(object sender, EventArgs e)
        {
            ASPxRadioButtonList rblExpira = (ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblExpira");
            HtmlInputHidden hdnExpira = (HtmlInputHidden)xgrdRelacion.FindEditFormTemplateControl("hdnExpira");
                      
            ListEditItem oItem = rblExpira.Items.FindByValue(hdnExpira.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
            else
            {
                rblExpira.Value = "si";
            }
        }

        protected void rblVenta_DataBound(object sender, EventArgs e)
        {
            ASPxRadioButtonList rblVenta = (ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblVenta");
            HtmlInputHidden hdnVenta = (HtmlInputHidden)xgrdRelacion.FindEditFormTemplateControl("hdnVenta");

            ListEditItem oItem = rblVenta.Items.FindByValue(hdnVenta.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
            else
            {
                rblVenta.Value = "si";
            }
        }

        protected void rblEtiqueta_DataBound(object sender, EventArgs e)
        {
            ASPxRadioButtonList rblEtiqueta = (ASPxRadioButtonList)xgrdRelacion.FindEditFormTemplateControl("rblEtiqueta");
            HtmlInputHidden hdnEtiqueta = (HtmlInputHidden)xgrdRelacion.FindEditFormTemplateControl("hdnEtiqueta");

            ListEditItem oItem = rblEtiqueta.Items.FindByValue(hdnEtiqueta.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
            else
            {
                rblEtiqueta.Value = "si";
            }
        }
    }
}