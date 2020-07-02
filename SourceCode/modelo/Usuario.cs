using System;

namespace SourceCode.modelo
{
    public class Usuario
    {
        public int carnet { get; set; }
        public int idDepartamento { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dui { get; set; }
        public DateTime FNacimiento { get; set; }

        public Usuario()
        {
            carnet = 0;
            idDepartamento = 0;
            contrasena = "";
            nombre = "";
            apellido = "";
            dui = "";
            FNacimiento = DateTime.Now;
        }
    }
}