using NotasLB1.Models;
using NotasLB1.Sevice;

namespace NotasLB1.Bussines
{
    public class Promedio : IPromedios
    {
        
        public string NombreCompleto(Notas notas)
        {
            return notas.Nombre;
        }

     

        public double Promedios(Notas notas)
        {
            return (notas.Lbuno + notas.Lbdos + notas.Lbtres + notas.Pcuno + notas.Pcdos + notas.Pctres)/6;
        }
    }
}
