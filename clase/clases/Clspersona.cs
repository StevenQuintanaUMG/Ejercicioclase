using Interfaces;

namespace Interfaces
{
    public class Clspersona : IPersona
    {
        public string Nombre { get; }
        public int edad { get; }

        public Clspersona(string Nombre, int Edad)
        {
            Nombre = "Steven";
            Edad = 19;
        }

        public void DecirMinombre()
        {
            Console.WriteLine("Mi nombre es" + this.Nombre);
        }

        public void cumplirAnios()
        {
            Console.WriteLine("Mi edad es" + edad);
        }
    }
