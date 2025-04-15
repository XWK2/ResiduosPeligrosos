using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace ResiduosPeligrosos.Entity
{
    public class GetMaterialesResult_
    {
        public List<Materiales> GetMaterialesResult { get; set; }
    }
    public class GetCmbMaterialesResult_
    {
        public List<Materiales> GetCmbMaterialesResult { get; set; }
    }

    public class DelMaterialesResult_
    {
        public int DelMaterialesResult { get; set; }
    }
    public class InsMaterialesResult_
    {
        public int InsMaterialesResult { get; set; }
    }
    public class UpdMaterialesResult_
    {
        public int UpdMaterialesResult { get; set; }
    }
    public class ValMaterialesResult_
    {
        public int ValMaterialesResult { get; set; }
    }
    public class DelMaterialesSelectedResult_
    {
        public int DelMaterialesSelectedResult { get; set; }
    }
    public class DelMaterialesAllResult_
    {
        public int DelMaterialesAllResult { get; set; }
    }

    public class Materiales
    {
        public int MaterialId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoYNombre { get; set; }
        public string pais { get; set; }
        public string cveSat { get; set; }
        public decimal precioU { get; set; }
        public string nameEnglish { get; set; }
    }
}