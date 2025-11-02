using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Guia_1_Unidad_2_HP2
{
    public class Presencial:Cursos
    {
        public double CostoAdicional { get; set; }

        public Presencial(int numeroEstudiantes, string nombreCurso, string nombreDocente, int duracionCurso, double precioCurso) : base (numeroEstudiantes, nombreCurso, nombreDocente, duracionCurso, precioCurso) 
        {
            if (numeroEstudiantes > 30)
            {
                CostoAdicional = precioCurso * 0.2;
            }
            else
            {
                CostoAdicional = 0;
            }
        }

        public override double CalcularPrecio()
        {
            return PrecioCurso + CostoAdicional;
        }


    }
}
