using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Guia_1_Unidad_2_HP2
{
    public abstract class Cursos
    {
        public int NumeroEstudiantes { get; set; }
        public string NombreCurso { get; set; }
        public string NombreDocente { get; set; }
        public int DuracionCurso { get; set; }

        public  double PrecioCurso { get; set; }

        public Cursos(int numeroEstudiantes, string nombreCurso, string nombreDocente, int duracionCurso, double precioCurso)
        {
            if (string.IsNullOrWhiteSpace(nombreCurso) || string.IsNullOrWhiteSpace(nombreDocente))
            {
                throw new ArgumentException("No puede dejar campos vacíos");
            }
            if (numeroEstudiantes < 0)
            {
                throw new ArgumentException("El numero de estudiantes no puede ser negativo");
            }
            if (duracionCurso <= 0)
            {
                throw new ArgumentException("La duracion del curso debe ser mayor a 0");
            }

            NumeroEstudiantes = numeroEstudiantes;
            NombreCurso = nombreCurso;
            NombreDocente = nombreDocente;
            DuracionCurso = duracionCurso;
            PrecioCurso = precioCurso;
        }

     
        public abstract double CalcularPrecio();

        public override string ToString()
        {
            return $"Nombre: {NombreCurso} Estudiantes: {NumeroEstudiantes} Duracion: {DuracionCurso} Precio: {CalcularPrecio()}";
        }

    }
}
