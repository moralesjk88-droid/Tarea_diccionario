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


        }
    }
}