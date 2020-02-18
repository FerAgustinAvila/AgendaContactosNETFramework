using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos
{
    class ControlAgenda
    {
        private Agenda _agenda;

        public ControlAgenda(Agenda agenda)
        {
            _agenda = agenda;
        }

        public void VerContactos()
        {

            // Limpiar consola
            Limpiar();

            // Mostrar opciones
            MostrarMenu();


            string opcion = Console.ReadLine();

            switch( opcion)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Contactos Orden Ascendente");
                    _agenda.MostrarOrdenados();
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Contactos Orden Descendiente");
                    _agenda.MostrarOrdenadosDesc();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción no válida!");
                    break;

            }

            PresionaContinuar();
        }

        public void AgregarContacto()
        {
            Limpiar();
            Console.WriteLine("Nuevo Contacto!");

            Contacto contacto = new Contacto();
            Console.Write("Nombre:  ");
            contacto.Nombre = Console.ReadLine();
            Console.Write("Teléfono:  ");
            contacto.Telefono = Console.ReadLine();
            Console.Write("Email:  ");
            contacto.Email = Console.ReadLine();

            _agenda.AgregarContacto(contacto);

            Console.WriteLine("Contacto agregado exitosamente!");

            // Presiona una tecla para continuar
            PresionaContinuar();
        }

        public void BorrarUltimoContacto()
        {
            Limpiar();
            _agenda.BorrarUltimoContacto();
            Console.WriteLine("Contacto borrado exitosamente!");
            PresionaContinuar();
        }

        public void BuscarPorNombre()
        {
            Limpiar();
            Console.WriteLine("Buscar contacto!");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Contacto contacto = _agenda.BuscarPorNombree(nombre);

            if ( contacto != null)
            {
                Console.WriteLine();
                Console.WriteLine("Datos:  \n" + contacto);

            }
            else
            {
                Console.WriteLine(" Contacto no encontrado");
            }

            PresionaContinuar();

        }


        public static void AcercaDe()
        {
            Limpiar();
            Console.WriteLine("Nombre: Fernando Agustin Avila");
            Console.WriteLine("Email: fernandoa_avila@hotmail.com");
            Console.WriteLine("Rol: Desarrollador Full Stack");
            PresionaContinuar();

        }

        public void MostrarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Mostrar orden ascendente");
            sb.AppendLine("2. Mostrar orden descendente");
            sb.AppendLine("3. Volver al menú principal");
            sb.Append("Seleccione una opción:  ");

            Console.Write(sb.ToString());
        }

        private static void PresionaContinuar()
        {
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }

        private static void Limpiar()
        {
            Console.Clear();

        }
    }
}
