using System;
using Primer_Parcial.Entidades;
using Primer_Parcial.DAL;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Primer_Parcial.BLL
{
    public class GrupoEstudiantesBLL
    {
        public static bool Guardar(GrupoEstudiantes estudiantes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();



            contexto.grupoEstudiantes.Add(estudiantes);
                
                    contexto.SaveChanges();
                    paso = true;
                
                contexto.Dispose();
            
           
            return paso;
        }
        
        public static bool Eliminar(int GrupoID) 
        {
            bool paso = false;
            Contexto contexto = new Contexto();

          
                var eliminar = contexto.grupoEstudiantes.Find(GrupoID);
                contexto.Entry(eliminar).State = EntityState.Deleted;
              
                contexto.Dispose();
            
           
            return paso;
        }
       


        public static GrupoEstudiantes Buscar(int GrupoID)
        {
            Contexto contexto = new Contexto();
            GrupoEstudiantes estudiantes = new GrupoEstudiantes();

            
            
                estudiantes = contexto.grupoEstudiantes.Find(GrupoID);
                contexto.Dispose();

            
           
            return estudiantes;
        }

        public static bool Modificar(GrupoEstudiantes estudiantes)
        {
            bool paso = false;
            Contexto contexto
                = new Contexto();

            
            
                contexto.Entry(estudiantes).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            
           

            return paso;
        }

        public static List<GrupoEstudiantes> GetList(Expression<Func<GrupoEstudiantes, bool>> expression)
        {
            List<GrupoEstudiantes> estudiantes = new List<GrupoEstudiantes>();
            Contexto contexto = new Contexto();
           
                estudiantes = contexto.grupoEstudiantes.Where(expression).ToList();
                contexto.Dispose();
            
          

            return estudiantes;

        }











    }


}
