using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class TiposVeiculosDa : Base
    {
        public List<Entity.TiposVeiculos> GetCatalog(string Codigo, string Descripcion, bool Activo)
        {
            string json = methodGet("GetTiposVeiculos/" + Codigo + "/" + Descripcion + "/" + Activo.ToString());
            Entity.GetTiposVeiculosResult_ regreso = JsonConvert.DeserializeObject<Entity.GetTiposVeiculosResult_>(json);
            return regreso.GetTiposVeiculosResult;
        }

        public List<Entity.TiposVeiculos> GetCombo()
        {
            string json = methodGet("GetCmbTiposVeiculos");
            Entity.GetCmbTiposVeiculosResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbTiposVeiculosResult_>(json);
            return regreso.GetCmbTiposVeiculosResult;
        }

        public int DelTipoVehiculo(int IdUser, int IdVehiculo)
        {
            Entity.DelTipoVehiculoResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoVehiculoResult_>(methodPost("DelTipoVehiculo/" + IdUser.ToString() + "/" + IdVehiculo.ToString()));
            return regreso.DelTipoVehiculoResult;
        }

        public int InsTipoVehiculo(int IdUser, string Codigo, string Tipo, string Placas, string Rutas, string Puntoprostesta, decimal pesoBruto)
        {
            Entity.TiposVeiculos tVehiculo = new Entity.TiposVeiculos();
            tVehiculo.Codigo = Codigo;
            tVehiculo.tipo = Tipo;
            tVehiculo.placas = Placas;
            tVehiculo.rutas = Rutas;
            tVehiculo.puntoProtesta = Puntoprostesta;
            tVehiculo.pesoBruto = pesoBruto;

            Entity.InsTipoVehiculoResult_ regreso = JsonConvert.DeserializeObject<Entity.InsTipoVehiculoResult_>(methodPost("InsTipoVehiculo/" + IdUser.ToString(), JsonConvert.SerializeObject(tVehiculo)));
            return regreso.InsTipoVehiculoResult;
        }

        public int UpdTipoVehiculo(int IdUser, int id_Vehiculo ,string Codigo, string Tipo, string Placas, string Rutas, string Puntoprostesta, decimal pesoBruto)
        {
            Entity.TiposVeiculos tVehiculo = new Entity.TiposVeiculos();
            tVehiculo.veiculoId = id_Vehiculo;
            tVehiculo.Codigo = Codigo;
            tVehiculo.tipo = Tipo;
            tVehiculo.placas = Placas;
            tVehiculo.rutas = Rutas;
            tVehiculo.puntoProtesta = Puntoprostesta;
            tVehiculo.pesoBruto = pesoBruto;

            Entity.UpdTipoVehiculoResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdTipoVehiculoResult_>(methodPost("UpdTipoVehiculo/" + IdUser.ToString(), JsonConvert.SerializeObject(tVehiculo)));
            return regreso.UpdTipoVehiculoResult;
        }

        public int ValTipoVehiculo(int id_Vehiculo, string Codigo, string Descripcion)
        {
            Entity.ValTipoVeiculoResult_ regreso = JsonConvert.DeserializeObject<Entity.ValTipoVeiculoResult_>(methodPost("ValTipoVeiculo/" + id_Vehiculo.ToString() + "/" + Codigo + "/" + Descripcion));
            return regreso.ValTipoVeiculoResult;
        }

        public int DelPlanSelected(int IdUser, string Valores, bool Activo)
        {
            Entity.DelTipoVeiculoSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoVeiculoSelectedResult_>(methodPost("DelTipoVeiculoSelected/" + IdUser.ToString() + "/" + Valores + "/" + Activo.ToString()));
            return regreso.DelTipoVeiculoSelectedResult;
        }

        public int DelPlanAll(int IdUser, bool Activo)
        {
            Entity.DelTipoVeiculoAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoVeiculoAllResult_>(methodPost("DelTipoVeiculoAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelTipoVeiculoAllResult;
        }
    }
}