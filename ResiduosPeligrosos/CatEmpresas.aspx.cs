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
    public partial class CatEmpresas : BasePage
    {
        private void ApplyLayout()
        {
            xgrdEmpresas.BeginUpdate();
            try
            {
                xgrdEmpresas.ClearSort();
            }
            finally
            {
                xgrdEmpresas.EndUpdate();
            }
        }

        public void fillGrid()
        {
            ASPxTextBox xtxtCodigo = ASPxNavBar2.Groups[0].FindControl("xtxtCodigo") as ASPxTextBox;
            ASPxComboBox cmbtipoEmpresa = ASPxNavBar2.Groups[0].FindControl("cmbtipoEmpresa") as ASPxComboBox;
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            var Bmtto = new EmpresasDa();
            var oListTipo = Bmtto.GetCatalog(xtxtCodigo.Text.Trim(), cmbtipoEmpresa.SelectedItem.Value.ToString().Trim(), chkActive.Checked);
            xgrdEmpresas.DataSource = oListTipo;
            xgrdEmpresas.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            xgrdEmpresas.JSProperties["cpAlertMessage"] = string.Empty;
            if (!IsPostBack)
            {
                Form.Attributes.Add("autocomplete", "off");
                ApplyLayout();
                foreach (NavBarGroup group in ASPxNavBar2.Groups)
                    group.Expanded = false;

                List<Tipo> lTipo = new List<Tipo>();                
                Tipo item = new Tipo();
                item.value = "G";
                item.text = "Generadora";
                Tipo item2 = new Tipo();
                item2.value = "T";
                item2.text = "Transportista";
                Tipo item3 = new Tipo();
                item3.value = "D";
                item3.text = "Destinataria";
                Tipo item4 = new Tipo();
                item4.value = "C";
                item4.text = "Cliente";
                lTipo.Add(item);
                lTipo.Add(item2);
                lTipo.Add(item3);
                lTipo.Add(item4);

                ASPxComboBox cmbtipoEmpresa = ASPxNavBar2.Groups[0].FindControl("cmbtipoEmpresa") as ASPxComboBox;
                cmbtipoEmpresa.TextField = "text";
                cmbtipoEmpresa.ValueField = "value";
                cmbtipoEmpresa.DataSource = lTipo;
                cmbtipoEmpresa.DataBind();

                ListEditItem oItem = cmbtipoEmpresa.Items.FindByValue("");
                if (oItem != null)
                    oItem.Selected = true;
                else
                    cmbtipoEmpresa.SelectedIndex = 0;

            }
            fillGrid();
        }

        protected void xgrdEmpresas_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e)
        {
            var pars = e.Parameters;
            if (pars == "Search")
            {
                fillGrid();
            }
        }
              
        protected void xgrdEmpresas_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            int EmpresaId = int.Parse(e.Keys[0].ToString());
            string Codigo = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtCodigo")).Text;
            string tipo = ((ASPxComboBox)xgrdEmpresas.FindEditFormTemplateControl("cmbtipo")).SelectedItem.Value.ToString();
            string NoRegistroAmbiental = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoRegistroAmbiental")).Text;
            string RazonSocial = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtRazonSocial")).Text;
            string RFC = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtRFC")).Text;
            string CodigoPostal = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtCodigoPostal")).Text;

            string Calle = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtCalle")).Text;
            string NoExterior = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoExterior")).Text;
            string NoInterior = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoInterior")).Text;
            string Colonia = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtColonia")).Text;
            string Municipio = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtMunicipio")).Text;
            string Estado = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtEstado")).Text;
            string Telefono = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtTelefono")).Text;
            string NoAutorizacionSEMARNAT = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoAutorizacionSEMARNAT")).Text;
            string NoPermisoSCT = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoPermisoSCT")).Text;            
            
            string Responsable = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtResponsable")).Text;
            string OpcionDefault = ((ASPxRadioButtonList)xgrdEmpresas.FindEditFormTemplateControl("rdbListOpcionDefault")).Value.ToString();
            string otrosdatos = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtOtrosDatos")).Text;
            //string OpcionDefault = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtOpcionDefault")).Text;

            try
            {
                var BEmpresas = new EmpresasDa();
                var res = BEmpresas.UpdEmpresas(EmpresaId, LoginInfo.CurrentUsuario.UsuarioId, Codigo, tipo, NoRegistroAmbiental, RazonSocial, RFC, CodigoPostal, Calle, NoExterior, NoInterior, Colonia, Municipio, Estado, Telefono, NoAutorizacionSEMARNAT, NoPermisoSCT, Responsable, OpcionDefault, otrosdatos);
                if (res == 1)
                    xgrdEmpresas.JSProperties["cpAlertMessage"] = "Update";
                else
                    xgrdEmpresas.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdEmpresas.JSProperties["cpAlertMessage"] = ex.Message;
            }
            xgrdEmpresas.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdEmpresas_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtCodigo")).Text;
            string tipo = ((ASPxComboBox)xgrdEmpresas.FindEditFormTemplateControl("cmbtipo")).SelectedItem.Value.ToString();
            string NoRegistroAmbiental = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoRegistroAmbiental")).Text;
            string RazonSocial = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtRazonSocial")).Text;
            string RFC = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtRFC")).Text;
            string CodigoPostal = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtCodigoPostal")).Text;

            string Calle = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtCalle")).Text;
            string NoExterior = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoExterior")).Text;
            string NoInterior = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoInterior")).Text;
            string Colonia = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtColonia")).Text;
            string Municipio = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtMunicipio")).Text;
            string Estado = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtEstado")).Text;
            string Telefono = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtTelefono")).Text;
            string NoAutorizacionSEMARNAT = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoAutorizacionSEMARNAT")).Text;
            string NoPermisoSCT = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtNoPermisoSCT")).Text;           
            
            string Responsable = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtResponsable")).Text;
            //string OpcionDefault = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtOpcionDefault")).Text;
            string OpcionDefault = ((ASPxRadioButtonList)xgrdEmpresas.FindEditFormTemplateControl("rdbListOpcionDefault")).Value.ToString();
            string otrosdatos = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtOtrosDatos")).Text;

            try
            {
                var BEmpresas = new EmpresasDa();
                var res = BEmpresas.InsEmpresas(LoginInfo.CurrentUsuario.UsuarioId, Codigo, tipo, NoRegistroAmbiental, RazonSocial, RFC, CodigoPostal, Calle, NoExterior, NoInterior, Colonia, Municipio, Estado, Telefono, NoAutorizacionSEMARNAT,NoPermisoSCT, Responsable, OpcionDefault, otrosdatos);
                if (res == 1)
                    xgrdEmpresas.JSProperties["cpAlertMessage"] = "Insert";
                else
                    xgrdEmpresas.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdEmpresas.JSProperties["cpAlertMessage"] = ex.Message;
            }

            xgrdEmpresas.CancelEdit();
            e.Cancel = true;
        }

        protected void xgrdEmpresas_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            string Codigo = ((ASPxTextBox)xgrdEmpresas.FindEditFormTemplateControl("txtCodigo")).Text;
            string tipo = ((ASPxComboBox)xgrdEmpresas.FindEditFormTemplateControl("cmbtipo")).SelectedItem.Value.ToString();

            var EmpresaId = 0;

            if (!e.IsNewRow)
                EmpresaId = (int)e.Keys[0];
            try
            {
                var BEmpresas = new EmpresasDa();
                var res = BEmpresas.ValEmpresas(EmpresaId, Codigo, tipo);
                if (res == 1)
                {
                    string opc = "";
                    if (tipo == "G")
                    {
                        opc = "Generadora";
                    }
                    else if (tipo == "T")
                    {
                        opc = "Transportista";
                    }
                    else if (tipo == "D")
                    {
                        opc = "Destinataria";
                    }
                    else
                    {
                        opc = "Cliente";
                    }
                    e.RowError = "A "+ opc + " with the same key or name already exists!";
                }
            }
            catch (Exception ex)
            {
                e.RowError = ex.Message;
            }
        }

        protected void xgrdEmpresas_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.Name == "CheckID")
            {
                var id = e.GetValue("EmpresaId");

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
                var Bmtto = new EmpresasDa();
                var res = Bmtto.DelEmpresasSelected(LoginInfo.CurrentUsuario.UsuarioId, Valores);
                if (res >= 1)
                    xgrdEmpresas.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdEmpresas.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdEmpresas.JSProperties["cpAlertMessage"] = ex.Message;
            }

        }

        protected void CallbackPanelDisableAll_Callback(object sender, CallbackEventArgsBase e)
        {
            ASPxCheckBox chkActive = ASPxNavBar2.Groups[0].FindControl("chkActive") as ASPxCheckBox;

            //desabilitamos o habilitamos con un update masivo.
            try
            {
                var Bmtto = new EmpresasDa();
                var res = Bmtto.DelEmpresasAll(LoginInfo.CurrentUsuario.UsuarioId, chkActive.Checked);
                if (res >= 1)
                    xgrdEmpresas.JSProperties["cpAlertMessage"] = "Delete";
                else
                    xgrdEmpresas.JSProperties["cpAlertMessage"] = "Error";
            }
            catch (Exception ex)
            {
                xgrdEmpresas.JSProperties["cpAlertMessage"] = ex.Message;
            }
        }

        protected void xgrdEmpresas_HtmlEditFormCreated(object sender, ASPxGridViewEditFormEventArgs e)
        {
            List<Tipo> lTipo = new List<Tipo>();
            Tipo item = new Tipo();
            item.value = "G";
            item.text = "Generadora";
            Tipo item2 = new Tipo();
            item2.value = "T";
            item2.text = "Transportista";
            Tipo item3 = new Tipo();
            item3.value = "D";
            item3.text = "Destinataria";
            Tipo item4 = new Tipo();
            item4.value = "C";
            item4.text = "Cliente";
            lTipo.Add(item);
            lTipo.Add(item2);
            lTipo.Add(item3);
            lTipo.Add(item4);

            ASPxComboBox cmbtipo = (ASPxComboBox)xgrdEmpresas.FindEditFormTemplateControl("cmbtipo");
            cmbtipo.TextField = "text";
            cmbtipo.ValueField = "value";
            cmbtipo.DataSource = lTipo;
            cmbtipo.DataBind();
                        
            ASPxRadioButtonList rdbListOpcionDefault = ((ASPxRadioButtonList)xgrdEmpresas.FindEditFormTemplateControl("rdbListOpcionDefault"));

            List<Expira> lexpp = new List<Expira>();
            Expira expp = new Expira();
            Expira expp2 = new Expira();
            expp.value = "SI";
            expp.text = "SI";
            expp2.value = "NO";
            expp2.text = "NO";
            lexpp.Add(expp);
            lexpp.Add(expp2);

            rdbListOpcionDefault.DataSource = lexpp;
            rdbListOpcionDefault.DataBind();
           
        }

        protected void cmbtipo_DataBound(object sender, EventArgs e)
        {
            string Codigo = ((HtmlInputHidden)xgrdEmpresas.FindEditFormTemplateControl("hdnTipo")).Value;
            var cmbtipo = ((ASPxComboBox)xgrdEmpresas.FindEditFormTemplateControl("cmbtipo"));
            ListEditItem oItem = cmbtipo.Items.FindByValue(Codigo);
            if (oItem != null)
                oItem.Selected = true;
            else
                cmbtipo.SelectedIndex = 0;
        }

        protected void rdbListOpcionDefault_DataBound(object sender, EventArgs e)
        {
            ASPxRadioButtonList rdbListOpcionDefault = (ASPxRadioButtonList)xgrdEmpresas.FindEditFormTemplateControl("rdbListOpcionDefault");
            HtmlInputHidden hdnOpcionDefault = (HtmlInputHidden)xgrdEmpresas.FindEditFormTemplateControl("hdnOpcionDefault");         

            ListEditItem oItem = rdbListOpcionDefault.Items.FindByValue(hdnOpcionDefault.Value);
            if (oItem != null)
            {
                oItem.Selected = true;
            }
            else
            {
                rdbListOpcionDefault.Value = "SI";
            }
        }       
    }

    public class Tipo
    {
        public string value { get; set; }
        public string text { get; set; }
    }
}