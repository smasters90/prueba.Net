using System.Text;

namespace PrimerProyecto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var objeto1 = new Program();

            objeto1.rellenar();
        }
        public void rellenar()
        {
            Console.WriteLine("Ingrese su nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            var edad = Console.ReadLine();

            Console.WriteLine($"{nombre}  {edad}");
            Console.ReadLine();
        }
    }
}