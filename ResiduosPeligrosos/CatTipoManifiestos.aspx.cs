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
    public partial class CatTipoManifiestos : BasePage
    {
        private void ApplyLayout()
        {
            xgrdTipoManifiesto.BeginUpdate();
            try
            {
                xgrdTipoManifiesto.ClearSort();
            }
            finally
            {
                xgrdTipoManifiesto.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxTextBox xtxtDescripcion = ASPxNavBar2.Groups[0].FindControl("xtxtDescripcion") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BTipoManifiesto = new TipoManifiestoDa();
            var oListTipoManifiesto = BTipoManifiesto.GetCatalog(xtxtCodigo.Text.Trim(), xtxtDescripcion.Text.Trim(), chkActive.Checked);
            xgrdTipoManifiesto.DataSource = oListTipoManifiesto;
            xgrdTipoManifiesto.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdTipoManifiesto_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }

        protected void xgrdTipoManifiesto_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int TipoManifiestoId = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdTipoManifiesto.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdTipoManifiesto.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/", "ñ|ñ");
            string CodigoMaquina = ((ASPxComboBox)xgrdTipoManifiesto.FindEditFormTemplateControl("cmbTipoMaterialEdit")).Value.ToString();
            try
            {
                var BTipoManifiesto = new TipoManifiestoDa();
                var res = BTipoManifiesto.UpdTipoManifiesto(LoginInfo.CurrentUsuario.UsuarioId, TipoManifiestoId, Codigo, Nombre, CodigoMaquina);
                if (res == 1)
                    xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdTipoManifiesto.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdTipoManifiesto_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdTipoManifiesto.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdTipoManifiesto.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/", "ñ|ñ");
            string CodigoMaquina = ((ASPxComboBox)xgrdTipoManifiesto.FindEditFormTemplateControl("cmbTipoMaterialEdit")).Value.ToString();

            try
            {
                var BTipoManifiesto = new TipoManifiestoDa();
                var res = BTipoManifiesto.InsTipoManifiesto(LoginInfo.CurrentUsuario.UsuarioId, Codigo, Nombre, CodigoMaquina);
                if (res == 1)
                    xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdTipoManifiesto.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdTipoManifiesto_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdTipoManifiesto.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdTipoManifiesto.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/", "ñ|ñ");

            var TipoManifiestoId = 0;

            if (!e.IsNewRow)
                TipoManifiestoId = (int)e.Keys[0];
            try
            {
                var BTipoManifiesto = new TipoManifiestoDa();
                var res = BTipoManifiesto.ValTipoManifiesto(TipoManifiestoId, Codigo, Nombre);
                if (res == 1)
                    e.RowError = "A Subcategory1 with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdTipoManifiesto_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("TipoManifiestoId");

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
                var BTipoManifiesto = new TipoManifiestoDa();
                var res = BTipoManifiesto.DelTipoManifiestoSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var BTipoManifiesto = new TipoManifiestoDa();
                var res = BTipoManifiesto.DelTipoManifiestoAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdTipoManifiesto.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }

        protected void xgrdTipoManifiesto_HtmlEditFormCreated(object sender, ASPxGridViewEditFormEventArgs e)
        {
            var BTipoMaterial= new TipoMaterialDa();
            var cmbTipoMaterial = ((ASPxComboBox)xgrdTipoManifiesto.FindEditFormTemplateControl("cmbTipoMaterialEdit"));
            cmbTipoMaterial.TextField = "Nombre";
            cmbTipoMaterial.ValueField = "Codigo";
            cmbTipoMaterial.DataSource = BTipoMaterial.GetCombo();
            cmbTipoMaterial.DataBind();
        }

        protected void cmbTipoMaterialEdit_DataBound(object sender, EventArgs e)
        {
            string Codigo = ((HtmlInputHidden)xgrdTipoManifiesto.FindEditFormTemplateControl("hdnCodigoTipoMaterial")).Value;
            var cmbTipoMaterial = ((ASPxComboBox)xgrdTipoManifiesto.FindEditFormTemplateControl("cmbTipoMaterialEdit"));
            ListEditItem oItem = cmbTipoMaterial.Items.FindByValue(Codigo);
            if (oItem != null)
                oItem.Selected = true;
            else
                cmbTipoMaterial.SelectedIndex = 0;
        }
    }
}