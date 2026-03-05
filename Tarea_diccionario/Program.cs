namespace Tarea_diccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1
        Dictionary<int,string> Estudiante = new Dictionary<int,string>();
            Estudiante.Add(202618, "Maria");
            Estudiante.Add(202620, "Juan");
            Estudiante.Add(202619, "Carlos");
            foreach (var item in Estudiante)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            Console.WriteLine("Nombre del estudiante en especifico:_" + Estudiante[202620]);






        }
    }
}
