using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Guia_1_Unidad_2_HP2
{
    public class Virtual : Cursos
    {
        public double Descuento { get; set; }

        public Virtual(int numeroEstudiantes, string nombreCurso, string nombreDocente, int duracionCurso, double precioCurso) : base(numeroEstudiantes, nombreCurso, nombreDocente, duracionCurso, precioCurso)
        {
            if (numeroEstudiantes > 50)
            {
                Descuento = precioCurso * 0.15;
            }
            else
            {
                Descuento = 0;
            }
        }

        public override double CalcularPrecio()
        {
            return PrecioCurso - Descuento;
        }
    }
}
