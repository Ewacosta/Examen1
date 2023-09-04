using System;

namespace sistemaBibiloteca
{
    class Program
    {
        static Libro[] biblioteca = new Libro[100];
        static int cantLibros = 0;
        public static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Agregar un libro");
                Console.WriteLine("2. Listado de libros");
                Console.WriteLine("3. Buscar libro por codigo");
                Console.WriteLine("4.Editar informacion de un libro por codigo");
                Console.WriteLine("5. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: agregarLibro();
                        break;

                    case 2: listadoLibros();
                        break;

                    case 3: buscarLibro(); 
                        break;

                    case 4: editarLibro();
                        break;

                    case 5: salir = true;
                        break;

                    default: Console.WriteLine("Opcion seleccionada es invalida.");
                        break;

                }
            }
            
        }
        static void agregarLibro()
        {
            if (cantLibros < biblioteca.Length)
            {
                Console.WriteLine("Ingrese el codigo del libro: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el titulo del libro: ");
                string titulo = Console.ReadLine();

                Console.WriteLine("Ingrese el ISBN del libro: ");
                string isbn = Console.ReadLine();

                Console.WriteLine("Ingrese la edicion del libro: ");
                int edicion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del autor o autora: ");
                string autor = Console.ReadLine();

                biblioteca[cantLibros] = new Libro(codigo,titulo,isbn,edicion,autor);
                cantLibros++;

                Console.WriteLine("Libro agregado con exito.");
            }
            else
            {
                Console.WriteLine("*ATENCION: Biblioteca llena.*");
            }
        }
        static void listadoLibros()
        {
            Console.WriteLine("Este es el listado de los libros que tenemos en nuestro registro: ");
            Console.WriteLine("| Codigo | Titulo | ISBN | Edicion | Autor |");

            for (int i = 0; i < cantLibros; i++)
            {
                Console.WriteLine($"| {biblioteca[i].codigo,-7} | {biblioteca[i].titulo,-11} | {biblioteca[i].isbn,-11} | {biblioteca[i].edicion,-7} | {biblioteca[i].Autor,-11} |");
            }
        }
        static void buscarLibro()
        {
            Console.WriteLine("Ingresar el codigo del libro para buscarlo: ");
            int buscar = int.Parse(Console.ReadLine());

            bool exito = false;

            for (int i = 0;i < cantLibros;i++)
            {
                if (biblioteca[i].codigo == buscar)
                {
                    mostrarInfo(biblioteca[i]);
                    exito = true;
                    break;
                }
            }
            if (!exito)
            {
                Console.WriteLine("La busqueda no tuvo exito, libro no registrado.");
            }
        }
        static void editarLibro()
        {
            Console.WriteLine("Digite el codigo del libro que desea editar: ");
            int editar = int.Parse(Console.ReadLine());

            bool exito = false;
             
            for (int i = 0; i< cantLibros;i++)
            {
                if (biblioteca[i].codigo == editar)
                {
                    mostrarInfo(biblioteca[i]);

                    Console.WriteLine("Ingrese la nueva informacion del libro: ");
                    Console.WriteLine("Ingrese el nuevo titulo: ");
                    string ntitulo = Console.ReadLine();

                    Console.WriteLine("Ingrese el nuevo ISBN: ");
                    string nisbn = Console.ReadLine();

                    Console.WriteLine("Ingrese la nueva edicion: ");
                    int nedicion = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el nuevo autor: ");
                    string nautor = Console.ReadLine();

                    biblioteca[i].titulo = ntitulo;
                    biblioteca[i].isbn = nisbn;
                    biblioteca[i].edicion = nedicion;
                    biblioteca[i].autor = nautor;

                    Console.WriteLine("La informacion ha sido actualizada.");
                    exito = true;
                    break;

                }
            }
            if (!exito)
            {
                Console.WriteLine("La busqueda no tuvo exito, libro no encontrado.");
            }
        }
        static void mostrarInfo(Libro libro)
        {
            Console.WriteLine("Informacion del libro:");
            Console.WriteLine($"Codigo: {libro.codigo}");
            Console.WriteLine($"Titulo");
        }
    }
}