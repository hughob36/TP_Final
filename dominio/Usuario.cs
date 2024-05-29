using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dominio
{
    public class Usuario
    {

        public int Id { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }

        public string Email { get; set; }

        public bool EsAdministrador { get; set; }

        public  bool EsVip { get; set; } 


    }
}