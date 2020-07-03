using System;

namespace SourceCode.modelo
{
    public class Registro
    {
        public int dRegistro { get; set; }
        public int idUsuario { get; set; }
        public bool entrada { get; set; }
        public DateTime fechaHora { get; set; }
        public int temperatura { get; set; }


        public Registro()
        {
            dRegistro = 0;
            idUsuario = 0;
            entrada = false;
            fechaHora = DateTime.Now;
            temperatura = 0;

        }
    }
}