using ResiduosPeligrosos.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class loggedEmpleado
    {
        public Usuario CurrentUsuario { get; set; }
        public Perfil CurrentPerfil { get; set; }

        public loggedEmpleado()
        {
            CurrentPerfil = new Perfil();
            CurrentUsuario = new Usuario();
        }
    }
}