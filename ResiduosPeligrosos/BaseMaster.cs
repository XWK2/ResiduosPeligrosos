using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResiduosPeligrosos.Entity;

namespace ResiduosPeligrosos
{
    public class BaseMaster : System.Web.UI.MasterPage
    {
        public loggedEmpleado LoginInfo
        {
            get
            {
                return (loggedEmpleado)Session["LoginInfo"];
            }
            set
            {
                Session["LoginInfo"] = value;
            }
        }
    }
}