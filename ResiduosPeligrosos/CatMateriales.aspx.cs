using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ResiduosPeligrosos.dataAccess;
using ResiduosPeligrosos.Entity;
using System.Text.RegularExpressions;

namespace ResiduosPeligrosos
{
    public partial class CatMateriales : BasePage
    {
        private void ApplyLayout()
        {
            xgrdMateriales.BeginUpdate();
            try
            {
                xgrdMateriales.ClearSort();
            }
            finally
            {
                xgrdMateriales.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxTextBox xtxtDescripcion = ASPxNavBar2.Groups[0].FindControl("xtxtDescripcion") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BMateriales = new MaterialesDa();
            var oList = BMateriales.GetCatalog(xtxtCodigo.Text.Trim(), xtxtDescripcion.Text.Trim(), chkActive.Checked);
            xgrdMateriales.DataSource = oList;
            xgrdMateriales.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdMateriales.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdMateriales_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }

       
        protected void xgrdMateriales_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int MaterialId = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/","ñ|ñ");

            string pais = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtpais")).Text;
            string cveSat = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtCveSat")).Text;
            decimal precioU = Convert.ToDecimal(((ASPxSpinEdit)xgrdMateriales.FindEditFormTemplateControl("xtxtprecio")).Value.ToString());
            string nameEnglish = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtNameEnglish")).Text.Replace("/", "ñ|ñ");
            try
            {
                var BMateriales = new MaterialesDa();
                var res = BMateriales.UpdMateriales(LoginInfo.CurrentUsuario.UsuarioId, MaterialId, Codigo, Nombre, pais, cveSat, precioU, nameEnglish);
                if (res == 1)
                    xgrdMateriales.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdMateriales.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdMateriales.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdMateriales.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdMateriales_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/", "ñ|ñ");

            string pais = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtpais")).Text;
            string cveSat = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtCveSat")).Text;
            decimal precioU = Convert.ToDecimal(((ASPxSpinEdit)xgrdMateriales.FindEditFormTemplateControl("xtxtprecio")).Value.ToString());
            string nameEnglish = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtNameEnglish")).Text.Replace("/", "ñ|ñ");
            try
            {
                var BMateriales = new MaterialesDa();
                var res = BMateriales.InsMateriales(LoginInfo.CurrentUsuario.UsuarioId, Codigo, Nombre, pais, cveSat, precioU, nameEnglish);
                if (res == 1)
                    xgrdMateriales.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdMateriales.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdMateriales.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdMateriales.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdMateriales_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string Nombre = ((ASPxTextBox)xgrdMateriales.FindEditFormTemplateControl("xtxtNombreEdit")).Text.Replace("/", "ñ|ñ");

            var MaterialesID = 0;

            if (!e.IsNewRow)
                MaterialesID = (int)e.Keys[0];
            try
            {
                var BMateriales = new MaterialesDa();
                var res = BMateriales.ValMateriales(MaterialesID, Codigo, Nombre);
                if (res == 1)
                    e.RowError = "A Material with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdMateriales_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("MaterialId");

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
                var BMateriales = new MaterialesDa();
                var res = BMateriales.DelMaterialesSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdMateriales.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdMateriales.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdMateriales.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var BMateriales = new MaterialesDa();
                var res = BMateriales.DelMaterialesAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdMateriales.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdMateriales.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdMateriales.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }
    }
}