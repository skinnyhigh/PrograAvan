using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb_Martes.Entidades
{
    public class Usuario
    {
        public string Identificacion { get; set; }
        public string Password { get; set;}

        public string Nombre { get; set; }

        public string Correo{ get; set; }
    }

}