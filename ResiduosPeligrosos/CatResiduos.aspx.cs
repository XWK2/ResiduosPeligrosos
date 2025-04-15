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
    public partial class CatResiduos : BasePage
    {
        private void ApplyLayout()
        {
            xgrdResiduos.BeginUpdate();
            try
            {
                xgrdResiduos.ClearSort();
            }
            finally
            {
                xgrdResiduos.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxTextBox xtxtDescripcion = ASPxNavBar2.Groups[0].FindControl("xtxtDescripcion") as ASPxTextBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var DA = new ResiduosDa();
            var oList = DA.GetCatalog(xtxtCodigo.Text.Trim(), xtxtDescripcion.Text.Trim(), chkActive.Checked);
            xgrdResiduos.DataSource = oList;
            xgrdResiduos.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdResiduos.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;
            }
            fillGrid();
        }

        protected void xgrdResiduos_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }

        protected void xgrdResiduos_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int ResiduosId = int.Parse(e.Keys[0].ToString());
            string CodigoResiduo = ((ASPxTextBox)xgrdResiduos.FindEditFormTemplateControl("txtCodigo")).Text;
            string Nombre = ((ASPxTextBox)xgrdResiduos.FindEditFormTemplateControl("txtNombre")).Text.Replace("/", "ñ|ñ");
        
            string CodigoGrupo = ((ASPxComboBox)xgrdResiduos.FindEditFormTemplateControl("cmbGrupo")).SelectedItem.Value.ToString(); 
            string CodigoTipoManifiesto = ((ASPxComboBox)xgrdResiduos.FindEditFormTemplateControl("cmbTipoManifiesto")).SelectedItem.Value.ToString();
            string Tipo = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbTipo")).Value.ToString();
            var chkListClasificaciones = ((ASPxCheckBoxList)xgrdResiduos.FindEditFormTemplateControl("chkListClasificacionesD"));
                       
            string Clasificaciones = string.Empty;            
            for (int i = 0; i < chkListClasificaciones.Items.Count; i++)
            {
                if (chkListClasificaciones.Items[i].Selected == true)
                {
                    if (Clasificaciones == string.Empty)
                        Clasificaciones = Clasificaciones + chkListClasificaciones.Items[i].Value.ToString();
                    else
                        Clasificaciones = Clasificaciones + ", " + chkListClasificaciones.Items[i].Value.ToString();
                }
            }

            string ValorizableConBeneficio = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbListValorizableConBeneficio")).Value.ToString();
            string ValorizableConGasto = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbListValorizableConGasto")).Value.ToString();
            
            try
            {
                var BTipo = new ResiduosDa();
                var res = BTipo.UpdResiduos(LoginInfo.CurrentUsuario.UsuarioId, ResiduosId, CodigoResiduo, Nombre, Clasificaciones, CodigoTipoManifiesto, CodigoGrupo, ValorizableConBeneficio, ValorizableConGasto, Tipo);
                if (res == 1)
                    xgrdResiduos.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdResiduos.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdResiduos.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdResiduos.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdResiduos_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string CodigoResiduo = ((ASPxTextBox)xgrdResiduos.FindEditFormTemplateControl("txtCodigo")).Text;
            string Nombre = ((ASPxTextBox)xgrdResiduos.FindEditFormTemplateControl("txtNombre")).Text.Replace("/", "ñ|ñ");
            string CodigoGrupo = ((ASPxComboBox)xgrdResiduos.FindEditFormTemplateControl("cmbGrupo")).SelectedItem.Value.ToString();
            string CodigoTipoManifiesto = ((ASPxComboBox)xgrdResiduos.FindEditFormTemplateControl("cmbTipoManifiesto")).SelectedItem.Value.ToString();
            string Tipo = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbTipo")).Value.ToString();
            var chkListClasificaciones = ((ASPxCheckBoxList)xgrdResiduos.FindEditFormTemplateControl("chkListClasificacionesD"));

            string Clasificaciones = string.Empty;
            for (int i = 0; i <= (chkListClasificaciones.Items.Count - 1); i++)
            {
                if (chkListClasificaciones.Items[i].Selected == true)
                {
                    if (Clasificaciones == string.Empty)
                        Clasificaciones = Clasificaciones + chkListClasificaciones.Items[i].Value.ToString();
                    else
                        Clasificaciones = Clasificaciones + ", " + chkListClasificaciones.Items[i].Value.ToString();
                }
            }

            string ValorizableConBeneficio = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbListValorizableConBeneficio")).Value.ToString();
            string ValorizableConGasto = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbListValorizableConGasto")).Value.ToString();
            
            try
            {
                var BTipo = new ResiduosDa();                
                var res = BTipo.InsResiduos(LoginInfo.CurrentUsuario.UsuarioId, CodigoResiduo, Nombre, Clasificaciones, CodigoTipoManifiesto, CodigoGrupo, ValorizableConBeneficio, ValorizableConGasto, Tipo);
                if (res == 1)
                    xgrdResiduos.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdResiduos.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdResiduos.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdResiduos.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdResiduos_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdResiduos.FindEditFormTemplateControl("txtCodigo")).Text;
            string Nombre = ((ASPxTextBox)xgrdResiduos.FindEditFormTemplateControl("txtNombre")).Text.Replace("/", "ñ|ñ");

            var ResiduoId = 0;

            if (!e.IsNewRow)
                ResiduoId = (int)e.Keys[0];
            try
            {
                var BTipo = new ResiduosDa();
                var res = BTipo.ValResiduos(ResiduoId, Codigo, Nombre);
                if (res == 1)
                    e.RowError = "A Type with the same key or name already exists!";
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdResiduos_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("ResiduoId");

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
                var BTipo = new ResiduosDa();
                var res = BTipo.DelResiduosSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdResiduos.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdResiduos.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdResiduos.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var BTipo = new ResiduosDa();
                var res = BTipo.DelResiduosAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdResiduos.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdResiduos.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdResiduos.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }

        protected void xgrdResiduos_HtmlEditFormCreated(object sender, ASPxGridViewEditFormEventArgs e)
        {           
            ASPxComboBox cmbGrupo = (ASPxComboBox)xgrdResiduos.FindEditFormTemplateControl("cmbGrupo");
            var DAG = new GruposDa();
            var oListG = DAG.GetCombo();
            cmbGrupo.ValueField = "codigo";
            cmbGrupo.TextField = "codigoyNombre";
            cmbGrupo.DataSource = oListG;
            cmbGrupo.DataBind();

            ASPxComboBox cmbTipoManifiesto = (ASPxComboBox)xgrdResiduos.FindEditFormTemplateControl("cmbTipoManifiesto");
            var DATM = new TipoManifiestoDa();
            var oListTM = DATM.GetCombo();
            cmbTipoManifiesto.ValueField = "codigo";
            cmbTipoManifiesto.TextField = "CodigoYNombre";
            cmbTipoManifiesto.DataSource = oListTM;
            cmbTipoManifiesto.DataBind();


            var chkListClasificaciones = ((ASPxCheckBoxList)xgrdResiduos.FindEditFormTemplateControl("chkListClasificacionesD"));

            var BAcces = new ClasificacionDa();
            List<Entity.Clasificacion> listClasificaciones = BAcces.GetCombo();            
            chkListClasificaciones.TextField = "nombre";
            chkListClasificaciones.ValueField = "codigo";
            chkListClasificaciones.DataSource = listClasificaciones;
            chkListClasificaciones.DataBind();

            ASPxRadioButtonList rdbListValorizableConBeneficio = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbListValorizableConBeneficio"));
            ASPxRadioButtonList rdbListValorizableConGasto = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbListValorizableConGasto"));

            List<Expira> lexpp = new List<Expira>();
            Expira expp = new Expira();
            Expira expp2 = new Expira();
            expp.value = "SI";
            expp.text = "SI";
            expp2.value = "NO";
            expp2.text = "NO";
            lexpp.Add(expp);
            lexpp.Add(expp2);
           
            rdbListValorizableConBeneficio.DataSource = lexpp;
            rdbListValorizableConBeneficio.DataBind();

            rdbListValorizableConGasto.DataSource = lexpp;
            rdbListValorizableConGasto.DataBind();

            var rdbTipo = ((ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbTipo"));
            List<ValoresDefault> lrb = new List<ValoresDefault>();
            ValoresDefault rb = new ValoresDefault();
            ValoresDefault rb2 = new ValoresDefault();
            rb.value = "Confinamiento";
            rb.text = "Confinamiento";
            rb2.value = "Relleno Sanitario";
            rb2.text = "Relleno Sanitario";
            lrb.Add(rb);
            lrb.Add(rb2);

            rdbTipo.DataSource = lrb;
            rdbTipo.DataBind();
        }

        protected void rdbListValorizableConBeneficio_DataBound(object sender, EventArgs e)
        {

            ASPxRadioButtonList rdbListValorizableConBeneficio = (ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbListValorizableConBeneficio");
            HtmlInputHidden hdnValorizableConBeneficio = (HtmlInputHidden)xgrdResiduos.FindEditFormTemplateControl("hdnValorizableConBeneficio");

            ListEditItem oItem = rdbListValorizableConBeneficio.Items.FindByValue(hdnValorizableConBeneficio.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
            else
            {
                rdbListValorizableConBeneficio.Value = "SI";
            }
        }

        protected void rdbListValorizableConGasto_DataBound(object sender, EventArgs e)
        {
            ASPxRadioButtonList rdbListValorizableConGasto = (ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbListValorizableConGasto");
            HtmlInputHidden hdnValorizableConGasto = (HtmlInputHidden)xgrdResiduos.FindEditFormTemplateControl("hdnValorizableConGasto");

            ListEditItem oItem = rdbListValorizableConGasto.Items.FindByValue(hdnValorizableConGasto.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
            else
            {
                rdbListValorizableConGasto.Value = "SI";
            }
        }

        protected void cmbGrupo_DataBound(object sender, EventArgs e)
        {
            ASPxComboBox cmbGrupo = (ASPxComboBox)xgrdResiduos.FindEditFormTemplateControl("cmbGrupo");
            HtmlInputHidden hdnCodigoGrupo = (HtmlInputHidden)xgrdResiduos.FindEditFormTemplateControl("hdnCodigoGrupo");

            ListEditItem oItem = cmbGrupo.Items.FindByValue(hdnCodigoGrupo.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
        }

        protected void cmbTipoManifiesto_DataBound(object sender, EventArgs e)
        {
            ASPxComboBox cmbTipoManifiesto = (ASPxComboBox)xgrdResiduos.FindEditFormTemplateControl("cmbTipoManifiesto");
            HtmlInputHidden hdnCodigoTipoManifiesto = (HtmlInputHidden)xgrdResiduos.FindEditFormTemplateControl("hdnCodigoTipoManifiesto");


            ListEditItem oItem = cmbTipoManifiesto.Items.FindByValue(hdnCodigoTipoManifiesto.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
        }

        protected void rdbTipo_DataBound(object sender, EventArgs e)
        {
            ASPxRadioButtonList rdbTipo = (ASPxRadioButtonList)xgrdResiduos.FindEditFormTemplateControl("rdbTipo");
            HtmlInputHidden hdnTipo = (HtmlInputHidden)xgrdResiduos.FindEditFormTemplateControl("hdnTipo");

            ListEditItem oItem = rdbTipo.Items.FindByValue(hdnTipo.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
            else
            {
                rdbTipo.Value = "Confinamiento";
            }
        }
   
        protected void chkListClasificacionesD_DataBound(object sender, EventArgs e)
        {
            var chkListClasificacionesD = ((ASPxCheckBoxList)xgrdResiduos.FindEditFormTemplateControl("chkListClasificacionesD"));
            HtmlInputHidden hdnClasificaciones = (HtmlInputHidden)xgrdResiduos.FindEditFormTemplateControl("hdnClasificaciones");

            if (hdnClasificaciones.Value != "")
            {
                string[] ListValues = hdnClasificaciones.Value.ToString().Split(',');

                for (int i = 0; i < ListValues.LongCount(); i++)
                {
                    string value = ListValues[i].ToString().Trim();
                    chkListClasificacionesD.Items.FindByValue(value).Selected = true;
                }
            }
        }
    }    
}