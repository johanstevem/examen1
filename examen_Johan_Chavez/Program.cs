using System;
namespace Examen_Johan_Chavez
{
    class Program
    {
        public static void Main(string [] args)
        {
            EstudiantePrimaria primaria = new EstudiantePrimaria();
            primaria.Datos("Johan Steven","Chavez Bailon","Anibal San Andres Robledo",1316767268);
            primaria.ImprimirDatos();

            EstudianteSecundaria secundaria = new EstudianteSecundaria();
            secundaria.Datos("Juan Alexander","Mero Mero","Anibal San Andres Robledo",1315672874);
            secundaria.DatosExtra(3);
            secundaria.ImprimirDatos();

            EstudianteUniversitario universitario = new EstudianteUniversitario();
            universitario.Datos("Carlos Wladimir","Mero Chavez","ULEAM",1316435827);
            universitario.DatosEx(5);
            universitario.ImprimirDatos();
        }
    }
}

