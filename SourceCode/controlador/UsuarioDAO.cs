using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.modelo;

namespace SourceCode.controlador
{
    public static class UsuarioDAO
    {
        public static List<Usuario> GetUsuario()
        {
            DataTable dt = ConnectionDB.ExecuteQuery("SELECT * FROM public.\"USUARIO\";");
            List<Usuario> lista = new List<Usuario>();
            
            foreach (DataRow columna in dt.Rows)
            {
                var u = new Usuario();
                u.carnet = Convert.ToInt32(columna[0].ToString());
                u.idDepartamento = Convert.ToInt32(columna[1].ToString());
                u.contrasena = columna[2].ToString();
                u.nombre = columna[3].ToString();
                u.apellido = columna[4].ToString();
                u.dui = columna[5].ToString();
                u.FNacimiento = DateTime.Parse(columna[6].ToString());
                lista.Add(u);
            }
            return lista;
        }
        
       /* public static void Nuevo(int carnet, int idDepartamento, string contrasena, string nombre, string apellido, string dui)
        {
            string sql = String.Format(
                "INSERT INTO APPUSER(fullname, username, password, userType) " +
                "VALUES('{0}', '{1}', '{2}' , {3});",
                name, uname, passwd, admin ? "true" : "false");

            ConnectioDB.ExecuteNonQuery(sql);
        } */
        
    
    }
}