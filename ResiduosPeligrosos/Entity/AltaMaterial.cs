using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{

    public class GetAltaMaterialxGaylordIdResult_
    {
        public List<AltaMaterial> GetAltaMaterialxGaylordIdResult { get; set; }
    }

    public class GetAltaMaterialResult_
    {
        public List<AltaMaterial> GetAltaMaterialResult { get; set; }
    }    

    public class AltaMaterial
    {
        public int GaylordID { get; set; }
        public int AltaMaterialID { get; set; }

        //lo usa horacio en el insert.
        public string codigoEmpleado { get; set; }    
            
        public string codigoDepartamento { get; set; }        
        public string codigoMaterial { get; set; }        
        public string codigoTipoVehiculo { get; set; }        
        public string codigoLocacion { get; set; }       
        public decimal peso { get; set; }        
        public string FechaEntrega { get; set; }        
        public string DescripcionMaterial { get; set; }        
        public string Departamento { get; set; }        
        public string UsuarioEntrega { get; set; }        
        public string UsuarioRecibe { get; set; }        
        public string TipoVehiculo { get; set; }        
        public string Locacion { get; set; }        
        public string codigoEmpleadoEntrega { get; set; }
        public string codigoEmpleadoRecibe { get; set; }
        public string codigoAlmacen { get; set; }
        public string Almacen { get; set; }
        public string ESSYM { get; set; }
    }
}