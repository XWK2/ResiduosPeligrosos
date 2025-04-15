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
    public partial class CatAlmacen : BasePage
    {
        private void ApplyLayout()
        {
            xgrdwarehouse.BeginUpdate();
            try
            {
                xgrdwarehouse.ClearSort();
            }
            finally
            {
                xgrdwarehouse.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var BAlmacen = new AlmacenDa();
            var oList = BAlmacen.GetCatalog(xtxtCodigo.Text.Trim(), chkActive.Checked);
            xgrdwarehouse.DataSource = oList;
            xgrdwarehouse.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdwarehouse.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdwarehouse_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }

        protected void xgrdwarehouse_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            var almacenId = int.Parse(e.Keys[0].ToString());

            try
            {
                var BAlmacen = new AlmacenDa();
                var res = BAlmacen.DelAlmacen(LoginInfo.CurrentUsuario.UsuarioId, almacenId);
                if (res == 1)
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdwarehouse.JSProperties["cpAlertMessage"] = ex.Message;
            }
            e.Cancel = true;
        }

        protected void xgrdwarehouse_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int almacenId = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdwarehouse.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string nombreAlmacen = ((ASPxTextBox)xgrdwarehouse.FindEditFormTemplateControl("xtxtNombreAlmacenEdit")).Text.Replace("/", "ñ|ñ");
            string codigoPlanta = ((ASPxComboBox)xgrdwarehouse.FindEditFormTemplateControl("cmbPlanta")).SelectedItem.Value.ToString();
            
            try
            {
                var BAlmacen = new AlmacenDa();
                var res = BAlmacen.UpdAlmacen(LoginInfo.CurrentUsuario.UsuarioId, almacenId, Codigo, nombreAlmacen, codigoPlanta);
                if (res == 1)
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdwarehouse.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdwarehouse.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdwarehouse_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdwarehouse.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;
            string nombrePlanta = ((ASPxTextBox)xgrdwarehouse.FindEditFormTemplateControl("xtxtNombreAlmacenEdit")).Text.Replace("/", "ñ|ñ");
            string codigoPlanta = ((ASPxComboBox)xgrdwarehouse.FindEditFormTemplateControl("cmbPlanta")).SelectedItem.Value.ToString();
            
            try
            {
                var BAlmacen = new AlmacenDa();
                var res = BAlmacen.InsAlmacen(LoginInfo.CurrentUsuario.UsuarioId, Codigo, nombrePlanta, codigoPlanta);
                if (res == 1)
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdwarehouse.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdwarehouse.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdwarehouse_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdwarehouse.FindEditFormTemplateControl("xtxtCodigoEdit")).Text;

            var almacenId = 0;

            if (!e.IsNewRow)
                almacenId = (int)e.Keys[0];
            try
            {
                var BAlmacen = new AlmacenDa();
                var res = BAlmacen.ValAlmacen(almacenId, Codigo);
                if (res == 1)
                    e.RowError = "A Warehouse with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdwarehouse_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("almacenId");

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
                var BAlmacen = new AlmacenDa();
                var res = BAlmacen.DelAlmacenSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdwarehouse.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var BAlmacen = new AlmacenDa();
                var res = BAlmacen.DelAlmacenAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdwarehouse.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdwarehouse.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }

        protected void xgrdwarehouse_HtmlEditFormCreated(object sender, ASPxGridViewEditFormEventArgs e)
        {
            ASPxComboBox cmbPlanta = (ASPxComboBox)xgrdwarehouse.FindEditFormTemplateControl("cmbPlanta");

            var BPlanta = new PlantaDa();
            var oList = BPlanta.GetCombo();
            cmbPlanta.ValueField = "Codigo";
            cmbPlanta.TextField = "Descripcion";
            cmbPlanta.DataSource = oList;
            cmbPlanta.DataBind();
        }

        protected void cmbPlanta_DataBound(object sender, EventArgs e)
        {
            ASPxComboBox cmbPlanta = (ASPxComboBox)xgrdwarehouse.FindEditFormTemplateControl("cmbPlanta");
            HtmlInputHidden hdnPlanta = (HtmlInputHidden)xgrdwarehouse.FindEditFormTemplateControl("hdnPlanta");


            ListEditItem oItem = cmbPlanta.Items.FindByValue(hdnPlanta.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
        }
    }
}