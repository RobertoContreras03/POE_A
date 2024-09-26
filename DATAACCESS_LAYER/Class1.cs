using COMMON_LAYER.Models;
using System.Collections.Generic;
namespace DATAACCESS_LAYER;



public class Repositorio_E
{
    private List<Estudiante> estudiantes = new List<Estudiante>();

    public List<Estudiante> GetEstudiantes()
    {
        return estudiantes;
    }
    public void AñadirEstudiante(Estudiante estudiante)
    {
        estudiantes.Add(estudiante);
    }
    public void EliminarEstudiante(int ID)
    {
        estudiantes.RemoveAll(s => s.ID == ID);
    }


}