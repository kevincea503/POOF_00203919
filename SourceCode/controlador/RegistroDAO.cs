using System;

namespace SourceCode.controlador
{
    public class RegistroDAO
    {
        public static void NuevoRegistro( int idU, bool entrad, DateTime fh, decimal temp)
        {
            string sql = String.Format(
                "INSERT INTO PUBLIC.\"Registro\" (\"idUsuario\", entrada, \"fecha/hora\", temperatura) " +
                "VALUES({0}, {1} , '{2}' , {3});",
                 idU, entrad, fh, temp);

            ConnectionDB.ExecuteNonQuery(sql);
        } 
        
    }
}