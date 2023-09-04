using System;

namespace SistemaParaBiblioteca
{
    class Libro
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int Edicion { get; set; }
        public string Autor { get; set; }

        // Constructor que toma 5 argumentos para inicializar las propiedades
        public Libro(int codigo, string titulo, string isbn, int edicion, string autor)
        {
            Codigo = codigo;
            Titulo = titulo;
            ISBN = isbn;
            Edicion = edicion;
            Autor = autor;
        }
    }

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
                Console.WriteLine("3. Buscar libro por código");
                Console.WriteLine("4. Editar información de un libro por código");
                Console.WriteLine("5. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        agregarLibro();
                        break;

                    case 2:
                        listadoLibros();
                        break;

                    case 3:
                        buscarLibro();
                        break;

                    case 4:
                        editarLibro();
                        break;

                    case 5:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción seleccionada es inválida.");
                        break;
                }
            }
        }

        static void agregarLibro()
        {
            if (cantLibros < biblioteca.Length)
            {
                Console.WriteLine("Ingrese el código del libro: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el título del libro: ");
                string titulo = Console.ReadLine();

                Console.WriteLine("Ingrese el ISBN del libro: ");
                string isbn = Console.ReadLine();

                Console.WriteLine("Ingrese la edición del libro: ");
                int edicion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del autor o autora: ");
                string autor = Console.ReadLine();

                biblioteca[cantLibros] = new Libro(codigo, titulo, isbn, edicion, autor);
                cantLibros++;

                Console.WriteLine("Libro agregado con éxito.");
            }
            else
            {
                Console.WriteLine("*ATENCIÓN: Biblioteca llena.*");
            }
        }

        static void listadoLibros()
        {
            Console.WriteLine("Este es el listado de los libros que tenemos en nuestro registro: ");
            Console.WriteLine("| Código | Título | ISBN | Edición | Autor |");

            for (int i = 0; i < cantLibros; i++)
            {
                Console.WriteLine($"| {biblioteca[i].Codigo,-7} | {biblioteca[i].Titulo,-11} | {biblioteca[i].ISBN,-11} | {biblioteca[i].Edicion,-7} | {biblioteca[i].Autor,-11} |");
            }
        }

        static void buscarLibro()
        {
            Console.WriteLine("Ingresar el código del libro para buscarlo: ");
            int buscar = int.Parse(Console.ReadLine());

            bool exito = false;

            for (int i = 0; i < cantLibros; i++)
            {
                if (biblioteca[i].Codigo == buscar)
                {
                    mostrarInfo(biblioteca[i]);
                    exito = true;
                    break;
                }
            }
            if (!exito)
            {
                Console.WriteLine("La búsqueda no tuvo éxito, libro no registrado.");
            }
        }

        static void editarLibro()
        {
            Console.WriteLine("Digite el código del libro que desea editar: ");
            int editar = int.Parse(Console.ReadLine());

            bool exito = false;

            for (int i = 0; i < cantLibros; i++)
            {
                if (biblioteca[i].Codigo == editar)
                {
                    mostrarInfo(biblioteca[i]);

                    Console.WriteLine("Ingrese la nueva información del libro: ");
                    Console.WriteLine("Ingrese el nuevo título: ");
                    string ntitulo = Console.ReadLine();

                    Console.WriteLine("Ingrese el nuevo ISBN: ");
                    string nisbn = Console.ReadLine();

                    Console.WriteLine("Ingrese la nueva edición: ");
                    int nedicion = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el nuevo autor: ");
                    string nautor = Console.ReadLine();

                    biblioteca[i].Titulo = ntitulo;
                    biblioteca[i].ISBN = nisbn;
                    biblioteca[i].Edicion = nedicion;
                    biblioteca[i].Autor = nautor;

                    Console.WriteLine("La información ha sido actualizada.");
                    exito = true;
                    break;
                }
            }
            if (!exito)
            {
                Console.WriteLine("La búsqueda no tuvo éxito, libro no encontrado.");
            }
        }

        static void mostrarInfo(Libro libro)
        {
            Console.WriteLine("Información del libro:");
            Console.WriteLine($"Código: {libro.Codigo}");
            Console.WriteLine($"Título: {libro.Titulo}");
            Console.WriteLine($"ISBN: {libro.ISBN}");
            Console.WriteLine($"Edición: {libro.Edicion}");
            Console.WriteLine($"Autor: {libro.Autor}");
        }
    }
}
