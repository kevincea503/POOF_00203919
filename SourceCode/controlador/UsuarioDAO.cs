﻿using System;
using System.Collections.Generic;
using System.Data;
using SourceCode.modelo;

namespace SourceCode.controlador
{
    public class UsuarioDAO
    {
        /*DataTable dt = ConnectionDB.ExecuteQuery("SELECT * FROM APPUSER");
        List<Usuario> lista = new List<Usuario>();

            foreach (DataRow columna in dt.Rows)
        {
            var u = new Usuario();
            u.id_user = Convert.ToInt32(columna[0].ToString());
            u.fullname = columna[1].ToString();
            u.username = columna[2].ToString();
            u.password = columna[3].ToString();
            u.userType = Convert.ToBoolean(columna[4].ToString());
            lista.Add(u);
        }

        return lista;
    }

    public static void Nuevo(string name, string uname, string passwd, bool admin)
    {
    string sql = String.Format(
        "INSERT INTO APPUSER(fullname, username, password, userType) " +
        "VALUES('{0}', '{1}', '{2}' , {3});",
        name, uname, passwd, admin ? "true" : "false");

    ConnectioDB.ExecuteNonQuery(sql);
    }
    */
    }
}