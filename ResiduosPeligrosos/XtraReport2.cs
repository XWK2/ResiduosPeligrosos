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
using ResiduosPeligrosos.Entity;

/// <summary>
/// Summary description for XtraReport2
/// </summary>
public class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private GroupHeaderBand GroupHeader1;
    private GroupFooterBand GroupFooter1;
    private XRLabel xrLabel6;
    private DevExpress.Utils.ImageCollection imageCollection1;
    private XRPictureBox xrPictureBox1;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell22;
    private XRLabel xlblvalRMENoCliente;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell29;
    private XRLabel xlblvalNombreCliente;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell31;
    private XRLabel xlblvalCPCliente;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell32;
    private XRLabel xlblvalCalleCliente;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRLabel xlblvalNECliente;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell45;
    private XRLabel xlblvalNICliente;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell36;
    private XRLabel xlblvalColCliente;
    private XRTableCell xrTableCell113;
    private XRTableCell xrTableCell38;
    private XRLabel xlblvalMunCliente;
    private XRTableCell xrTableCell114;
    private XRTableCell xrTableCell40;
    private XRLabel xlblvalEdoCliente;
    private XRTableCell xrTableCell47;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell25;
    private XRLabel xlblvalTelCliente;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell2;
    private XRLabel xlblvalemailCliente;
    private XRTableCell xrTableCell1;
    private XRLabel xlblvalFechaCliente;
    private XRTable xrTable14;
    private XRTableRow xrTableRow34;
    private XRTableCell xrTableCellNR;
    private XRTableCell xrTableCellCC;
    private XRTableCell xrTableCellCantidad;
    private XRTableCell xrTableCellPeso;
    private XRTableCell xrTableCellPresentacion;
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
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRLabel xlblVal11TipoVehiculo;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRLabel xlblVal12Placa;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell3;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell7;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell8;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell19;
    private XRLabel xlblResponsableTrans;
    private XRTable xrTable9;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell6;
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
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell108;
    private XRLabel xlblVal17NombreRecibeResiduos;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell106;
    private XRLabel xlblVal18Observaciones;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell17;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell21;
    private XRLine xrLine1;
    private XRTableCell xrTableCell50;
    private XRLine xrLine2;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell51;
    private XRLabel xlblResponsableDes;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRLabel xlblVal19FechaDes;


    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public XtraReport2(Manifiestos Manifiesto, Empresas Empresa)
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //

        PasarDatos(Manifiesto, Empresa);
    }

    private void PasarDatos(Manifiestos Manifiesto, Empresas Empresa)
    {

        ////Datos Generador.
        //xlblValRegistroAmbiental.Text = Manifiesto.numRegistroAmbiental;
        xlblvalRMENoCliente.Text = Manifiesto.numManifiesto;
        //xlblValPagina.Text = Manifiesto.paginaNumero.ToString("0.##");
        xlblvalNombreCliente.Text = Empresa.RazonSocial.ToString();
        xlblvalCPCliente.Text = Manifiesto.cpGen;
        xlblvalCalleCliente.Text = Manifiesto.direccion;
        xlblvalNECliente.Text = Manifiesto.numeroExterior;
        xlblvalNICliente.Text = Manifiesto.numeroInterior;
        xlblvalColCliente.Text = Manifiesto.colonia;
        xlblvalMunCliente.Text = Manifiesto.municipio;
        xlblvalEdoCliente.Text = Manifiesto.estado;
        xlblvalTelCliente.Text = Manifiesto.tel;
        xlblvalemailCliente.Text = Manifiesto.correoElectronico;
        xlblvalFechaCliente.Text = "";

        ////Datos Generador.
        //xlblVal1RegistroAmbiental.Text = Manifiesto.numRegistroAmbiental;
        //xlblVal2NumManifiesto.Text = Manifiesto.numManifiesto;
        //xlblVal3Pagina.Text = Manifiesto.paginaNumero.ToString("0.##");
        //xlblVal4NombreGenerador.Text = Manifiesto.nombreGeneradorDesc.ToString();
        //xlblVal4CP.Text = Manifiesto.cpGen;
        //xlblVal4Calle.Text = Manifiesto.direccion;
        //xlblVal4NE.Text = Manifiesto.numeroExterior;
        //xlblVal4NI.Text = Manifiesto.numeroInterior;
        //xlblVal4Col.Text = Manifiesto.colonia;
        //xlblVal4Mun.Text = Manifiesto.municipio;
        //xlblVal4Edo.Text = Manifiesto.estado;
        //xlblVal4Tel.Text = Manifiesto.tel;
        //xlblVal4email.Text = Manifiesto.correoElectronico;
        //xlblVal6Instrucciones.Text = Manifiesto.instrucciones;
        //xlblVal6Responsable.Text = Manifiesto.responsable;
        //xlblVal7Fecha.Text = Manifiesto.fechaGenerador;

        ////Datos Transportista
        xlblVal8Nombre.Text = Manifiesto.nombreTransportistaDesc;
        xlblVal8CP.Text = Manifiesto.cpGen;
        xlblVal8Calle.Text = Manifiesto.direccion;
        xlblVal8NE.Text = Manifiesto.numeroExteriorTrans;
        xlblVal8NI.Text = Manifiesto.numeroInteriorTrans;
        xlblVal8Estado.Text = Manifiesto.estadoTrans;
        xlblVal8Telefono.Text = Manifiesto.telTrans;
        xlblVal8email.Text = Manifiesto.correoElectronicoTrans;      
        xlblVal11TipoVehiculo.Text = Manifiesto.tipoVehiculoTrans;
        xlblVal12Placa.Text = Manifiesto.placasTrans;       
        xlblResponsableTrans.Text = Manifiesto.responsable;


        ////Datos Destinatario
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
       
        xlblVal17NombreRecibeResiduos.Text = Manifiesto.nomnbrePersonaRecibeDes;
        xlblVal18Observaciones.Text = "";
        xlblResponsableDes.Text = Manifiesto.responsableDes;
        xlblVal19FechaDes.Text = Manifiesto.fechaDes;


        for (int i = 0; i < Manifiesto.gaylords.Count; i++)
        {
            XRTableRow row = new XRTableRow();

            //Opcion 2: Ejemplo pasando info en campos ya diseñados
            //Agregamos celdas
            XRTableCell xrTableCellNRX = new XRTableCell();
            XRTableCell xrTableCellDescripcion = new XRTableCell();                        
            XRTableCell xrTableCellCantidad = new XRTableCell();
            XRTableCell xrTableCellPeso = new XRTableCell();
            XRTableCell xrTableCellPresentacion = new XRTableCell();

            row.Cells.Add(xrTableCellNRX);
            row.Cells.Add(xrTableCellDescripcion);               
            row.Cells.Add(xrTableCellCantidad);            
            row.Cells.Add(xrTableCellPeso);
            row.Cells.Add(xrTableCellPresentacion);

            xrTableCellNRX.WidthF = 134.79f;
            xrTableCellDescripcion.WidthF = 115.57f;
            xrTableCellCantidad.WidthF = 109.29f;
            xrTableCellPeso.WidthF = 116.39f;
            xrTableCellPresentacion.WidthF = 173.96f;

            xrTableCellNRX.DataBindings.Add("Text", Manifiesto.gaylords[i], "residuo");            
            xrTableCellDescripcion.DataBindings.Add("Text", Manifiesto.gaylords[i], "IEDescripcion");
            xrTableCellCantidad.DataBindings.Add("Text", Manifiesto.gaylords[i], "capacidad");
            xrTableCellPeso.DataBindings.Add("Text", Manifiesto.gaylords[i], "peso");
            xrTableCellPeso.DataBindings.Add("Text", Manifiesto.gaylords[i], "peso");

            xrTable14.Rows.Add(row);

        }

    }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport2));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalRMENoCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalNombreCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalCPCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalCalleCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalNECliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalNICliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalColCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalMunCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalEdoCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalTelCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblvalemailCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xlblvalFechaCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellNR = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCC = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellCantidad = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellPeso = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellPresentacion = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal11TipoVehiculo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal12Placa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblResponsableTrans = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal17NombreRecibeResiduos = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal18Observaciones = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xlblResponsableDes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xlblVal19FechaDes = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable14});
            this.Detail.HeightF = 19.79167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel6});
            this.TopMargin.HeightF = 71.87502F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(214.5833F, 10.00001F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(425.4167F, 55.29166F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "HOJA DE CONTROL PARA LA ENTREGA, TRANSPORTE Y RECEPCIÓN  DE RESIDUOS INDUSTRIALES" +
    " \r\nNO PELIGROSOS";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
            this.GroupHeader1.HeightF = 159.9437F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable9,
            this.xrTable7});
            this.GroupFooter1.HeightF = 546.9327F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(189.5833F, 69.16667F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 7.105774F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow9,
            this.xrTableRow10,
            this.xrTableRow11});
            this.xrTable6.SizeF = new System.Drawing.SizeF(650F, 152.8379F);
            this.xrTable6.StylePriority.UseBorders = false;
            this.xrTable6.StylePriority.UseFont = false;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20,
            this.xrTableCell23,
            this.xrTableCell22});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "RME-CH1-No.";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell23.Weight = 0.57944359086850261D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalRMENoCliente});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell22.Weight = 0.78449799693885314D;
            // 
            // xlblvalRMENoCliente
            // 
            this.xlblvalRMENoCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalRMENoCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalRMENoCliente.ForeColor = System.Drawing.Color.Red;
            this.xlblvalRMENoCliente.LocationFloat = new DevExpress.Utils.PointFloat(6.28479F, 2.894226F);
            this.xlblvalRMENoCliente.Name = "xlblvalRMENoCliente";
            this.xlblvalRMENoCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalRMENoCliente.SizeF = new System.Drawing.SizeF(103.4802F, 14.45945F);
            this.xlblvalRMENoCliente.StylePriority.UseBorders = false;
            this.xlblvalRMENoCliente.StylePriority.UseFont = false;
            this.xlblvalRMENoCliente.StylePriority.UseForeColor = false;
            this.xlblvalRMENoCliente.StylePriority.UsePadding = false;
            this.xlblvalRMENoCliente.Text = "val RMENo";
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
            this.xrTableCell24.Text = "EMPRESA O NEGOCIACION";
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell24.Weight = 3.2657224801471529D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalNombreCliente});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseTextAlignment = false;
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell29.Weight = 6.8004317451351692D;
            // 
            // xlblvalNombreCliente
            // 
            this.xlblvalNombreCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalNombreCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalNombreCliente.LocationFloat = new DevExpress.Utils.PointFloat(16.18245F, 0.5405445F);
            this.xlblvalNombreCliente.Name = "xlblvalNombreCliente";
            this.xlblvalNombreCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalNombreCliente.SizeF = new System.Drawing.SizeF(414.4752F, 22.45946F);
            this.xlblvalNombreCliente.StylePriority.UseBorders = false;
            this.xlblvalNombreCliente.StylePriority.UseFont = false;
            this.xlblvalNombreCliente.StylePriority.UsePadding = false;
            this.xlblvalNombreCliente.Text = "val NombreCliente";
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
            this.xrTableCell26.Text = "C.P.";
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell26.Weight = 0.4936285432030047D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalCPCliente});
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseTextAlignment = false;
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell31.Weight = 0.46894834245140271D;
            // 
            // xlblvalCPCliente
            // 
            this.xlblvalCPCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalCPCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalCPCliente.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 0.06753922F);
            this.xlblvalCPCliente.Name = "xlblvalCPCliente";
            this.xlblvalCPCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalCPCliente.SizeF = new System.Drawing.SizeF(71.28027F, 22.99999F);
            this.xlblvalCPCliente.StylePriority.UseBorders = false;
            this.xlblvalCPCliente.StylePriority.UseFont = false;
            this.xlblvalCPCliente.StylePriority.UsePadding = false;
            this.xlblvalCPCliente.Text = "Valor CP";
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseTextAlignment = false;
            this.xrTableCell33.Text = "CALLE:";
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell33.Weight = 0.28026182974091496D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalCalleCliente});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseTextAlignment = false;
            this.xrTableCell32.Text = " ";
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell32.Weight = 0.89779934750740176D;
            // 
            // xlblvalCalleCliente
            // 
            this.xlblvalCalleCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalCalleCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalCalleCliente.LocationFloat = new DevExpress.Utils.PointFloat(10.00006F, 0.06752777F);
            this.xlblvalCalleCliente.Name = "xlblvalCalleCliente";
            this.xlblvalCalleCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalCalleCliente.SizeF = new System.Drawing.SizeF(134.7062F, 22.99997F);
            this.xlblvalCalleCliente.StylePriority.UseBorders = false;
            this.xlblvalCalleCliente.StylePriority.UseFont = false;
            this.xlblvalCalleCliente.StylePriority.UsePadding = false;
            this.xlblvalCalleCliente.Text = "Valor Calle";
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
            this.xlblvalNECliente});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseTextAlignment = false;
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell35.Weight = 0.27871924397250458D;
            // 
            // xlblvalNECliente
            // 
            this.xlblvalNECliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalNECliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalNECliente.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xlblvalNECliente.Name = "xlblvalNECliente";
            this.xlblvalNECliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalNECliente.SizeF = new System.Drawing.SizeF(38.02811F, 22.99998F);
            this.xlblvalNECliente.StylePriority.UseBorders = false;
            this.xlblvalNECliente.StylePriority.UseFont = false;
            this.xlblvalNECliente.StylePriority.UsePadding = false;
            this.xlblvalNECliente.Text = "VNE";
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
            this.xlblvalNICliente});
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseTextAlignment = false;
            this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell45.Weight = 0.22835144903765953D;
            // 
            // xlblvalNICliente
            // 
            this.xlblvalNICliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalNICliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalNICliente.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06753922F);
            this.xlblvalNICliente.Name = "xlblvalNICliente";
            this.xlblvalNICliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalNICliente.SizeF = new System.Drawing.SizeF(35.66498F, 23.00001F);
            this.xlblvalNICliente.StylePriority.UseBorders = false;
            this.xlblvalNICliente.StylePriority.UseFont = false;
            this.xlblvalNICliente.StylePriority.UsePadding = false;
            this.xlblvalNICliente.Text = "VNI";
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
            this.xrTableCell37.Text = "COLONIA:";
            this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell37.Weight = 0.37946915849559942D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalColCliente});
            this.xrTableCell36.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseFont = false;
            this.xrTableCell36.StylePriority.UseTextAlignment = false;
            this.xrTableCell36.Text = " ";
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell36.Weight = 1.1731610263072427D;
            // 
            // xlblvalColCliente
            // 
            this.xlblvalColCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalColCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalColCliente.LocationFloat = new DevExpress.Utils.PointFloat(1.907349E-05F, 2.472984F);
            this.xlblvalColCliente.Name = "xlblvalColCliente";
            this.xlblvalColCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalColCliente.SizeF = new System.Drawing.SizeF(179.1765F, 20.52703F);
            this.xlblvalColCliente.StylePriority.UseBorders = false;
            this.xlblvalColCliente.StylePriority.UseFont = false;
            this.xlblvalColCliente.StylePriority.UsePadding = false;
            this.xlblvalColCliente.Text = "Valor Colonia";
            // 
            // xrTableCell113
            // 
            this.xrTableCell113.Name = "xrTableCell113";
            this.xrTableCell113.StylePriority.UseTextAlignment = false;
            this.xrTableCell113.Text = "MUNICIPIO:";
            this.xrTableCell113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell113.Weight = 0.77708924842887928D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalMunCliente});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseTextAlignment = false;
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell38.Weight = 0.82686260834144432D;
            // 
            // xlblvalMunCliente
            // 
            this.xlblvalMunCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalMunCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalMunCliente.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.433228E-05F);
            this.xlblvalMunCliente.Name = "xlblvalMunCliente";
            this.xlblvalMunCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalMunCliente.SizeF = new System.Drawing.SizeF(111.8243F, 22.99998F);
            this.xlblvalMunCliente.StylePriority.UseBorders = false;
            this.xlblvalMunCliente.StylePriority.UseFont = false;
            this.xlblvalMunCliente.StylePriority.UsePadding = false;
            this.xlblvalMunCliente.Text = "Valor CP";
            // 
            // xrTableCell114
            // 
            this.xrTableCell114.Name = "xrTableCell114";
            this.xrTableCell114.StylePriority.UseTextAlignment = false;
            this.xrTableCell114.Text = "EDO.";
            this.xrTableCell114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell114.Weight = 0.26648240001712731D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalEdoCliente});
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseTextAlignment = false;
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell40.Weight = 0.59275943839971246D;
            // 
            // xlblvalEdoCliente
            // 
            this.xlblvalEdoCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalEdoCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalEdoCliente.LocationFloat = new DevExpress.Utils.PointFloat(10F, 1.907349E-05F);
            this.xlblvalEdoCliente.Name = "xlblvalEdoCliente";
            this.xlblvalEdoCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalEdoCliente.SizeF = new System.Drawing.SizeF(71.28027F, 22.99999F);
            this.xlblvalEdoCliente.StylePriority.UseBorders = false;
            this.xlblvalEdoCliente.StylePriority.UseFont = false;
            this.xlblvalEdoCliente.StylePriority.UsePadding = false;
            this.xlblvalEdoCliente.Text = "Valor CP";
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
            this.xrTableCell2,
            this.xrTableCell1,
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
            this.xrTableCell39.Text = "TELEFONO:";
            this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell39.Weight = 0.39349882060865216D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalTelCliente});
            this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.StylePriority.UseTextAlignment = false;
            this.xrTableCell25.Text = " ";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell25.Weight = 0.67832896779873164D;
            // 
            // xlblvalTelCliente
            // 
            this.xlblvalTelCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalTelCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalTelCliente.LocationFloat = new DevExpress.Utils.PointFloat(3.307926F, 2.472992F);
            this.xlblvalTelCliente.Name = "xlblvalTelCliente";
            this.xlblvalTelCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalTelCliente.SizeF = new System.Drawing.SizeF(109.4596F, 20.52705F);
            this.xlblvalTelCliente.StylePriority.UseBorders = false;
            this.xlblvalTelCliente.StylePriority.UseFont = false;
            this.xlblvalTelCliente.StylePriority.UsePadding = false;
            this.xlblvalTelCliente.Text = "Valor Tel";
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseTextAlignment = false;
            this.xrTableCell27.Text = "CORREO ELECTRONICO:";
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell27.Weight = 0.77842390470581058D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalFechaCliente});
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseTextAlignment = false;
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell28.Weight = 0.73413000588632593D;
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
            this.xrTableCell41.Text = "Identificacion de los reciduos";
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell41.Weight = 3.772113477652788D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell20.Weight = 2.6669756587924156D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "FECHA:";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell1.Weight = 0.27539393382909916D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblvalemailCliente});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell2.Weight = 0.91233784482416913D;
            // 
            // xlblvalemailCliente
            // 
            this.xlblvalemailCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalemailCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalemailCliente.LocationFloat = new DevExpress.Utils.PointFloat(0.0001220703F, 2.472992F);
            this.xlblvalemailCliente.Name = "xlblvalemailCliente";
            this.xlblvalemailCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalemailCliente.SizeF = new System.Drawing.SizeF(147.2114F, 20.52705F);
            this.xlblvalemailCliente.StylePriority.UseBorders = false;
            this.xlblvalemailCliente.StylePriority.UseFont = false;
            this.xlblvalemailCliente.StylePriority.UsePadding = false;
            this.xlblvalemailCliente.Text = "Val Email";
            // 
            // xlblvalFechaCliente
            // 
            this.xlblvalFechaCliente.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblvalFechaCliente.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblvalFechaCliente.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.472992F);
            this.xlblvalFechaCliente.Name = "xlblvalFechaCliente";
            this.xlblvalFechaCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblvalFechaCliente.SizeF = new System.Drawing.SizeF(116.5032F, 15.47294F);
            this.xlblvalFechaCliente.StylePriority.UseBorders = false;
            this.xlblvalFechaCliente.StylePriority.UseFont = false;
            this.xlblvalFechaCliente.StylePriority.UsePadding = false;
            this.xlblvalFechaCliente.Text = "Val Fecha";
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
            this.xrTable14.SizeF = new System.Drawing.SizeF(650F, 17.70833F);
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
            this.xrTableCellCantidad,
            this.xrTableCellPeso,
            this.xrTableCellPresentacion});
            this.xrTableRow34.Name = "xrTableRow34";
            this.xrTableRow34.Weight = 1D;
            // 
            // xrTableCellNR
            // 
            this.xrTableCellNR.Name = "xrTableCellNR";
            this.xrTableCellNR.Text = "RESIDUO REGISTRADO";
            this.xrTableCellNR.Weight = 1.2113125808169258D;
            // 
            // xrTableCellCC
            // 
            this.xrTableCellCC.Name = "xrTableCellCC";
            this.xrTableCellCC.Text = "DESCRIPCION";
            this.xrTableCellCC.Weight = 1.03860188957588D;
            // 
            // xrTableCellCantidad
            // 
            this.xrTableCellCantidad.Name = "xrTableCellCantidad";
            this.xrTableCellCantidad.Text = "CANTIDAD TOTAL";
            this.xrTableCellCantidad.Weight = 0.98208541807089755D;
            // 
            // xrTableCellPeso
            // 
            this.xrTableCellPeso.Name = "xrTableCellPeso";
            this.xrTableCellPeso.Text = "UNIDAD VOL/ PESO";
            this.xrTableCellPeso.Weight = 1.0459284273225831D;
            // 
            // xrTableCellPresentacion
            // 
            this.xrTableCellPresentacion.Name = "xrTableCellPresentacion";
            this.xrTableCellPresentacion.Text = "PRESENTACIÓN ESPECIFICA";
            this.xrTableCellPresentacion.Weight = 1.5632689949854568D;
            // 
            // xrTable7
            // 
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17,
            this.xrTableRow18,
            this.xrTableRow14,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow2});
            this.xrTable7.SizeF = new System.Drawing.SizeF(650F, 241.2569F);
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
            this.xrTableCell16.Text = "NOMBRE DE LA EMPRESA O TRANSPORTISTA PARTICULAR";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell16.Weight = 5.1472410205392825D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8Nombre});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell18.Weight = 4.91891320474304D;
            // 
            // xlblVal8Nombre
            // 
            this.xlblVal8Nombre.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Nombre.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Nombre.LocationFloat = new DevExpress.Utils.PointFloat(10F, 1.333364F);
            this.xlblVal8Nombre.Name = "xlblVal8Nombre";
            this.xlblVal8Nombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Nombre.SizeF = new System.Drawing.SizeF(303.9443F, 15.47296F);
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
            this.xrTableCell62.Text = "DOMICILIO";
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell62.Weight = 0.39349885126240769D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.Text = "C.P.";
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell63.Weight = 0.19529806152408372D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8CP});
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StylePriority.UseTextAlignment = false;
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell64.Weight = 0.35423160579955781D;
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
            this.xrTableCell65.Text = "CALLE:";
            this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell65.Weight = 0.28074319075129373D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8Calle});
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.StylePriority.UseTextAlignment = false;
            this.xrTableCell66.Text = " ";
            this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell66.Weight = 1.0578644576422169D;
            // 
            // xlblVal8Calle
            // 
            this.xlblVal8Calle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Calle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Calle.LocationFloat = new DevExpress.Utils.PointFloat(10.00011F, 0.06752777F);
            this.xlblVal8Calle.Name = "xlblVal8Calle";
            this.xlblVal8Calle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Calle.SizeF = new System.Drawing.SizeF(162.2881F, 22.99999F);
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
            this.xrTableCell67.Text = "NÚM. EXT.:";
            this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell67.Weight = 0.42292046182859233D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8NE});
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.StylePriority.UseTextAlignment = false;
            this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell68.Weight = 0.24935739563472245D;
            // 
            // xlblVal8NE
            // 
            this.xlblVal8NE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8NE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8NE.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06752777F);
            this.xlblVal8NE.Name = "xlblVal8NE";
            this.xlblVal8NE.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8NE.SizeF = new System.Drawing.SizeF(32.96875F, 22.99998F);
            this.xlblVal8NE.StylePriority.UseBorders = false;
            this.xlblVal8NE.StylePriority.UseFont = false;
            this.xlblVal8NE.StylePriority.UsePadding = false;
            this.xlblVal8NE.Text = "VNE";
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.StylePriority.UseTextAlignment = false;
            this.xrTableCell69.Text = "NÚM. INT.:";
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell69.Weight = 0.40471692263798681D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8NI});
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell70.Weight = 0.41348253057192724D;
            // 
            // xlblVal8NI
            // 
            this.xlblVal8NI.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8NI.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8NI.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06752777F);
            this.xlblVal8NI.Name = "xlblVal8NI";
            this.xlblVal8NI.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8NI.SizeF = new System.Drawing.SizeF(67.56628F, 23F);
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
            this.xrTableCell71.Text = "COLONIA:";
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell71.Weight = 0.37946918215210557D;
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
            this.xrTableCell72.Weight = 1.1731610026507366D;
            // 
            // xlblVal8Colonia
            // 
            this.xlblVal8Colonia.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8Colonia.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8Colonia.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 1.525879E-05F);
            this.xlblVal8Colonia.Name = "xlblVal8Colonia";
            this.xlblVal8Colonia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8Colonia.SizeF = new System.Drawing.SizeF(179.1764F, 22.99999F);
            this.xlblVal8Colonia.StylePriority.UseBorders = false;
            this.xlblVal8Colonia.StylePriority.UseFont = false;
            this.xlblVal8Colonia.StylePriority.UsePadding = false;
            this.xlblVal8Colonia.Text = "Valor Colonia";
            // 
            // xrTableCell117
            // 
            this.xrTableCell117.Name = "xrTableCell117";
            this.xrTableCell117.StylePriority.UseTextAlignment = false;
            this.xrTableCell117.Text = "MUNICIPIO:";
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
            this.xrTableCell118.Text = "EDO.";
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
            this.xrTableCell76.Text = "TELEFONTEL:";
            this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell76.Weight = 0.39349886488394747D;
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
            this.xrTableCell77.Weight = 1.059445175231998D;
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
            this.xrTableCell78.Text = "CORREO ELECTRONICO";
            this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell78.Weight = 0.88672357929733925D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal8email});
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.StylePriority.UseTextAlignment = false;
            this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell79.Weight = 1.4324458582395037D;
            // 
            // xlblVal8email
            // 
            this.xlblVal8email.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal8email.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal8email.LocationFloat = new DevExpress.Utils.PointFloat(9.999969F, 5.340576E-05F);
            this.xlblVal8email.Name = "xlblVal8email";
            this.xlblVal8email.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal8email.SizeF = new System.Drawing.SizeF(228.3695F, 22.99998F);
            this.xlblVal8email.StylePriority.UseBorders = false;
            this.xlblVal8email.StylePriority.UseFont = false;
            this.xlblVal8email.StylePriority.UsePadding = false;
            this.xlblVal8email.Text = "Val Email";
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
            this.xrTableCell10.Text = "TIPO DE VEHICULO";
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
            this.xrTableCell12.Text = "NÚM DE PLACA";
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
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "TRANSPORTISTA";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell3.Weight = 10.066154225282322D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell7});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "OBSERVACIONES:";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell4.Weight = 1.4529440230837296D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell7.Weight = 2.3191694545690584D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell8});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "NOMBRE DEL OPERADOR";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell5.Weight = 1.8502515731781895D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "FIRMA";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell8.Weight = 1.9218619044745984D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell19});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblResponsableTrans});
            this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell14.Weight = 1.8502521930323237D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell19.Weight = 1.9218612846204644D;
            // 
            // xlblResponsableTrans
            // 
            this.xlblResponsableTrans.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblResponsableTrans.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblResponsableTrans.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xlblResponsableTrans.Name = "xlblResponsableTrans";
            this.xlblResponsableTrans.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblResponsableTrans.SizeF = new System.Drawing.SizeF(298.8303F, 22.99998F);
            this.xlblResponsableTrans.StylePriority.UseBorders = false;
            this.xlblResponsableTrans.StylePriority.UseFont = false;
            this.xlblResponsableTrans.StylePriority.UsePadding = false;
            this.xlblResponsableTrans.Text = "Nombre Responsable Trans";
            // 
            // xrTable9
            // 
            this.xrTable9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 241.2569F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5,
            this.xrTableRow21,
            this.xrTableRow22,
            this.xrTableRow23,
            this.xrTableRow24,
            this.xrTableRow26,
            this.xrTableRow28,
            this.xrTableRow27,
            this.xrTableRow13,
            this.xrTableRow19,
            this.xrTableRow20});
            this.xrTable9.SizeF = new System.Drawing.SizeF(650F, 280.2028F);
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
            this.xrTableCell15.Text = "EMPRESA O NEGOCIACIÓN";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell15.Weight = 2.5165387719724888D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15NombreDest});
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.StylePriority.UseTextAlignment = false;
            this.xrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell80.Weight = 7.5496154533098334D;
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
            this.xrTableCell83.Text = "DOMICILIO";
            this.xrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell83.Weight = 0.35510555109045439D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.StylePriority.UseTextAlignment = false;
            this.xrTableCell86.Text = "C.P.";
            this.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell86.Weight = 0.17324072926538459D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15CP});
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.StylePriority.UseTextAlignment = false;
            this.xrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell87.Weight = 0.41468223823021011D;
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
            this.xrTableCell88.Weight = 0.22271067571048167D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15Calle});
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.StylePriority.UseTextAlignment = false;
            this.xrTableCell89.Text = " ";
            this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell89.Weight = 1.1158968841324384D;
            // 
            // xlblVal15Calle
            // 
            this.xlblVal15Calle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Calle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Calle.LocationFloat = new DevExpress.Utils.PointFloat(10.00006F, 0.06758118F);
            this.xlblVal15Calle.Name = "xlblVal15Calle";
            this.xlblVal15Calle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Calle.SizeF = new System.Drawing.SizeF(172.2882F, 22.99997F);
            this.xlblVal15Calle.StylePriority.UseBorders = false;
            this.xlblVal15Calle.StylePriority.UseFont = false;
            this.xlblVal15Calle.StylePriority.UsePadding = false;
            this.xlblVal15Calle.Text = "Valor Calle";
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.StylePriority.UseTextAlignment = false;
            this.xrTableCell90.Text = "NÚM. EXT.:";
            this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell90.Weight = 0.4229206389297735D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15NE});
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.StylePriority.UseTextAlignment = false;
            this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell91.Weight = 0.24935799335120892D;
            // 
            // xlblVal15NE
            // 
            this.xlblVal15NE.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15NE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15NE.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06758118F);
            this.xlblVal15NE.Name = "xlblVal15NE";
            this.xlblVal15NE.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15NE.SizeF = new System.Drawing.SizeF(32.96875F, 22.99997F);
            this.xlblVal15NE.StylePriority.UseBorders = false;
            this.xlblVal15NE.StylePriority.UseFont = false;
            this.xlblVal15NE.StylePriority.UsePadding = false;
            this.xlblVal15NE.Text = "VNE";
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.StylePriority.UseTextAlignment = false;
            this.xrTableCell92.Text = "NÚM. INT.:";
            this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell92.Weight = 0.40471621423326215D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15NI});
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.StylePriority.UseTextAlignment = false;
            this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell93.Weight = 0.41348255270957485D;
            // 
            // xlblVal15NI
            // 
            this.xlblVal15NI.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15NI.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15NI.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 0.06742859F);
            this.xlblVal15NI.Name = "xlblVal15NI";
            this.xlblVal15NI.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15NI.SizeF = new System.Drawing.SizeF(67.56622F, 23.00009F);
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
            this.xrTableCell94.Text = "COLONIA:";
            this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell94.Weight = 0.42049666077089165D;
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
            this.xrTableCell95.Weight = 1.1321335240319506D;
            // 
            // xlblVal15Colonia
            // 
            this.xlblVal15Colonia.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Colonia.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Colonia.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 0F);
            this.xlblVal15Colonia.Name = "xlblVal15Colonia";
            this.xlblVal15Colonia.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Colonia.SizeF = new System.Drawing.SizeF(179.1764F, 23F);
            this.xlblVal15Colonia.StylePriority.UseBorders = false;
            this.xlblVal15Colonia.StylePriority.UseFont = false;
            this.xlblVal15Colonia.StylePriority.UsePadding = false;
            this.xlblVal15Colonia.Text = "Valor Colonia";
            // 
            // xrTableCell115
            // 
            this.xrTableCell115.Name = "xrTableCell115";
            this.xrTableCell115.StylePriority.UseTextAlignment = false;
            this.xrTableCell115.Text = "MUNICIPIO:";
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
            this.xrTableCell116.Text = "EDO:";
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
            this.xrTableCell99.Text = "TELEFONO:";
            this.xrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell99.Weight = 0.39349886488394742D;
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
            this.xrTableCell100.Weight = 1.0594451752319978D;
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
            this.xrTableCell101.Text = "CORREO ELECTRONICO:";
            this.xrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell101.Weight = 0.88672340219615808D;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal15Email});
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.StylePriority.UseTextAlignment = false;
            this.xrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell102.Weight = 1.4324460353406849D;
            // 
            // xlblVal15Email
            // 
            this.xlblVal15Email.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal15Email.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal15Email.LocationFloat = new DevExpress.Utils.PointFloat(10F, 2.473083F);
            this.xlblVal15Email.Name = "xlblVal15Email";
            this.xlblVal15Email.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal15Email.SizeF = new System.Drawing.SizeF(228.3696F, 20.52695F);
            this.xlblVal15Email.StylePriority.UseBorders = false;
            this.xlblVal15Email.StylePriority.UseFont = false;
            this.xlblVal15Email.StylePriority.UsePadding = false;
            this.xlblVal15Email.Text = "Val Email";
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
            this.xrTableCell107.Text = "REPRESENTANTE";
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
            this.xlblVal17NombreRecibeResiduos.LocationFloat = new DevExpress.Utils.PointFloat(10F, 1.525879E-05F);
            this.xlblVal17NombreRecibeResiduos.Name = "xlblVal17NombreRecibeResiduos";
            this.xlblVal17NombreRecibeResiduos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblVal17NombreRecibeResiduos.SizeF = new System.Drawing.SizeF(352.3214F, 20.5271F);
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
            this.xrTableCell105.Text = "OBSERVACIONES:";
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
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "DESTINATARIO";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell6.Weight = 10.066154225282322D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseBorders = false;
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell17.Weight = 3.772113477652788D;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21,
            this.xrTableCell50});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Weight = 1D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTableCell21.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1});
            this.xrTableCell21.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell21.Weight = 1.850251484627599D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell50.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblResponsableDes,
            this.xrLine2});
            this.xrTableCell50.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.StylePriority.UseBorders = false;
            this.xrTableCell50.StylePriority.UseFont = false;
            this.xrTableCell50.StylePriority.UseTextAlignment = false;
            this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell50.Weight = 1.921861993025189D;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell51});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "NOMBRE Y FIRMA DEL GENERADOR";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell9.Weight = 1.8502516617287803D;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell51.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.StylePriority.UseBorders = false;
            this.xrTableCell51.StylePriority.UseFont = false;
            this.xrTableCell51.StylePriority.UseTextAlignment = false;
            this.xrTableCell51.Text = "NOBRE Y FIRMA DEL DESTINATARIO";
            this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell51.Weight = 1.9218618159240077D;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(48.56412F, 20.26465F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(228.125F, 5.208334F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(56.84549F, 20.26466F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(228.125F, 5.208334F);
            // 
            // xlblResponsableDes
            // 
            this.xlblResponsableDes.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblResponsableDes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblResponsableDes.LocationFloat = new DevExpress.Utils.PointFloat(31.16986F, 0F);
            this.xlblResponsableDes.Name = "xlblResponsableDes";
            this.xlblResponsableDes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xlblResponsableDes.SizeF = new System.Drawing.SizeF(270.0014F, 15.47302F);
            this.xlblResponsableDes.StylePriority.UseBorders = false;
            this.xlblResponsableDes.StylePriority.UseFont = false;
            this.xlblResponsableDes.StylePriority.UsePadding = false;
            this.xlblResponsableDes.Text = "Nombre Responsable";
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell52,
            this.xrTableCell53});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 1D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.StylePriority.UseFont = false;
            this.xrTableCell52.StylePriority.UseTextAlignment = false;
            this.xrTableCell52.Text = "FECHA:";
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell52.Weight = 1.6056965368980718D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlblVal19FechaDes});
            this.xrTableCell53.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.StylePriority.UseFont = false;
            this.xrTableCell53.StylePriority.UseTextAlignment = false;
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell53.Weight = 2.1664169407547162D;
            // 
            // xlblVal19FechaDes
            // 
            this.xlblVal19FechaDes.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xlblVal19FechaDes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlblVal19FechaDes.LocationFloat = new DevExpress.Utils.PointFloat(10F, 3.051758E-05F);
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
            // XtraReport2
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 72, 100);
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
