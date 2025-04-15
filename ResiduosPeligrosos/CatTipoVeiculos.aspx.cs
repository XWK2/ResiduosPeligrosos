using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ResiduosPeligrosos.dataAccess;
using ResiduosPeligrosos.Entity;

namespace ResiduosPeligrosos
{
    public partial class CatTipoVeiculos : BasePage
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
            ASPxTextBox xtxtDescripcion = ASPxNavBar2.Groups[0].FindControl("xtxtDescripcion") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BTipoVehiculo = new TiposVeiculosDa();
            var oList = BTipoVehiculo.GetCatalog(xtxtCodigo.Text.Trim(), xtxtDescripcion.Text.Trim(), chkActive.Checked);
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
            var veiculoId = int.Parse(e.Keys[0].ToString());

            try
            {
                var BTipoVehiculo = new TiposVeiculosDa();
                var res = BTipoVehiculo.DelTipoVehiculo(LoginInfo.CurrentUsuario.UsuarioId, veiculoId);
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
            int PlanID = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Tipo = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtTipoEdit")).Text.Replace("/", "ñ|ñ");

            string Placas = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtPlacas")).Text;
            string Rutas = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtRutas")).Text;
            string Punto = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtPuntoProtesta")).Text;
            decimal pesoBruto = Convert.ToDecimal(((ASPxSpinEdit)xgrdType.FindEditFormTemplateControl("xtxtPesoBruto")).Text);


            try
            {
                var BTipoVehiculo = new TiposVeiculosDa();
                var res = BTipoVehiculo.UpdTipoVehiculo(LoginInfo.CurrentUsuario.UsuarioId, PlanID, Codigo, Tipo, Placas, Rutas, Punto, pesoBruto);
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
            string Tipo = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtTipoEdit")).Text.Replace("/", "ñ|ñ");

            string Placas = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtPlacas")).Text;
            string Rutas = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtRutas")).Text;
            string Punto = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtPuntoProtesta")).Text;
            decimal pesoBruto = Convert.ToDecimal(((ASPxSpinEdit)xgrdType.FindEditFormTemplateControl("xtxtPesoBruto")).Text);

            try
            {
                var BTipoVehiculo = new TiposVeiculosDa();
                var res = BTipoVehiculo.InsTipoVehiculo(LoginInfo.CurrentUsuario.UsuarioId, Codigo, Tipo, Placas, Rutas, Punto, pesoBruto);
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
            string Tipo = ((ASPxTextBox)xgrdType.FindEditFormTemplateControl("xtxtTipoEdit")).Text;

            var veiculoId = 0;

            if (!e.IsNewRow)
                veiculoId = (int)e.Keys[0];
            try
            {
                var BTipoVehiculo = new TiposVeiculosDa();
                var res = BTipoVehiculo.ValTipoVehiculo(veiculoId, Codigo, Tipo);
                if (res == 1)
                    e.RowError = "A Vehicle Type with the same key or name already exists!";
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
                var id = e.GetValue("veiculoId");

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
                var BTipoVehiculo = new TiposVeiculosDa();
                var res = BTipoVehiculo.DelPlanSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores, chkActive.Checked);
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
                var BTipoVehiculo = new TiposVeiculosDa();
                var res = BTipoVehiculo.DelPlanAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
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
    }
}