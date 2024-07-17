using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace WebApiPerson.Models
{
    public class Person
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string LastName { get; set; }

        public required decimal Deberes { get; set; }

        public required decimal Examen { get; set; }


        // Hacer que Promedio y EstadoAprobacion tenga getters y seters para tambien almacenarlos en la base de datos

        public decimal Promedio
            {
            get { return CalcularPromedio(); }
            set { }
        }

        public string EstadoAprobacion
        {
            get { return ObtenerEstadoAprobacion(); }
            set { }
        }

        // Método para calcular el promedio
        private decimal CalcularPromedio()
        {
            return (Deberes + Examen) / 2m;
        }

        // Método renombrado para determinar el estado de aprobación
        private string ObtenerEstadoAprobacion()
        {
            return CalcularPromedio() >= 7 ? "Aprobado" : "Reprobado";
        }
    }

}
