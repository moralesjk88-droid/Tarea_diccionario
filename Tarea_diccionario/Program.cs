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

            //ejercicio5

            Dictionary<string, int> usuario = new Dictionary<string, int>();

            usuario.Add("Juan", 1234);
            usuario.Add("Ingrid", 5678);
            usuario.Add("Admin", 4321);
            Console.WriteLine("Ingrese el usuario:_");
            string nombre = Console.ReadLine();

            Console.WriteLine("La contraseña es:_ " + usuario[nombre]);




        }
    }
}