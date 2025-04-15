using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetTipoManifiestoResult_
    {
        public List<TipoManifiesto> GetTipoManifiestoResult { get; set; }
    }
    public class GetCmbTipoManifiestoResult_
    {
        public List<TipoManifiesto> GetCmbTipoManifiestoResult { get; set; }
    }

    public class DelTipoManifiestoResult_
    {
        public int DelTipoManifiestoResult { get; set; }
    }
    public class InsTipoManifiestoResult_
    {
        public int InsTipoManifiestoResult { get; set; }
    }
    public class UpdTipoManifiestoResult_
    {
        public int UpdTipoManifiestoResult { get; set; }
    }
    public class ValTipoManifiestoResult_
    {
        public int ValTipoManifiestoResult { get; set; }
    }
    public class DelTipoManifiestoSelectedResult_
    {
        public int DelTipoManifiestoSelectedResult { get; set; }
    }
    public class DelTipoManifiestoAllResult_
    {
        public int DelTipoManifiestoAllResult { get; set; }
    }

    public class TipoManifiesto
    {
        public int TipoManifiestoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoTipoMaterial { get; set; }
        public string TipoMaterial { get; set; }
        public string CodigoYNombre { get; set; }
    }
}