using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.modelo;

namespace SourceCode.controlador
{
    public class DepartamentoDAO
    {
        public static List<Departamento> GetDep()
        {
            DataTable dt = ConnectionDB.ExecuteQuery("SELECT * FROM public.\"DEPARTAMENTO\";");
            List<Departamento> lista = new List<Departamento>();
            
            foreach (DataRow columna in dt.Rows)
            {
                var d = new Departamento();
                d.idDepartamento = Convert.ToInt32(columna[0].ToString());
                d.nombre = columna[1].ToString();
                d.ubicacion = columna[2].ToString();
            }
            return lista;
        }
        
        
        public static void Nuevo(int id, string nombre, string dir)
        {
            string sql = String.Format(
                "INSERT INTO \\\"DEPARTAMENTO\\\"(idDepartamento, nombre, ubicacion) " +
                "VALUES({0}, '{1}', '{2}');",
                id, nombre, dir);

            ConnectionDB.ExecuteNonQuery(sql);
        }
        
    }
}