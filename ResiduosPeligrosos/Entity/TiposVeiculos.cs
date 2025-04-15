using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetTiposVeiculosResult_
    {
        public List<TiposVeiculos> GetTiposVeiculosResult { get; set; }
    }
    public class GetCmbTiposVeiculosResult_
    {
        public List<TiposVeiculos> GetCmbTiposVeiculosResult { get; set; }
    }

    public class DelTipoVehiculoResult_
    {
        public int DelTipoVehiculoResult { get; set; }
    }
    public class InsTipoVehiculoResult_
    {
        public int InsTipoVehiculoResult { get; set; }
    }
    public class UpdTipoVehiculoResult_
    {
        public int UpdTipoVehiculoResult { get; set; }
    }
    public class ValTipoVeiculoResult_
    {
        public int ValTipoVeiculoResult { get; set; }
    }
    public class DelTipoVeiculoSelectedResult_
    {
        public int DelTipoVeiculoSelectedResult { get; set; }
    }
    public class DelTipoVeiculoAllResult_
    {
        public int DelTipoVeiculoAllResult { get; set; }
    }

    public class TiposVeiculos
    {
        public int veiculoId { get; set; }
        public string Codigo { get; set; }
        public string codigoQR { get; set; }
        public string tipo { get; set; }
        public string placas { get; set; }
        public string rutas { get; set; }
        public string puntoProtesta { get; set; }
        public bool Activo { get; set; }
        public string CodigoYNombre { get; set; }
        public decimal pesoBruto { get; set; }
    }
}