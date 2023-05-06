namespace Interfaces
{
    internal interface IPersona
    {
        string Nombre { get; }

        int Edad { get; }

        void DecirMiNombre();
        void cumplirAnios();
    }
}