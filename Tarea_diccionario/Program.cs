namespace Tarea_diccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //ejercicio2
           Dictionary<int,string>productos= new Dictionary<int,string>();

            productos.Add(200521, "Leche");
            productos.Add(201015, "Papel");
            productos.Add(200419, "Envace de agua");

            foreach (var item in productos)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

            //ejrcico3

            Dictionary<string,double> Notas = new Dictionary<string,double>();
            Notas.Add("Mario Rodas", 69.5);
            Notas.Add("Eduardo Berquefer", 40);
            Notas.Add("Alejandra Morales", 98.3);

            if (Notas.ContainsKey("Eduardo Berquefer"))
            {
                Console.WriteLine("Nota del estudiante" + Notas["Eduardo Berquefer"]);
            }

            //ejericio4
            Dictionary<int,string>ciudades = new Dictionary<int,string>();
            ciudades.Add(901, "Quetzaltenango");
            ciudades.Add(118, "Guatemala");
            ciudades.Add(785, "Huehuetenango");
            ciudades.Add(588, "Jutipa");
            ciudades.Add(458, "Retalhuleu");

            Console.WriteLine("La ciudad de:_ " + ciudades[901]);

         /*   //ejercicio5

            Dictionary<string, int> usuario = new Dictionary<string, int>();

            usuario.Add("Juan", 1234);
            usuario.Add("Ingrid", 5678);
            usuario.Add("Admin", 4321);
            Console.WriteLine("Ingrese el usuario:_");
            string nombre = Console.ReadLine();

            Console.WriteLine("La contraseña es:_ " + usuario[nombre]);*/

            //ejercico6

            Dictionary<int,string>Registro=new Dictionary<int,string>();
            Registro.Add(123, "Marcos");
            Registro.Add(888, "Estuardo");
            Registro.Add(985, "Alberto");

            Registro.Remove(985);
            foreach (var item in Registro)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

         /*   //ejercicio7
            Dictionary<int,string>Productos=new Dictionary<int,string>();

            int codigo = 888;
            string produicto = "Telefono";

            if (!Productos.ContainsKey(codigo))
            {
                Productos.Add(codigo, produicto);
            }
            else
            {
                Console.WriteLine("El producto ya existe");
            }*/

            //ejercicio8

            Dictionary<int, string>empleado = new Dictionary<int,string>();
            empleado.Add(1, "Pedro");
            empleado.Add(2, "Juan");
            empleado.Add(3, "Luis");
            
            
            empleado[3] = "Julieta";

            foreach (var item in empleado)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

            //ejericicio9

          /*  Dictionary<string, double>notas=new Dictionary<string, double>();
            notas.Add("Maria", 85);
            notas.Add("Juan", 70);
            notas.Add("carlos", 95);

            Console.WriteLine("Ingrese el nombre:_ ");
            string NombreEStudiante=Console.ReadLine();
            if (notas.ContainsKey(NombreEStudiante))
            {
                Console.WriteLine("La nota es: " + notas[NombreEStudiante]);
            }
            else
            {
                Console.WriteLine("El estudiante no existe");
            }*/

            //ejercicio10
          /*  Dictionary<int, string> inventarioproducto=new Dictionary<int,string>();
            inventarioproducto.Add(1, "Mouse");
            inventarioproducto.Add(2, "Teclado");
            inventarioproducto.Add(3, "Monitor");

            Console.WriteLine("Ingrese el codigo del producto a eliminar");
            int codigoProducto=int.Parse(Console.ReadLine());
            if (inventarioproducto.ContainsKey(codigoProducto))
            {
                inventarioproducto.Remove(codigoProducto);
                Console.WriteLine("Eliminado correctamente");
            }
            else
            {
                Console.WriteLine("Codigo no valido");
            }
            foreach (var item in inventarioproducto)
            {
                Console.WriteLine(item.Key+"_"+item.Value);
                
            }*/

            //ejercicio11

            Dictionary<int,string>ListaEstudiantes=new Dictionary<int,string>();

            ListaEstudiantes.Add(12, "Mario Lopez");
            ListaEstudiantes.Add(16, "Eduardo Berquefer");
            ListaEstudiantes.Add(19, "Luisa Lopez");
            ListaEstudiantes.Add(20, "Oscar Reyes");
            ListaEstudiantes.Add(18, "Miguel Morales");

            foreach (var item in ListaEstudiantes)
            {
                Console.WriteLine("Lista de Estudiantes:_ "+item.Key + "-" + item.Value);
            }

            //ejercicio12
            Dictionary<int ,string>ListaProductos=new Dictionary<int ,string>();

            ListaProductos.Add(1, "leche");
            ListaProductos.Add(2, "huevos");
            ListaProductos.Add(3, "aceite");
            ListaProductos.Add(4, "azucar");
            ListaProductos.Add(5, "arina");
            ListaProductos.Add(6, "miel");
            
            Console.WriteLine("Lista de productos");
            foreach (var item in ListaProductos)
            {
               
                Console.WriteLine("Codigo:_ "+item.Key+" Nombre producto:_ "+item.Value);
            }

            //ejercicio13
            Dictionary<int,double>PromedioNotas=new Dictionary<int ,double>();

            PromedioNotas.Add(1, 68.2);
            PromedioNotas.Add(3, 48.6);
            PromedioNotas.Add(5,78);
            PromedioNotas.Add(7, 98);
            PromedioNotas.Add(9, 88);
            double promedio,suma=0;
            foreach (var item in PromedioNotas)
            {
                suma=item.Value;

                }
            promedio = suma / PromedioNotas.Count;

            Console.WriteLine("Promedio de notas:_ " + promedio);

            //ejercicio14
            Dictionary<int,string>LineaCiudades=new Dictionary<int ,string>();

            LineaCiudades.Add(901, "Quetzaltenango");
            LineaCiudades.Add(902, "Salcaja");
            LineaCiudades.Add(903, "Olintepeque");
            LineaCiudades.Add(906, "Cabrican");
            LineaCiudades.Add(907, "Cajolá");

            foreach (var item in LineaCiudades)
            {
                Console.WriteLine("Linea:_"+item.Key); 
              
            }

            foreach (var item in LineaCiudades)
            {
                 Console.WriteLine("Ciudades:_ "+item.Value);

            }

            //ejercicio15
             Dictionary<int, string> Empleados=new Dictionary<int ,string>();
            Empleados.Add(125, "Estefany Morales");
            Empleados.Add(236, "Eduardo Perez");
            Empleados.Add(698, "Ingrid Mendoza");
            Empleados.Add(874, "José Arriaga");

            foreach (var item in Empleados)
            {
                Console.WriteLine("ID:_" + item.Key + " Nombre:_" + item.Value);

            }

            

        }
    }
}