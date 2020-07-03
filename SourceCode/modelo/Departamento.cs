namespace SourceCode.modelo
{
    public class Departamento
    {
        public int idDepartamento { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }

        public Departamento()
        {
            idDepartamento = 0;
            nombre = "";
            ubicacion = "";

        }
    }
}