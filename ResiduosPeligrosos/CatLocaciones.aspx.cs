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
    public partial class CatLocaciones : BasePage
    {
        private void ApplyLayout()
        {
            xgrdLocaciones.BeginUpdate();
            try
            {
                xgrdLocaciones.ClearSort();
            }
            finally
            {
                xgrdLocaciones.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BLocaciones = new LocacionesDa();
            var oList = BLocaciones.GetCatalog(xtxtCodigo.Text.Trim(), chkActive.Checked);
            xgrdLocaciones.DataSource = oList;
            xgrdLocaciones.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdLocaciones.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdLocaciones_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }

        protected void xgrdLocaciones_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            var locacionId = int.Parse(e.Keys[0].ToString());

            try
            {
                var BLocaciones = new LocacionesDa();
                var res = BLocaciones.DelLocaciones(LoginInfo.CurrentUsuario.UsuarioId, locacionId);
                if (res == 1)
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdLocaciones.JSProperties["cpAlertMessage"] = ex.Message;
            }
            e.Cancel = true;
        }

        protected void xgrdLocaciones_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int locacionId = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdLocaciones.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string nombreLocacion = ((ASPxTextBox)xgrdLocaciones.FindEditFormTemplateControl("xtxtNombreLocacionEdit")).Text.Replace("/", "ñ|ñ");
            string codigoAlmacen = ((ASPxComboBox)xgrdLocaciones.FindEditFormTemplateControl("cmbAlmacen")).SelectedItem.Value.ToString();

            try
            {
                var BLocaciones = new LocacionesDa();
                var res = BLocaciones.UpdLocaciones(LoginInfo.CurrentUsuario.UsuarioId, locacionId, Codigo, nombreLocacion, codigoAlmacen);
                if (res == 1)
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdLocaciones.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdLocaciones.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdLocaciones_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdLocaciones.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string nombreLocacion = ((ASPxTextBox)xgrdLocaciones.FindEditFormTemplateControl("xtxtNombreLocacionEdit")).Text.Replace("/", "ñ|ñ");
            string codigoAlmacen = ((ASPxComboBox)xgrdLocaciones.FindEditFormTemplateControl("cmbAlmacen")).SelectedItem.Value.ToString();

            try
            {
                var BLocaciones = new LocacionesDa();
                var res = BLocaciones.InsLocaciones(LoginInfo.CurrentUsuario.UsuarioId, Codigo, nombreLocacion, codigoAlmacen);
                if (res == 1)
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdLocaciones.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdLocaciones.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdLocaciones_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdLocaciones.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;

            var locacionId = 0;

            if (!e.IsNewRow)
                locacionId = (int)e.Keys[0];
            try
            {
                var BLocaciones = new LocacionesDa();
                var res = BLocaciones.ValLocaciones(locacionId, Codigo);
                if (res == 1)
                    e.RowError = "A Warehouse with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdLocaciones_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("locacionId");

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
                var BLocaciones = new LocacionesDa();
                var res = BLocaciones.DelLocacionesSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdLocaciones.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var BLocaciones = new LocacionesDa();
                var res = BLocaciones.DelLocacionesAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdLocaciones.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdLocaciones.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }

        protected void xgrdLocaciones_HtmlEditFormCreated(object sender, ASPxGridViewEditFormEventArgs e)
        {
            ASPxComboBox cmbAlmacen = (ASPxComboBox)xgrdLocaciones.FindEditFormTemplateControl("cmbAlmacen");

            var BAlmacen = new AlmacenDa();
            var oList = BAlmacen.GetCombo();
            cmbAlmacen.ValueField = "Codigo";
            cmbAlmacen.TextField = "CodigoYNombre";
            cmbAlmacen.DataSource = oList;
            cmbAlmacen.DataBind();
        }

        protected void cmbAlmacen_DataBound(object sender, EventArgs e)
        {
            ASPxComboBox cmbAlmacen = (ASPxComboBox)xgrdLocaciones.FindEditFormTemplateControl("cmbAlmacen");
            HtmlInputHidden hdnAlmacen = (HtmlInputHidden)xgrdLocaciones.FindEditFormTemplateControl("hdnAlmacen");


            ListEditItem oItem = cmbAlmacen.Items.FindByValue(hdnAlmacen.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
        }
    }
}