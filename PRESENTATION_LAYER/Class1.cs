using BUSINESS_LAYER;
using COMMON_LAYER.Models;
using System;
namespace PRESENTATION_LAYER
{
    class Program
    {
        static void Main(string[] args)
        {
            S_ESTUDIANTE servicio_estudiante = new S_ESTUDIANTE();
            servicio_estudiante.AñadirEstudiante(new Estudiante { ID = 1, Nombre= "Roberto", EDAD=21, Clase= "Matematica"});
            servicio_estudiante.AñadirEstudiante(new Estudiante { ID = 2, Nombre = "Elmer", EDAD = 20, Clase = "Sociales" });

            var estudiantes = servicio_estudiante.GetEstudiantes();
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"ID: {estudiante.ID}, Nombre: {estudiante.Nombre}, Edad: {estudiante.EDAD}, clase: {estudiante.Clase}");
            }
        }
    }
}