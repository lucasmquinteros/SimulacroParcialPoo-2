using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial2.Modulos
{
    public static class Menu
    {
        static List<Action> Acciones = new List<Action>
        {
            AgregarVideoJuego,
            MostrarVideoJuegos,
            ModificarVideoJuego,
            EliminarVideoJuego
        };

        public static void MostrarMenu()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Agregar VideoJuego");
                Console.WriteLine("2. Mostrar VideoJuegos");
                Console.WriteLine("3. Modificar VideoJuego");
                Console.WriteLine("4. Eliminar VideoJuego");
                Console.WriteLine("5. Guardar y salir");
                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();
                Console.WriteLine("\n");
                if (int.TryParse(opcion, out int indice) && indice >= 1 && indice <= Acciones.Count + 1)
                {
                    if (indice == 5)
                    {
                        salir = true;
                    }
                    else
                    {
                        Acciones[indice - 1].Invoke();
                    }
                }
            }
        }
        //Arma el videoJuego recibiendo el nombre como parametro para poder adaptarlo a mis metodos sin tener que repetir codigo
        //pido cada dato del videojuego, lo instancio y lo retorno
        public static VideoJuego ArmarVideoJuego(string nombre)
        {
            Console.WriteLine("Ingrese el tipo de plataforma del videojuego: ");
            foreach (Plataforma plat in Enum.GetValues(typeof(Plataforma)))
            {
                Console.Write(" " + (int)plat + "." + plat.ToString());
            }
            Plataforma p;
            Console.Write("\nOpcion: ");
            if (Enum.TryParse(Console.ReadLine(), out p))
            {

            }
            else { Console.WriteLine("Ingrese una opcion correcta porfavor."); }

            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad en stock del producto: ");
            int cantStock = int.Parse(Console.ReadLine());

            VideoJuego videoJuego = new VideoJuego(nombre, p, precio, cantStock);
            return videoJuego;
        }

        //Creo el nuevo videojuego y se lo envio a SysVideoJuegos para que se agregue
        static void AgregarVideoJuego()
        {
            Console.Write("Ingrese el nombre del videoJuego: ");
            string nombre = Console.ReadLine();

            var v = ArmarVideoJuego(nombre);
            SysVideoJuego.AgregarVideoJuego(v);
        }
        //Muestro cada videoJuego con detalle
        static void MostrarVideoJuegos()
        {
            SysVideoJuego.MostrarVideoJuegos();
        }
        //Pido el nombre del videojuego que quiero modificar, pido el nuevo nombre, Armo el videojuego y se lo envio a SysVideoJuego para que lo modifique
        static void ModificarVideoJuego()
        {
            Console.Write("Ingrese el nombre del videoJuego a modificar: ");
            string nombreAntiguo = Console.ReadLine();

            Console.Write("Ingrese el nuevo nombre del VideoJuego: ");
            string nuevoNombre = Console.ReadLine();

            var v = ArmarVideoJuego(nuevoNombre);
            SysVideoJuego.ModificarVideoJuego(nombreAntiguo, v);
        }
        //Pido el nombre del videojuego a eliminar y llamo al sistema para que ejecute la funcion eliminar
        static void EliminarVideoJuego()
        {
            Console.Write("Ingrese el nombre del videojuego que quiere eliminar: ");
            string nombre = Console.ReadLine();
            SysVideoJuego.EliminarVideoJuego(nombre);
        }
    }
}
