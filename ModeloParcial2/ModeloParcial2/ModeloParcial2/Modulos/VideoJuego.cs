using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial2.Modulos
{
    public class VideoJuego
    {
        public string Nombre { get; private set; }
        public Plataforma Plataforma { get; private set;}
        public double Precio { get; private set; }
        public int CantidadStock { get; private set; }
        public VideoJuego(string nombre, Plataforma plataforma, double precio, int cantidadStock)
        {
            Nombre = nombre;
            Plataforma = plataforma;
            Precio = precio;
            CantidadStock = cantidadStock;
        }
        public override string ToString()
        {
            return $"{Nombre}, {Plataforma}, {Precio}, {CantidadStock}";
        }
    }
}
