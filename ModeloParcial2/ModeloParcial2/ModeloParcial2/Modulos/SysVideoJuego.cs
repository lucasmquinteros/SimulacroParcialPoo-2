using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial2.Modulos
{
    public static class SysVideoJuego
    {
        static List<VideoJuego> VideoJuegos = new List<VideoJuego>();
        static readonly string archivoVideoJuego = "ArchivoVideoJuegos.txt";
        //Pido un videoJuego por parametro y lo agrego a la lista guardando el juego en el archivo
        public static void AgregarVideoJuego(VideoJuego videoJuego)
        {
            VideoJuegos.Add(videoJuego);
            GuardarJuego(videoJuego);
            Console.WriteLine("VideoJuego agregado");
        }
        //Muestro cada juego
        public static void MostrarVideoJuegos()
        {
            foreach(var videoJuego in VideoJuegos)
            {
                Console.WriteLine($"Nombre: {videoJuego.Nombre} - Plataforma: {videoJuego.Plataforma} - Precio: {videoJuego.Precio} - Cantidad en Stock: {videoJuego.CantidadStock}");
                Console.WriteLine("\n");
            }
        }
        //Busco dentro de la lista si el videojuego antiguo existe, lo elimino y agrego el nuevo juego ya modificado
        //Guardo todos los datos para no generar redundancia en el archivo
        public static void ModificarVideoJuego(string nombre, VideoJuego videoJuego)
        {
            var m = VideoJuegos.Find(v => v.Nombre == nombre);
            if(m != null)
            {
                if (VideoJuegos.Remove(m))
                {
                    VideoJuegos.Add(videoJuego);
                    GuardarDatos();
                    Console.WriteLine("VideoJuego Modificado");
                }
            }
            else
            {
                Console.WriteLine("Juego no encontrado");
            }
        }
        //Busco por el nombre el videojuego y lo elimino de la lista 
        //Guardo todos los juegos devuelta
        public static void EliminarVideoJuego(string nombre)
        {
            var m = VideoJuegos.Find(v => v.Nombre == nombre);
            if (VideoJuegos.Remove(m))
            {
                Console.WriteLine("Juego eliminado");
                GuardarDatos();
            }
            else
            {
                Console.WriteLine("Juego no encontrado");
            }
        }
        public static void GuardarJuego(VideoJuego juego)
        {
            using StreamWriter writer = new StreamWriter(archivoVideoJuego, true);
            writer.WriteLine(juego);
        }
        public static void GuardarDatos()
        {
            using StreamWriter writer = new StreamWriter(archivoVideoJuego);
            foreach(var v in VideoJuegos)
            {
                writer.WriteLine(v);
            }
        }
        //Leo todas las lineas, distribuyo cada parte del juego en un array y genero cada tipo de dato
        //una vez creada todas las variables instancio el juego y lo agrego
        public static void CargarDatos()
        {
            if (File.Exists(archivoVideoJuego))
            {
                foreach(string linea in File.ReadAllLines(archivoVideoJuego))
                {
                    string[] p = linea.Split(", ");
                    string nom = p[0];
                    Plataforma plat =  (Plataforma)Enum.Parse(typeof(Plataforma), p[1]);
                    double prec = Double.Parse(p[2]);
                    int cantS = int.Parse(p[3]);
                    VideoJuego v = new VideoJuego(nom, plat, prec, cantS);
                    VideoJuegos.Add(v);
                }
            }
        }
    }
}
