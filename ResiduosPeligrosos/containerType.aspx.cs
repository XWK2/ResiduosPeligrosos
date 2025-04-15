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
    public partial class containerType : BasePage
    {
        private void ApplyLayout()
        {
            xgrdType.BeginUpdate();
            try
            {
                xgrdType.ClearSort();
            }
            finally
            {
                xgrdType.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BTipoEnvase = new TiposEnvaseDa();
            var oList = BTipoEnvase.GetCatalog(xtxtCodigo.Text.Trim(),  chkActive.Checked);
            xgrdType.DataSource = oList;
            xgrdType.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdType.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdType_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }

        protected void xgrdType_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            var tipoEnvaseID = int.Parse(e.Keys[0].ToString());

            try
            {
                var BTipoEnvase = new TiposEnvaseDa();
                var res = BTipoEnvase.DelTipoEnvase(LoginInfo.CurrentUsuario.UsuarioId, tipoEnvaseID);
                if (res == 1)
                    xgrdType.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdType.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdType.JSProperties["cpAlertMessage"] = ex.Message;
            }
            e.Cancel = true;
        }

        protected void xgrdType_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int tipoEnvaseID = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            decimal capicidad = Convert.ToDecimal(((ASPxSpinEdit)xgrdType.FindEditFormTemplateControl("xtxtCapacidad")).Value);
            string Material = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtMaterial")).Text.Replace("/", "ñ|ñ");
            decimal peso = Convert.ToDecimal(((ASPxSpinEdit)xgrdType.FindEditFormTemplateControl("xtxtWeight")).Value);

            try
            {
                var BTipoEnvase = new TiposEnvaseDa();
                var res = BTipoEnvase.UpdTipoEnvase(LoginInfo.CurrentUsuario.UsuarioId, tipoEnvaseID, Codigo, capicidad, Material, peso);
                if (res == 1)
                    xgrdType.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdType.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdType.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdType.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdType_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            decimal capicidad = Convert.ToDecimal(((ASPxSpinEdit)xgrdType.FindEditFormTemplateControl("xtxtCapacidad")).Value);
            string Material = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtMaterial")).Text.Replace("/", "ñ|ñ");
            decimal peso = Convert.ToDecimal(((ASPxSpinEdit)xgrdType.FindEditFormTemplateControl("xtxtWeight")).Value);

            try
            {
                var BTipoEnvase = new TiposEnvaseDa();
                var res = BTipoEnvase.InsTipoEnvase(LoginInfo.CurrentUsuario.UsuarioId, Codigo, capicidad, Material, peso);
                if (res == 1)
                    xgrdType.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdType.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdType.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdType.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdType_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;

            var tipoEnvaseID = 0;

            if (!e.IsNewRow)
                tipoEnvaseID = (int)e.Keys[0];
            try
            {
                var BTipoEnvase = new TiposEnvaseDa();
                var res = BTipoEnvase.ValTipoEnvase(tipoEnvaseID, Codigo);
                if (res == 1)
                    e.RowError = "A Container Type with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdType_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("tipoEnvaseID");

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
                var BTipoEnvase = new TiposEnvaseDa();
                var res = BTipoEnvase.DelTipoEnvaseSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdType.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdType.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdType.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var BTipoEnvase = new TiposEnvaseDa();
                var res = BTipoEnvase.DelTipoEnvaseAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdType.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdType.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdType.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }

        protected void xgrdType_HtmlEditFormCreated(object sender, ASPxGridViewEditFormEventArgs e)
        {
           

        }
                
    }
}

