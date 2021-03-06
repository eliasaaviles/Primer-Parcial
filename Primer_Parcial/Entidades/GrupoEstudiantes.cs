﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Primer_Parcial.Entidades
{
   public class GrupoEstudiantes
    {
        [Key]
        public int GrupoID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Grupos { get; set; }
        public int Integrantes { get; set; }
        public String Descripcion { get; set; }
        public String Fecha { get; set; }

        public GrupoEstudiantes()
        {
            GrupoID = 0;
            Nombre = string.Empty;
            Cantidad = 0;
            Grupos = 0;
            Integrantes = 0;
            Descripcion = String.Empty;
            Fecha = String.Empty;
        }

        public GrupoEstudiantes(int grupoid,string nombre, int cantidad, int grupos, int integrantes,String descripcion, String fecha)
        {

            GrupoID = grupoid;
            Nombre = nombre;
            Cantidad = cantidad;
            Grupos = grupos;
            Integrantes = integrantes;
            Descripcion = Descripcion;
            Fecha = fecha;
        }
    }



    }

