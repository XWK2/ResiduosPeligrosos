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
    public partial class CatGrupos : BasePage
    {
        private void ApplyLayout()
        {
            xgrdGrupos.BeginUpdate();
            try
            {
                xgrdGrupos.ClearSort();
            }
            finally
            {
                xgrdGrupos.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxTextBox xtxtDescripcion = ASPxNavBar2.Groups[0].FindControl("xtxtDescripcion") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BGrupos = new GruposDa();
            var oListPosicion = BGrupos.GetCatalog(xtxtCodigo.Text.Trim(), xtxtDescripcion.Text.Trim(), chkActive.Checked);
            xgrdGrupos.DataSource = oListPosicion;
            xgrdGrupos.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdGrupos.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdGrupos_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }

       
        protected void xgrdGrupos_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int GruposID = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdGrupos.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdGrupos.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/", "ñ|ñ");
            try
            {
                var BGrupos = new GruposDa();
                var res = BGrupos.UpdGrupos(LoginInfo.CurrentUsuario.UsuarioId, GruposID, Codigo, Nombre);
                if (res == 1)
                    xgrdGrupos.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdGrupos.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdGrupos.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdGrupos.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdGrupos_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdGrupos.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdGrupos.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/", "ñ|ñ");

            try
            {
                var BGrupos = new GruposDa();
                var res = BGrupos.InsGrupos(LoginInfo.CurrentUsuario.UsuarioId, Codigo, Nombre);
                if (res == 1)
                    xgrdGrupos.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdGrupos.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdGrupos.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdGrupos.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdGrupos_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdGrupos.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdGrupos.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/", "ñ|ñ");

            var GruposID = 0;

            if (!e.IsNewRow)
                GruposID = (int)e.Keys[0];
            try
            {
                var BGrupos = new GruposDa();
                var res = BGrupos.ValGrupos(GruposID, Codigo, Nombre);
                if (res == 1)
                    e.RowError = "A Machine with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdGrupos_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("grupoId");

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
                var BGrupos = new GruposDa();
                var res = BGrupos.DelGruposSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdGrupos.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdGrupos.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdGrupos.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var BGrupos = new GruposDa();
                var res = BGrupos.DelGruposAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdGrupos.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdGrupos.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdGrupos.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }
    }
}