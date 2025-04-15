using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using DevExpress.XtraReports.UI.PivotGrid;
using DevExpress.XtraPivotGrid;
using System.Data;
using System.IO;
using System.Web.UI;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRLabel xrLabel6;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private GroupFooterBand GroupFooter2;
    private XRTable xrTable1;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell7;
    private XRTable xrTable2;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell8;
    private XRTable xrTable3;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow32;
    private XRTableCell xrTableCell124;
    private XRLabel xlblResponsableTrans;
    private XRTableCell xrTableCell125;
    private XRLabel xlblVal14FechaTrans;
    private XRTableCell xrTableCell126;
    private XRTable xrTable4;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTable xrTable7;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell18;
    private XRLabel xlblVal8Nombre;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell64;
    private XRLabel xlblVal8CP;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRLabel xlblVal8Calle;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell68;
    private XRLabel xlblVal8NE;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell70;
    private XRLabel xlblVal8NI;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRLabel xlblVal8Colonia;
    private XRTableCell xrTableCell117;
    private XRTableCell xrTableCell73;
    private XRLabel xlblVal8Municipio;
    private XRTableCell xrTableCell118;
    private XRTableCell xrTableCell74;
    private XRLabel xlblVal8Estado;
    private XRTableCell xrTableCell75;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell76;
    private XRTableCell xrTableCell77;
    private XRLabel xlblVal8Telefono;
    private XRTableCell xrTableCell78;
    private XRTableCell xrTableCell79;
    private XRLabel xlblVal8email;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRLabel xlblVal9SEMARNAT;
    private XRTableCell xrTableCell84;
    private XRTableCell xrTableCell85;
    private XRLabel xlblVal10SCT;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRLabel xlblVal11TipoVehiculo;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRLabel xlblVal12Placa;
    private XRTable xrTable8;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell123;
    private XRTableCell xrTableCell14;
    private XRLabel xlblVal13Ruta;
    private XRTable xrTable9;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell80;
    private XRLabel xlblVal15NombreDest;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private XRLabel xlblVal15CP;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell89;
    private XRLabel xlblVal15Calle;
    private XRTableCell xrTableCell90;
    private XRTableCell xrTableCell91;
    private XRLabel xlblVal15NE;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell93;
    private XRLabel xlblVal15NI;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell95;
    private XRLabel xlblVal15Colonia;
    private XRTableCell xrTableCell115;
    private XRTableCell xrTableCell96;
    private XRLabel xlblVal15Municipio;
    private XRTableCell xrTableCell116;
    private XRTableCell xrTableCell97;
    private XRLabel xlblVal15Estado;
    private XRTableCell xrTableCell98;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell100;
    private XRLabel xlblVal15Telefono;
    private XRTableCell xrTableCell101;
    private XRTableCell xrTableCell102;
    private XRLabel xlblVal15Email;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell103;
    private XRTableCell xrTableCell104;
    private XRLabel xlblVal16SEMARNAT;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell108;
    private XRLabel xlblVal17NombreRecibeResiduos;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell106;
    private XRLabel xlblVal18Observaciones;
    private XRTable xrTable10;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell109;
    private XRTable xrTable11;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRTableCell xrTableCell112;
    private XRTableRow xrTableRow33;
    private XRTableCell xrTableCell127;
    private XRLabel xlblResponsableDes;
    private XRTableCell xrTableCell128;
    private XRLabel xlblVal19FechaDes;
    private XRTableCell xrTableCell129;
    private XRTable xrTable12;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell119;
    private XRLabel xlblVal6Instrucciones;
    private XRTable xrTable13;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell120;
    private XRLabel xlblVal6Responsable;
    private XRTableCell xrTableCell121;
    private XRLabel xlblVal7Fecha;
    private XRTableCell xrTableCell122;
    private XRTable xrTable14;
    private XRTableRow xrTableRow34;
    private XRTableCell xrTableCellNR;
    private XRTableCell xrTableCellCC;
    private XRTableCell xrTableCellCR;
    private XRTableCell xrTableCellCE;
    private XRTableCell xrTableCellCI;
    private XRTableCell xrTableCellCB;
    private XRTableCell xrTableCellCM;
    private XRTableCell xrTableCellTipo;
    private XRTableCell xrTableCellCapacidad;
    private XRTableCell xrTableCellCantidad;
    private XRTableCell xrTableCellSi;
    private XRTableCell xrTableCellNo;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell17;
    private XRLabel xlblVal1RegistroAmbiental;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell20;
    private XRLabel xlblVal2NumManifiesto;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell22;
    private XRLabel xlblVal3Pagina;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell29;
    private XRLabel xlblVal4NombreGenerador;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell31;
    private XRLabel xlblVal4CP;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell32;
    private XRLabel xlblVal4Calle;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRLabel xlblVal4NE;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell45;
    private XRLabel xlblVal4NI;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell36;
    private XRLabel xlblVal4Col;
    private XRTableCell xrTableCell113;
    private XRTableCell xrTableCell38;
    private XRLabel xlblVal4Mun;
    private XRTableCell xrTableCell114;
    private XRTableCell xrTableCell40;
    private XRLabel xlblVal4Edo;
    private XRTableCell xrTableCell47;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell25;
    private XRLabel xlblVal4Tel;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRLabel xlblVal4email;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell41;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell42;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReport1(ResiduosPeligrosos.Entity.Manifiestos Manifiesto)
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
        
        PasarDatos(Manifiesto);        
    }

    private void PasarDatos(ResiduosPeligrosos.Entity.Manifiestos Manifiesto)
    {
        //Datos Generador.
        xlblVal1RegistroAmbiental.Text = Manifiesto.numRegistroAmbiental;
        xlblVal2NumManifiesto.Text = Manifiesto.numManifiesto;
        xlblVal3Pagina.Text = Manifiesto.paginaNumero.ToString("0.##");
        xlblVal4NombreGenerador.Text = Manifiesto.nombreGeneradorDesc.ToString();
        xlblVal4CP.Text = Manifiesto.cpGen;
        xlblVal4Calle.Text = Manifiesto.direccion;
        xlblVal4NE.Text = Manifiesto.numeroExterior;
        xlblVal4NI.Text = Manifiesto.numeroInterior;
        xlblVal4Col.Text = Manifiesto.colonia;
        xlblVal4Mun.Text = Manifiesto.municipio;
        xlblVal4Edo.Text = Manifiesto.estado;
        xlblVal4Tel.Text = Manifiesto.tel;
        xlblVal4email.Text = Manifiesto.correoElectronico;
        xlblVal6Instrucciones.Text = Manifiesto.instrucciones;
        xlblVal6Responsable.Text = Manifiesto.responsable;
        xlblVal7Fecha.Text = Manifiesto.fechaGenerador;

        //Datos Transportista
        xlblVal8Nombre.Text = Manifiesto.nombreTransportistaDesc;
        xlblVal8CP.Text = Manifiesto.cpGen;
        xlblVal8Calle.Text = Manifiesto.direccion;
        xlblVal8NE.Text = Manifiesto.numeroExteriorTrans;
        xlblVal8NI.Text = Manifiesto.numeroInteriorTrans;
        xlblVal8Estado.Text = Manifiesto.estadoTrans;
        xlblVal8Telefono.Text = Manifiesto.telTrans;
        xlblVal8email.Text = Manifiesto.correoElectronicoTrans;
        xlblVal9SEMARNAT.Text = Manifiesto.numeroAutorizacionSemarnatTrans;
        xlblVal10SCT.Text = Manifiesto.numeroPermisoSCTTrans;
        xlblVal11TipoVehiculo.Text = Manifiesto.tipoVehiculoTrans;
        xlblVal12Placa.Text = Manifiesto.placasTrans;
        xlblVal13Ruta.Text = Manifiesto.rutaEmpresaTrans;
        xlblResponsableTrans.Text = Manifiesto.responsable;
        xlblVal14FechaTrans.Text = Manifiesto.fechaTrans;

        //Datos Destinatario
        xlblVal15NombreDest.Text = Manifiesto.nombreDestinatarioDesc;
        xlblVal15CP.Text = Manifiesto.cpDes;
        xlblVal15Calle.Text = Manifiesto.direccionDes;
        xlblVal15NE.Text = Manifiesto.numeroExteriorDes;
        xlblVal15NI.Text = Manifiesto.numeroInteriorDes;
        xlblVal15Colonia.Text = Manifiesto.coloniaDes;
        xlblVal15Municipio.Text = Manifiesto.municipioDes;
        xlblVal15Estado.Text = Manifiesto.estadoDes;
        xlblVal15Telefono.Text = Manifiesto.telDes;
        xlblVal15Email.Text = Manifiesto.correoElectronicoDes;
        xlblVal16SEMARNAT.Text = Manifiesto.numeroAutorizacionSemarnatDes;
        xlblVal17NombreRecibeResiduos.Text = Manifiesto.nomnbrePersonaRecibeDes;
        xlblVal18Observaciones.Text = "";
        xlblResponsableDes.Text = Manifiesto.responsableDes;
        xlblVal19FechaDes.Text = Manifiesto.fechaDes;


        ////Generate pivot grid's fields.
        //XRPivotGridField fieldResiduo = new XRPivotGridField("residuo", PivotArea.RowArea);
        //XRPivotGridField fieldTipo = new XRPivotGridField("TipoEnvase", PivotArea.RowArea);
        //XRPivotGridField fieldMaterial = new XRPivotGridField("Material", PivotArea.RowArea);
        //XRPivotGridField fieldclasificaciones = new XRPivotGridField("clasificaciones", PivotArea.RowArea);

        //xrPivotGrid1.Fields.AddRange(new XRPivotGridField[] { fieldResiduo, fieldTipo, fieldMaterial, fieldclasificaciones });

        //DataTable dsg = new DataTable();

        //DataTable dataTable = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(Newtonsoft.Json.JsonConvert.SerializeObject(Manifiesto.gaylords));

        //xrPivotGrid1.Report.DataSource = dataTable; //Manifiesto.gaylords;

     
        for (int i = 0; i < Manifiesto.gaylords.Count; i++)
        {
            XRTableRow row = new XRTableRow();

            ////Opcion 1: Ejemplo creando los campos dinamimos.
            //XRTableCell Material = new XRTableCell();
            //XRTableCell Clasificaciones = new XRTableCell();
            //XRTableCell Peso = new XRTableCell();
            //XRTableCell CodigoLocacion = new XRTableCell();

            //row.Cells.Add(Material);
            //row.Cells.Add(Clasificaciones);
            //row.Cells.Add(Peso);
            //row.Cells.Add(CodigoLocacion);

            //Material.DataBindings.Add("Text", Manifiesto.gaylords[i], "material");
            //Clasificaciones.DataBindings.Add("Text", Manifiesto.gaylords[i], "Clasificaciones");
            //Peso.DataBindings.Add("Text", Manifiesto.gaylords[i], "peso");
            //CodigoLocacion.DataBindings.Add("Text", Manifiesto.gaylords[i], "codigoLocacion");


            //Opcion 2: Ejemplo pasando info en campos ya diseñados
            //Agregamos celdas
            XRTableCell xrTableCellNRX = new XRTableCell();
            XRTableCell xrTableCellCCX = new XRTableCell();
            XRTableCell xrTableCellCRX = new XRTableCell();
            XRTableCell xrTableCellCEX = new XRTableCell();
            XRTableCell xrTableCellCIX = new XRTableCell();
            XRTableCell xrTableCellCBX = new XRTableCell();
            XRTableCell xrTableCellCMX = new XRTableCell();
            XRTableCell xrTableCellTipoX = new XRTableCell();
            XRTableCell xrTableCellCapacidadX = new XRTableCell();
            XRTableCell xrTableCellCantidadX = new XRTableCell();
            XRTableCell xrTableCellSiX = new XRTableCell();
            XRTableCell xrTableCellNoX = new XRTableCell();

            row.Cells.Add(xrTableCellNRX);            
            row.Cells.Add(xrTableCellCCX);
            row.Cells.Add(xrTableCellCRX);
            row.Cells.Add(xrTableCellCEX);
            row.Cells.Add(xrTableCellCIX);
            row.Cells.Add(xrTableCellCBX);
            row.Cells.Add(xrTableCellCMX);
            row.Cells.Add(xrTableCellTipoX);
            row.Cells.Add(xrTableCellCapacidadX);
            row.Cells.Add(xrTableCellCantidadX);
            row.Cells.Add(xrTableCellSiX);
            row.Cells.Add(xrTableCellNoX);

            xrTableCellNRX.WidthF = 162.5f;
            xrTableCellCCX.WidthF = 22.19f;            
            xrTableCellCRX.WidthF = 26.18f;
            xrTableCellCEX.WidthF = 26.18f;
            xrTableCellCIX.WidthF = 28.29f;
            xrTableCellCBX.WidthF = 26.34f;
            xrTableCellCMX.WidthF = 27.14f;
            xrTableCellTipoX.WidthF = 84.33f;
            xrTableCellCapacidadX.WidthF = 84.33f;
            xrTableCellCantidadX.WidthF = 81.25f;
            xrTableCellSiX.WidthF = 40.62f;
            xrTableCellNoX.WidthF = 40.62f;

            xrTableCellNRX.DataBindings.Add("Text", Manifiesto.gaylords[i], "residuo");

            //xrTableCellCCX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
            //xrTableCellCRX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
            //xrTableCellCEX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
            //xrTableCellCIX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
            //xrTableCellCBX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
            //xrTableCellCMX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");

            switch (Manifiesto.gaylords[i].clasificaciones)
            {
                case "C":
                    xrTableCellCCX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
                    xrTableCellCRX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCEX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCIX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCBX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCMX.DataBindings.Add("Text", "", "clasificaciones");
                    break;

                case "R":
                    xrTableCellCCX.DataBindings.Add("Text", "", "Clasificaciones");
                    xrTableCellCRX.DataBindings.Add("Text", Manifiesto.gaylords[i], "Clasificaciones");
                    xrTableCellCEX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCIX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCBX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCMX.DataBindings.Add("Text", "", "clasificaciones");
                    break;

                case "E":
                    xrTableCellCCX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCRX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCEX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
                    xrTableCellCIX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCBX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCMX.DataBindings.Add("Text", "", "clasificaciones");
                    break;

                case "I":
                    xrTableCellCCX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCRX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCEX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCIX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
                    xrTableCellCBX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCMX.DataBindings.Add("Text", "", "clasificaciones");
                    break;

                case "B":
                    xrTableCellCCX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCRX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCEX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCIX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCBX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
                    xrTableCellCMX.DataBindings.Add("Text", "", "clasificaciones");
                    break;

                case "M":
                    xrTableCellCCX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCRX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCEX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCIX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCBX.DataBindings.Add("Text", "", "clasificaciones");
                    xrTableCellCMX.DataBindings.Add("Text", Manifiesto.gaylords[i], "clasificaciones");
                    break;
            }

            xrTableCellTipoX.DataBindings.Add("Text", Manifiesto.gaylords[i], "TipoEnvase");
            xrTableCellCapacidadX.DataBindings.Add("Text", Manifiesto.gaylords[i], "capacidad");
            xrTableCellCantidadX.DataBindings.Add("Text", Manifiesto.gaylords[i], "peso");
            xrTableCellSiX.DataBindings.Add("Text", "", "");
            xrTableCellNoX.DataBindings.Add("Text", "", "");

            xrTable14.Rows.Add(row);
            
        }
        
    }
    
    //private void xrPivotGrid1_CustomFieldValueCells(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCustomFieldValueCellsEventArgs e)
    //{
    //    bool isColumn = true;
    //    for (int i = e.GetCellCount(isColumn) - 1; i >= 0; i--)
    //    {
    //        DevExpress.XtraReports.UI.PivotGrid.FieldValueCell cell = e.GetCell(isColumn, i);
    //        if (cell != null)
    //            e.Remove(cell);
    //    }
    //}

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellNR = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCC = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCR = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCE = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCI = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCB = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCM = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellTipo = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCapacidad = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCantidad = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellSi = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellNo = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblResponsableTrans = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal14FechaTrans = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8Nombre = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8CP = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8Calle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8NE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8NI = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8Colonia = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8Municipio = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8Estado = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8Telefono = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal8email = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal9SEMARNAT = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal10SCT = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal11TipoVehiculo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal12Placa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal13Ruta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15NombreDest = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15CP = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15Calle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15NE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15NI = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15Colonia = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15Municipio = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15Estado = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15Telefono = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal15Email = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal16SEMARNAT = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal17NombreRecibeResiduos = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal18Observaciones = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblResponsableDes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal19FechaDes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable12 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal6Instrucciones = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal6Responsable = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal7Fecha = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal1RegistroAmbiental = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal2NumManifiesto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal3Pagina = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4NombreGenerador = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4CP = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4Calle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4NE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4NI = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4Col = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4Mun = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4Edo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4Tel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal4email = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable14});
            this.Detail.HeightF = 33.88392F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable14
            // 
            this.xrTable14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable14.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable14.Name = "xrTable14";
            this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow34});
            this.xrTable14.SizeF = new System.Drawing.SizeF(649.9852F, 17.70833F);
            this.xrTable14.StylePriority.UseBorders = false;
            this.xrTable14.StylePriority.UseFont = false;
            this.xrTable14.StylePriority.UseTextAlignment = false;
            this.xrTable14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTableRow34
            // 
            this.xrTableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellNR,
            this.xrTableCellCC,
            this.xrTableCellCR,
            this.xrTableCellCE,
            this.xrTableCellCI,
            this.xrTableCellCB,
            this.xrTableCellCM,
            this.xrTableCellTipo,
            this.xrTableCellCapacidad,
            this.xrTableCellCantidad,
            this.xrTableCellSi,
            this.xrTableCellNo});
            this.xrTableRow34.Name = "xrTableRow34";
            this.xrTableRow34.Weight = 1D;
            // 
            // xrTableCellNR
            // 
            this.xrTableCellNR.Name = "xrTableCellNR";
            this.xrTableCellNR.Weight = 1.460299402756295D;
            // 
            // xrTableCellCC
            // 
            this.xrTableCellCC.Name = "xrTableCellCC";
            this.xrTableCellCC.Text = "C";
            this.xrTableCellCC.Weight = 0.19944982109441753D;
            // 
            // xrTableCellCR
            // 
            this.xrTableCellCR.Name = "xrTableCellCR";
            this.xrTableCellCR.Text = "R";
            this.xrTableCellCR.Weight = 0.23528718521266595D;
            // 
            // xrTableCellCE
            // 
            this.xrTableCellCE.Name = "xrTableCellCE";
            this.xrTableCellCE.Text = "E";
            this.xrTableCellCE.Weight = 0.23528731613597181D;
            // 
            // xrTableCellCI
            // 
            this.xrTableCellCI.Name = "xrTableCellCI";
            this.xrTableCellCI.Text = "I";
            this.xrTableCellCI.Weight = 0.25426167874765904D;
            // 
            // xrTableCellCB
            // 
            this.xrTableCellCB.Name = "xrTableCellCB";
            this.xrTableCellCB.Text = "B";
            this.xrTableCellCB.Weight = 0.23667940612943589D;
            // 
            // xrTableCellCM
            // 
            this.xrTableCellCM.Name = "xrTableCellCM";
            this.xrTableCellCM.Text = "M";
            this.xrTableCellCM.Weight = 0.24388985372315764D;
            // 
            // xrTableCellTipo
            // 
            this.xrTableCellTipo.Name = "xrTableCellTipo";
            this.xrTableCellTipo.Text = "Tipo";
            this.xrTableCellTipo.Weight = 0.7578719900926767D;
            // 
            // xrTableCellCapacidad
            // 
            this.xrTableCellCapacidad.Name = "xrTableCellCapacidad";
            this.xrTableCellCapacidad.Text = "Capacidad";
            this.xrTableCellCapacidad.Weight = 0.75782797378205791D;
            // 
            // xrTableCellCantidad
            // 
            this.xrTableCellCantidad.Name = "xrTableCellCantidad";
            this.xrTableCellCantidad.Text = "(Kg o ton)";
            this.xrTableCellCantidad.Weight = 0.73014966750561794D;
            // 
            // xrTableCellSi
            // 
            this.xrTableCellSi.Name = "xrTableCellSi";
            this.xrTableCellSi.Text = "Si";
            this.xrTableCellSi.Weight = 0.36502990598986373D;
            // 
            // xrTableCellNo
            // 
            this.xrTableCellNo.Name = "xrTableCellNo";
            this.xrTableCellNo.Text = "No";
            this.xrTableCellNo.Weight = 0.36503007739294246D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6});
            this.TopMargin.HeightF = 33.83331F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(11.97906F, 6.479168F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(620.6251F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "MANIFIESTO DE ENTREGA, TRANSPORTE Y RECEPCION DE RECIDUOS PELIGROSOS (GENERADOR)";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 39F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "perfetto3.ResPeligrosos.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "spContainerDetailsxManifiestoId_s";
            queryParameter1.Name = "@ManifiestoId";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "0";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "spContainerDetailsxManifiestoId_s";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "perfetto3.ResPeligrosos.dbo";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery2.Name = "spResiduosxIds_s";
            queryParameter2.Name = "@Ids";
            queryParameter2.Type = typeof(string);
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.StoredProcName = "spResiduosxIds_s";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrTable2,
            this.xrTable3,
            this.xrTable5,
            this.xrTable4,
            this.xrTable7,
            this.xrTable8,
            this.xrTable9,
            this.xrTable10,
            this.xrTable11,
            this.xrTable12,
            this.xrTable13});
            this.GroupFooter2.HeightF = 742.8833F;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 56.61222F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650.0001F, 58.1306F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 2.0548773705925614D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = resources.GetString("xrTableCell7.Text");
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell7.Weight = 4.98660968862913D;
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 18.86262F);
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "6- Instrucciones especiales e informacion  adicional  para el manejo seguro:";
            this.xrTableCell8.Weight = 1D;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(1.890215F, 114.7428F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable3.SizeF = new System.Drawing.SizeF(648.1095F, 20.0732F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.Text = "Nombre y firma del responsable";
            this.xrTableCell4.Weight = 1.350045805326062D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.Text = "Fecha:";
            this.xrTableCell5.Weight = 0.91155315927704073D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Text = "Sello:";
            this.xrTableCell6.Weight = 0.75555057788823365D;
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(1.890215F, 382.3287F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow32});
            this.xrTable5.SizeF = new System.Drawing.SizeF(648.1095F, 65.54184F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell9});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "Nombre y firma del responsable";
            this.xrTableCell2.Weight = 1.350045805326062D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "Fecha:";
            this.xrTableCell3.Weight = 0.91155315927704073D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.Text = "Sello:";
            this.xrTableCell9.Weight = 0.75555057788823365D;
            // 
            // xrTableRow32
            // 
            this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell124,
            this.xrTableCell125,
            this.xrTableCell126});
            this.xrTableRow32.Name = "xrTableRow32";
            this.xrTableRow32.Weight = 1D;
            // 
            // xrTableCell124
            // 
            this.xrTableCell124.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblResponsableTrans});
            this.xrTableCell124.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell124.Name = "xrTableCell124";
            this.xrTableCell124.StylePriority.UseFont = false;
            this.xrTableCell124.Weight = 1.350045805326062D;
            // 
            // xlblResponsableTrans
            // 
            this.xlblResponsableTrans.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblResponsableTrans.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblResponsableTrans.LocationFloat = new DevExpress.Utils.PointFloat(10.60956F, 4.682983F);
            this.xlblResponsableTrans.Name = "xlblResponsableTrans";
            this.xlblResponsableTrans.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblResponsableTrans.SizeF = new System.Drawing.SizeF(270.0014F, 22.99998F);
            this.xlblResponsableTrans.StylePriority.UseBorders = false;
            this.xlblResponsableTrans.StylePriority.UseFont = false;
            this.xlblResponsableTrans.StylePriority.UsePadding = false;
            this.xlblResponsableTrans.Text = "Nombre Responsable";
            // 
            // xrTableCell125
            // 
            this.xrTableCell125.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal14FechaTrans});
            this.xrTableCell125.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell125.Name = "xrTableCell125";
            this.xrTableCell125.StylePriority.UseFont = false;
            this.xrTableCell125.Weight = 0.91155315927704073D;
            // 
            // xlblVal14FechaTrans
            // 
            this.xlblVal14FechaTrans.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal14FechaTrans.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal14FechaTrans.LocationFloat = new DevExpress.Utils.PointFloat(8.10819F, 4.682983F);
            this.xlblVal14FechaTrans.Name = "xlblVal14FechaTrans";
            this.xlblVal14FechaTrans.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal14FechaTrans.SizeF = new System.Drawing.SizeF(172.9503F, 22.99998F);
            this.xlblVal14FechaTrans.StylePriority.UseBorders = false;
            this.xlblVal14FechaTrans.StylePriority.UseFont = false;
            this.xlblVal14FechaTrans.StylePriority.UsePadding = false;
            this.xlblVal14FechaTrans.StylePriority.UseTextAlignment = false;
            this.xlblVal14FechaTrans.Text = "Valor Fecha";
            this.xlblVal14FechaTrans.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell126
            // 
            this.xrTableCell126.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell126.Name = "xrTableCell126";
            this.xrTableCell126.StylePriority.UseFont = false;
            this.xrTableCell126.Weight = 0.75555057788823365D;
            // 
            // xrTable4
            // 
            this.xrTable4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 348.037F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable4.SizeF = new System.Drawing.SizeF(650.0001F, 34.29166F);
            this.xrTable4.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 2.0548773705925614D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "14- Declaro bajo protesta de decir la verdad que recibo los residuos peligrosos d" +
    "escritos en el manifiesto para su transporte a la empresa destinataria señalada " +
    "por el generador.";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 4.98660968862913D;
            // 
            // xrTable7
            // 
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 167.1077F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17,
            this.xrTableRow18,
            this.xrTableRow20,
            this.xrTableRow14});
            this.xrTable7.SizeF = new System.Drawing.SizeF(650F, 160.8379F);
            this.xrTable7.StylePriority.UseBorders = false;
            this.xrTable7.StylePriority.UseFont = false;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell18});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = " 8- Nombre o razon social del transportista:";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell16.Weight = 3.2657224801471529D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8Nombre});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell18.Weight = 6.8004317451351692D;
            // 
            // xlblVal8Nombre
            // 
            this.xlblVal8Nombre.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Nombre.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Nombre.LocationFloat = new DevExpress.Utils.PointFloat(17.63896F, 1.333374F);
            this.xlblVal8Nombre.Name = "xlblVal8Nombre";
            this.xlblVal8Nombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Nombre.SizeF = new System.Drawing.SizeF(410.4945F, 15.47296F);
            this.xlblVal8Nombre.StylePriority.UseBorders = false;
            this.xlblVal8Nombre.StylePriority.UseFont = false;
            this.xlblVal8Nombre.StylePriority.UsePadding = false;
            this.xlblVal8Nombre.Text = "Valor 8";
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xrTableCell62.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.StylePriority.UseBackColor = false;
            this.xrTableCell62.StylePriority.UseFont = false;
            this.xrTableCell62.StylePriority.UseTextAlignment = false;
            this.xrTableCell62.Text = " Domicilio";
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell62.Weight = 0.35510555109045439D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.Text = " Código Postal:";
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell63.Weight = 0.42108727954785552D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8CP});
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StylePriority.UseTextAlignment = false;
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell64.Weight = 0.37503849303106557D;
            // 
            // xlblVal8CP
            // 
            this.xlblVal8CP.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8CP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8CP.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06752014F);
            this.xlblVal8CP.Name = "xlblVal8CP";
            this.xlblVal8CP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8CP.SizeF = new System.Drawing.SizeF(50.94299F, 22.99998F);
            this.xlblVal8CP.StylePriority.UseBorders = false;
            this.xlblVal8CP.StylePriority.UseFont = false;
            this.xlblVal8CP.StylePriority.UsePadding = false;
            this.xlblVal8CP.Text = "Valor CP";
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.StylePriority.UseTextAlignment = false;
            this.xrTableCell65.Text = "Calle:";
            this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell65.Weight = 0.22448248447734504D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8Calle});
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.StylePriority.UseTextAlignment = false;
            this.xrTableCell66.Text = " ";
            this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell66.Weight = 0.96395398836774571D;
            // 
            // xlblVal8Calle
            // 
            this.xlblVal8Calle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Calle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Calle.LocationFloat = new DevExpress.Utils.PointFloat(10.00009F, 0.06753922F);
            this.xlblVal8Calle.Name = "xlblVal8Calle";
            this.xlblVal8Calle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Calle.SizeF = new System.Drawing.SizeF(144.7063F, 22.99998F);
            this.xlblVal8Calle.StylePriority.UseBorders = false;
            this.xlblVal8Calle.StylePriority.UseFont = false;
            this.xlblVal8Calle.StylePriority.UsePadding = false;
            this.xlblVal8Calle.StylePriority.UseTextAlignment = false;
            this.xlblVal8Calle.Text = "Valor Calle";
            this.xlblVal8Calle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StylePriority.UseTextAlignment = false;
            this.xrTableCell67.Text = "Núm.  Ext.";
            this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell67.Weight = 0.35792713982602342D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8NE});
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.StylePriority.UseTextAlignment = false;
            this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell68.Weight = 0.256319088102385D;
            // 
            // xlblVal8NE
            // 
            this.xlblVal8NE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8NE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8NE.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06752014F);
            this.xlblVal8NE.Name = "xlblVal8NE";
            this.xlblVal8NE.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8NE.SizeF = new System.Drawing.SizeF(38.02808F, 22.99998F);
            this.xlblVal8NE.StylePriority.UseBorders = false;
            this.xlblVal8NE.StylePriority.UseFont = false;
            this.xlblVal8NE.StylePriority.UsePadding = false;
            this.xlblVal8NE.Text = "VNE";
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.StylePriority.UseTextAlignment = false;
            this.xrTableCell69.Text = "Núm.  Int.";
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell69.Weight = 0.346684761799537D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8NI});
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell70.Weight = 0.47151469141037705D;
            // 
            // xlblVal8NI
            // 
            this.xlblVal8NI.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8NI.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8NI.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06752014F);
            this.xlblVal8NI.Name = "xlblVal8NI";
            this.xlblVal8NI.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8NI.SizeF = new System.Drawing.SizeF(71.25F, 23F);
            this.xlblVal8NI.StylePriority.UseBorders = false;
            this.xlblVal8NI.StylePriority.UseFont = false;
            this.xlblVal8NI.StylePriority.UsePadding = false;
            this.xlblVal8NI.Text = "VNI";
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell71,
            this.xrTableCell72,
            this.xrTableCell117,
            this.xrTableCell73,
            this.xrTableCell118,
            this.xrTableCell74,
            this.xrTableCell75});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseFont = false;
            this.xrTableCell71.StylePriority.UseTextAlignment = false;
            this.xrTableCell71.Text = "Colonia:";
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell71.Weight = 0.28397333147086334D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8Colonia});
            this.xrTableCell72.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.StylePriority.UseFont = false;
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.Text = " ";
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell72.Weight = 1.2686568533319789D;
            // 
            // xlblVal8Colonia
            // 
            this.xlblVal8Colonia.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Colonia.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Colonia.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xlblVal8Colonia.Name = "xlblVal8Colonia";
            this.xlblVal8Colonia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Colonia.SizeF = new System.Drawing.SizeF(194.5755F, 22.99999F);
            this.xlblVal8Colonia.StylePriority.UseBorders = false;
            this.xlblVal8Colonia.StylePriority.UseFont = false;
            this.xlblVal8Colonia.StylePriority.UsePadding = false;
            this.xlblVal8Colonia.Text = "Valor Colonia";
            // 
            // xrTableCell117
            // 
            this.xrTableCell117.Name = "xrTableCell117";
            this.xrTableCell117.StylePriority.UseTextAlignment = false;
            this.xrTableCell117.Text = " Municipio o Delegación:";
            this.xrTableCell117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell117.Weight = 0.7770887752987562D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8Municipio});
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.StylePriority.UseTextAlignment = false;
            this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell73.Weight = 0.764849419459034D;
            // 
            // xlblVal8Municipio
            // 
            this.xlblVal8Municipio.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Municipio.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Municipio.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xlblVal8Municipio.Name = "xlblVal8Municipio";
            this.xlblVal8Municipio.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Municipio.SizeF = new System.Drawing.SizeF(113.3347F, 23F);
            this.xlblVal8Municipio.StylePriority.UseBorders = false;
            this.xlblVal8Municipio.StylePriority.UseFont = false;
            this.xlblVal8Municipio.StylePriority.UsePadding = false;
            this.xlblVal8Municipio.Text = "Valor Mun";
            // 
            // xrTableCell118
            // 
            this.xrTableCell118.Name = "xrTableCell118";
            this.xrTableCell118.StylePriority.UseTextAlignment = false;
            this.xrTableCell118.Text = "Estado:";
            this.xrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell118.Weight = 0.23569676917163154D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8Estado});
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.StylePriority.UseTextAlignment = false;
            this.xrTableCell74.Text = " ";
            this.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell74.Weight = 0.68555873125774169D;
            // 
            // xlblVal8Estado
            // 
            this.xlblVal8Estado.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Estado.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Estado.LocationFloat = new DevExpress.Utils.PointFloat(12.263F, 3.051758E-05F);
            this.xlblVal8Estado.Name = "xlblVal8Estado";
            this.xlblVal8Estado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Estado.SizeF = new System.Drawing.SizeF(92.25409F, 22.99998F);
            this.xlblVal8Estado.StylePriority.UseBorders = false;
            this.xlblVal8Estado.StylePriority.UseFont = false;
            this.xlblVal8Estado.StylePriority.UsePadding = false;
            this.xlblVal8Estado.Text = "Valor Mun";
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.StylePriority.UseTextAlignment = false;
            this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell75.Weight = 0.015093366609766012D;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78,
            this.xrTableCell79});
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Weight = 1D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.StylePriority.UseFont = false;
            this.xrTableCell76.StylePriority.UseTextAlignment = false;
            this.xrTableCell76.Text = "Telefono:";
            this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell76.Weight = 0.3551055204366988D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8Telefono});
            this.xrTableCell77.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseFont = false;
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.Text = " ";
            this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell77.Weight = 1.0978385196792466D;
            // 
            // xlblVal8Telefono
            // 
            this.xlblVal8Telefono.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Telefono.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Telefono.LocationFloat = new DevExpress.Utils.PointFloat(3.307922F, 2.472984F);
            this.xlblVal8Telefono.Name = "xlblVal8Telefono";
            this.xlblVal8Telefono.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Telefono.SizeF = new System.Drawing.SizeF(175.8685F, 20.52705F);
            this.xlblVal8Telefono.StylePriority.UseBorders = false;
            this.xlblVal8Telefono.StylePriority.UseFont = false;
            this.xlblVal8Telefono.StylePriority.UsePadding = false;
            this.xlblVal8Telefono.Text = "Valor Tel";
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.StylePriority.UseTextAlignment = false;
            this.xrTableCell78.Text = " Correo Electronico:";
            this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell78.Weight = 0.72719636972498647D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8email});
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.StylePriority.UseTextAlignment = false;
            this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell79.Weight = 1.5919730678118564D;
            // 
            // xlblVal8email
            // 
            this.xlblVal8email.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8email.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8email.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.814697E-05F);
            this.xlblVal8email.Name = "xlblVal8email";
            this.xlblVal8email.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8email.SizeF = new System.Drawing.SizeF(265.8588F, 23F);
            this.xlblVal8email.StylePriority.UseBorders = false;
            this.xlblVal8email.StylePriority.UseFont = false;
            this.xlblVal8email.StylePriority.UsePadding = false;
            this.xlblVal8email.Text = "Val Email";
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell81,
            this.xrTableCell82,
            this.xrTableCell84,
            this.xrTableCell85});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 1D;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.StylePriority.UseFont = false;
            this.xrTableCell81.StylePriority.UseTextAlignment = false;
            this.xrTableCell81.Text = "9- Núm. de autorización  de la SEMARNAT:";
            this.xrTableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell81.Weight = 1.4529440230837296D;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal9SEMARNAT});
            this.xrTableCell82.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.StylePriority.UseFont = false;
            this.xrTableCell82.StylePriority.UseTextAlignment = false;
            this.xrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell82.Weight = 0.57375797295912856D;
            // 
            // xlblVal9SEMARNAT
            // 
            this.xlblVal9SEMARNAT.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal9SEMARNAT.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal9SEMARNAT.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 0F);
            this.xlblVal9SEMARNAT.Name = "xlblVal9SEMARNAT";
            this.xlblVal9SEMARNAT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal9SEMARNAT.SizeF = new System.Drawing.SizeF(88.86838F, 20.52707F);
            this.xlblVal9SEMARNAT.StylePriority.UseBorders = false;
            this.xlblVal9SEMARNAT.StylePriority.UseFont = false;
            this.xlblVal9SEMARNAT.StylePriority.UsePadding = false;
            this.xlblVal9SEMARNAT.StylePriority.UseTextAlignment = false;
            this.xlblVal9SEMARNAT.Text = "Valor 9";
            this.xlblVal9SEMARNAT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.StylePriority.UseFont = false;
            this.xrTableCell84.StylePriority.UseTextAlignment = false;
            this.xrTableCell84.Text = "10- Núm. de permiso de S.C.T";
            this.xrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell84.Weight = 0.86918063034466853D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal10SCT});
            this.xrTableCell85.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.StylePriority.UseFont = false;
            this.xrTableCell85.StylePriority.UseTextAlignment = false;
            this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell85.Weight = 0.876230851265261D;
            // 
            // xlblVal10SCT
            // 
            this.xlblVal10SCT.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal10SCT.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal10SCT.LocationFloat = new DevExpress.Utils.PointFloat(25.98962F, 0F);
            this.xlblVal10SCT.Name = "xlblVal10SCT";
            this.xlblVal10SCT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal10SCT.SizeF = new System.Drawing.SizeF(116.5344F, 20.52707F);
            this.xlblVal10SCT.StylePriority.UseBorders = false;
            this.xlblVal10SCT.StylePriority.UseFont = false;
            this.xlblVal10SCT.StylePriority.UsePadding = false;
            this.xlblVal10SCT.StylePriority.UseTextAlignment = false;
            this.xlblVal10SCT.Text = "Valor 10";
            this.xlblVal10SCT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "11- Tipo de vehículo ";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell10.Weight = 1.4529440230837296D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal11TipoVehiculo});
            this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell11.Weight = 0.573757884408538D;
            // 
            // xlblVal11TipoVehiculo
            // 
            this.xlblVal11TipoVehiculo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal11TipoVehiculo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal11TipoVehiculo.LocationFloat = new DevExpress.Utils.PointFloat(0.4407196F, 0F);
            this.xlblVal11TipoVehiculo.Name = "xlblVal11TipoVehiculo";
            this.xlblVal11TipoVehiculo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal11TipoVehiculo.SizeF = new System.Drawing.SizeF(88.42767F, 20.52707F);
            this.xlblVal11TipoVehiculo.StylePriority.UseBorders = false;
            this.xlblVal11TipoVehiculo.StylePriority.UseFont = false;
            this.xlblVal11TipoVehiculo.StylePriority.UsePadding = false;
            this.xlblVal11TipoVehiculo.StylePriority.UseTextAlignment = false;
            this.xlblVal11TipoVehiculo.Text = "Valor 11";
            this.xlblVal11TipoVehiculo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "12- Núm. de placa:";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell12.Weight = 0.86918071889525916D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal12Placa});
            this.xrTableCell13.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell13.Weight = 0.876230851265261D;
            // 
            // xlblVal12Placa
            // 
            this.xlblVal12Placa.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal12Placa.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal12Placa.LocationFloat = new DevExpress.Utils.PointFloat(25.98956F, 0F);
            this.xlblVal12Placa.Name = "xlblVal12Placa";
            this.xlblVal12Placa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal12Placa.SizeF = new System.Drawing.SizeF(114.9999F, 20.52707F);
            this.xlblVal12Placa.StylePriority.UseBorders = false;
            this.xlblVal12Placa.StylePriority.UseFont = false;
            this.xlblVal12Placa.StylePriority.UsePadding = false;
            this.xlblVal12Placa.StylePriority.UseTextAlignment = false;
            this.xlblVal12Placa.Text = "Valor 12";
            this.xlblVal12Placa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable8
            // 
            this.xrTable8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(1.890209F, 327.9456F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow19});
            this.xrTable8.SizeF = new System.Drawing.SizeF(646.2191F, 20.09149F);
            this.xrTable8.StylePriority.UseFont = false;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell123,
            this.xrTableCell14});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Weight = 2.0548773705925614D;
            // 
            // xrTableCell123
            // 
            this.xrTableCell123.Name = "xrTableCell123";
            this.xrTableCell123.StylePriority.UseTextAlignment = false;
            this.xrTableCell123.Text = "13- Ruta de la empresa generadora hasta su entrega:";
            this.xrTableCell123.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell123.Weight = 1.9062409518435983D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal13Ruta});
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell14.Weight = 3.0513615040644515D;
            // 
            // xlblVal13Ruta
            // 
            this.xlblVal13Ruta.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal13Ruta.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal13Ruta.LocationFloat = new DevExpress.Utils.PointFloat(5.152418F, 0F);
            this.xlblVal13Ruta.Name = "xlblVal13Ruta";
            this.xlblVal13Ruta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal13Ruta.SizeF = new System.Drawing.SizeF(377.7422F, 16.83066F);
            this.xlblVal13Ruta.StylePriority.UseBorders = false;
            this.xlblVal13Ruta.StylePriority.UseFont = false;
            this.xlblVal13Ruta.StylePriority.UsePadding = false;
            this.xlblVal13Ruta.Text = "Valor 13";
            // 
            // xrTable9
            // 
            this.xrTable9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 447.8705F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow21,
            this.xrTableRow22,
            this.xrTableRow23,
            this.xrTableRow24,
            this.xrTableRow25,
            this.xrTableRow26,
            this.xrTableRow27});
            this.xrTable9.SizeF = new System.Drawing.SizeF(650F, 178.3109F);
            this.xrTable9.StylePriority.UseBorders = false;
            this.xrTable9.StylePriority.UseFont = false;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell80});
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.Weight = 1D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = " 15- Nombre o razon social del destinatario:";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell15.Weight = 3.2657224801471529D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15NombreDest});
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.StylePriority.UseTextAlignment = false;
            this.xrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell80.Weight = 6.8004317451351692D;
            // 
            // xlblVal15NombreDest
            // 
            this.xlblVal15NombreDest.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15NombreDest.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15NombreDest.LocationFloat = new DevExpress.Utils.PointFloat(10.00015F, 2.472961F);
            this.xlblVal15NombreDest.Name = "xlblVal15NombreDest";
            this.xlblVal15NombreDest.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15NombreDest.SizeF = new System.Drawing.SizeF(420.6575F, 13.00003F);
            this.xlblVal15NombreDest.StylePriority.UseBorders = false;
            this.xlblVal15NombreDest.StylePriority.UseFont = false;
            this.xlblVal15NombreDest.StylePriority.UsePadding = false;
            this.xlblVal15NombreDest.Text = "Valor 15";
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell83,
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell88,
            this.xrTableCell89,
            this.xrTableCell90,
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93});
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.Weight = 1D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xrTableCell83.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.StylePriority.UseBackColor = false;
            this.xrTableCell83.StylePriority.UseFont = false;
            this.xrTableCell83.StylePriority.UseTextAlignment = false;
            this.xrTableCell83.Text = " Domicilio";
            this.xrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell83.Weight = 0.35510555109045439D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.StylePriority.UseTextAlignment = false;
            this.xrTableCell86.Text = " Código Postal:";
            this.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell86.Weight = 0.42108798795258012D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15CP});
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.StylePriority.UseTextAlignment = false;
            this.xrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell87.Weight = 0.38343273481544177D;
            // 
            // xlblVal15CP
            // 
            this.xlblVal15CP.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15CP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15CP.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 0.06750488F);
            this.xlblVal15CP.Name = "xlblVal15CP";
            this.xlblVal15CP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15CP.SizeF = new System.Drawing.SizeF(64.62556F, 23F);
            this.xlblVal15CP.StylePriority.UseBorders = false;
            this.xlblVal15CP.StylePriority.UseFont = false;
            this.xlblVal15CP.StylePriority.UsePadding = false;
            this.xlblVal15CP.Text = "Valor CP";
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.StylePriority.UseTextAlignment = false;
            this.xrTableCell88.Text = "Calle:";
            this.xrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell88.Weight = 0.21608841979414994D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15Calle});
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.StylePriority.UseTextAlignment = false;
            this.xrTableCell89.Text = " ";
            this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell89.Weight = 0.96395363416538338D;
            // 
            // xlblVal15Calle
            // 
            this.xlblVal15Calle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Calle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Calle.LocationFloat = new DevExpress.Utils.PointFloat(10.00009F, 0.06753922F);
            this.xlblVal15Calle.Name = "xlblVal15Calle";
            this.xlblVal15Calle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Calle.SizeF = new System.Drawing.SizeF(144.7063F, 22.99998F);
            this.xlblVal15Calle.StylePriority.UseBorders = false;
            this.xlblVal15Calle.StylePriority.UseFont = false;
            this.xlblVal15Calle.StylePriority.UsePadding = false;
            this.xlblVal15Calle.Text = "Valor Calle";
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.StylePriority.UseTextAlignment = false;
            this.xrTableCell90.Text = "Núm.  Ext.";
            this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell90.Weight = 0.35792713982602342D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15NE});
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.StylePriority.UseTextAlignment = false;
            this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell91.Weight = 0.25631924306591858D;
            // 
            // xlblVal15NE
            // 
            this.xlblVal15NE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15NE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15NE.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06753922F);
            this.xlblVal15NE.Name = "xlblVal15NE";
            this.xlblVal15NE.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15NE.SizeF = new System.Drawing.SizeF(38.02811F, 22.99998F);
            this.xlblVal15NE.StylePriority.UseBorders = false;
            this.xlblVal15NE.StylePriority.UseFont = false;
            this.xlblVal15NE.StylePriority.UsePadding = false;
            this.xlblVal15NE.Text = "VNE";
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.StylePriority.UseTextAlignment = false;
            this.xrTableCell92.Text = "Núm.  Int.";
            this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell92.Weight = 0.34668442973482227D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15NI});
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.StylePriority.UseTextAlignment = false;
            this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell93.Weight = 0.47151433720801472D;
            // 
            // xlblVal15NI
            // 
            this.xlblVal15NI.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15NI.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15NI.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06750488F);
            this.xlblVal15NI.Name = "xlblVal15NI";
            this.xlblVal15NI.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15NI.SizeF = new System.Drawing.SizeF(72.78455F, 23.00006F);
            this.xlblVal15NI.StylePriority.UseBorders = false;
            this.xlblVal15NI.StylePriority.UseFont = false;
            this.xlblVal15NI.StylePriority.UsePadding = false;
            this.xlblVal15NI.Text = "VNI";
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell94,
            this.xrTableCell95,
            this.xrTableCell115,
            this.xrTableCell96,
            this.xrTableCell116,
            this.xrTableCell97,
            this.xrTableCell98});
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 1D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.StylePriority.UseFont = false;
            this.xrTableCell94.StylePriority.UseTextAlignment = false;
            this.xrTableCell94.Text = "Colonia:";
            this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell94.Weight = 0.28397333147086334D;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15Colonia});
            this.xrTableCell95.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.StylePriority.UseFont = false;
            this.xrTableCell95.StylePriority.UseTextAlignment = false;
            this.xrTableCell95.Text = " ";
            this.xrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell95.Weight = 1.2686568533319789D;
            // 
            // xlblVal15Colonia
            // 
            this.xlblVal15Colonia.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Colonia.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Colonia.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xlblVal15Colonia.Name = "xlblVal15Colonia";
            this.xlblVal15Colonia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Colonia.SizeF = new System.Drawing.SizeF(194.5755F, 22.99999F);
            this.xlblVal15Colonia.StylePriority.UseBorders = false;
            this.xlblVal15Colonia.StylePriority.UseFont = false;
            this.xlblVal15Colonia.StylePriority.UsePadding = false;
            this.xlblVal15Colonia.Text = "Valor Colonia";
            // 
            // xrTableCell115
            // 
            this.xrTableCell115.Name = "xrTableCell115";
            this.xrTableCell115.StylePriority.UseTextAlignment = false;
            this.xrTableCell115.Text = " Municipio o Delegación:";
            this.xrTableCell115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell115.Weight = 0.77708905917683D;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15Municipio});
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.StylePriority.UseTextAlignment = false;
            this.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell96.Weight = 0.82686298684554282D;
            // 
            // xlblVal15Municipio
            // 
            this.xlblVal15Municipio.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Municipio.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Municipio.LocationFloat = new DevExpress.Utils.PointFloat(0.5591736F, 3.051758E-05F);
            this.xlblVal15Municipio.Name = "xlblVal15Municipio";
            this.xlblVal15Municipio.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Municipio.SizeF = new System.Drawing.SizeF(122.7755F, 22.99994F);
            this.xlblVal15Municipio.StylePriority.UseBorders = false;
            this.xlblVal15Municipio.StylePriority.UseFont = false;
            this.xlblVal15Municipio.StylePriority.UsePadding = false;
            this.xlblVal15Municipio.Text = "Valor Del";
            // 
            // xrTableCell116
            // 
            this.xrTableCell116.Name = "xrTableCell116";
            this.xrTableCell116.StylePriority.UseTextAlignment = false;
            this.xrTableCell116.Text = "Estado:";
            this.xrTableCell116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell116.Weight = 0.26648221076507805D;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15Estado});
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.StylePriority.UseTextAlignment = false;
            this.xrTableCell97.Text = " ";
            this.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell97.Weight = 0.59275943839971246D;
            // 
            // xlblVal15Estado
            // 
            this.xlblVal15Estado.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Estado.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Estado.LocationFloat = new DevExpress.Utils.PointFloat(10.51849F, 0F);
            this.xlblVal15Estado.Name = "xlblVal15Estado";
            this.xlblVal15Estado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Estado.SizeF = new System.Drawing.SizeF(70.72119F, 22.99994F);
            this.xlblVal15Estado.StylePriority.UseBorders = false;
            this.xlblVal15Estado.StylePriority.UseFont = false;
            this.xlblVal15Estado.StylePriority.UsePadding = false;
            this.xlblVal15Estado.Text = "Valor Del";
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.StylePriority.UseTextAlignment = false;
            this.xrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell98.Weight = 0.015093366609766012D;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell99,
            this.xrTableCell100,
            this.xrTableCell101,
            this.xrTableCell102});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.Weight = 1D;
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.StylePriority.UseFont = false;
            this.xrTableCell99.StylePriority.UseTextAlignment = false;
            this.xrTableCell99.Text = "Telefono:";
            this.xrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell99.Weight = 0.3551055204366988D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15Telefono});
            this.xrTableCell100.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.StylePriority.UseFont = false;
            this.xrTableCell100.StylePriority.UseTextAlignment = false;
            this.xrTableCell100.Text = " ";
            this.xrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell100.Weight = 1.0978385196792466D;
            // 
            // xlblVal15Telefono
            // 
            this.xlblVal15Telefono.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Telefono.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Telefono.LocationFloat = new DevExpress.Utils.PointFloat(3.307922F, 2.472984F);
            this.xlblVal15Telefono.Name = "xlblVal15Telefono";
            this.xlblVal15Telefono.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Telefono.SizeF = new System.Drawing.SizeF(175.8685F, 20.52705F);
            this.xlblVal15Telefono.StylePriority.UseBorders = false;
            this.xlblVal15Telefono.StylePriority.UseFont = false;
            this.xlblVal15Telefono.StylePriority.UsePadding = false;
            this.xlblVal15Telefono.Text = "Valor Tel";
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.StylePriority.UseTextAlignment = false;
            this.xrTableCell101.Text = " Correo Electronico:";
            this.xrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell101.Weight = 0.72719636972498647D;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15Email});
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.StylePriority.UseTextAlignment = false;
            this.xrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell102.Weight = 1.5919730678118564D;
            // 
            // xlblVal15Email
            // 
            this.xlblVal15Email.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Email.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Email.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.814697E-05F);
            this.xlblVal15Email.Name = "xlblVal15Email";
            this.xlblVal15Email.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Email.SizeF = new System.Drawing.SizeF(265.8588F, 23F);
            this.xlblVal15Email.StylePriority.UseBorders = false;
            this.xlblVal15Email.StylePriority.UseFont = false;
            this.xlblVal15Email.StylePriority.UsePadding = false;
            this.xlblVal15Email.Text = "Val Email";
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell103,
            this.xrTableCell104});
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.Weight = 1D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.StylePriority.UseFont = false;
            this.xrTableCell103.StylePriority.UseTextAlignment = false;
            this.xrTableCell103.Text = "16- Núm. de autorización  de la SEMARNAT:";
            this.xrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell103.Weight = 1.6056965368980718D;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal16SEMARNAT});
            this.xrTableCell104.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.StylePriority.UseFont = false;
            this.xrTableCell104.StylePriority.UseTextAlignment = false;
            this.xrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell104.Weight = 2.1664169407547162D;
            // 
            // xlblVal16SEMARNAT
            // 
            this.xlblVal16SEMARNAT.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal16SEMARNAT.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal16SEMARNAT.LocationFloat = new DevExpress.Utils.PointFloat(9.999969F, 3.051758E-05F);
            this.xlblVal16SEMARNAT.Name = "xlblVal16SEMARNAT";
            this.xlblVal16SEMARNAT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal16SEMARNAT.SizeF = new System.Drawing.SizeF(138.6163F, 20.5271F);
            this.xlblVal16SEMARNAT.StylePriority.UseBorders = false;
            this.xlblVal16SEMARNAT.StylePriority.UseFont = false;
            this.xlblVal16SEMARNAT.StylePriority.UsePadding = false;
            this.xlblVal16SEMARNAT.StylePriority.UseTextAlignment = false;
            this.xlblVal16SEMARNAT.Text = "Valor 16";
            this.xlblVal16SEMARNAT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell107,
            this.xrTableCell108});
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.Weight = 1D;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.StylePriority.UseFont = false;
            this.xrTableCell107.StylePriority.UseTextAlignment = false;
            this.xrTableCell107.Text = "17- Nombre y cargo de la persona que recibe los reciduos:";
            this.xrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell107.Weight = 1.6056965368980718D;
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal17NombreRecibeResiduos});
            this.xrTableCell108.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.StylePriority.UseFont = false;
            this.xrTableCell108.StylePriority.UseTextAlignment = false;
            this.xrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell108.Weight = 2.1664169407547162D;
            // 
            // xlblVal17NombreRecibeResiduos
            // 
            this.xlblVal17NombreRecibeResiduos.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal17NombreRecibeResiduos.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal17NombreRecibeResiduos.LocationFloat = new DevExpress.Utils.PointFloat(9.999971F, 0F);
            this.xlblVal17NombreRecibeResiduos.Name = "xlblVal17NombreRecibeResiduos";
            this.xlblVal17NombreRecibeResiduos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal17NombreRecibeResiduos.SizeF = new System.Drawing.SizeF(138.6163F, 20.5271F);
            this.xlblVal17NombreRecibeResiduos.StylePriority.UseBorders = false;
            this.xlblVal17NombreRecibeResiduos.StylePriority.UseFont = false;
            this.xlblVal17NombreRecibeResiduos.StylePriority.UsePadding = false;
            this.xlblVal17NombreRecibeResiduos.StylePriority.UseTextAlignment = false;
            this.xlblVal17NombreRecibeResiduos.Text = "Valor 17";
            this.xlblVal17NombreRecibeResiduos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell105,
            this.xrTableCell106});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 1D;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.StylePriority.UseFont = false;
            this.xrTableCell105.StylePriority.UseTextAlignment = false;
            this.xrTableCell105.Text = "18- Observaciones:";
            this.xrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell105.Weight = 1.6056965368980718D;
            // 
            // xrTableCell106
            // 
            this.xrTableCell106.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal18Observaciones});
            this.xrTableCell106.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell106.Name = "xrTableCell106";
            this.xrTableCell106.StylePriority.UseFont = false;
            this.xrTableCell106.StylePriority.UseTextAlignment = false;
            this.xrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell106.Weight = 2.1664169407547162D;
            // 
            // xlblVal18Observaciones
            // 
            this.xlblVal18Observaciones.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal18Observaciones.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal18Observaciones.LocationFloat = new DevExpress.Utils.PointFloat(9.999969F, 0F);
            this.xlblVal18Observaciones.Name = "xlblVal18Observaciones";
            this.xlblVal18Observaciones.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal18Observaciones.SizeF = new System.Drawing.SizeF(352.3214F, 20.5271F);
            this.xlblVal18Observaciones.StylePriority.UseBorders = false;
            this.xlblVal18Observaciones.StylePriority.UseFont = false;
            this.xlblVal18Observaciones.StylePriority.UsePadding = false;
            this.xlblVal18Observaciones.StylePriority.UseTextAlignment = false;
            this.xlblVal18Observaciones.Text = "...";
            this.xlblVal18Observaciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable10
            // 
            this.xrTable10.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 626.1815F);
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow28});
            this.xrTable10.SizeF = new System.Drawing.SizeF(650.0001F, 58.13055F);
            this.xrTable10.StylePriority.UseFont = false;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell109});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 2.0548773705925614D;
            // 
            // xrTableCell109
            // 
            this.xrTableCell109.Name = "xrTableCell109";
            this.xrTableCell109.StylePriority.UseTextAlignment = false;
            this.xrTableCell109.Text = "19- Declaro bajo protesta de decir verdad que recibí los residuos peligrosos desc" +
    "ritos en el manifiesto.";
            this.xrTableCell109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell109.Weight = 4.98660968862913D;
            // 
            // xrTable11
            // 
            this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 684.312F);
            this.xrTable11.Name = "xrTable11";
            this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow29,
            this.xrTableRow33});
            this.xrTable11.SizeF = new System.Drawing.SizeF(648.1095F, 51.60474F);
            // 
            // xrTableRow29
            // 
            this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell110,
            this.xrTableCell111,
            this.xrTableCell112});
            this.xrTableRow29.Name = "xrTableRow29";
            this.xrTableRow29.Weight = 1D;
            // 
            // xrTableCell110
            // 
            this.xrTableCell110.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell110.Name = "xrTableCell110";
            this.xrTableCell110.StylePriority.UseFont = false;
            this.xrTableCell110.Text = "Nombre y firma del responsable";
            this.xrTableCell110.Weight = 1.350045805326062D;
            // 
            // xrTableCell111
            // 
            this.xrTableCell111.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell111.Name = "xrTableCell111";
            this.xrTableCell111.StylePriority.UseFont = false;
            this.xrTableCell111.Text = "Fecha:";
            this.xrTableCell111.Weight = 0.91155315927704073D;
            // 
            // xrTableCell112
            // 
            this.xrTableCell112.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell112.Name = "xrTableCell112";
            this.xrTableCell112.StylePriority.UseFont = false;
            this.xrTableCell112.Text = "Sello:";
            this.xrTableCell112.Weight = 0.75555057788823365D;
            // 
            // xrTableRow33
            // 
            this.xrTableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell127,
            this.xrTableCell128,
            this.xrTableCell129});
            this.xrTableRow33.Name = "xrTableRow33";
            this.xrTableRow33.Weight = 1D;
            // 
            // xrTableCell127
            // 
            this.xrTableCell127.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblResponsableDes});
            this.xrTableCell127.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell127.Name = "xrTableCell127";
            this.xrTableCell127.StylePriority.UseFont = false;
            this.xrTableCell127.Weight = 1.350045805326062D;
            // 
            // xlblResponsableDes
            // 
            this.xlblResponsableDes.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblResponsableDes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblResponsableDes.LocationFloat = new DevExpress.Utils.PointFloat(12.5F, 0.814209F);
            this.xlblResponsableDes.Name = "xlblResponsableDes";
            this.xlblResponsableDes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblResponsableDes.SizeF = new System.Drawing.SizeF(270.0014F, 22.99998F);
            this.xlblResponsableDes.StylePriority.UseBorders = false;
            this.xlblResponsableDes.StylePriority.UseFont = false;
            this.xlblResponsableDes.StylePriority.UsePadding = false;
            this.xlblResponsableDes.Text = "Nombre Responsable";
            // 
            // xrTableCell128
            // 
            this.xrTableCell128.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal19FechaDes});
            this.xrTableCell128.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell128.Name = "xrTableCell128";
            this.xrTableCell128.StylePriority.UseFont = false;
            this.xrTableCell128.Weight = 0.91155315927704073D;
            // 
            // xlblVal19FechaDes
            // 
            this.xlblVal19FechaDes.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal19FechaDes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal19FechaDes.LocationFloat = new DevExpress.Utils.PointFloat(9.998627F, 0F);
            this.xlblVal19FechaDes.Name = "xlblVal19FechaDes";
            this.xlblVal19FechaDes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal19FechaDes.SizeF = new System.Drawing.SizeF(172.9503F, 22.99998F);
            this.xlblVal19FechaDes.StylePriority.UseBorders = false;
            this.xlblVal19FechaDes.StylePriority.UseFont = false;
            this.xlblVal19FechaDes.StylePriority.UsePadding = false;
            this.xlblVal19FechaDes.StylePriority.UseTextAlignment = false;
            this.xlblVal19FechaDes.Text = "Valor Fecha";
            this.xlblVal19FechaDes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell129
            // 
            this.xrTableCell129.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell129.Name = "xrTableCell129";
            this.xrTableCell129.StylePriority.UseFont = false;
            this.xrTableCell129.Weight = 0.75555057788823365D;
            // 
            // xrTable12
            // 
            this.xrTable12.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 28.86262F);
            this.xrTable12.Name = "xrTable12";
            this.xrTable12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow30});
            this.xrTable12.SizeF = new System.Drawing.SizeF(650F, 27.7496F);
            this.xrTable12.StylePriority.UseFont = false;
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell119});
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Weight = 1D;
            // 
            // xrTableCell119
            // 
            this.xrTableCell119.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal6Instrucciones});
            this.xrTableCell119.Name = "xrTableCell119";
            this.xrTableCell119.Weight = 1D;
            // 
            // xlblVal6Instrucciones
            // 
            this.xlblVal6Instrucciones.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal6Instrucciones.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal6Instrucciones.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 1.487621F);
            this.xlblVal6Instrucciones.Name = "xlblVal6Instrucciones";
            this.xlblVal6Instrucciones.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal6Instrucciones.SizeF = new System.Drawing.SizeF(629.0105F, 23.87067F);
            this.xlblVal6Instrucciones.StylePriority.UseBorders = false;
            this.xlblVal6Instrucciones.StylePriority.UseFont = false;
            this.xlblVal6Instrucciones.StylePriority.UsePadding = false;
            this.xlblVal6Instrucciones.Text = "Val 6";
            // 
            // xrTable13
            // 
            this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 134.816F);
            this.xrTable13.Name = "xrTable13";
            this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow31});
            this.xrTable13.SizeF = new System.Drawing.SizeF(648.1095F, 32.29166F);
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell120,
            this.xrTableCell121,
            this.xrTableCell122});
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.Weight = 1D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal6Responsable});
            this.xrTableCell120.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.StylePriority.UseFont = false;
            this.xrTableCell120.Weight = 1.350045805326062D;
            // 
            // xlblVal6Responsable
            // 
            this.xlblVal6Responsable.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal6Responsable.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal6Responsable.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xlblVal6Responsable.Name = "xlblVal6Responsable";
            this.xlblVal6Responsable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal6Responsable.SizeF = new System.Drawing.SizeF(270.0014F, 22.99998F);
            this.xlblVal6Responsable.StylePriority.UseBorders = false;
            this.xlblVal6Responsable.StylePriority.UseFont = false;
            this.xlblVal6Responsable.StylePriority.UsePadding = false;
            this.xlblVal6Responsable.Text = "Nombre Responsable";
            // 
            // xrTableCell121
            // 
            this.xrTableCell121.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal7Fecha});
            this.xrTableCell121.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell121.Name = "xrTableCell121";
            this.xrTableCell121.StylePriority.UseFont = false;
            this.xrTableCell121.Weight = 0.91155315927704073D;
            // 
            // xlblVal7Fecha
            // 
            this.xlblVal7Fecha.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal7Fecha.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal7Fecha.LocationFloat = new DevExpress.Utils.PointFloat(1.890442F, 0F);
            this.xlblVal7Fecha.Name = "xlblVal7Fecha";
            this.xlblVal7Fecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal7Fecha.SizeF = new System.Drawing.SizeF(172.9503F, 22.99998F);
            this.xlblVal7Fecha.StylePriority.UseBorders = false;
            this.xlblVal7Fecha.StylePriority.UseFont = false;
            this.xlblVal7Fecha.StylePriority.UsePadding = false;
            this.xlblVal7Fecha.StylePriority.UseTextAlignment = false;
            this.xlblVal7Fecha.Text = "Valor Fecha";
            this.xlblVal7Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell122
            // 
            this.xrTableCell122.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell122.Name = "xrTableCell122";
            this.xrTableCell122.StylePriority.UseFont = false;
            this.xrTableCell122.Weight = 0.75555057788823365D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
            this.GroupHeader1.HeightF = 178.3109F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow9,
            this.xrTableRow10,
            this.xrTableRow11,
            this.xrTableRow12});
            this.xrTable6.SizeF = new System.Drawing.SizeF(650F, 178.3109F);
            this.xrTable6.StylePriority.UseBorders = false;
            this.xrTable6.StylePriority.UseFont = false;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell17,
            this.xrTableCell21,
            this.xrTableCell20,
            this.xrTableCell23,
            this.xrTableCell22});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.Text = " 1- Núm de registro ambiental:";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell19.Weight = 0.906965562687967D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal1RegistroAmbiental});
            this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell17.Weight = 0.64566459595726033D;
            // 
            // xlblVal1RegistroAmbiental
            // 
            this.xlblVal1RegistroAmbiental.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal1RegistroAmbiental.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal1RegistroAmbiental.LocationFloat = new DevExpress.Utils.PointFloat(3.307999F, 1.013525F);
            this.xlblVal1RegistroAmbiental.Name = "xlblVal1RegistroAmbiental";
            this.xlblVal1RegistroAmbiental.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal1RegistroAmbiental.SizeF = new System.Drawing.SizeF(90.80779F, 23.00001F);
            this.xlblVal1RegistroAmbiental.StylePriority.UseBorders = false;
            this.xlblVal1RegistroAmbiental.StylePriority.UseFont = false;
            this.xlblVal1RegistroAmbiental.StylePriority.UsePadding = false;
            this.xlblVal1RegistroAmbiental.Text = "Valor 1";
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "2- Núm de manifiesto:";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell21.Weight = 0.77708926150768654D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal2NumManifiesto});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell20.Weight = 0.69248933733832119D;
            // 
            // xlblVal2NumManifiesto
            // 
            this.xlblVal2NumManifiesto.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal2NumManifiesto.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal2NumManifiesto.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 1.013525F);
            this.xlblVal2NumManifiesto.Name = "xlblVal2NumManifiesto";
            this.xlblVal2NumManifiesto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal2NumManifiesto.SizeF = new System.Drawing.SizeF(101.6664F, 23.00001F);
            this.xlblVal2NumManifiesto.StylePriority.UseBorders = false;
            this.xlblVal2NumManifiesto.StylePriority.UseFont = false;
            this.xlblVal2NumManifiesto.StylePriority.UsePadding = false;
            this.xlblVal2NumManifiesto.Text = "Valor 2";
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "3- Página:";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell23.Weight = 0.50435424455426814D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal3Pagina});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell22.Weight = 0.50435424455426814D;
            // 
            // xlblVal3Pagina
            // 
            this.xlblVal3Pagina.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal3Pagina.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal3Pagina.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.013525F);
            this.xlblVal3Pagina.Name = "xlblVal3Pagina";
            this.xlblVal3Pagina.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal3Pagina.SizeF = new System.Drawing.SizeF(70.33942F, 23.00001F);
            this.xlblVal3Pagina.StylePriority.UseBorders = false;
            this.xlblVal3Pagina.StylePriority.UseFont = false;
            this.xlblVal3Pagina.StylePriority.UsePadding = false;
            this.xlblVal3Pagina.Text = "Valor 4";
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell24,
            this.xrTableCell29});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.StylePriority.UseTextAlignment = false;
            this.xrTableCell24.Text = " 4- Nombre o razon social del generador:";
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell24.Weight = 3.2657224801471529D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4NombreGenerador});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseTextAlignment = false;
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell29.Weight = 6.8004317451351692D;
            // 
            // xlblVal4NombreGenerador
            // 
            this.xlblVal4NombreGenerador.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4NombreGenerador.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4NombreGenerador.LocationFloat = new DevExpress.Utils.PointFloat(16.18245F, 0.5405445F);
            this.xlblVal4NombreGenerador.Name = "xlblVal4NombreGenerador";
            this.xlblVal4NombreGenerador.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4NombreGenerador.SizeF = new System.Drawing.SizeF(414.4752F, 22.45946F);
            this.xlblVal4NombreGenerador.StylePriority.UseBorders = false;
            this.xlblVal4NombreGenerador.StylePriority.UseFont = false;
            this.xlblVal4NombreGenerador.StylePriority.UsePadding = false;
            this.xlblVal4NombreGenerador.Text = "Valor 4";
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell30,
            this.xrTableCell26,
            this.xrTableCell31,
            this.xrTableCell33,
            this.xrTableCell32,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell46,
            this.xrTableCell45});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xrTableCell30.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseBackColor = false;
            this.xrTableCell30.StylePriority.UseFont = false;
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.Text = " Domicilio";
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell30.Weight = 0.35510555109045439D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseTextAlignment = false;
            this.xrTableCell26.Text = " Código Postal:";
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell26.Weight = 0.4936285432030047D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4CP});
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseTextAlignment = false;
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell31.Weight = 0.46894834245140271D;
            // 
            // xlblVal4CP
            // 
            this.xlblVal4CP.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4CP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4CP.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 0.06753922F);
            this.xlblVal4CP.Name = "xlblVal4CP";
            this.xlblVal4CP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4CP.SizeF = new System.Drawing.SizeF(71.28027F, 22.99999F);
            this.xlblVal4CP.StylePriority.UseBorders = false;
            this.xlblVal4CP.StylePriority.UseFont = false;
            this.xlblVal4CP.StylePriority.UsePadding = false;
            this.xlblVal4CP.Text = "Valor CP";
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseTextAlignment = false;
            this.xrTableCell33.Text = "Calle:";
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell33.Weight = 0.22222896049774052D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4Calle});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseTextAlignment = false;
            this.xrTableCell32.Text = " ";
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell32.Weight = 0.95583221675057617D;
            // 
            // xlblVal4Calle
            // 
            this.xlblVal4Calle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4Calle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4Calle.LocationFloat = new DevExpress.Utils.PointFloat(10.00004F, 2.473005F);
            this.xlblVal4Calle.Name = "xlblVal4Calle";
            this.xlblVal4Calle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4Calle.SizeF = new System.Drawing.SizeF(144.7063F, 22.99998F);
            this.xlblVal4Calle.StylePriority.UseBorders = false;
            this.xlblVal4Calle.StylePriority.UseFont = false;
            this.xlblVal4Calle.StylePriority.UsePadding = false;
            this.xlblVal4Calle.Text = "Valor Calle";
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseTextAlignment = false;
            this.xrTableCell34.Text = "Núm.  Ext.";
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell34.Weight = 0.40013885215191297D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4NE});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseTextAlignment = false;
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell35.Weight = 0.27871924397250458D;
            // 
            // xlblVal4NE
            // 
            this.xlblVal4NE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4NE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4NE.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06753922F);
            this.xlblVal4NE.Name = "xlblVal4NE";
            this.xlblVal4NE.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4NE.SizeF = new System.Drawing.SizeF(38.02811F, 22.99998F);
            this.xlblVal4NE.StylePriority.UseBorders = false;
            this.xlblVal4NE.StylePriority.UseFont = false;
            this.xlblVal4NE.StylePriority.UsePadding = false;
            this.xlblVal4NE.Text = "VNE";
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.StylePriority.UseTextAlignment = false;
            this.xrTableCell46.Text = "Núm.  Int.";
            this.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell46.Weight = 0.36916031849753317D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4NI});
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseTextAlignment = false;
            this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell45.Weight = 0.22835144903765953D;
            // 
            // xlblVal4NI
            // 
            this.xlblVal4NI.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4NI.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4NI.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06753922F);
            this.xlblVal4NI.Name = "xlblVal4NI";
            this.xlblVal4NI.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4NI.SizeF = new System.Drawing.SizeF(35.66498F, 23.00001F);
            this.xlblVal4NI.StylePriority.UseBorders = false;
            this.xlblVal4NI.StylePriority.UseFont = false;
            this.xlblVal4NI.StylePriority.UsePadding = false;
            this.xlblVal4NI.Text = "VNI";
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell37,
            this.xrTableCell36,
            this.xrTableCell113,
            this.xrTableCell38,
            this.xrTableCell114,
            this.xrTableCell40,
            this.xrTableCell47});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.StylePriority.UseFont = false;
            this.xrTableCell37.StylePriority.UseTextAlignment = false;
            this.xrTableCell37.Text = "Colonia:";
            this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell37.Weight = 0.28397333147086334D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4Col});
            this.xrTableCell36.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseFont = false;
            this.xrTableCell36.StylePriority.UseTextAlignment = false;
            this.xrTableCell36.Text = " ";
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell36.Weight = 1.2686568533319789D;
            // 
            // xlblVal4Col
            // 
            this.xlblVal4Col.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4Col.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4Col.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xlblVal4Col.Name = "xlblVal4Col";
            this.xlblVal4Col.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4Col.SizeF = new System.Drawing.SizeF(194.5755F, 22.99999F);
            this.xlblVal4Col.StylePriority.UseBorders = false;
            this.xlblVal4Col.StylePriority.UseFont = false;
            this.xlblVal4Col.StylePriority.UsePadding = false;
            this.xlblVal4Col.Text = "Valor Colonia";
            // 
            // xrTableCell113
            // 
            this.xrTableCell113.Name = "xrTableCell113";
            this.xrTableCell113.StylePriority.UseTextAlignment = false;
            this.xrTableCell113.Text = " Municipio o Delegación:";
            this.xrTableCell113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell113.Weight = 0.77708924842887928D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4Mun});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseTextAlignment = false;
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell38.Weight = 0.82686260834144432D;
            // 
            // xlblVal4Mun
            // 
            this.xlblVal4Mun.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4Mun.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4Mun.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.433228E-05F);
            this.xlblVal4Mun.Name = "xlblVal4Mun";
            this.xlblVal4Mun.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4Mun.SizeF = new System.Drawing.SizeF(111.8243F, 22.99998F);
            this.xlblVal4Mun.StylePriority.UseBorders = false;
            this.xlblVal4Mun.StylePriority.UseFont = false;
            this.xlblVal4Mun.StylePriority.UsePadding = false;
            this.xlblVal4Mun.Text = "Valor CP";
            // 
            // xrTableCell114
            // 
            this.xrTableCell114.Name = "xrTableCell114";
            this.xrTableCell114.StylePriority.UseTextAlignment = false;
            this.xrTableCell114.Text = " Estado:";
            this.xrTableCell114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell114.Weight = 0.26648240001712731D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4Edo});
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseTextAlignment = false;
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell40.Weight = 0.59275943839971246D;
            // 
            // xlblVal4Edo
            // 
            this.xlblVal4Edo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4Edo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4Edo.LocationFloat = new DevExpress.Utils.PointFloat(10F, 1.907349E-05F);
            this.xlblVal4Edo.Name = "xlblVal4Edo";
            this.xlblVal4Edo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4Edo.SizeF = new System.Drawing.SizeF(71.28027F, 22.99999F);
            this.xlblVal4Edo.StylePriority.UseBorders = false;
            this.xlblVal4Edo.StylePriority.UseFont = false;
            this.xlblVal4Edo.StylePriority.UsePadding = false;
            this.xlblVal4Edo.Text = "Valor CP";
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.StylePriority.UseTextAlignment = false;
            this.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell47.Weight = 0.015093366609766012D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell39,
            this.xrTableCell25,
            this.xrTableCell27,
            this.xrTableCell28});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.StylePriority.UseFont = false;
            this.xrTableCell39.StylePriority.UseTextAlignment = false;
            this.xrTableCell39.Text = "Telefono:";
            this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell39.Weight = 0.3551055204366988D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4Tel});
            this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.StylePriority.UseTextAlignment = false;
            this.xrTableCell25.Text = " ";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell25.Weight = 1.0978385196792466D;
            // 
            // xlblVal4Tel
            // 
            this.xlblVal4Tel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4Tel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4Tel.LocationFloat = new DevExpress.Utils.PointFloat(3.307922F, 2.472984F);
            this.xlblVal4Tel.Name = "xlblVal4Tel";
            this.xlblVal4Tel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4Tel.SizeF = new System.Drawing.SizeF(175.8685F, 20.52705F);
            this.xlblVal4Tel.StylePriority.UseBorders = false;
            this.xlblVal4Tel.StylePriority.UseFont = false;
            this.xlblVal4Tel.StylePriority.UsePadding = false;
            this.xlblVal4Tel.Text = "Valor Tel";
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseTextAlignment = false;
            this.xrTableCell27.Text = " Correo Electronico:";
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell27.Weight = 0.72719636972498647D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal4email});
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseTextAlignment = false;
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell28.Weight = 1.5919730678118564D;
            // 
            // xlblVal4email
            // 
            this.xlblVal4email.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal4email.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal4email.LocationFloat = new DevExpress.Utils.PointFloat(5.427856F, 2.472979F);
            this.xlblVal4email.Name = "xlblVal4email";
            this.xlblVal4email.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal4email.SizeF = new System.Drawing.SizeF(251.5007F, 15.47295F);
            this.xlblVal4email.StylePriority.UseBorders = false;
            this.xlblVal4email.StylePriority.UseFont = false;
            this.xlblVal4email.StylePriority.UsePadding = false;
            this.xlblVal4email.Text = "Val Email";
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell41});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xrTableCell41.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.StylePriority.UseBackColor = false;
            this.xrTableCell41.StylePriority.UseFont = false;
            this.xrTableCell41.StylePriority.UseTextAlignment = false;
            this.xrTableCell41.Text = "5- Identificacion de los reciduos";
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell41.Weight = 3.772113477652788D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell48,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell49,
            this.xrTableCell42});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.StylePriority.UseFont = false;
            this.xrTableCell48.StylePriority.UseTextAlignment = false;
            this.xrTableCell48.Text = "Nombre residuo";
            this.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell48.Weight = 0.943028369413197D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.StylePriority.UseFont = false;
            this.xrTableCell43.StylePriority.UseTextAlignment = false;
            this.xrTableCell43.Text = "Clasificación";
            this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell43.Weight = 0.90722355796735488D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.StylePriority.UseFont = false;
            this.xrTableCell44.StylePriority.UseTextAlignment = false;
            this.xrTableCell44.Text = "Envase";
            this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell44.Weight = 0.97883318085903914D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.StylePriority.UseFont = false;
            this.xrTableCell49.StylePriority.UseTextAlignment = false;
            this.xrTableCell49.Text = "Cantidad";
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell49.Weight = 0.4715141847065985D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.StylePriority.UseFont = false;
            this.xrTableCell42.StylePriority.UseTextAlignment = false;
            this.xrTableCell42.Text = "Etiqueta";
            this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell42.Weight = 0.4715141847065985D;
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupFooter2,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.sqlDataSource2});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 34, 39);
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    
}
