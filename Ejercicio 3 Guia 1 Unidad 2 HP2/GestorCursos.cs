using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Guia_1_Unidad_2_HP2
{
    public class GestorCursos
    {
        public static GestorCursos _instancia;
        private List<Cursos> cursos;

        public GestorCursos()
        {
            cursos = new List<Cursos> { };
        }

        public static GestorCursos Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new GestorCursos();
                }
                return _instancia;
            }
        }

        public void AñadirCurso(Cursos curso)
        {
            cursos.Add(curso);
        }
        public List<Cursos> ObtenerCurso()
        {
            return cursos;
        }

        public void Eliminar()
        {
            cursos.Clear();
        }

    }
}
