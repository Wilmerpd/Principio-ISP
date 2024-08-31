

namespace Principio_ISP
{
    public class Gallina : IAves
    {
        public Gallina()
        {
            Console.WriteLine("Soy una gallina");
        }
        public void volar()
        {
            Console.WriteLine("Tengo la capacidad de volar");
        }
        public void PonerHuevos()
        {
            Console.WriteLine("Puedo poner Huevos");

        }
        public void cantar()
        {
            Console.WriteLine("Canto.");
        }

    }
}
