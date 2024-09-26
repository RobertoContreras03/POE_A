using COMMON_LAYER.Models;
using DATAACCESS_LAYER;
using System.Collections.Generic;
namespace BUSINESS_LAYER
{
    public class S_ESTUDIANTE
    {
        private Repositorio_E estudianteRepositorio = new Repositorio_E();

        public List<Estudiante> GetEstudiantes()
        {
            return estudianteRepositorio.GetEstudiantes();
        }
        public void AñadirEstudiante(Estudiante estudiante)
        {
            estudianteRepositorio.AñadirEstudiante(estudiante);
        }
        public void EliminarEstudiante(int ID)
        {
            estudianteRepositorio.EliminarEstudiante(ID);
        }

    }
}