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
    public partial class CatClasificacion : BasePage
    {
        private void ApplyLayout()
        {
            xgrdClasificacion.BeginUpdate();
            try
            {
                xgrdClasificacion.ClearSort();
            }
            finally
            {
                xgrdClasificacion.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxTextBox xtxtDescripcion = ASPxNavBar2.Groups[0].FindControl("xtxtDescripcion") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BClasificacion = new ClasificacionDa();
            var oListPosicion = BClasificacion.GetCatalog(xtxtCodigo.Text.Trim(), xtxtDescripcion.Text.Trim(), chkActive.Checked);
            xgrdClasificacion.DataSource = oListPosicion;
            xgrdClasificacion.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdClasificacion.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdClasificacion_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }
        

        protected void xgrdClasificacion_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int ClasificacionID = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdClasificacion.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdClasificacion.FindEditFormTemplateControl("xtxtNombreEdit")).Text;
            try
            {
                var BClasificacion = new ClasificacionDa();
                var res = BClasificacion.UpdClasificacion(LoginInfo.CurrentUsuario.UsuarioId, ClasificacionID, Codigo, Nombre);
                if (res == 1)
                    xgrdClasificacion.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdClasificacion.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdClasificacion.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdClasificacion.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdClasificacion_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdClasificacion.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdClasificacion.FindEditFormTemplateControl("xtxtNombreEdit")).Text;

            try
            {
                var BClasificacion = new ClasificacionDa();
                var res = BClasificacion.InsClasificacion(LoginInfo.CurrentUsuario.UsuarioId, Codigo, Nombre);
                if (res == 1)
                    xgrdClasificacion.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdClasificacion.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdClasificacion.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdClasificacion.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdClasificacion_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdClasificacion.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdClasificacion.FindEditFormTemplateControl("xtxtNombreEdit")).Text;

            var ClasificacionID = 0;

            if (!e.IsNewRow)
                ClasificacionID = (int)e.Keys[0];
            try
            {
                var BClasificacion = new ClasificacionDa();
                var res = BClasificacion.ValClasificacion(ClasificacionID, Codigo, Nombre);
                if (res == 1)
                    e.RowError = "A Machine with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdClasificacion_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("clasificacionId");

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
                var BClasificacion = new ClasificacionDa();
                var res = BClasificacion.DelClasificacionSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdClasificacion.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdClasificacion.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdClasificacion.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var BClasificacion = new ClasificacionDa();
                var res = BClasificacion.DelClasificacionAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdClasificacion.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdClasificacion.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdClasificacion.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }
    }
}