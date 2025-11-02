using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Guia_1_Unidad_2_HP2
{
    public class CursosFactory
    {
        public static Cursos CrearCurso(string tipo, int numeroEstudiantes, string nombreCurso, string nombreDocente, int duracionCurso, double precioCurso)
        {
            if (tipo == "Presencial")
            {
                return new Presencial(numeroEstudiantes,nombreCurso ,nombreDocente, duracionCurso, precioCurso);
            }
            else if (tipo == "Virtual")
            {
                return new Virtual(numeroEstudiantes, nombreCurso, nombreDocente, duracionCurso, precioCurso);
            }
            else
            {
                throw new ArgumentException("Tipo de curso no valido");
            }
        }
    }
}
