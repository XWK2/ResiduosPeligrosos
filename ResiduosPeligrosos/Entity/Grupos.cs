using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetGruposResult_
    {
        public List<Grupos> GetGruposResult { get; set; }
    }
    public class GetCmbGruposResult_
    {
        public List<Grupos> GetCmbGruposResult { get; set; }
    }

    public class GetCmbGruposbyTipoManifiestoResult_
    {
        public List<Grupos> GetCmbGruposbyTipoManifiestoResult { get; set; }
    }

    public class DelGruposResult_
    {
        public int DelGruposResult { get; set; }
    }
    public class InsGruposResult_
    {
        public int InsGruposResult { get; set; }
    }
    public class UpdGruposResult_
    {
        public int UpdGruposResult { get; set; }
    }
    public class ValGruposResult_
    {
        public int ValGruposResult { get; set; }
    }
    public class DelGruposSelectedResult_
    {
        public int DelGruposSelectedResult { get; set; }
    }
    public class DelGruposAllResult_
    {
        public int DelGruposAllResult { get; set; }
    }

    public class Grupos
    {
        public int grupoId { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string codigoyNombre { get; set; }
    }
}