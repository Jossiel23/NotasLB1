using NotasLB1.Models;

namespace NotasLB1.Sevice
{
    public interface IPromedios
    {
        string NombreCompleto(Notas notas);
        double Promedios(Notas notas);
    }
}
